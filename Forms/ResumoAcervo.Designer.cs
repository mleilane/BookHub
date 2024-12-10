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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MediumSeaGreen;
            btnEntrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(20, 337);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(194, 38);
            btnEntrar.TabIndex = 14;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(20, 410);
            button1.Name = "button1";
            button1.Size = new Size(194, 38);
            button1.TabIndex = 15;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(20, 478);
            button2.Name = "button2";
            button2.Size = new Size(194, 38);
            button2.TabIndex = 16;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(20, 549);
            button3.Name = "button3";
            button3.Size = new Size(194, 38);
            button3.TabIndex = 17;
            button3.Text = "Entrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(411, 43);
            label1.Name = "label1";
            label1.Size = new Size(268, 41);
            label1.TabIndex = 18;
            label1.Text = "Resumo do Acervo";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1089, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 301);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 20;
            label2.Text = "Menu de Navegação";
            // 
            // panel1
            // 
            panel1.Location = new Point(325, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 82);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Location = new Point(576, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(110, 82);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(834, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 82);
            panel3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 113);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 23;
            label3.Text = "Lidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 113);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 24;
            label4.Text = "Não Lidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(834, 113);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 25;
            label5.Text = "Total Acervo";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Lido });
            dataGridView1.Location = new Point(320, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(633, 295);
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
            // TodosLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 699);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TodosLivros";
            Text = "Biblioteca Pessoal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private MenuStrip menuStrip1;
        private Label label2;
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
    }
}