using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta
{
    public partial class MainForm : Form
    {
        public static SqlConnection conexao;

        public MainForm()
        {
            InitializeComponent();

            // Data Source=(localdb)\SteelConnections2022;Initial Catalog=LP2;Integrated Security=True
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Data Source=(localdb)\SteelConnections2022;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro de banco de dados =/{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Outros erros =/{ex.Message}");
            }
        }

        private void cadastroDeFerramentadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmFerramenta"];
            if (fc != null)
                fc.Close();

            frmFerramenta frm = new frmFerramenta();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
