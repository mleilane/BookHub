using BookHub.Controller;
using BookHub.Models;
using Microsoft.VisualBasic.Logging;
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
    public partial class FrmLogin : Form
    {
        #region ..:: Construtor ::..
        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion ..:: Construtor ::..

        #region ..:: Eventos ::..
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os valores de login e senha
                string loginUsuario = txtLogin.Text;
                string senhaUsuario = txtSenha.Text;

                // Valida se os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(loginUsuario) || string.IsNullOrWhiteSpace(senhaUsuario))
                {
                    MessageBox.Show("Por favor, preencha os campos de login e senha.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                // Cria uma instância de UsuarioController para realizar o login
                UsuarioController usuarioController = new UsuarioController();

                // Cria uma instância de Usuario para passar os dados ao controlador
                Usuario usuarioObj = new Usuario { Login = loginUsuario, Senha = senhaUsuario };

                // Tenta realizar o login
                bool loginBemSucedido = usuarioController.LoginUsuario(usuarioObj);

                if (loginBemSucedido)
                {
                    // Abrir a tela TodosLivros se o login for bem-sucedido
                    FrmAcervoCompleto telaTodosLivros = new FrmAcervoCompleto();
                    telaTodosLivros.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos.",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                                       "Erro",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
            }
            
        }
        #endregion ..:: Eventos ::..
    }


}
