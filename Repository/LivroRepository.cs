using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using System.CodeDom.Compiler;
using System.Runtime.Intrinsics.X86;
using BookHub.Models;

namespace BookHub.Repository
{
    internal class LivroRepository
    {

        /// <summary>
        /// A classe LivroRepository gerencia as operações de dados dos livros no banco de dados.
        /// - ObterTodosLivros: Recupera todos os livros da tabela "Livros" no banco de dados e retorna uma lista de objetos Livro.
        /// -  Utiliza ExecuteReader para ler os dados linha por linha, evitando o uso excessivo de memória em grandes volumes de dados.
        /// - CadastrarLivro: Insere um novo livro no banco de dados com base nos dados fornecidos.Retorna true se a inserção for bem-sucedida.
        /// Utiliza um dicionário de parâmetros para evitar injeção de SQL e garantir que os dados sejam tratados corretamente.
        /// - BuscarLivroPorTitulo, BuscarLivroPorAuto e BuscarLivroPorIsbn: Buscam um livro no banco de dados e retorna o objeto Livro correspondente, ou null se não encontrado.
        /// Usa ExecuteReader com um parâmetro para buscar especificamente o livro pelo título, evitando resultados incorretos.
        /// - ExcluirLivro: Exclui um livro do banco de dados pelo ID.
        /// - AtualizarLivro: Atualiza as informações de um livro no banco de dados com base no ID.
        /// - Esses métodos abstraem as operações CRUD para a entidade Livro e fazem uso do DatabaseHelper para executar comandos no banco.
        /// </summary>
        /// 


        #region ..:: C (CREATE) - CRIAR ::..
        public bool CadastrarLivro(Livro livro)
        {
            string query = @"INSERT INTO Livros 
                                (Titulo,
                                Autor,
                                ISBN, 
                                Quantidade,
                                Lido,
                                Data_De_Registro) 
                            VALUES 
                                (@Titulo, 
                                @Autor,
                                @ISBN, 
                                @Quantidade, 
                                @Lido, 
                                @DataDeRegistro)";

            // Cria um dicionário de parâmetros para a consulta SQL                    
            var parameters = new Dictionary<string, object>
            {
                { "@Titulo", livro.Titulo },
                { "@Autor", livro.Autor },
                { "@ISBN", livro.ISBN },
                { "@Quantidade", livro.Quantidade },
                { "@Lido", livro.Lido },
                { "@DataDeRegistro", livro.DataDeRegistro }
            };

            // Executa a consulta de inserção e retorna o número de linhas afetadas
            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);

            // Retorna true se a inserção foi bem-sucedida (pelo menos uma linha afetada)
            return rows > 0;
        }

        #endregion ..:: C (CREATE) - CRIAR ::..


        #region ..:: R (READ) - LER ::..

        public List<Livro> ObterTodosLivros()
        {
            var livros = new List<Livro>(); // Lista para armazenar os livros recuperados

            string query = @"SELECT 
                              Id,
                              Titulo,
                              Autor, 
                              ISBN, 
                              Quantidade, 
                              Lido,
                              Data_De_Registro 
                          FROM Livros";

            // Executa a consulta e retorna um SqlDataReader para ler os resultados
            using (var reader = DatabaseHelper.ExecuteReader(query))
            {
                // Lê cada linha de resultado da consulta
                while (reader.Read())
                {
                    // Cria um novo objeto Livro e preenche com os dados da linha lida
                    Livro livro = new Livro
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Lido = Convert.ToBoolean(reader["Lido"]),
                        DataDeRegistro = Convert.ToDateTime(reader["Data_De_Registro"])
                    };

                    //Adiciona o livro a lista
                    livros.Add(livro);
                }
            }

            return livros;
        }

        public Livro BuscarLivroPorTitulo(string titulo)
        {
            string query = @"SELECT 
                                Id, 
                                Titulo,
                                Autor, 
                                ISBN, 
                                Quantidade, 
                                Lido, 
                                Data_De_Registro 
                            FROM Livros 
                            WHERE Titulo = @Titulo";

            // Cria um dicionário de parâmetros com o título a ser buscado
            var parameters = new Dictionary<string, object>
            {
                { "@Titulo", titulo }
            };

            // Executa a consulta e retorna um SqlDataReader para ler o resultado
            using (var reader = DatabaseHelper.ExecuteReader(query, parameters))
            {
                if (reader.Read()) // Verifica se o livro foi encontrado
                {
                    // Cria e retorna o livro com os dados recuperados da consulta
                    return new Livro
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Lido = Convert.ToBoolean(reader["Lido"]),
                        DataDeRegistro = Convert.ToDateTime(reader["Data_De_Registro"])
                    };
                }
            }

            return null; // Retorna null caso o livro não seja encontrado
        }

        public Livro BuscarLivroPorIsbn(string isbn)
        {
            string query = @"SELECT 
                                Id, 
                                Titulo,
                                Autor, 
                                ISBN, 
                                Quantidade, 
                                Lido, 
                                Data_De_Registro 
                            FROM Livros 
                            WHERE ISBN = @ISBN";

            // Cria um dicionário de parâmetros com o ISBN a ser buscado
            var parameters = new Dictionary<string, object>
            {
                { "@ISBN", isbn }
            };

            // Executa a consulta e retorna um SqlDataReader para ler o resultado
            using (var reader = DatabaseHelper.ExecuteReader(query, parameters))
            {
                if (reader.Read()) // Verifica se o livro foi encontrado
                {
                    // Cria e retorna o livro com os dados recuperados da consulta
                    return new Livro
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Lido = Convert.ToBoolean(reader["Lido"]),
                        DataDeRegistro = Convert.ToDateTime(reader["Data_De_Registro"])
                    };
                }
            }

            return null; // Retorna null caso o livro não seja encontrado
        }

        public Livro BuscarLivroPorAutor(string autor)
        {
            string query = @"SELECT 
                                Id, 
                                Titulo,
                                Autor, 
                                ISBN, 
                                Quantidade, 
                                Lido, 
                                Data_De_Registro 
                            FROM Livros 
                            WHERE Autor = @Autor";

            // Cria um dicionário de parâmetros com o ator a ser buscado
            var parameters = new Dictionary<string, object>
            {
                { "@Autor", autor }
            };

            // Executa a consulta e retorna um SqlDataReader para ler o resultado
            using (var reader = DatabaseHelper.ExecuteReader(query, parameters))
            {
                if (reader.Read()) // Verifica se o livro foi encontrado
                {
                    // Cria e retorna o livro com os dados recuperados da consulta
                    return new Livro
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Lido = Convert.ToBoolean(reader["Lido"]),
                        DataDeRegistro = Convert.ToDateTime(reader["Data_De_Registro"])
                    };
                }
            }

            return null; // Retorna null caso o livro não seja encontrado
        }

        #endregion ..:: R (READ) - LER ::..


        #region ..:: U (UPDATE) - ATUALIZAR ::..

        public bool AtualizarLivro(Livro livro)
        {
            string query = @"UPDATE Livros
                            SET Titulo = @Titulo,
                                Autor = @Autor,
                                ISBN = @ISBN,
                                Quantidade = @Quantidade,
                                Lido = @Lido,
                                Data_De_Registro = @DataDeRegistro
                            WHERE Id = @Id";

            var parameters = new Dictionary<string, object>
            {
                { "@Id", livro.Id },
                { "@Titulo", livro.Titulo },
                { "@Autor", livro.Autor },
                { "@ISBN", livro.ISBN },
                { "@Quantidade", livro.Quantidade },
                { "@Lido", livro.Lido },
                { "@DataDeRegistro", livro.DataDeRegistro }
            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rows > 0;
        }

        #endregion ..:: U (UPDATE) - ATUALIZAR ::..


        #region ..:: D (DELETE) - EXCLUIR ::..

        public bool ExcluirLivro(int id)
        {
            string query = @"DELETE
                             FROM LIVROS
                             WHERE ID = @id";

            var parameters = new Dictionary<string, object>
            {
                { "Id", id }

            };

            int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rows > 0;

        }

        #endregion ..:: D (DELETE) - EXCLUIR ::..

    }
}
