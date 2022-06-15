namespace PFerramenta
{
    partial class frmFerramenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerramenta));
            this.bnvFerramenta = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbFerramenta = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.dgvFerramenta = new System.Windows.Forms.DataGridView();
            this.tabDetalhes = new System.Windows.Forms.TabPage();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtSiteOficial = new System.Windows.Forms.TextBox();
            this.lblSiteOficial = new System.Windows.Forms.Label();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.dtpDtCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDistribuicao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.cbxDistribuicao = new System.Windows.Forms.ComboBox();
            this.txtIdFerramenta = new System.Windows.Forms.TextBox();
            this.lblIdFerramenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).BeginInit();
            this.bnvFerramenta.SuspendLayout();
            this.tbFerramenta.SuspendLayout();
            this.tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).BeginInit();
            this.tabDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvFerramenta
            // 
            this.bnvFerramenta.AddNewItem = null;
            this.bnvFerramenta.CountItem = this.bindingNavigatorCountItem;
            this.bnvFerramenta.DeleteItem = null;
            this.bnvFerramenta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnvFerramenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvFerramenta.Location = new System.Drawing.Point(0, 0);
            this.bnvFerramenta.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvFerramenta.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvFerramenta.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvFerramenta.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvFerramenta.Name = "bnvFerramenta";
            this.bnvFerramenta.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bnvFerramenta.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvFerramenta.Size = new System.Drawing.Size(1061, 27);
            this.bnvFerramenta.TabIndex = 0;
            this.bnvFerramenta.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(83, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(29, 24);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(29, 24);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(29, 24);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 24);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(29, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(29, 24);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbFerramenta
            // 
            this.tbFerramenta.Controls.Add(this.tabDados);
            this.tbFerramenta.Controls.Add(this.tabDetalhes);
            this.tbFerramenta.Location = new System.Drawing.Point(14, 35);
            this.tbFerramenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbFerramenta.Name = "tbFerramenta";
            this.tbFerramenta.SelectedIndex = 0;
            this.tbFerramenta.Size = new System.Drawing.Size(959, 394);
            this.tbFerramenta.TabIndex = 1;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.dgvFerramenta);
            this.tabDados.Location = new System.Drawing.Point(4, 38);
            this.tabDados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDados.Size = new System.Drawing.Size(951, 352);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // dgvFerramenta
            // 
            this.dgvFerramenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFerramenta.Location = new System.Drawing.Point(5, 4);
            this.dgvFerramenta.Name = "dgvFerramenta";
            this.dgvFerramenta.ReadOnly = true;
            this.dgvFerramenta.RowHeadersWidth = 51;
            this.dgvFerramenta.RowTemplate.Height = 24;
            this.dgvFerramenta.Size = new System.Drawing.Size(941, 344);
            this.dgvFerramenta.TabIndex = 0;
            // 
            // tabDetalhes
            // 
            this.tabDetalhes.Controls.Add(this.cbxCategoria);
            this.tabDetalhes.Controls.Add(this.lblCategoria);
            this.tabDetalhes.Controls.Add(this.txtSiteOficial);
            this.tabDetalhes.Controls.Add(this.lblSiteOficial);
            this.tabDetalhes.Controls.Add(this.lblOpcoes);
            this.tabDetalhes.Controls.Add(this.txtFornecedor);
            this.tabDetalhes.Controls.Add(this.lblFornecedor);
            this.tabDetalhes.Controls.Add(this.lblDtCadastro);
            this.tabDetalhes.Controls.Add(this.dtpDtCadastro);
            this.tabDetalhes.Controls.Add(this.txtNome);
            this.tabDetalhes.Controls.Add(this.lblDistribuicao);
            this.tabDetalhes.Controls.Add(this.lblNome);
            this.tabDetalhes.Controls.Add(this.cbxDistribuicao);
            this.tabDetalhes.Controls.Add(this.txtIdFerramenta);
            this.tabDetalhes.Controls.Add(this.lblIdFerramenta);
            this.tabDetalhes.Location = new System.Drawing.Point(4, 38);
            this.tabDetalhes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDetalhes.Name = "tabDetalhes";
            this.tabDetalhes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabDetalhes.Size = new System.Drawing.Size(951, 352);
            this.tabDetalhes.TabIndex = 1;
            this.tabDetalhes.Text = "Detalhes";
            this.tabDetalhes.UseVisualStyleBackColor = true;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(214, 274);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(291, 37);
            this.cbxCategoria.TabIndex = 15;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(10, 277);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(124, 29);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtSiteOficial
            // 
            this.txtSiteOficial.Enabled = false;
            this.txtSiteOficial.Location = new System.Drawing.Point(214, 232);
            this.txtSiteOficial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSiteOficial.MaxLength = 100;
            this.txtSiteOficial.Name = "txtSiteOficial";
            this.txtSiteOficial.Size = new System.Drawing.Size(696, 34);
            this.txtSiteOficial.TabIndex = 5;
            // 
            // lblSiteOficial
            // 
            this.lblSiteOficial.AutoSize = true;
            this.lblSiteOficial.Location = new System.Drawing.Point(10, 235);
            this.lblSiteOficial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSiteOficial.Name = "lblSiteOficial";
            this.lblSiteOficial.Size = new System.Drawing.Size(135, 29);
            this.lblSiteOficial.TabIndex = 11;
            this.lblSiteOficial.Text = "Site Oficial:";
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Location = new System.Drawing.Point(515, 146);
            this.lblOpcoes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(395, 29);
            this.lblOpcoes.TabIndex = 10;
            this.lblOpcoes.Text = "1-Grátis 2-Paga 3-Parceria 4-Outras";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(214, 101);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFornecedor.MaxLength = 20;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(364, 34);
            this.txtFornecedor.TabIndex = 2;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(10, 104);
            this.lblFornecedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(145, 29);
            this.lblFornecedor.TabIndex = 8;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Location = new System.Drawing.Point(10, 194);
            this.lblDtCadastro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(171, 29);
            this.lblDtCadastro.TabIndex = 7;
            this.lblDtCadastro.Text = "Data Cadastro:";
            // 
            // dtpDtCadastro
            // 
            this.dtpDtCadastro.Enabled = false;
            this.dtpDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtCadastro.Location = new System.Drawing.Point(214, 189);
            this.dtpDtCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDtCadastro.Name = "dtpDtCadastro";
            this.dtpDtCadastro.Size = new System.Drawing.Size(181, 34);
            this.dtpDtCadastro.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(214, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(364, 34);
            this.txtNome.TabIndex = 1;
            // 
            // lblDistribuicao
            // 
            this.lblDistribuicao.AutoSize = true;
            this.lblDistribuicao.Location = new System.Drawing.Point(10, 146);
            this.lblDistribuicao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDistribuicao.Name = "lblDistribuicao";
            this.lblDistribuicao.Size = new System.Drawing.Size(146, 29);
            this.lblDistribuicao.TabIndex = 4;
            this.lblDistribuicao.Text = "Distribuição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 62);
            this.lblNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 29);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // cbxDistribuicao
            // 
            this.cbxDistribuicao.Enabled = false;
            this.cbxDistribuicao.FormattingEnabled = true;
            this.cbxDistribuicao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxDistribuicao.Location = new System.Drawing.Point(214, 143);
            this.cbxDistribuicao.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxDistribuicao.Name = "cbxDistribuicao";
            this.cbxDistribuicao.Size = new System.Drawing.Size(291, 37);
            this.cbxDistribuicao.TabIndex = 3;
            // 
            // txtIdFerramenta
            // 
            this.txtIdFerramenta.Enabled = false;
            this.txtIdFerramenta.Location = new System.Drawing.Point(214, 17);
            this.txtIdFerramenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIdFerramenta.Name = "txtIdFerramenta";
            this.txtIdFerramenta.Size = new System.Drawing.Size(181, 34);
            this.txtIdFerramenta.TabIndex = 0;
            this.txtIdFerramenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIdFerramenta
            // 
            this.lblIdFerramenta.AutoSize = true;
            this.lblIdFerramenta.Location = new System.Drawing.Point(10, 20);
            this.lblIdFerramenta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdFerramenta.Name = "lblIdFerramenta";
            this.lblIdFerramenta.Size = new System.Drawing.Size(42, 29);
            this.lblIdFerramenta.TabIndex = 0;
            this.lblIdFerramenta.Text = "ID:";
            // 
            // frmFerramenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1061, 631);
            this.Controls.Add(this.tbFerramenta);
            this.Controls.Add(this.bnvFerramenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmFerramenta";
            this.Text = "frmFerramenta";
            this.Load += new System.EventHandler(this.frmFerramenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).EndInit();
            this.bnvFerramenta.ResumeLayout(false);
            this.bnvFerramenta.PerformLayout();
            this.tbFerramenta.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).EndInit();
            this.tabDetalhes.ResumeLayout(false);
            this.tabDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvFerramenta;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbFerramenta;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TabPage tabDetalhes;
        private System.Windows.Forms.ComboBox cbxDistribuicao;
        private System.Windows.Forms.TextBox txtIdFerramenta;
        private System.Windows.Forms.Label lblIdFerramenta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDistribuicao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.DateTimePicker dtpDtCadastro;
        private System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtSiteOficial;
        private System.Windows.Forms.Label lblSiteOficial;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.DataGridView dgvFerramenta;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ComboBox cbxCategoria;
    }
}