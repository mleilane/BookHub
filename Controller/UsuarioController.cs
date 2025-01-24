using BookHub.Models;
using BookHub.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Controller
{
    internal class UsuarioController
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }

        public void CadastrarUsuario(string nome, string login, string senha)
        {
            try
            {
                Usuario usuario = new Usuario
                {
                    Nome = nome,
                    Login = login,
                    Senha = senha
                };

                _usuarioService.CadastrarUsuario(usuario);
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                throw;
            }
        }
    }
}
