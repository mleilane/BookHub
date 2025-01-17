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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Lido = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnResumoAcervo = new Button();
            btnPaginaInicial = new Button();
            btnAddLivro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(635, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 35);
            label1.TabIndex = 18;
            label1.Text = "Resumo do Acervo";
            // 
            // panel1
            // 
            panel1.Location = new Point(375, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 149);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Location = new Point(731, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 149);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(1087, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 149);
            panel3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(434, 84);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 23;
            label3.Text = "Lidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(731, 84);
            label4.Name = "label4";
            label4.Size = new Size(79, 18);
            label4.TabIndex = 24;
            label4.Text = "Não Lidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(1083, 84);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 25;
            label5.Text = "Total Acervo";
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
            dataGridView1.Location = new Point(371, 480);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1059, 295);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResumoAcervo);
            groupBox1.Controls.Add(btnPaginaInicial);
            groupBox1.Controls.Add(btnAddLivro);
            groupBox1.Location = new Point(33, 475);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 300);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu de Navegação";
            // 
            // btnResumoAcervo
            // 
            btnResumoAcervo.BackColor = Color.DarkSlateGray;
            btnResumoAcervo.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnResumoAcervo.ForeColor = SystemColors.Control;
            btnResumoAcervo.Image = Properties.Resources.Vector;
            btnResumoAcervo.ImageAlign = ContentAlignment.MiddleLeft;
            btnResumoAcervo.Location = new Point(19, 228);
            btnResumoAcervo.Name = "btnResumoAcervo";
            btnResumoAcervo.Padding = new Padding(8, 0, 0, 0);
            btnResumoAcervo.Size = new Size(200, 46);
            btnResumoAcervo.TabIndex = 31;
            btnResumoAcervo.Text = "Resumo Acervo";
            btnResumoAcervo.UseVisualStyleBackColor = false;
            // 
            // btnPaginaInicial
            // 
            btnPaginaInicial.BackColor = Color.DarkSlateGray;
            btnPaginaInicial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaginaInicial.ForeColor = SystemColors.Control;
            btnPaginaInicial.Image = Properties.Resources.home;
            btnPaginaInicial.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaginaInicial.Location = new Point(19, 69);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(8, 0, 0, 0);
            btnPaginaInicial.Size = new Size(194, 46);
            btnPaginaInicial.TabIndex = 30;
            btnPaginaInicial.Text = "Página Inicial";
            btnPaginaInicial.UseVisualStyleBackColor = false;
            // 
            // btnAddLivro
            // 
            btnAddLivro.BackColor = Color.DarkSlateGray;
            btnAddLivro.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.addLivro;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(19, 148);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(8, 0, 0, 0);
            btnAddLivro.Size = new Size(194, 46);
            btnAddLivro.TabIndex = 32;
            btnAddLivro.Text = "Adicionar Livro";
            btnAddLivro.UseVisualStyleBackColor = false;
            // 
            // ResumoAcervo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 829);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResumoAcervo";
            Text = "Biblioteca Pessoal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button button1;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Lido;
        private GroupBox groupBox1;
        private Button btnResumoAcervo;
        private Button btnPaginaInicial;
        private Button btnAddLivro;
    }
}