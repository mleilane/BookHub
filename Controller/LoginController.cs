using BookHub.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Controller
{
    internal class LoginController
    {

        private readonly LoginService _loginService;

        public LoginController()
        {
            _loginService = new LoginService();
        }

        //verifica se tem login salvo
        public int? VerificarLoginAutomatico()
        {
            return _loginService.VerificarLoginAutomatico();
        }



        
        public void SalvarLogin(int idUsuario, bool lembrarLogin)
        {
            if (lembrarLogin) 
            {
                _loginService.SalvarLoginAutomatico(idUsuario);
            }

        }
    }

}

