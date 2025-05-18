using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BookHub.Models;

namespace BookHub.Repository
{
    internal class UsuarioRepository
    {
        /// <summary>
        /// Responsavel por gerenciar as operações de dados do usuário no banco de dados 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        #region ..:: MÉTODOS - CADASTRO E LOGIN ::..

        /// <summary>
        /// Cadastra um novo usuário no banco de dados.
        /// </summary>
        /// <param name="usuario">Objeto do tipo <see cref="Usuario"/> contendo as informações a serem registradas.</param>
        /// <returns>Retorna <c>true</c> se o usuário foi cadastrado com sucesso, caso contrário <c>false</c>.</returns>

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO USUARIOS (NOME_USUARIO, LOGIN, SENHA,DATA_CRIACAO ) VALUES (@Nome, @Login, @Senha, @DataCriacao)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@Login", usuario.Login);
                        cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                        cmd.Parameters.AddWithValue("@DataCriacao", usuario.DataCriacao);


                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário" + ex.Message);
                    return false;
                }
            }
        }

        /// <summary>
        /// Verifica se já existe login registrado no banco de dados.
        /// </summary>
        /// <param name="login">Login a ser verificado.</param>
        /// <returns>Retorna <c>true</c> se o login já existe, caso contrário <c>false</c>.</returns>
        public bool LoginExistente(string login)
        {
            string query = "SELECT COUNT(*) FROM USUARIOS WHERE LOGIN = @Login";

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", login);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        internal Usuario BuscarUsuarioPorLogin(string login)
        {
            Usuario usuario = null;

            string query = "SELECT Login, Senha FROM Usuarios WHERE Login = @Login";

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", login);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Login = reader["Login"].ToString(),
                                Senha = reader["Senha"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;

        }
        #endregion 

        #region ..:: MÉTODOS - LOGIN AUTOMATICO::..


        //Verifica se o usuario ja salvou login nesse dispositivo 
        public int? ObterUsuarioPorDispositivo(string dispositivo)
        {
            string query = "SELECT ID_USUARIO FROM LEMBRAR_ME WHERE DISPOSITIVO = @Dispositivo";

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Dispositivo", dispositivo);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }

                }
            }
        }

        public void SalvarLoginAutomatico(int idUsuario, string dispositivo) //Salva login automatico 
        {

            if (ObterUsuarioPorDispositivo(dispositivo).HasValue)
            {
                return; //ja salvo, nao precisa inserir de novo
            }

            string query = " INSERT INTO LEMBRAR_ME (ID_USUARIO, DISPOSITIVO, DATA_CRIACAO) VALUES (@IdUsuario, @Dispositivo, @DataCriacao)";

            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Dispositivo", dispositivo);
                    cmd.Parameters.AddWithValue("@DataCriacao", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int ObterIdUsuarioPorLogin(string login)
        {
            string query = "SELECT ID FROM USUARIOS WHERE LOGIN = @Login";
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Login", login);

                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public Usuario BuscarUsuarioLembrado(int idUsuario)
        {
            const string query = @"
                                SELECT 
                                    U.ID, 
                                    U.Login, 
                                    U.Senha 
                                FROM USUARIOS U
                                INNER JOIN LEMBRAR_ME L 
                                    ON U.ID = L.ID_USUARIO
                                WHERE L.ID_USUARIO = @idUsuario";

            using (var conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Login = reader["Login"].ToString(),
                            Senha = reader["Senha"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        #endregion
    }
}

