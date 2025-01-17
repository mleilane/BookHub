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
            Button btnEditarLivro;
            Button btnSalvar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosLivros));
            label1 = new Label();
            dgvTodosLivros = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
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
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            txtIsbn = new TextBox();
            txtAutor = new TextBox();
            groupBox1 = new GroupBox();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            btnEditarLivro = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodosLivros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarLivro
            // 
            btnEditarLivro.BackColor = Color.DarkSlateGray;
            btnEditarLivro.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarLivro.ForeColor = SystemColors.Control;
            btnEditarLivro.Location = new Point(27, 227);
            btnEditarLivro.Name = "btnEditarLivro";
            btnEditarLivro.Size = new Size(220, 46);
            btnEditarLivro.TabIndex = 41;
            btnEditarLivro.Text = "Editar";
            btnEditarLivro.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Location = new Point(283, 227);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(220, 46);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(623, 21);
            label1.Name = "label1";
            label1.Size = new Size(318, 35);
            label1.TabIndex = 27;
            label1.Text = "Minha Estante Virtual";
            label1.Click += label1_Click;
            // 
            // dgvTodosLivros
            // 
            dgvTodosLivros.AllowUserToAddRows = false;
            dgvTodosLivros.AllowUserToDeleteRows = false;
            dgvTodosLivros.AllowUserToOrderColumns = true;
            dgvTodosLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodosLivros.ColumnHeadersHeight = 29;
            dgvTodosLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTodosLivros.Columns.AddRange(new DataGridViewColumn[] { Título, Autor, ISBN, Lido, Data_de_Registro });
            dgvTodosLivros.Location = new Point(279, 26);
            dgvTodosLivros.Name = "dgvTodosLivros";
            dgvTodosLivros.ReadOnly = true;
            dgvTodosLivros.RowHeadersWidth = 51;
            dgvTodosLivros.Size = new Size(1168, 367);
            dgvTodosLivros.TabIndex = 28;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Location = new Point(27, 55);
            txtTituloLivro.Multiline = true;
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(1132, 45);
            txtTituloLivro.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 34;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 36;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(671, 120);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 38;
            label4.Text = "ISBN";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(939, 227);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(220, 46);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkSlateGray;
            btnPesquisar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Location = new Point(1023, 140);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(136, 46);
            btnPesquisar.TabIndex = 40;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnCadastrar_Click;
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
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1495, 826);
            panel2.TabIndex = 40;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTodosLivros);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Location = new Point(14, 59);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1470, 757);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acervo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(txtIsbn);
            groupBox2.Controls.Add(txtAutor);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnEditarLivro);
            groupBox2.Controls.Add(txtTituloLivro);
            groupBox2.Controls.Add(btnPesquisar);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(268, 439);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1181, 300);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Livros no Acervo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(538, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 46);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(671, 141);
            txtIsbn.Multiline = true;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(331, 45);
            txtIsbn.TabIndex = 44;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(27, 141);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(622, 45);
            txtAutor.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResumoAcervo);
            groupBox1.Controls.Add(btnPaginaInicial);
            groupBox1.Controls.Add(btnAddLivro);
            groupBox1.Location = new Point(13, 439);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 300);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu de Navegação";
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // TodosLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 829);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TodosLivros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Livros";
            ((System.ComponentModel.ISupportInitialize)dgvTodosLivros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView dgvTodosLivros;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Lido;
        private DataGridViewTextBoxColumn Data_de_Registro;
        private Button btnAddLivro;
        private Button btnResumoAcervo;
        private Button btnPaginaInicial;
        private PictureBox pictureBox1;
        private TextBox txtTituloLivro;
        private Label label2;
        private Label label3;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnEditarLivro;
        private Button btnPesquisar;
        private Button btnExcluir;
        private Panel panel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtIsbn;
        private TextBox txtAutor;
        private Button btnCancelar;
        private GroupBox groupBox3;
    }
}