using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class MainForm : Form
    {
        bool numero1Valid;
        bool numero2Valid;
        int numero1;
        int numero2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LimparBtn_Click(object sender, EventArgs e)
        {
            Numero1Txt.Clear();
            Numero2Txt.Clear();
            ResultadoTxt.Clear();
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Numero1Txt_Validated(object sender, EventArgs e)
        {
            numero1Valid = int.TryParse(Numero1Txt.Text, out numero1);
            Refresh();
        }

        private void Numero2Txt_Validated(object sender, EventArgs e)
        {
            numero2Valid = int.TryParse(Numero2Txt.Text, out numero2);
            Refresh();
        }

        private void AdicionarBtn_Click(object sender, EventArgs e)
        {
            if (NumerosValidos())
                ResultadoTxt.Text = (numero1 + numero2).ToString();
        }

        private void SubtrairBtn_Click(object sender, EventArgs e)
        {
            if (NumerosValidos())
                ResultadoTxt.Text = (numero1 - numero2).ToString();
        }

        private void MultiplicarBtn_Click(object sender, EventArgs e)
        {
            if (NumerosValidos())
                ResultadoTxt.Text = (numero1 * numero2).ToString();
        }

        private void DividirBtn_Click(object sender, EventArgs e)
        {
            if (NumerosValidos())
            {
                if (numero2 != 0)
                {
                    ResultadoTxt.Text = (numero1 / numero2).ToString();
                }
                else
                {
                    MessageBox.Show("Não é possivel dividir por 0\nAltere o valor!");
                    Numero2Txt.Focus();
                }
            }
        }

        private bool NumerosValidos()
        {
            bool n1valido = int.TryParse(Numero1Txt.Text, out numero1);
            bool n2valido = int.TryParse(Numero2Txt.Text, out numero2);

            if (!n1valido || !n2valido)
            {
                string msg = "Os seguintes campos não podem ser convertidos em inteiros";
                if (!n1valido) msg += "\n\tCampo numero 1";
                if (!n2valido) msg += "\n\tCampo numero 2";
                msg += "\nÉ necessário corrigir os campos para poder realizar a conta!";
                MessageBox.Show(msg);
                if (!n1valido) Numero1Txt.Focus();
                else if (!n2valido) Numero2Txt.Focus();
                return false;
            }
            return true;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            AlterarBorda(Numero1Txt, numero1Valid, e);
            AlterarBorda(Numero2Txt, numero2Valid, e);
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
