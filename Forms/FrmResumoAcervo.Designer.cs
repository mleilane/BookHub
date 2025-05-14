namespace BookHub.Forms
{
    partial class FrmResumoAcervo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumoAcervo));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            pnlLidos = new Panel();
            lblQtdLidos = new Label();
            lblPercLidos = new Label();
            pnlNaoLidos = new Panel();
            lblQtdNaoLidos = new Label();
            lblPercNaoLidos = new Label();
            lblNaoLidos = new Label();
            pnlTotal = new Panel();
            lblTotal = new Label();
            lblLidos = new Label();
            lblTotalAcervo = new Label();
            dgvUltimosAdicionados = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Lido = new DataGridViewTextBoxColumn();
            Data_de_Registro = new DataGridViewTextBoxColumn();
            grpMenuAcervo = new GroupBox();
            btnAcervoCompleto = new Button();
            btnPaginaInicial = new Button();
            btnAddLivro = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            grpEstatisticaAcervo = new GroupBox();
            grpNovidades = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLidos.SuspendLayout();
            pnlNaoLidos.SuspendLayout();
            pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosAdicionados).BeginInit();
            grpMenuAcervo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            grpEstatisticaAcervo.SuspendLayout();
            grpNovidades.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkSlateGray;
            lblTitulo.Location = new Point(618, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 36);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Resumo do Acervo";
            // 
            // pnlLidos
            // 
            pnlLidos.Controls.Add(lblQtdLidos);
            pnlLidos.Location = new Point(157, 112);
            pnlLidos.Name = "pnlLidos";
            pnlLidos.Size = new Size(176, 125);
            pnlLidos.TabIndex = 21;
            // 
            // lblQtdLidos
            // 
            lblQtdLidos.AutoSize = true;
            lblQtdLidos.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            lblQtdLidos.Location = new Point(16, 41);
            lblQtdLidos.Name = "lblQtdLidos";
            lblQtdLidos.Size = new Size(58, 54);
            lblQtdLidos.TabIndex = 0;
            lblQtdLidos.Text = "N";
            // 
            // lblPercLidos
            // 
            lblPercLidos.AutoSize = true;
            lblPercLidos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercLidos.Location = new Point(176, 82);
            lblPercLidos.Name = "lblPercLidos";
            lblPercLidos.Size = new Size(71, 20);
            lblPercLidos.TabIndex = 1;
            lblPercLidos.Text = "%Lidos";
            // 
            // pnlNaoLidos
            // 
            pnlNaoLidos.Controls.Add(lblQtdNaoLidos);
            pnlNaoLidos.Location = new Point(555, 112);
            pnlNaoLidos.Name = "pnlNaoLidos";
            pnlNaoLidos.Size = new Size(141, 125);
            pnlNaoLidos.TabIndex = 22;
            // 
            // lblQtdNaoLidos
            // 
            lblQtdNaoLidos.AutoSize = true;
            lblQtdNaoLidos.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQtdNaoLidos.Location = new Point(30, 41);
            lblQtdNaoLidos.Name = "lblQtdNaoLidos";
            lblQtdNaoLidos.Size = new Size(58, 54);
            lblQtdNaoLidos.TabIndex = 2;
            lblQtdNaoLidos.Text = "N";
            // 
            // lblPercNaoLidos
            // 
            lblPercNaoLidos.AutoSize = true;
            lblPercNaoLidos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercNaoLidos.Location = new Point(587, 82);
            lblPercNaoLidos.Name = "lblPercNaoLidos";
            lblPercNaoLidos.Size = new Size(104, 20);
            lblPercNaoLidos.TabIndex = 3;
            lblPercNaoLidos.Text = "%Não lidos";
            // 
            // lblNaoLidos
            // 
            lblNaoLidos.AutoSize = true;
            lblNaoLidos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaoLidos.ForeColor = Color.DarkSlateGray;
            lblNaoLidos.Location = new Point(446, 75);
            lblNaoLidos.Name = "lblNaoLidos";
            lblNaoLidos.Size = new Size(132, 29);
            lblNaoLidos.TabIndex = 24;
            lblNaoLidos.Text = "Não Lidos";
            // 
            // pnlTotal
            // 
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Location = new Point(963, 111);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(176, 127);
            pnlTotal.TabIndex = 22;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            lblTotal.Location = new Point(13, 42);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 54);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "N";
            // 
            // lblLidos
            // 
            lblLidos.AutoSize = true;
            lblLidos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblLidos.ForeColor = Color.DarkSlateGray;
            lblLidos.Location = new Point(62, 75);
            lblLidos.Name = "lblLidos";
            lblLidos.Size = new Size(77, 29);
            lblLidos.TabIndex = 23;
            lblLidos.Text = "Lidos";
            // 
            // lblTotalAcervo
            // 
            lblTotalAcervo.AutoSize = true;
            lblTotalAcervo.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            lblTotalAcervo.ForeColor = Color.DarkSlateGray;
            lblTotalAcervo.Location = new Point(853, 75);
            lblTotalAcervo.Name = "lblTotalAcervo";
            lblTotalAcervo.Size = new Size(160, 29);
            lblTotalAcervo.TabIndex = 25;
            lblTotalAcervo.Text = "Total Acervo";
            // 
            // dgvUltimosAdicionados
            // 
            dgvUltimosAdicionados.AllowUserToAddRows = false;
            dgvUltimosAdicionados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dgvUltimosAdicionados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUltimosAdicionados.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvUltimosAdicionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimosAdicionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosAdicionados.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Quantidade, Lido, Data_de_Registro });
            dgvUltimosAdicionados.Location = new Point(27, 40);
            dgvUltimosAdicionados.Name = "dgvUltimosAdicionados";
            dgvUltimosAdicionados.ReadOnly = true;
            dgvUltimosAdicionados.RowHeadersVisible = false;
            dgvUltimosAdicionados.RowHeadersWidth = 51;
            dgvUltimosAdicionados.Size = new Size(1135, 271);
            dgvUltimosAdicionados.TabIndex = 26;
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
            // grpMenuAcervo
            // 
            grpMenuAcervo.Controls.Add(btnAcervoCompleto);
            grpMenuAcervo.Controls.Add(btnPaginaInicial);
            grpMenuAcervo.Controls.Add(btnAddLivro);
            grpMenuAcervo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMenuAcervo.ForeColor = Color.DarkSlateGray;
            grpMenuAcervo.Location = new Point(26, 469);
            grpMenuAcervo.Name = "grpMenuAcervo";
            grpMenuAcervo.Size = new Size(235, 331);
            grpMenuAcervo.TabIndex = 42;
            grpMenuAcervo.TabStop = false;
            grpMenuAcervo.Text = "Menu de Navegação";
            // 
            // btnAcervoCompleto
            // 
            btnAcervoCompleto.BackColor = Color.DarkSlateGray;
            btnAcervoCompleto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAcervoCompleto.ForeColor = SystemColors.Control;
            btnAcervoCompleto.Image = Properties.Resources.Vector;
            btnAcervoCompleto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcervoCompleto.Location = new Point(14, 240);
            btnAcervoCompleto.Name = "btnAcervoCompleto";
            btnAcervoCompleto.Padding = new Padding(8, 0, 0, 0);
            btnAcervoCompleto.Size = new Size(206, 45);
            btnAcervoCompleto.TabIndex = 31;
            btnAcervoCompleto.Text = "Acervo Completo";
            btnAcervoCompleto.UseVisualStyleBackColor = false;
            btnAcervoCompleto.Click += btnAcervoCompleto_Click;
            // 
            // btnPaginaInicial
            // 
            btnPaginaInicial.BackColor = Color.DarkSlateGray;
            btnPaginaInicial.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPaginaInicial.ForeColor = SystemColors.Control;
            btnPaginaInicial.Image = Properties.Resources.home;
            btnPaginaInicial.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaInicial.Location = new Point(14, 64);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(8, 0, 0, 0);
            btnPaginaInicial.Size = new Size(206, 45);
            btnPaginaInicial.TabIndex = 30;
            btnPaginaInicial.Text = "Página Inicial";
            btnPaginaInicial.UseVisualStyleBackColor = false;
            btnPaginaInicial.Click += btnPaginaInicial_Click;
            // 
            // btnAddLivro
            // 
            btnAddLivro.BackColor = Color.DarkSlateGray;
            btnAddLivro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.addLivro;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(14, 152);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(8, 0, 0, 0);
            btnAddLivro.Size = new Size(206, 45);
            btnAddLivro.TabIndex = 32;
            btnAddLivro.Text = "Adicionar Livro";
            btnAddLivro.UseVisualStyleBackColor = false;
            btnAddLivro.Click += btnAddLivro_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.livro_fechado;
            pictureBox2.Location = new Point(446, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pilha_de_livros;
            pictureBox3.Location = new Point(853, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.livro_aberto3;
            pictureBox4.Location = new Point(48, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(106, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // grpEstatisticaAcervo
            // 
            grpEstatisticaAcervo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpEstatisticaAcervo.Controls.Add(lblPercLidos);
            grpEstatisticaAcervo.Controls.Add(pictureBox4);
            grpEstatisticaAcervo.Controls.Add(lblPercNaoLidos);
            grpEstatisticaAcervo.Controls.Add(pictureBox3);
            grpEstatisticaAcervo.Controls.Add(pictureBox2);
            grpEstatisticaAcervo.Controls.Add(lblNaoLidos);
            grpEstatisticaAcervo.Controls.Add(lblTotalAcervo);
            grpEstatisticaAcervo.Controls.Add(lblLidos);
            grpEstatisticaAcervo.Controls.Add(pnlTotal);
            grpEstatisticaAcervo.Controls.Add(pnlNaoLidos);
            grpEstatisticaAcervo.Controls.Add(pnlLidos);
            grpEstatisticaAcervo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEstatisticaAcervo.ForeColor = Color.DarkSlateGray;
            grpEstatisticaAcervo.Location = new Point(289, 133);
            grpEstatisticaAcervo.Name = "grpEstatisticaAcervo";
            grpEstatisticaAcervo.Size = new Size(1184, 295);
            grpEstatisticaAcervo.TabIndex = 46;
            grpEstatisticaAcervo.TabStop = false;
            grpEstatisticaAcervo.Text = "Indicadores de Leitura";
            // 
            // grpNovidades
            // 
            grpNovidades.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grpNovidades.Controls.Add(dgvUltimosAdicionados);
            grpNovidades.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpNovidades.ForeColor = Color.DarkSlateGray;
            grpNovidades.Location = new Point(289, 468);
            grpNovidades.Name = "grpNovidades";
            grpNovidades.Size = new Size(1184, 331);
            grpNovidades.TabIndex = 47;
            grpNovidades.TabStop = false;
            grpNovidades.Text = "Novidades";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(grpNovidades);
            groupBox4.Controls.Add(lblTitulo);
            groupBox4.Controls.Add(grpEstatisticaAcervo);
            groupBox4.Controls.Add(grpMenuAcervo);
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Location = new Point(0, -17);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1494, 846);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            groupBox4.Text = " ";
            // 
            // FrmResumoAcervo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 829);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmResumoAcervo";
            Text = "Resumo do Acervo";
            Load += FrmResumoAcervo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLidos.ResumeLayout(false);
            pnlLidos.PerformLayout();
            pnlNaoLidos.ResumeLayout(false);
            pnlNaoLidos.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosAdicionados).EndInit();
            grpMenuAcervo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            grpEstatisticaAcervo.ResumeLayout(false);
            grpEstatisticaAcervo.PerformLayout();
            grpNovidades.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button button1;
        private Button button2;
        private Label lblTitulo;
        private Panel pnlLidos;
        private Panel pnlNaoLidos;
        private Panel pnlTotal;
        private Label lblLidos;
        private Label lblNaoLidos;
        private Label lblTotalAcervo;
        private DataGridView dgvUltimosAdicionados;
        private GroupBox grpMenuAcervo;
        private Button btnAcervoCompleto;
        private Button btnPaginaInicial;
        private Button btnAddLivro;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private GroupBox grpEstatisticaAcervo;
        private GroupBox grpNovidades;
        private GroupBox groupBox4;
        private Label lblPercLidos;
        private Label lblQtdLidos;
        private Label lblPercNaoLidos;
        private Label lblQtdNaoLidos;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Lido;
        private DataGridViewTextBoxColumn Data_de_Registro;
    }
}