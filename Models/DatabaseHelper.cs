using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BookHub.Models
{
    internal class DatabaseHelper
    {
        /// <summary>
        /// A classe DatabaseHelper contém métodos auxiliares para interação com o banco de dados.
        /// - GetConnectionString: Retorna a string de conexão configurada no App.config.
        /// - ExecuteNonQuery: Executa comandos de manipulação de dados (INSERT, UPDATE, DELETE) no banco.
        /// - ExecuteReader: Executa consultas SELECT e retorna um SqlDataReader para ler os resultados.
        /// Esses métodos ajudam a abstrair e centralizar a lógica de acesso a dados, mantendo a separação de responsabilidades na arquitetura MVC.
        /// </summary>
        /// <returns></returns>

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BookHubDBConnection"].ConnectionString;

        }

        // Método genérico para executar comandos sem retorno (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            //cria uma conexao com o BD
            using (SqlConnection conn = new SqlConnection(GetConnectionString())) 
            {
                conn.Open(); // Abre a conexão com o banco.

                // Cria um comando SQL com a query passada como parâmetro.
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) // Se houver parâmetros, adiciona cada um ao comando SQL.
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método genérico para executar consultas (SELECT) e retornar um SqlDataReader
        public static SqlDataReader ExecuteReader(string query, Dictionary<string, object> parameters = null)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);  //fechar a conexão automaticamente
            }
        }

    }
}

