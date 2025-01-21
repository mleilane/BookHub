namespace BookHub.Forms
{
    partial class FrmCadastroDeLivros
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
            Button btnAddLivro;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDeLivros));
            label3 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            btnExcluir = new Button();
            label6 = new Label();
            lblautor = new Label();
            lbltitulo = new Label();
            txtAutorAddLivro = new TextBox();
            txtTituloAddLivro = new TextBox();
            lblTituloAddLivro = new Label();
            lblisbn = new Label();
            txtIsbnAddLivro = new TextBox();
            label11 = new Label();
            txtQtdAddLivro = new TextBox();
            lbllido = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnCancelarLivro = new Button();
            btnSalvar = new Button();
            btnAddLivro = new Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkSlateGray;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnSalvar.ForeColor = SystemColors.Control;
            btnSalvar.Image = Properties.Resources.salvar;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(24, 305);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(8, 0, 0, 0);
            btnSalvar.Size = new Size(192, 34);
            btnSalvar.TabIndex = 46;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnAddLivro
            // 
            btnAddLivro.BackColor = Color.DarkSlateGray;
            btnAddLivro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnAddLivro.ForeColor = SystemColors.Control;
            btnAddLivro.Image = Properties.Resources.salvar2;
            btnAddLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLivro.Location = new Point(27, 328);
            btnAddLivro.Margin = new Padding(3, 2, 3, 2);
            btnAddLivro.Name = "btnAddLivro";
            btnAddLivro.Padding = new Padding(8, 0, 0, 0);
            btnAddLivro.Size = new Size(192, 34);
            btnAddLivro.TabIndex = 47;
            btnAddLivro.Text = "Adicionar";
            btnAddLivro.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(24, 104);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 13;
            label3.Text = "Titulo";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(94, 101);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(476, 31);
            textBox3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(27, 148);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Autor";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F);
            textBox1.Location = new Point(94, 143);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 31);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(28, 189);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "ISBN";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F);
            textBox2.Location = new Point(94, 186);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 31);
            textBox2.TabIndex = 16;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(96, 239);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 19);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(179, 239);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(28, 240);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 20;
            label4.Text = "Lido?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(358, 192);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 22;
            label5.Text = "Qtd.";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F);
            textBox4.Location = new Point(406, 189);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 31);
            textBox4.TabIndex = 21;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Image = Properties.Resources.excluir_cancelar;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(249, 305);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(8, 0, 0, 0);
            btnExcluir.Size = new Size(192, 34);
            btnExcluir.TabIndex = 47;
            btnExcluir.Text = "Cancelar";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(204, 21);
            label6.Name = "label6";
            label6.Size = new Size(187, 29);
            label6.TabIndex = 48;
            label6.Text = "Adicionar Livro";
            // 
            // lblautor
            // 
            lblautor.AutoSize = true;
            lblautor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblautor.ForeColor = Color.DarkSlateGray;
            lblautor.Location = new Point(26, 154);
            lblautor.Name = "lblautor";
            lblautor.Size = new Size(40, 15);
            lblautor.TabIndex = 17;
            lblautor.Text = "Autor";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbltitulo.ForeColor = Color.DarkSlateGray;
            lbltitulo.Location = new Point(23, 103);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(43, 15);
            lbltitulo.TabIndex = 16;
            lbltitulo.Text = "Titulo";
            // 
            // txtAutorAddLivro
            // 
            txtAutorAddLivro.Font = new Font("Microsoft Sans Serif", 9F);
            txtAutorAddLivro.Location = new Point(91, 143);
            txtAutorAddLivro.Margin = new Padding(3, 2, 3, 2);
            txtAutorAddLivro.Multiline = true;
            txtAutorAddLivro.Name = "txtAutorAddLivro";
            txtAutorAddLivro.PasswordChar = '*';
            txtAutorAddLivro.Size = new Size(477, 34);
            txtAutorAddLivro.TabIndex = 15;
            // 
            // txtTituloAddLivro
            // 
            txtTituloAddLivro.Font = new Font("Microsoft Sans Serif", 9F);
            txtTituloAddLivro.Location = new Point(91, 92);
            txtTituloAddLivro.Margin = new Padding(3, 2, 3, 2);
            txtTituloAddLivro.Multiline = true;
            txtTituloAddLivro.Name = "txtTituloAddLivro";
            txtTituloAddLivro.Size = new Size(477, 34);
            txtTituloAddLivro.TabIndex = 14;
            // 
            // lblTituloAddLivro
            // 
            lblTituloAddLivro.AutoSize = true;
            lblTituloAddLivro.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAddLivro.ForeColor = Color.DarkSlateGray;
            lblTituloAddLivro.Location = new Point(172, 30);
            lblTituloAddLivro.Name = "lblTituloAddLivro";
            lblTituloAddLivro.Size = new Size(187, 29);
            lblTituloAddLivro.TabIndex = 28;
            lblTituloAddLivro.Text = "Adicionar Livro";
            // 
            // lblisbn
            // 
            lblisbn.AutoSize = true;
            lblisbn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblisbn.ForeColor = Color.DarkSlateGray;
            lblisbn.Location = new Point(27, 203);
            lblisbn.Name = "lblisbn";
            lblisbn.Size = new Size(39, 15);
            lblisbn.TabIndex = 30;
            lblisbn.Text = "ISBN";
            // 
            // txtIsbnAddLivro
            // 
            txtIsbnAddLivro.Font = new Font("Microsoft Sans Serif", 9F);
            txtIsbnAddLivro.Location = new Point(91, 192);
            txtIsbnAddLivro.Margin = new Padding(3, 2, 3, 2);
            txtIsbnAddLivro.Multiline = true;
            txtIsbnAddLivro.Name = "txtIsbnAddLivro";
            txtIsbnAddLivro.PasswordChar = '*';
            txtIsbnAddLivro.Size = new Size(223, 34);
            txtIsbnAddLivro.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(333, 202);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 32;
            label11.Text = "Qtd.";
            // 
            // txtQtdAddLivro
            // 
            txtQtdAddLivro.Font = new Font("Microsoft Sans Serif", 9F);
            txtQtdAddLivro.Location = new Point(372, 192);
            txtQtdAddLivro.Margin = new Padding(3, 2, 3, 2);
            txtQtdAddLivro.Multiline = true;
            txtQtdAddLivro.Name = "txtQtdAddLivro";
            txtQtdAddLivro.PasswordChar = '*';
            txtQtdAddLivro.Size = new Size(196, 34);
            txtQtdAddLivro.TabIndex = 31;
            // 
            // lbllido
            // 
            lbllido.AutoSize = true;
            lbllido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbllido.ForeColor = Color.DarkSlateGray;
            lbllido.Location = new Point(27, 248);
            lbllido.Name = "lbllido";
            lbllido.Size = new Size(43, 15);
            lbllido.TabIndex = 33;
            lbllido.Text = "Lido?";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 9F);
            radioButton3.ForeColor = Color.DarkSlateGray;
            radioButton3.Location = new Point(91, 248);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(47, 19);
            radioButton3.TabIndex = 34;
            radioButton3.TabStop = true;
            radioButton3.Text = "Sim";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 9F);
            radioButton4.ForeColor = Color.DarkSlateGray;
            radioButton4.Location = new Point(193, 248);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(48, 19);
            radioButton4.TabIndex = 35;
            radioButton4.TabStop = true;
            radioButton4.Text = "Não";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnCancelarLivro
            // 
            btnCancelarLivro.BackColor = Color.LightCoral;
            btnCancelarLivro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCancelarLivro.ForeColor = SystemColors.Control;
            btnCancelarLivro.Image = Properties.Resources.excluir_cancelar;
            btnCancelarLivro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarLivro.Location = new Point(293, 328);
            btnCancelarLivro.Margin = new Padding(3, 2, 3, 2);
            btnCancelarLivro.Name = "btnCancelarLivro";
            btnCancelarLivro.Padding = new Padding(8, 0, 0, 0);
            btnCancelarLivro.Size = new Size(192, 34);
            btnCancelarLivro.TabIndex = 46;
            btnCancelarLivro.Text = "Cancelar";
            btnCancelarLivro.UseVisualStyleBackColor = false;
            // 
            // FrmCadastroDeLivros
            // 
            ClientSize = new Size(605, 396);
            Controls.Add(btnAddLivro);
            Controls.Add(btnCancelarLivro);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(lbllido);
            Controls.Add(label11);
            Controls.Add(txtQtdAddLivro);
            Controls.Add(lblisbn);
            Controls.Add(txtIsbnAddLivro);
            Controls.Add(lblTituloAddLivro);
            Controls.Add(lblautor);
            Controls.Add(lbltitulo);
            Controls.Add(txtAutorAddLivro);
            Controls.Add(txtTituloAddLivro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastroDeLivros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button btnExcluir;
        private Label label6;
        private Label lblautor;
        private Label lbltitulo;
        private TextBox txtAutorAddLivro;
        private TextBox txtTituloAddLivro;
        private Label lblTituloAddLivro;
        private Label lblisbn;
        private TextBox txtIsbnAddLivro;
        private Label label11;
        private TextBox txtQtdAddLivro;
        private Label lbllido;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button btnCancelarLivro;
    }
}