using BookHub.Forms;

namespace BookHub
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }


        //evento de click no botao entrar e cadastrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // criando uma instancia do formulario login
            Login loginForm = new Login();

            //abre o form login como uma janela modal 
            loginForm.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // criando uma instancia do formulario login
            Cadastro cadastroForm = new Cadastro();

            //abre o form login como uma janela modal 
            cadastroForm.ShowDialog();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
