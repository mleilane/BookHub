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


        #region ..:: CONSTRUTOR ::..
        public FrmCadastro()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController();

        }
        #endregion

        #region ..:: EVENTOS ::..

        private void btnCadastrarUser_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;


                // Validações para garantir que os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(login) ||
                    string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!",
                                    "Atenção",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Envia os dados para o Controller
                _usuarioController.CadastrarUsuario(nome, login, senha);

                MessageBox.Show("Cadastro realizado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                       "Erro",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            // Exibe mensagem de confirmação
            var resultado = MessageBox.Show("Tem certeza que deseja cancelar o cadastro?",
                                             "Confirmação",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            // Fecha o formulário apenas se o usuário confirmar
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion 
    }
}
