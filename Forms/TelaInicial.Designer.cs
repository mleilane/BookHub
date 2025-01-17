namespace BookHub
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            lblTitulo = new Label();
            imgCapa = new PictureBox();
            btnCadastrar = new Button();
            btnEntrar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgCapa).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MediumSeaGreen;
            lblTitulo.Location = new Point(475, 203);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(510, 93);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BookHub 📚";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // imgCapa
            // 
            imgCapa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            imgCapa.BackgroundImageLayout = ImageLayout.None;
            imgCapa.ErrorImage = null;
            imgCapa.Image = (Image)resources.GetObject("imgCapa.Image");
            imgCapa.InitialImage = null;
            imgCapa.Location = new Point(967, 481);
            imgCapa.Name = "imgCapa";
            imgCapa.Size = new Size(515, 345);
            imgCapa.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCapa.TabIndex = 1;
            imgCapa.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.MediumSeaGreen;
            btnCadastrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(501, 357);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(162, 46);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.MediumSeaGreen;
            btnEntrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(740, 357);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(162, 46);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(imgCapa);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1494, 829);
            panel1.TabIndex = 4;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1494, 829);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookHub";
            ((System.ComponentModel.ISupportInitialize)imgCapa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private PictureBox imgCapa;
        private Button btnCadastrar;
        private Button btnEntrar;
        private Panel panel1;
    }
}
