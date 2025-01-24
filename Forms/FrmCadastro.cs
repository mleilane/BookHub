using BookHub.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub.Forms
{
    public partial class FrmCadastro : Form
    {
        private UsuarioController _usuarioController;


        public FrmCadastro()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                _usuarioController.CadastrarUsuario(nome, login, senha);

                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
