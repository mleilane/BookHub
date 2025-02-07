using BookHub.Forms;

namespace BookHub
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }


        //evento de click no botao cadastro e login
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // criando uma instancia do formulario login
            FrmCadastro cadastroForm = new FrmCadastro();

            //abre o form login como uma janela modal 
            cadastroForm.ShowDialog();
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            // criando uma instancia do formulario login
            FrmLogin loginForm = new FrmLogin();

            //abre o form login como uma janela modal 
            loginForm.ShowDialog();
        }
    }
}
