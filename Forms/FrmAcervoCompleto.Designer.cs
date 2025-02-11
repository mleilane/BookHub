﻿namespace BookHub.Forms
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
            Button btnEditarLivro;
            Button btnSalvar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcervoCompleto));
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
            grpBuscarLivros = new GroupBox();
            btnCancelar = new Button();
            txtIsbn = new TextBox();
            txtAutor = new TextBox();
            grpMenuAcervoCompleto = new GroupBox();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            btnEditarLivro = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodosLivros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            grpBuscarLivros.SuspendLayout();
            grpMenuAcervoCompleto.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditarLivro
            // 
            btnEditarLivro.BackColor = Color.DarkSlateGray;
            btnEditarLivro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnEditarLivro.ForeColor = SystemColors.Control;
            btnEditarLivro.Image = Properties.Resources.editar;
            btnEditarLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarLivro.Location = new Point(24, 170);
            btnEditarLivro.Margin = new Padding(3, 2, 3, 2);
            btnEditarLivro.Name = "btnEditarLivro";
            btnEditarLivro.Padding = new Padding(8, 0, 0, 0);
            btnEditarLivro.Size = new Size(192, 34);
            btnEditarLivro.TabIndex = 41;
            btnEditarLivro.Text = "Editar";
            btnEditarLivro.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Image = Properties.Resources.salvar2;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(248, 170);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(8, 0, 0, 0);
            btnSalvar.Size = new Size(192, 34);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(534, 45);
            label1.Name = "label1";
            label1.Size = new Size(258, 29);
            label1.TabIndex = 27;
            label1.Text = "Minha Estante Virtual";
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
            dgvTodosLivros.Location = new Point(246, 114);
            dgvTodosLivros.Margin = new Padding(3, 2, 3, 2);
            dgvTodosLivros.Name = "dgvTodosLivros";
            dgvTodosLivros.ReadOnly = true;
            dgvTodosLivros.RowHeadersWidth = 51;
            dgvTodosLivros.Size = new Size(1022, 275);
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
            btnAddLivro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.addLivro;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(17, 111);
            btnAddLivro.Margin = new Padding(3, 2, 3, 2);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(7, 0, 0, 0);
            btnAddLivro.Size = new Size(170, 34);
            btnAddLivro.TabIndex = 32;
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
            btnResumoAcervo.Location = new Point(17, 171);
            btnResumoAcervo.Margin = new Padding(3, 2, 3, 2);
            btnResumoAcervo.Name = "btnResumoAcervo";
            btnResumoAcervo.Padding = new Padding(7, 0, 0, 0);
            btnResumoAcervo.Size = new Size(170, 34);
            btnResumoAcervo.TabIndex = 31;
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
            btnPaginaInicial.Location = new Point(17, 52);
            btnPaginaInicial.Margin = new Padding(3, 2, 3, 2);
            btnPaginaInicial.Name = "btnPaginaInicial";
            btnPaginaInicial.Padding = new Padding(7, 0, 0, 0);
            btnPaginaInicial.Size = new Size(170, 34);
            btnPaginaInicial.TabIndex = 30;
            btnPaginaInicial.Text = "Página Inicial";
            btnPaginaInicial.UseVisualStyleBackColor = false;
            btnPaginaInicial.Click += btnPaginaInicial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 114);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // txtTituloLivro
            // 
            txtTituloLivro.Location = new Point(24, 41);
            txtTituloLivro.Margin = new Padding(3, 2, 3, 2);
            txtTituloLivro.Multiline = true;
            txtTituloLivro.Name = "txtTituloLivro";
            txtTituloLivro.Size = new Size(991, 35);
            txtTituloLivro.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(20, 26);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 34;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 36;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(587, 90);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 38;
            label4.Text = "ISBN";
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Image = Properties.Resources.excluir_cancelar;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(822, 170);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(8, 0, 0, 0);
            btnExcluir.Size = new Size(192, 34);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkSlateGray;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnPesquisar.ForeColor = SystemColors.Control;
            btnPesquisar.Image = Properties.Resources.pesquisar;
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.Location = new Point(878, 105);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Padding = new Padding(8, 0, 0, 0);
            btnPesquisar.Size = new Size(136, 34);
            btnPesquisar.TabIndex = 40;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(-2, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1308, 620);
            panel2.TabIndex = 40;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvTodosLivros);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(grpBuscarLivros);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(grpMenuAcervoCompleto);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.DarkSlateGray;
            groupBox3.Location = new Point(0, -28);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(1313, 655);
            groupBox3.TabIndex = 44;
            groupBox3.TabStop = false;
            groupBox3.Text = " ";
            // 
            // grpBuscarLivros
            // 
            grpBuscarLivros.Controls.Add(btnCancelar);
            grpBuscarLivros.Controls.Add(btnSalvar);
            grpBuscarLivros.Controls.Add(txtIsbn);
            grpBuscarLivros.Controls.Add(txtAutor);
            grpBuscarLivros.Controls.Add(btnExcluir);
            grpBuscarLivros.Controls.Add(label2);
            grpBuscarLivros.Controls.Add(btnEditarLivro);
            grpBuscarLivros.Controls.Add(txtTituloLivro);
            grpBuscarLivros.Controls.Add(btnPesquisar);
            grpBuscarLivros.Controls.Add(label3);
            grpBuscarLivros.Controls.Add(label4);
            grpBuscarLivros.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBuscarLivros.ForeColor = Color.DarkSlateGray;
            grpBuscarLivros.Location = new Point(246, 406);
            grpBuscarLivros.Margin = new Padding(3, 2, 3, 2);
            grpBuscarLivros.Name = "grpBuscarLivros";
            grpBuscarLivros.Padding = new Padding(3, 2, 3, 2);
            grpBuscarLivros.Size = new Size(1033, 225);
            grpBuscarLivros.TabIndex = 43;
            grpBuscarLivros.TabStop = false;
            grpBuscarLivros.Text = "Buscar Livros no Acervo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSlateGray;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Image = Properties.Resources.excluir_cancelar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(471, 170);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(8, 0, 0, 0);
            btnCancelar.Size = new Size(192, 34);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(587, 106);
            txtIsbn.Margin = new Padding(3, 2, 3, 2);
            txtIsbn.Multiline = true;
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(273, 35);
            txtIsbn.TabIndex = 44;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(24, 106);
            txtAutor.Margin = new Padding(3, 2, 3, 2);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(545, 35);
            txtAutor.TabIndex = 43;
            // 
            // grpMenuAcervoCompleto
            // 
            grpMenuAcervoCompleto.Controls.Add(btnResumoAcervo);
            grpMenuAcervoCompleto.Controls.Add(btnPaginaInicial);
            grpMenuAcervoCompleto.Controls.Add(btnAddLivro);
            grpMenuAcervoCompleto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpMenuAcervoCompleto.ForeColor = Color.DarkSlateGray;
            grpMenuAcervoCompleto.Location = new Point(23, 406);
            grpMenuAcervoCompleto.Margin = new Padding(3, 2, 3, 2);
            grpMenuAcervoCompleto.Name = "grpMenuAcervoCompleto";
            grpMenuAcervoCompleto.Padding = new Padding(3, 2, 3, 2);
            grpMenuAcervoCompleto.Size = new Size(206, 225);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 622);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private GroupBox grpMenuAcervoCompleto;
        private GroupBox grpBuscarLivros;
        private TextBox txtIsbn;
        private TextBox txtAutor;
        private Button btnCancelar;
        private GroupBox groupBox3;
    }
}