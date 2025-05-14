namespace BookHub.Forms
{
    partial class FrmAcervoCompleto
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
            Button btnSalvar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcervoCompleto));
            dgvTodosLivros = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Lido = new DataGridViewTextBoxColumn();
            Data_de_Registro = new DataGridViewTextBoxColumn();
            btnAddLivro = new Button();
            btnResumoAcervo = new Button();
            btnPaginaInicial = new Button();
            pictureBox1 = new PictureBox();
            txtTituloLivro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            lblTitulo = new Label();
            grpBuscarLivros = new GroupBox();
            rbtnNao = new RadioButton();
            rbtnSim = new RadioButton();
            lbllido = new Label();
            txtIsbn = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            txtQtd = new TextBox();
            txtAutor = new TextBox();
            grpMenuAcervoCompleto = new GroupBox();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodosLivros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            grpBuscarLivros.SuspendLayout();
            grpMenuAcervoCompleto.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Image = Properties.Resources.salvar2;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(28, 212);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(9, 0, 0, 0);
            btnSalvar.Size = new Size(177, 45);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // dgvTodosLivros
            // 
            dgvTodosLivros.AllowUserToAddRows = false;
            dgvTodosLivros.AllowUserToDeleteRows = false;
            dgvTodosLivros.AllowUserToOrderColumns = true;
            dgvTodosLivros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTodosLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodosLivros.ColumnHeadersHeight = 29;
            dgvTodosLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTodosLivros.Columns.AddRange(new DataGridViewColumn[] { Id, Título, Autor, ISBN, Quantidade, Lido, Data_de_Registro });
            dgvTodosLivros.Location = new Point(291, 108);
            dgvTodosLivros.Name = "dgvTodosLivros";
            dgvTodosLivros.ReadOnly = true;
            dgvTodosLivros.RowHeadersVisible = false;
            dgvTodosLivros.RowHeadersWidth = 51;
            dgvTodosLivros.Size = new Size(1175, 404);
            dgvTodosLivros.TabIndex = 28;
            dgvTodosLivros.CellClick += dgvTodosLivros_CellClick_1;
            dgvTodosLivros.SelectionChanged += dgvTodosLivros_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.MinimumWidth = 6;
            Título.Name = "Título";
            Título.ReadOnly = true;
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.ReadOnly = true;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Lido
            // 
            Lido.HeaderText = "Lido";
            Lido.MinimumWidth = 6;
            Lido.Name = "Lido";
            Lido.ReadOnly = true;
            // 
            // Data_de_Registro
            // 
            Data_de_Registro.HeaderText = "Data de Registro";
            Data_de_Registro.MinimumWidth = 6;
            Data_de_Registro.Name = "Data_de_Registro";
            Data_de_Registro.ReadOnly = true;
            // 
            // btnAddLivro
            // 
            btnAddLivro.BackColor = Color.DarkSlateGray;
            btnAddLivro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.addLivro;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(19, 133);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(8, 0, 0, 0);
            btnAddLivro.Size = new Size(194, 45);
            btnAddLivro.TabIndex = 12;
            btnAddLivro.Text = "Adicionar Livro";
            btnAddLivro.UseVisualStyleBackColor = false;
            btnAddLivro.Click += btnAddLivro_Click;
            // 
            // btnResumoAcervo
            // 
            btnResumoAcervo.BackColor = Color.DarkSlateGray;
            btnResumoAcervo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnResumoAcervo.ForeColor = SystemColors.Control;
            btnResumoAcervo.Image = Properties.Resources.Vector;
            btnResumoAcervo.ImageAlign = ContentAlignment.MiddleLeft;
            btnResumoAcervo.Location = new Point(19, 213);
            btnResumoAcervo.Name = "btnResumoAcervo";
            btnResumoAcervo.Padding = new Padding(8, 0, 0, 0);
            btnResumoAcervo.Size = new Size(194, 45);
            btnResumoAcervo.TabIndex = 13;
            btnResumoAcervo.Text = "Resumo Acervo";
            btnResumoAcervo.UseVisualStyleBackColor = false;
            btnResumoAcervo.Click += btnResumoAcervo_Click;
            // 
            // btnPaginaInicial
            // 
            btnPaginaInicial.BackColor = Color.DarkSlateGray;
            btnPaginaInicial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPaginaInicial.ForeColor = SystemColors.Control;
            btnPaginaInicial.Image = Properties.Resources.home;
            btnPaginaInicial.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaInicial.Location = new Point(19, 54);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(8, 0, 0, 0);
            btnPaginaInicial.Size = new Size(194, 45);
            btnPaginaInicial.TabIndex = 11;
            btnPaginaInicial.Text = "Página Inicial";
            btnPaginaInicial.UseVisualStyleBackColor = false;
            btnPaginaInicial.Click += btnPaginaInicial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTituloLivro.Location = new Point(27, 58);
            txtTituloLivro.Multiline = true;
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(545, 45);
            txtTituloLivro.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(23, 35);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 34;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(602, 34);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 36;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(28, 120);
            label4.Name = "label4";
            label4.Size = new Size(46, 18);
            label4.TabIndex = 38;
            label4.Text = "ISBN";
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Image = Properties.Resources.excluir_cancelar;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(400, 212);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(9, 0, 0, 0);
            btnExcluir.Size = new Size(177, 45);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.DarkSlateGray;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Image = Properties.Resources.pesquisar;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(956, 141);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Padding = new Padding(9, 0, 0, 0);
            btnPesquisar.Size = new Size(201, 45);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox3);
            panel2.Location = new Point(-2, -11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1495, 857);
            panel2.TabIndex = 40;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTitulo);
            groupBox3.Controls.Add(dgvTodosLivros);
            groupBox3.Controls.Add(grpBuscarLivros);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(grpMenuAcervoCompleto);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.DarkSlateGray;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1495, 857);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkSlateGray;
            lblTitulo.Location = new Point(611, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 36);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Minha Estante Virtual";
            // 
            // grpBuscarLivros
            // 
            grpBuscarLivros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpBuscarLivros.Controls.Add(rbtnNao);
            grpBuscarLivros.Controls.Add(rbtnSim);
            grpBuscarLivros.Controls.Add(lbllido);
            grpBuscarLivros.Controls.Add(txtIsbn);
            grpBuscarLivros.Controls.Add(label5);
            grpBuscarLivros.Controls.Add(btnCancelar);
            grpBuscarLivros.Controls.Add(btnSalvar);
            grpBuscarLivros.Controls.Add(txtQtd);
            grpBuscarLivros.Controls.Add(txtAutor);
            grpBuscarLivros.Controls.Add(btnExcluir);
            grpBuscarLivros.Controls.Add(label2);
            grpBuscarLivros.Controls.Add(txtTituloLivro);
            grpBuscarLivros.Controls.Add(btnPesquisar);
            grpBuscarLivros.Controls.Add(label3);
            grpBuscarLivros.Controls.Add(label4);
            grpBuscarLivros.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBuscarLivros.ForeColor = Color.DarkSlateGray;
            grpBuscarLivros.Location = new Point(291, 541);
            grpBuscarLivros.Name = "grpBuscarLivros";
            grpBuscarLivros.Size = new Size(1175, 275);
            grpBuscarLivros.TabIndex = 43;
            grpBuscarLivros.TabStop = false;
            grpBuscarLivros.Text = "Editar livros do acervo";
            // 
            // rbtnNao
            // 
            rbtnNao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbtnNao.AutoSize = true;
            rbtnNao.Font = new Font("Microsoft Sans Serif", 9F);
            rbtnNao.ForeColor = Color.DarkSlateGray;
            rbtnNao.Location = new Point(850, 159);
            rbtnNao.Name = "rbtnNao";
            rbtnNao.Size = new Size(57, 22);
            rbtnNao.TabIndex = 6;
            rbtnNao.TabStop = true;
            rbtnNao.Text = "Não";
            rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            rbtnSim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbtnSim.AutoSize = true;
            rbtnSim.Font = new Font("Microsoft Sans Serif", 9F);
            rbtnSim.ForeColor = Color.DarkSlateGray;
            rbtnSim.Location = new Point(787, 159);
            rbtnSim.Name = "rbtnSim";
            rbtnSim.Size = new Size(55, 22);
            rbtnSim.TabIndex = 5;
            rbtnSim.TabStop = true;
            rbtnSim.Text = "Sim";
            rbtnSim.UseVisualStyleBackColor = true;
            // 
            // lbllido
            // 
            lbllido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbllido.AutoSize = true;
            lbllido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbllido.ForeColor = Color.DarkSlateGray;
            lbllido.Location = new Point(787, 120);
            lbllido.Name = "lbllido";
            lbllido.Size = new Size(49, 18);
            lbllido.TabIndex = 50;
            lbllido.Text = "Lido?";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(28, 141);
            txtIsbn.Multiline = true;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(543, 45);
            txtIsbn.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(610, 120);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 47;
            label5.Text = "Qtd.";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Image = Properties.Resources.excluir_cancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(214, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(9, 0, 0, 0);
            btnCancelar.Size = new Size(177, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(613, 140);
            txtQtd.Multiline = true;
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(128, 45);
            txtQtd.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAutor.Location = new Point(606, 58);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(551, 45);
            txtAutor.TabIndex = 2;
            // 
            // grpMenuAcervoCompleto
            // 
            grpMenuAcervoCompleto.Controls.Add(btnResumoAcervo);
            grpMenuAcervoCompleto.Controls.Add(btnPaginaInicial);
            grpMenuAcervoCompleto.Controls.Add(btnAddLivro);
            grpMenuAcervoCompleto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMenuAcervoCompleto.ForeColor = Color.DarkSlateGray;
            grpMenuAcervoCompleto.Location = new Point(26, 541);
            grpMenuAcervoCompleto.Name = "grpMenuAcervoCompleto";
            grpMenuAcervoCompleto.Size = new Size(235, 280);
            grpMenuAcervoCompleto.TabIndex = 41;
            grpMenuAcervoCompleto.TabStop = false;
            grpMenuAcervoCompleto.Text = "Menu de Navegação";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // FrmAcervoCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 847);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAcervoCompleto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acervo Completo";
            ((System.ComponentModel.ISupportInitialize)dgvTodosLivros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grpBuscarLivros.ResumeLayout(false);
            grpBuscarLivros.PerformLayout();
            grpMenuAcervoCompleto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvTodosLivros;
        private Button btnAddLivro;
        private Button btnResumoAcervo;
        private Button btnPaginaInicial;
        private PictureBox pictureBox1;
        private TextBox txtTituloLivro;
        private Label label2;
        private Label label3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Panel panel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private GroupBox grpMenuAcervoCompleto;
        private GroupBox grpBuscarLivros;
        private TextBox txtQtd;
        private TextBox txtAutor;
        private Button btnCancelar;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Lido;
        private DataGridViewTextBoxColumn Data_de_Registro;
        private TextBox txtIsbn;
        private Label label5;
        private RadioButton rbtnNao;
        private RadioButton rbtnSim;
        private Label lbllido;
        private Label lblTitulo;
    }
}