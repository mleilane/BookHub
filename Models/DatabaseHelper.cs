using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BookHub.Models
{
    internal class DatabaseHelper
    {
        /// <summary>
        /// Clase responsável por acessar a string de conexão no BD  definida no App.config.
        /// </summary>
        /// <returns></returns>
        
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BookHubDBConnection"].ConnectionString;

        }
    }
}

