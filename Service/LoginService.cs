using BookHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Service
{
    /// <summary>
    /// Descobre o nome do dispositivo
    /// Verifica no banco se já existe um login salvo
    /// Retorna o ID do usuario, se existir. 
    /// </summary>
    internal class LoginService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public LoginService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        //verifica se ja tem login salvo
        public int? VerificarLoginAutomatico()// int? = numero inteiro ou nada
        {
            string dispositivo = ObterNomeDoDispositivo();

            //busca o ID do usuario com login salvo 
            return _usuarioRepository.ObterUsuarioPorDispositivo(dispositivo); 
        }
        

        //Salva login automatico
        public void SalvarLoginAutomatico(int idUsuario)
        {
            string dispositivo = ObterNomeDoDispositivo();
            _usuarioRepository.SalvarLoginAutomatico(idUsuario, dispositivo);
        }

        //utiliza o nome do pc atual como identificador
        private string ObterNomeDoDispositivo()
        {
            return Environment.MachineName;
        }
    }
}
