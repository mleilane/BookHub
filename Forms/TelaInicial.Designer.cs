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
            ((System.ComponentModel.ISupportInitialize)imgCapa).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MediumSeaGreen;
            lblTitulo.Location = new Point(284, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(503, 93);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BookHub 📚";
            // 
            // imgCapa
            // 
            imgCapa.BackgroundImageLayout = ImageLayout.None;
            imgCapa.ErrorImage = null;
            imgCapa.Image = (Image)resources.GetObject("imgCapa.Image");
            imgCapa.InitialImage = null;
            imgCapa.Location = new Point(573, 342);
            imgCapa.Name = "imgCapa";
            imgCapa.Size = new Size(515, 345);
            imgCapa.SizeMode = PictureBoxSizeMode.AutoSize;
            imgCapa.TabIndex = 1;
            imgCapa.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumSeaGreen;
            btnCadastrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.Control;
            btnCadastrar.Location = new Point(555, 240);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(162, 46);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MediumSeaGreen;
            btnEntrar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.Control;
            btnEntrar.Location = new Point(315, 240);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(162, 46);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1089, 699);
            Controls.Add(btnEntrar);
            Controls.Add(btnCadastrar);
            Controls.Add(imgCapa);
            Controls.Add(lblTitulo);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHub";
            ((System.ComponentModel.ISupportInitialize)imgCapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox imgCapa;
        private Button btnCadastrar;
        private Button btnEntrar;
    }
}
