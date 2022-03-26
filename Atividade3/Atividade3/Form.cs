using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool PesoValido;
        bool AlturaValido;
        double Peso;
        double Altura;
        double IMC;

        public Form()
        {
            InitializeComponent();
        }

        private void PesoTxt_Validated(object sender, EventArgs e)
        {
            PesoValido = double.TryParse(PesoTxt.Text, out Peso);
            Refresh();
        }

        private void AlturaTxt_Validated(object sender, EventArgs e)
        {
            AlturaValido = double.TryParse(AlturaTxt.Text, out Altura);
            Refresh();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            AlterarBorda(PesoTxt, PesoValido, e);
            AlterarBorda(AlturaTxt, AlturaValido, e);
        }

        private void CalcularIMCBtn_Click(object sender, EventArgs e)
        {
            if (NumerosValidos())
            {
                CalcularIMC();
                IMCTxt.Text = IMC.ToString("N3");
                if (IMC < 18.5)
                {
                    IMCInfoText.Text = "Menor que 18,5";
                    ClassificacaoTxt.Text = "Magreza";
                    GrauTxt.Text = "0";
                }
                else if (IMC < 25)
                {
                    IMCInfoText.Text = "Entre 18,5 e 24.9";
                    ClassificacaoTxt.Text = "Normal";
                    GrauTxt.Text = "0";
                }
                else if (IMC < 30)
                {
                    IMCInfoText.Text = "Entre 25,0 e 29.9";
                    ClassificacaoTxt.Text = "Sobrepeso";
                    GrauTxt.Text = "I";
                }
                else if (IMC < 40)
                {
                    IMCInfoText.Text = "Entre 29,9 e 39.9";
                    ClassificacaoTxt.Text = "Obesidade";
                    GrauTxt.Text = "II";
                }
                else if (IMC >= 40)
                {
                    IMCInfoText.Text = "Maior que 40,0";
                    ClassificacaoTxt.Text = "Obesidade Grave";
                    GrauTxt.Text = "III";
                }
            }
        }

        private void CalcularIMC()
        {
            IMC = Peso / (Math.Pow(Altura, 2));
        }

        private bool NumerosValidos()
        {
            PesoValido = double.TryParse(PesoTxt.Text, out Peso);
            AlturaValido = double.TryParse(AlturaTxt.Text, out Altura);

            if (!PesoValido || !AlturaValido)
            {
                string msg = "Os seguintes campos não podem ser convertidos:";
                if (!PesoValido) msg += "\n\tPeso";
                if (!AlturaValido) msg += "\n\tAltura";
                msg += "\nÉ necessário corrigir os campos para poder realizar a conta!";
                MessageBox.Show(msg);
                return false;
            }
            return true;
        }

        private void AlterarBorda(TextBox textBox, bool valid, PaintEventArgs e)
        {
            if (!valid)
            {
                textBox.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 1;
                g.DrawRectangle(p, new Rectangle(textBox.Location.X - variance, textBox.Location.Y - variance,
                    textBox.Width + variance, textBox.Height + variance));
            }
            else
            {
                textBox.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Green);
                Graphics g = e.Graphics;
                int variance = 1;
                g.DrawRectangle(p, new Rectangle(textBox.Location.X - variance, textBox.Location.Y - variance,
                    textBox.Width + variance, textBox.Height + variance));
            }
        }
    }
}
