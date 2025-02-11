﻿namespace BookHub
{
    partial class FrmTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            lblTitulo = new Label();
            imgCapa = new PictureBox();
            btnCadastrar = new Button();
            btnFazerLogin = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgCapa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DarkSlateGray;
            lblTitulo.Location = new Point(264, 353);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(509, 95);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BookHub 📚";
            // 
            // imgCapa
            // 
            imgCapa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgCapa.BackgroundImageLayout = ImageLayout.None;
            imgCapa.ErrorImage = null;
            imgCapa.Image = (Image)resources.GetObject("imgCapa.Image");
            imgCapa.InitialImage = null;
            imgCapa.Location = new Point(991, 107);
            imgCapa.Name = "imgCapa";
            imgCapa.Size = new Size(393, 626);
            imgCapa.SizeMode = PictureBoxSizeMode.AutoSize;
            imgCapa.TabIndex = 1;
            imgCapa.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.DarkSlateGray;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Image = Properties.Resources.user;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(280, 509);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Padding = new Padding(8, 0, 0, 0);
            btnCadastrar.Size = new Size(213, 45);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Criar Conta";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnFazerLogin
            // 
            btnFazerLogin.Anchor = AnchorStyles.None;
            btnFazerLogin.BackColor = Color.DarkSlateGray;
            btnFazerLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnFazerLogin.ForeColor = SystemColors.Control;
            btnFazerLogin.Image = Properties.Resources.cadeado;
            btnFazerLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnFazerLogin.Location = new Point(519, 509);
            btnFazerLogin.Name = "btnFazerLogin";
            btnFazerLogin.Padding = new Padding(8, 0, 0, 0);
            btnFazerLogin.Size = new Size(213, 45);
            btnFazerLogin.TabIndex = 3;
            btnFazerLogin.Text = "Fazer Login";
            btnFazerLogin.UseVisualStyleBackColor = false;
            btnFazerLogin.Click += btnFazerLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(btnFazerLogin);
            panel1.Controls.Add(imgCapa);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1494, 947);
            panel1.TabIndex = 4;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1494, 947);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bem-vindo ao BookHub";
            ((System.ComponentModel.ISupportInitialize)imgCapa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private PictureBox imgCapa;
        private Button btnCadastrar;
        private Button btnFazerLogin;
        private Panel panel1;
    }
}
