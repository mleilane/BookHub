﻿using BookHub.Controller;
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

            // Impede o Enter no campo de login
            txtLogin.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // Impede a quebra de linha no campo de login
                }
            };

            // Chamando o evento de login quando pressionar Enter no campo de senha
            txtSenha.KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnEntrar_Click(sender, e); // Chama o evento de login
                }
            };

        }

        #endregion ..:: Construtor ::..

        #region ..:: Eventos ::..
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura os valores digitados
                string loginUsuario = txtLogin.Text;
                string senhaUsuario = txtSenha.Text;
                bool lembrarLogin = chkLembrarMe.Checked;

                // Valida se os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(loginUsuario) || string.IsNullOrWhiteSpace(senhaUsuario))
                {
                    MessageBox.Show("Por favor, preencha os campos de login e senha.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }


                UsuarioController usuarioController = new UsuarioController();  // instância de UsuarioController para realizar o login

                // Cria objeto com os do login digitado
                Usuario usuarioObj = new Usuario
                {
                    Login = loginUsuario,
                    Senha = senhaUsuario
                };


                // Tenta realizar o login
                bool loginBemSucedido = usuarioController.LoginUsuario(usuarioObj);


                if (loginBemSucedido)
                {
                    LoginController loginController = new LoginController();
                    int? usuarioId = loginController.VerificarLoginAutomatico();  // Verifica login salvo automaticamente

                    //salva login automatico, se a opção estiver marcada 
                    if (usuarioId.HasValue)
                    {
                        loginController.SalvarLogin(usuarioId.Value, lembrarLogin);
                    }

                    // Abre a proxima tela (TodosLivros) 
                    FrmAcervoCompleto telaTodosLivros = new FrmAcervoCompleto();
                    telaTodosLivros.Show();

                    this.Hide();
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
