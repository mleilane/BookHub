using BookHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static System.Resources.ResXFileRef;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookHub.Service
{
    /// <summary>
    /// logica de cadastro e autenticação
    /// </summary>

    internal class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        #region ..:: Construtor ::..

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        #endregion ..:: Construtor ::..

        #region ..:: Métodos ::..

        /// <summary>
        /// Realiza o cadastro do usuário no sistema
        /// - verificando se o login já existe
        /// - criptografando a senha antes de salvar no banco de dados.
        /// </summary>
        /// <param name="usuario">Objeto do tipo <see cref="Usuario"/> contendo as informações a serem registradas.</param>
        /// <exception cref="Exception">Lança uma exceção se o login já estiver cadastrado.</exception>

        public void CadastrarUsuario(Usuario usuario)
        {
            // valida se os campos estao vazios 
            if (string.IsNullOrWhiteSpace(usuario.Nome) ||
                string.IsNullOrWhiteSpace(usuario.Login) ||
                string.IsNullOrWhiteSpace(usuario.Senha))
            {
                throw new Exception("Todos os campos devem ser preenchidos!");
            }
            if (_usuarioRepository.LoginExistente(usuario.Login))
            {
                throw new Exception("Este login já está cadastrado!");
            }

            // Criptografar a senha antes de salvar
            usuario.Senha = HashSenha(usuario.Senha);
            usuario.DataCriacao = DateTime.Now;

            _usuarioRepository.CadastrarUsuario(usuario);
        }


        private string HashSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a senha para um array de bytes e aplica o algoritmo SHA-256
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));

                //// Converte os bytes criptografados para formato Base64
                return Convert.ToBase64String(hashedBytes);
            }
        }

        /// <summary>
        /// Método para validar os dados de login e senha e realizar a busca no banco
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="Exception"></exception>
        public void LoginUsuario(Usuario usuario)
        {
            // campos obrigatórios preenchidos?
            if (string.IsNullOrWhiteSpace(usuario.Login) || string.IsNullOrWhiteSpace(usuario.Senha))
            {
                throw new Exception("Os campos de login e senha são obrigatórios!"); //lança exceção se estiverem vazios
            }

            // Busca no BD usuário com o login informado
            Usuario usuarioEncontrado = _usuarioRepository.BuscarUsuarioPorLogin(usuario.Login);

            // Verifica se o usuário foi encontrado
            if (usuarioEncontrado == null)
            {
                throw new Exception("Usuário não encontrado!");
            }

            // Verifica se a senha fornecida corresponde à senha cadastrada 
            if (usuarioEncontrado.Senha != HashSenha(usuario.Senha))
            {
                throw new Exception("Senha inválida!");
            }
        }

    }

    #endregion ..:: Métodos ::..
}


