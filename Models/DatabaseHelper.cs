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
        //acesso a string de conexao App.config
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BookHubDBConnection"].ConnectionString;

        }
    }
}

//comentar mais?