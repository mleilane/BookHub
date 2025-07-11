﻿namespace BookHub.Forms
{
    partial class FrmLogin
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
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            chkLembrarMe = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 9F);
            txtLogin.Location = new Point(57, 223);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(553, 43);
            txtLogin.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Microsoft Sans Serif", 9F);
            txtSenha.Location = new Point(57, 323);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(553, 48);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(57, 200);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(54, 300);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user02;
            pictureBox1.Location = new Point(190, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.DarkSlateGray;
            btnEntrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Image = Properties.Resources.logar;
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(57, 412);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Padding = new Padding(9, 0, 0, 0);
            btnEntrar.Size = new Size(223, 47);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // chkLembrarMe
            // 
            chkLembrarMe.AutoSize = true;
            chkLembrarMe.Location = new Point(497, 435);
            chkLembrarMe.Name = "chkLembrarMe";
            chkLembrarMe.Size = new Size(113, 24);
            chkLembrarMe.TabIndex = 5;
            chkLembrarMe.Text = "Lembrar-me";
            chkLembrarMe.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 528);
            Controls.Add(chkLembrarMe);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logar no Sistema";
            Load += FrmLogin_Load;
            Shown += FrmLogin_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private CheckBox chkLembrarMe;
    }
}