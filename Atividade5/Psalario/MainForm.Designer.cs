namespace Psalario
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtMas = new System.Windows.Forms.RadioButton();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.cbxCasado = new System.Windows.Forms.CheckBox();
            this.cbxQtdFilhos = new System.Windows.Forms.ComboBox();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblQtdFilhos = new System.Windows.Forms.Label();
            this.lblAirpf = new System.Windows.Forms.Label();
            this.txtAirrf = new System.Windows.Forms.TextBox();
            this.lblAinss = new System.Windows.Forms.Label();
            this.txtAinss = new System.Windows.Forms.TextBox();
            this.lblSliquido = new System.Windows.Forms.Label();
            this.txtSliquido = new System.Windows.Forms.TextBox();
            this.lblSfamilia = new System.Windows.Forms.Label();
            this.txtSfamilia = new System.Windows.Forms.TextBox();
            this.lblDirrf = new System.Windows.Forms.Label();
            this.txtDirrf = new System.Windows.Forms.TextBox();
            this.lblDinss = new System.Windows.Forms.Label();
            this.txtDinss = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gpbSexo.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(380, 162);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(215, 44);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(133, 33);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 36);
            this.lblNome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtMas);
            this.gpbSexo.Controls.Add(this.rbtFem);
            this.gpbSexo.Location = new System.Drawing.Point(463, 33);
            this.gpbSexo.Margin = new System.Windows.Forms.Padding(6);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Padding = new System.Windows.Forms.Padding(6);
            this.gpbSexo.Size = new System.Drawing.Size(132, 112);
            this.gpbSexo.TabIndex = 4;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtMas
            // 
            this.rbtMas.AutoSize = true;
            this.rbtMas.Location = new System.Drawing.Point(46, 72);
            this.rbtMas.Margin = new System.Windows.Forms.Padding(6);
            this.rbtMas.Name = "rbtMas";
            this.rbtMas.Size = new System.Drawing.Size(40, 24);
            this.rbtMas.TabIndex = 1;
            this.rbtMas.Text = "M";
            this.rbtMas.UseVisualStyleBackColor = true;
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Checked = true;
            this.rbtFem.Location = new System.Drawing.Point(46, 31);
            this.rbtFem.Margin = new System.Windows.Forms.Padding(6);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(37, 24);
            this.rbtFem.TabIndex = 0;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "F";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // cbxCasado
            // 
            this.cbxCasado.AutoSize = true;
            this.cbxCasado.Location = new System.Drawing.Point(26, 12);
            this.cbxCasado.Margin = new System.Windows.Forms.Padding(6);
            this.cbxCasado.Name = "cbxCasado";
            this.cbxCasado.Size = new System.Drawing.Size(83, 24);
            this.cbxCasado.TabIndex = 0;
            this.cbxCasado.Text = "Casado";
            this.cbxCasado.UseVisualStyleBackColor = true;
            // 
            // cbxQtdFilhos
            // 
            this.cbxQtdFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQtdFilhos.FormattingEnabled = true;
            this.cbxQtdFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxQtdFilhos.Location = new System.Drawing.Point(133, 117);
            this.cbxQtdFilhos.Margin = new System.Windows.Forms.Padding(6);
            this.cbxQtdFilhos.Name = "cbxQtdFilhos";
            this.cbxQtdFilhos.Size = new System.Drawing.Size(177, 28);
            this.cbxQtdFilhos.TabIndex = 2;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.cbxCasado);
            this.pnlCasado.Location = new System.Drawing.Point(319, 105);
            this.pnlCasado.Margin = new System.Windows.Forms.Padding(6);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(132, 45);
            this.pnlCasado.TabIndex = 3;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(15, 78);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(101, 20);
            this.lblSalarioBruto.TabIndex = 8;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(133, 75);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(318, 26);
            this.txtSalario.TabIndex = 1;
            // 
            // lblQtdFilhos
            // 
            this.lblQtdFilhos.AutoSize = true;
            this.lblQtdFilhos.Location = new System.Drawing.Point(15, 123);
            this.lblQtdFilhos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQtdFilhos.Name = "lblQtdFilhos";
            this.lblQtdFilhos.Size = new System.Drawing.Size(85, 20);
            this.lblQtdFilhos.TabIndex = 9;
            this.lblQtdFilhos.Text = "Qtd. Filhos";
            // 
            // lblAirpf
            // 
            this.lblAirpf.AutoSize = true;
            this.lblAirpf.Location = new System.Drawing.Point(15, 341);
            this.lblAirpf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAirpf.Name = "lblAirpf";
            this.lblAirpf.Size = new System.Drawing.Size(108, 20);
            this.lblAirpf.TabIndex = 13;
            this.lblAirpf.Text = "Alíquota IRPF";
            // 
            // txtAirrf
            // 
            this.txtAirrf.Location = new System.Drawing.Point(168, 338);
            this.txtAirrf.Margin = new System.Windows.Forms.Padding(6);
            this.txtAirrf.Name = "txtAirrf";
            this.txtAirrf.ReadOnly = true;
            this.txtAirrf.Size = new System.Drawing.Size(142, 26);
            this.txtAirrf.TabIndex = 12;
            // 
            // lblAinss
            // 
            this.lblAinss.AutoSize = true;
            this.lblAinss.Location = new System.Drawing.Point(15, 299);
            this.lblAinss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAinss.Name = "lblAinss";
            this.lblAinss.Size = new System.Drawing.Size(109, 20);
            this.lblAinss.TabIndex = 11;
            this.lblAinss.Text = "Alíquota INSS";
            // 
            // txtAinss
            // 
            this.txtAinss.Location = new System.Drawing.Point(168, 296);
            this.txtAinss.Margin = new System.Windows.Forms.Padding(6);
            this.txtAinss.Name = "txtAinss";
            this.txtAinss.ReadOnly = true;
            this.txtAinss.Size = new System.Drawing.Size(142, 26);
            this.txtAinss.TabIndex = 10;
            // 
            // lblSliquido
            // 
            this.lblSliquido.AutoSize = true;
            this.lblSliquido.Location = new System.Drawing.Point(15, 425);
            this.lblSliquido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSliquido.Name = "lblSliquido";
            this.lblSliquido.Size = new System.Drawing.Size(113, 20);
            this.lblSliquido.TabIndex = 17;
            this.lblSliquido.Text = "Salário Líquido";
            // 
            // txtSliquido
            // 
            this.txtSliquido.Location = new System.Drawing.Point(168, 422);
            this.txtSliquido.Margin = new System.Windows.Forms.Padding(6);
            this.txtSliquido.Name = "txtSliquido";
            this.txtSliquido.ReadOnly = true;
            this.txtSliquido.Size = new System.Drawing.Size(142, 26);
            this.txtSliquido.TabIndex = 16;
            // 
            // lblSfamilia
            // 
            this.lblSfamilia.AutoSize = true;
            this.lblSfamilia.Location = new System.Drawing.Point(15, 383);
            this.lblSfamilia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSfamilia.Name = "lblSfamilia";
            this.lblSfamilia.Size = new System.Drawing.Size(112, 20);
            this.lblSfamilia.TabIndex = 15;
            this.lblSfamilia.Text = "Salário Família";
            // 
            // txtSfamilia
            // 
            this.txtSfamilia.Location = new System.Drawing.Point(168, 380);
            this.txtSfamilia.Margin = new System.Windows.Forms.Padding(6);
            this.txtSfamilia.Name = "txtSfamilia";
            this.txtSfamilia.ReadOnly = true;
            this.txtSfamilia.Size = new System.Drawing.Size(142, 26);
            this.txtSfamilia.TabIndex = 14;
            // 
            // lblDirrf
            // 
            this.lblDirrf.AutoSize = true;
            this.lblDirrf.Location = new System.Drawing.Point(322, 341);
            this.lblDirrf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDirrf.Name = "lblDirrf";
            this.lblDirrf.Size = new System.Drawing.Size(121, 20);
            this.lblDirrf.TabIndex = 21;
            this.lblDirrf.Text = "Desconto IRRF";
            // 
            // txtDirrf
            // 
            this.txtDirrf.Location = new System.Drawing.Point(454, 338);
            this.txtDirrf.Margin = new System.Windows.Forms.Padding(6);
            this.txtDirrf.Name = "txtDirrf";
            this.txtDirrf.ReadOnly = true;
            this.txtDirrf.Size = new System.Drawing.Size(141, 26);
            this.txtDirrf.TabIndex = 20;
            // 
            // lblDinss
            // 
            this.lblDinss.AutoSize = true;
            this.lblDinss.Location = new System.Drawing.Point(322, 299);
            this.lblDinss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDinss.Name = "lblDinss";
            this.lblDinss.Size = new System.Drawing.Size(120, 20);
            this.lblDinss.TabIndex = 19;
            this.lblDinss.Text = "Desconto INSS";
            // 
            // txtDinss
            // 
            this.txtDinss.Location = new System.Drawing.Point(454, 296);
            this.txtDinss.Margin = new System.Windows.Forms.Padding(6);
            this.txtDinss.Name = "txtDinss";
            this.txtDinss.ReadOnly = true;
            this.txtDinss.Size = new System.Drawing.Size(141, 26);
            this.txtDinss.TabIndex = 18;
            // 
            // lblDados
            // 
            this.lblDados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDados.Location = new System.Drawing.Point(15, 217);
            this.lblDados.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(580, 65);
            this.lblDados.TabIndex = 22;
            this.lblDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(618, 473);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblDirrf);
            this.Controls.Add(this.txtDirrf);
            this.Controls.Add(this.lblDinss);
            this.Controls.Add(this.txtDinss);
            this.Controls.Add(this.lblSliquido);
            this.Controls.Add(this.txtSliquido);
            this.Controls.Add(this.lblSfamilia);
            this.Controls.Add(this.txtSfamilia);
            this.Controls.Add(this.lblAirpf);
            this.Controls.Add(this.txtAirrf);
            this.Controls.Add(this.lblAinss);
            this.Controls.Add(this.txtAinss);
            this.Controls.Add(this.lblQtdFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.cbxQtdFilhos);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVerificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IRRF / INSS";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtMas;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.CheckBox cbxCasado;
        private System.Windows.Forms.ComboBox cbxQtdFilhos;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblQtdFilhos;
        private System.Windows.Forms.Label lblAirpf;
        private System.Windows.Forms.TextBox txtAirrf;
        private System.Windows.Forms.Label lblAinss;
        private System.Windows.Forms.TextBox txtAinss;
        private System.Windows.Forms.Label lblSliquido;
        private System.Windows.Forms.TextBox txtSliquido;
        private System.Windows.Forms.Label lblSfamilia;
        private System.Windows.Forms.TextBox txtSfamilia;
        private System.Windows.Forms.Label lblDirrf;
        private System.Windows.Forms.TextBox txtDirrf;
        private System.Windows.Forms.Label lblDinss;
        private System.Windows.Forms.TextBox txtDinss;
        private System.Windows.Forms.Label lblDados;
    }
}

