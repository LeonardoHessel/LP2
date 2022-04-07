using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class MainForm : Form
    {
        bool salarioBrutoValido;
        double salarioBruto;
        bool aliquotaINSSMaxima;
        double aliquotaINSS;
        double descontoINSS;
        double aliquotaIRPF;
        double descontoIRPF;
        int quantidadeDeFilhos;
        double adicionalPorFilho;
        double salarioFamilia;
        string filhos;
        string titulo;
        string status;

        public MainForm()
        {
            InitializeComponent();
            cbxQtdFilhos.SelectedIndex = 0;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            salarioBrutoValido = double.TryParse(txtSalario.Text, out salarioBruto);
            if (salarioBrutoValido)
            {
                CalcularINSS();
                CalcularIRPF();
                SalarioFamilia();
                IdentificarTitulo();
                ExibirInformações();
            }
            else
                MessageBox.Show("Salario invalido!");
        }

        private void CalcularINSS()
        {
            // Atriui valor falso para iniciar o calculo
            aliquotaINSSMaxima = false;

            // Identifica a aliquota
            if (salarioBruto <= 800.47)
                aliquotaINSS = .0765;
            else if (salarioBruto <= 1050)
                aliquotaINSS = .0865;
            else if (salarioBruto <= 1400.77)
                aliquotaINSS = .09;
            else if (salarioBruto <= 2801.56)
                aliquotaINSS = .11;
            else
            {
                aliquotaINSS = .11;
                aliquotaINSSMaxima = true;
            }
            
            // Calcula o desconto
            if (aliquotaINSSMaxima)
                descontoINSS = 2801.56 * .11;
            else
                descontoINSS = salarioBruto * aliquotaINSS;
        }

        private void CalcularIRPF()
        {
            // Identifica a aliquota
            if (salarioBruto <= 1257.12)
                aliquotaIRPF = 0;
            else if (salarioBruto <= 2512.08)
                aliquotaIRPF = .15;
            else
                aliquotaIRPF = .275;

            // Calcula o desconto
            descontoIRPF = salarioBruto * aliquotaIRPF;
        }

        private void SalarioFamilia()
        {
            // Identifica a quantidade de filhos
            if (int.TryParse(cbxQtdFilhos.Text, out quantidadeDeFilhos))
            {
                // Identifica o adicional por filho
                if (salarioBruto <= 435.52)
                    adicionalPorFilho = 22.33;
                else if (salarioBruto <= 654.61)
                    adicionalPorFilho = 15.74;
                else
                    adicionalPorFilho = 0;
                
                // Calcula o adicional
                salarioFamilia = adicionalPorFilho * quantidadeDeFilhos;

                // Atribui o texto referente a quantidade de filhos
                string qtd = quantidadeDeFilhos > 1 ? "s" : "";
                if (quantidadeDeFilhos > 0)
                    filhos = $"que tem {quantidadeDeFilhos} filho{qtd}";
                else
                    filhos = "não tem filhos";
            }
            else
                MessageBox.Show("Selecione uma quantidade de filhos invalida.");
        }

        private void IdentificarTitulo()
        {
            // Identifica o Sexo
            if (rbtFem.Checked)
            {
                // Identificas se é casado ou não
                if (cbxCasado.Checked)
                {
                    titulo = "da Sr.ª";
                    status = "casada";
                }
                else
                {
                    titulo = "da Srta";
                    status = "solterira";
                }
            }
            else
            {
                // Identificas se é casado ou não
                if (cbxCasado.Checked)
                {
                    titulo = "do Sr.";
                    status = "casado";
                }
                else
                {
                    titulo = "do Srt";
                    status = "solteriro";
                }
            }
        }

        private void ExibirInformações()
        {
            // Monta, formata e exibe as informações nos campos do formulário
            lblDados.Text = $@"Os descontos do salario {titulo} {txtNome.Text} que é {status} e {filhos} são:";
            txtAinss.Text = $"{(aliquotaINSS * 100).ToString("N2")} %";
            txtDinss.Text = (descontoINSS).ToString("N2");
            txtAirrf.Text = $"{(aliquotaIRPF * 100).ToString("N2")} %";
            txtDirrf.Text = (descontoIRPF).ToString("N2");
            txtSfamilia.Text = (salarioFamilia).ToString("N2");
            txtSliquido.Text = (salarioBruto - descontoINSS - descontoIRPF + salarioFamilia).ToString("N2");
        }
    }
}
