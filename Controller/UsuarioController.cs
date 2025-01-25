using BookHub.Models;
using BookHub.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Controller
{

    /// <summary>
    /// Controlador responsável por gerenciar as operações do usuário
    /// </summary>

    
    internal class UsuarioController
    {
        private readonly UsuarioService _usuarioService;

        #region ..:: Construtor ::..

        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }

        #endregion ..:: Construtor ::..

        #region ..:: Metodos ::..

        /// <summary>
        /// Esse metodo realiza o cadastro de usuários com os dados fornecidos 
        /// - Envia as informações para a service garantindo que  o usuário seja registrado ao BD 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        public void CadastrarUsuario(string nome, string login, string senha)
        {
            try
            {
                // Criação do objeto Usuario com os dados fornecidos
                Usuario usuario = new Usuario
                {
                    Nome = nome,
                    Login = login,
                    Senha = senha
                };

                //chama a service para cadastrar o usuario no BD
                _usuarioService.CadastrarUsuario(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                throw;
            }
        }

        #endregion ..:: Metodos ::..
    }
}
