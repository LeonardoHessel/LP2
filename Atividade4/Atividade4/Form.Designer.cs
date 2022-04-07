namespace Atividade4
{
    partial class Form
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
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.lblNumA = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.lblNumC = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(106, 54);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(129, 26);
            this.txtNumA.TabIndex = 0;
            this.txtNumA.Validated += new System.EventHandler(this.txtNumA_Validated);
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Location = new System.Drawing.Point(22, 57);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(61, 20);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "Num A:";
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Location = new System.Drawing.Point(319, 161);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(154, 63);
            this.btnIdentificar.TabIndex = 3;
            this.btnIdentificar.Text = "Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = true;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // lblNumC
            // 
            this.lblNumC.AutoSize = true;
            this.lblNumC.Location = new System.Drawing.Point(22, 201);
            this.lblNumC.Name = "lblNumC";
            this.lblNumC.Size = new System.Drawing.Size(61, 20);
            this.lblNumC.TabIndex = 3;
            this.lblNumC.Text = "Num C:";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Location = new System.Drawing.Point(22, 133);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(61, 20);
            this.lblNumB.TabIndex = 4;
            this.lblNumB.Text = "Num B:";
            // 
            // txtNumC
            // 
            this.txtNumC.Location = new System.Drawing.Point(106, 198);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(129, 26);
            this.txtNumC.TabIndex = 2;
            this.txtNumC.Validated += new System.EventHandler(this.txtNumC_Validated);
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(106, 130);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(129, 26);
            this.txtNumB.TabIndex = 1;
            this.txtNumB.Validated += new System.EventHandler(this.txtNumB_Validated);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTipo.Location = new System.Drawing.Point(26, 258);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(447, 72);
            this.txtTipo.TabIndex = 7;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 368);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblNumC);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.txtNumA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificador de Triangulo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Label lblNumC;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtTipo;
    }
}

