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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblLidos = new Label();
            lblNaoLidos = new Label();
            lblTotalAcervo = new Label();
            dataGridView1 = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Lido = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            pictureBox1.Location = new Point(23, 75);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkSlateGray;
            lblTitulo.Location = new Point(541, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 29);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Resumo do Acervo";
            // 
            // panel1
            // 
            panel1.Location = new Point(137, 84);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 94);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Location = new Point(486, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 96);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(843, 83);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 95);
            panel3.TabIndex = 22;
            // 
            // lblLidos
            // 
            lblLidos.AutoSize = true;
            lblLidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblLidos.ForeColor = Color.DarkSlateGray;
            lblLidos.Location = new Point(40, 62);
            lblLidos.Name = "lblLidos";
            lblLidos.Size = new Size(49, 18);
            lblLidos.TabIndex = 23;
            lblLidos.Text = "Lidos";
            // 
            // lblNaoLidos
            // 
            lblNaoLidos.AutoSize = true;
            lblNaoLidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblNaoLidos.ForeColor = Color.DarkSlateGray;
            lblNaoLidos.Location = new Point(394, 62);
            lblNaoLidos.Name = "lblNaoLidos";
            lblNaoLidos.Size = new Size(85, 18);
            lblNaoLidos.TabIndex = 24;
            lblNaoLidos.Text = "Não Lidos";
            // 
            // lblTotalAcervo
            // 
            lblTotalAcervo.AutoSize = true;
            lblTotalAcervo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblTotalAcervo.ForeColor = Color.DarkSlateGray;
            lblTotalAcervo.Location = new Point(745, 62);
            lblTotalAcervo.Name = "lblTotalAcervo";
            lblTotalAcervo.Size = new Size(103, 18);
            lblTotalAcervo.TabIndex = 25;
            lblTotalAcervo.Text = "Total Acervo";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Lido });
            dataGridView1.Location = new Point(24, 30);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(993, 203);
            dataGridView1.TabIndex = 26;
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
            // Lido
            // 
            Lido.HeaderText = "Lido";
            Lido.MinimumWidth = 6;
            Lido.Name = "Lido";
            Lido.ReadOnly = true;
            // 
            // grpMenuAcervo
            // 
            grpMenuAcervo.Controls.Add(btnAcervoCompleto);
            grpMenuAcervo.Controls.Add(btnPaginaInicial);
            grpMenuAcervo.Controls.Add(btnAddLivro);
            grpMenuAcervo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMenuAcervo.ForeColor = Color.DarkSlateGray;
            grpMenuAcervo.Location = new Point(23, 376);
            grpMenuAcervo.Margin = new Padding(3, 2, 3, 2);
            grpMenuAcervo.Name = "grpMenuAcervo";
            grpMenuAcervo.Padding = new Padding(3, 2, 3, 2);
            grpMenuAcervo.Size = new Size(206, 248);
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
            btnAcervoCompleto.Location = new Point(12, 180);
            btnAcervoCompleto.Margin = new Padding(3, 2, 3, 2);
            btnAcervoCompleto.Name = "btnAcervoCompleto";
            btnAcervoCompleto.Padding = new Padding(7, 0, 0, 0);
            btnAcervoCompleto.Size = new Size(180, 34);
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
            btnPaginaInicial.Location = new Point(12, 64);
            btnPaginaInicial.Margin = new Padding(3, 2, 3, 2);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(7, 0, 0, 0);
            btnPaginaInicial.Size = new Size(180, 34);
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
            btnAddLivro.Location = new Point(12, 121);
            btnAddLivro.Margin = new Padding(3, 2, 3, 2);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(7, 0, 0, 0);
            btnAddLivro.Size = new Size(180, 34);
            btnAddLivro.TabIndex = 32;
            btnAddLivro.Text = "Adicionar Livro";
            btnAddLivro.UseVisualStyleBackColor = false;
            btnAddLivro.Click += btnAddLivro_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.livro_fechado;
            pictureBox2.Location = new Point(390, 84);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pilha_de_livros;
            pictureBox3.Location = new Point(746, 84);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.livro_aberto3;
            pictureBox4.Location = new Point(42, 84);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(93, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // grpEstatisticaAcervo
            // 
            grpEstatisticaAcervo.Controls.Add(pictureBox4);
            grpEstatisticaAcervo.Controls.Add(pictureBox3);
            grpEstatisticaAcervo.Controls.Add(pictureBox2);
            grpEstatisticaAcervo.Controls.Add(lblTotalAcervo);
            grpEstatisticaAcervo.Controls.Add(lblNaoLidos);
            grpEstatisticaAcervo.Controls.Add(lblLidos);
            grpEstatisticaAcervo.Controls.Add(panel3);
            grpEstatisticaAcervo.Controls.Add(panel2);
            grpEstatisticaAcervo.Controls.Add(panel1);
            grpEstatisticaAcervo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEstatisticaAcervo.ForeColor = Color.DarkSlateGray;
            grpEstatisticaAcervo.Location = new Point(260, 100);
            grpEstatisticaAcervo.Margin = new Padding(3, 2, 3, 2);
            grpEstatisticaAcervo.Name = "grpEstatisticaAcervo";
            grpEstatisticaAcervo.Padding = new Padding(3, 2, 3, 2);
            grpEstatisticaAcervo.Size = new Size(1036, 221);
            grpEstatisticaAcervo.TabIndex = 46;
            grpEstatisticaAcervo.TabStop = false;
            grpEstatisticaAcervo.Text = "Estatísticas do Acervo";
            // 
            // grpNovidades
            // 
            grpNovidades.Controls.Add(dataGridView1);
            grpNovidades.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpNovidades.ForeColor = Color.DarkSlateGray;
            grpNovidades.Location = new Point(260, 376);
            grpNovidades.Margin = new Padding(3, 2, 3, 2);
            grpNovidades.Name = "grpNovidades";
            grpNovidades.Padding = new Padding(3, 2, 3, 2);
            grpNovidades.Size = new Size(1036, 248);
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
            groupBox4.Location = new Point(-5, -27);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(1314, 646);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            groupBox4.Text = " ";
            // 
            // FrmResumoAcervo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 622);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmResumoAcervo";
            Text = "Resumo do Acervo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblLidos;
        private Label lblNaoLidos;
        private Label lblTotalAcervo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Lido;
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
    }
}