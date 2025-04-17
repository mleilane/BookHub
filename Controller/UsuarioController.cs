using BookHub.Forms;
using BookHub.Models;
using BookHub.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        #region ..:: Metodos - Cadastro e Login ::..

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

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        /// <summary>
        /// Método para chamar o service de login e retornar se o login foi bem-sucedido ou não
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool LoginUsuario(Usuario usuario)
        {
            try
            {
                // Cria uma instância da Service para chamar a lógica de login
                UsuarioService service = new UsuarioService();

                // Chama o método LoginUsuario na Service para validar o login
                service.LoginUsuario(usuario);

                // Se não lançar exceção, o login foi bem-sucedido
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                // Retorna falso caso ocorra um erro
                return false; 
            }
        }
        #endregion 


        #region ..:: Metodos - Login Automático ::..

        //verifica se tem login salvo
        public int? VerificarLoginAutomatico()
        {
            return _usuarioService.VerificarLoginAutomatico();
        }

        public void SalvarLogin(int idUsuario, bool lembrarLogin)
        {
            if (lembrarLogin)
            {
                _usuarioService.SalvarLoginAutomatico(idUsuario);
            }

        }

        public int ObterIdUsuarioPorLogin(string login)
        {
            return _usuarioService.ObterIdUsuarioPorLogin(login);
        }
        #endregion
    }
}
