using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookHub.Models
{
    internal class UsuarioRepository
    {
        /// <summary>
        /// Responsavel por gerenciar as operações de dados do usuário no banco de dados 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>

        #region ..:: Metodos ::..

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

        #endregion ..:: Metodos ::..
    }
}

