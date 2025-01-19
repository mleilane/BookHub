namespace BookHub.Forms
{
    partial class ResumoAcervo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumoAcervo));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            lblTitulo.Location = new Point(618, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 36);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Resumo do Acervo";
            // 
            // panel1
            // 
            panel1.Location = new Point(157, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 126);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Location = new Point(555, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 128);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(963, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 127);
            panel3.TabIndex = 22;
            // 
            // lblLidos
            // 
            lblLidos.AutoSize = true;
            lblLidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblLidos.ForeColor = Color.DarkSlateGray;
            lblLidos.Location = new Point(46, 83);
            lblLidos.Name = "lblLidos";
            lblLidos.Size = new Size(58, 22);
            lblLidos.TabIndex = 23;
            lblLidos.Text = "Lidos";
            // 
            // lblNaoLidos
            // 
            lblNaoLidos.AutoSize = true;
            lblNaoLidos.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblNaoLidos.ForeColor = Color.DarkSlateGray;
            lblNaoLidos.Location = new Point(450, 83);
            lblNaoLidos.Name = "lblNaoLidos";
            lblNaoLidos.Size = new Size(100, 22);
            lblNaoLidos.TabIndex = 24;
            lblNaoLidos.Text = "Não Lidos";
            // 
            // lblTotalAcervo
            // 
            lblTotalAcervo.AutoSize = true;
            lblTotalAcervo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            lblTotalAcervo.ForeColor = Color.DarkSlateGray;
            lblTotalAcervo.Location = new Point(851, 83);
            lblTotalAcervo.Name = "lblTotalAcervo";
            lblTotalAcervo.Size = new Size(124, 22);
            lblTotalAcervo.TabIndex = 25;
            lblTotalAcervo.Text = "Total Acervo";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Lido });
            dataGridView1.Location = new Point(28, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1135, 271);
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
            grpMenuAcervo.Location = new Point(26, 502);
            grpMenuAcervo.Name = "grpMenuAcervo";
            grpMenuAcervo.Size = new Size(235, 330);
            grpMenuAcervo.TabIndex = 42;
            grpMenuAcervo.TabStop = false;
            grpMenuAcervo.Text = "Menu de Navegação";
            // 
            // btnAcervoCompleto
            // 
            btnAcervoCompleto.BackColor = Color.DarkSlateGray;
            btnAcervoCompleto.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnAcervoCompleto.ForeColor = SystemColors.Control;
            btnAcervoCompleto.Image = Properties.Resources.Vector;
            btnAcervoCompleto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcervoCompleto.Location = new Point(18, 240);
            btnAcervoCompleto.Name = "btnAcervoCompleto";
            btnAcervoCompleto.Padding = new Padding(8, 0, 0, 0);
            btnAcervoCompleto.Size = new Size(194, 46);
            btnAcervoCompleto.TabIndex = 31;
            btnAcervoCompleto.Text = "Acervo Completo";
            btnAcervoCompleto.UseVisualStyleBackColor = false;
            btnAcervoCompleto.Click += btnAcervoCompleto_Click;
            // 
            // btnPaginaInicial
            // 
            btnPaginaInicial.BackColor = Color.DarkSlateGray;
            btnPaginaInicial.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPaginaInicial.ForeColor = SystemColors.Control;
            btnPaginaInicial.Image = Properties.Resources.home;
            btnPaginaInicial.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaInicial.Location = new Point(18, 85);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(8, 0, 0, 0);
            btnPaginaInicial.Size = new Size(194, 46);
            btnPaginaInicial.TabIndex = 30;
            btnPaginaInicial.Text = "Página Inicial";
            btnPaginaInicial.UseVisualStyleBackColor = false;
            btnPaginaInicial.Click += btnPaginaInicial_Click;
            // 
            // btnAddLivro
            // 
            btnAddLivro.BackColor = Color.DarkSlateGray;
            btnAddLivro.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.addLivro;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(18, 161);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(8, 0, 0, 0);
            btnAddLivro.Size = new Size(194, 46);
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
            pictureBox2.Size = new Size(106, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pilha_de_livros;
            pictureBox3.Location = new Point(853, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 126);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.livro_aberto3;
            pictureBox4.Location = new Point(48, 112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(106, 126);
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
            grpEstatisticaAcervo.Location = new Point(297, 133);
            grpEstatisticaAcervo.Name = "grpEstatisticaAcervo";
            grpEstatisticaAcervo.Size = new Size(1184, 295);
            grpEstatisticaAcervo.TabIndex = 46;
            grpEstatisticaAcervo.TabStop = false;
            grpEstatisticaAcervo.Text = "Estatísticas do Acervo";
            // 
            // grpNovidades
            // 
            grpNovidades.Controls.Add(dataGridView1);
            grpNovidades.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpNovidades.ForeColor = Color.DarkSlateGray;
            grpNovidades.Location = new Point(297, 502);
            grpNovidades.Name = "grpNovidades";
            grpNovidades.Size = new Size(1184, 330);
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
            groupBox4.Location = new Point(-6, -36);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1502, 862);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            groupBox4.Text = " ";
            // 
            // ResumoAcervo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 829);
            Controls.Add(groupBox4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResumoAcervo";
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