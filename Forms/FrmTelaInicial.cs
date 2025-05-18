using BookHub.Forms;

namespace BookHub
{
    public partial class FrmTelaInicial : Form
    {
        #region ..:: CONSTRUTOR ::..
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        #endregion

        #region ..:: EVENTOS ::..
        
        private void btnCadastrar_Click(object sender, EventArgs e) //click no botao cadastro e login
        {

            // criando uma instancia 
            FrmCadastro cadastroForm = new FrmCadastro();

            //abre o form cadastro como uma janela modal 
            cadastroForm.ShowDialog();
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.ShowDialog();
        }

        #endregion
    }
}
