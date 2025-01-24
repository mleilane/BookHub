using BookHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BookHub.Service
{
    //logica de cadastro e autenticação
    internal class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
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
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}

