namespace BookHub.Forms
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtLogin = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            btnCadastrarUser = new Button();
            btnCancelarCadastro = new Button();
            txtSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user03;
            pictureBox1.Location = new Point(262, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(370, 299);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(99, 299);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 9F);
            txtLogin.Location = new Point(99, 321);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(222, 40);
            txtLogin.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(99, 205);
            label3.Name = "label3";
            label3.Size = new Size(53, 18);
            label3.TabIndex = 0;
            label3.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Microsoft Sans Serif", 9F);
            txtNome.Location = new Point(99, 229);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(497, 40);
            txtNome.TabIndex = 1;
            // 
            // btnCadastrarUser
            // 
            btnCadastrarUser.BackColor = Color.DarkSlateGray;
            btnCadastrarUser.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCadastrarUser.ForeColor = SystemColors.Control;
            btnCadastrarUser.Image = Properties.Resources.salvar2;
            btnCadastrarUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarUser.Location = new Point(99, 423);
            btnCadastrarUser.Name = "btnCadastrarUser";
            btnCadastrarUser.Padding = new Padding(9, 0, 0, 0);
            btnCadastrarUser.Size = new Size(223, 46);
            btnCadastrarUser.TabIndex = 6;
            btnCadastrarUser.Text = "Cadastrar";
            btnCadastrarUser.UseVisualStyleBackColor = false;
            btnCadastrarUser.Click += btnCadastrarUser_Click_1;
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.BackColor = Color.LightCoral;
            btnCancelarCadastro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCancelarCadastro.ForeColor = SystemColors.Control;
            btnCancelarCadastro.Image = Properties.Resources.excluir_cancelar;
            btnCancelarCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarCadastro.Location = new Point(374, 423);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Padding = new Padding(9, 0, 0, 0);
            btnCancelarCadastro.Size = new Size(223, 46);
            btnCancelarCadastro.TabIndex = 7;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = false;
            btnCancelarCadastro.Click += btnCancelarCadastro_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 9F);
            txtSenha.Location = new Point(374, 321);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(222, 40);
            txtSenha.TabIndex = 5;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 528);
            Controls.Add(txtSenha);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(btnCadastrarUser);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuário";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label3;
        private TextBox txtNome;
        private Button btnCadastrarUser;
        private Button btnCancelarCadastro;
    }
}