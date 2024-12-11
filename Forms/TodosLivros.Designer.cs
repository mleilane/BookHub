namespace BookHub.Forms
{
    partial class TodosLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosLivros));
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Lido = new DataGridViewTextBoxColumn();
            Data_de_Registro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 299);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 26;
            label2.Text = "Menu de Navegação";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(29, 547);
            button3.Name = "button3";
            button3.Size = new Size(194, 38);
            button3.TabIndex = 25;
            button3.Text = "Entrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(29, 476);
            button2.Name = "button2";
            button2.Size = new Size(194, 38);
            button2.TabIndex = 24;
            button2.Text = "Entrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(29, 408);
            button1.Name = "button1";
            button1.Size = new Size(194, 38);
            button1.TabIndex = 23;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MediumSeaGreen;
            btnEntrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(29, 335);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(194, 38);
            btnEntrar.TabIndex = 22;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(558, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 27;
            label1.Text = "Lista de Livros ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Lido, Data_de_Registro });
            dataGridView1.Location = new Point(259, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 359);
            dataGridView1.TabIndex = 28;
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
            // Data_de_Registro
            // 
            Data_de_Registro.HeaderText = "Data_de_Registro";
            Data_de_Registro.MinimumWidth = 6;
            Data_de_Registro.Name = "Data_de_Registro";
            Data_de_Registro.ReadOnly = true;
            // 
            // TodosLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 699);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Name = "TodosLivros";
            Text = "Lista de Livros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Lido;
        private DataGridViewTextBoxColumn Data_de_Registro;
    }
}