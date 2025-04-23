using BookHub.Models;
using BookHub.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BookHub.Controller
{
    internal class LivroController
    {
        private readonly LivroService _livroService;

        // Construtor adicionando a inicialização de _livroService
        public LivroController()
        {
            _livroService = new LivroService();
        }


        public List<Livro> ObterTodosLivros()
        {
            return _livroService.ObterTodosLivros();
        }

        public bool CadastrarLivro(Livro livro)
        {
            // Chama a service para verificar a existência do livro e tentar cadastrá-lo
            var resultado = _livroService.CadastrarLivro(livro);

            switch (resultado)
            {
                case ResultadoCadastro.NovoCadastro:
                    MessageBox.Show(
                         "Livro cadastrado com sucesso!",
                         "Cadastro Realizado",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                    );
                    return true;

                case ResultadoCadastro.AtualizacaoQuantidade:
                    MessageBox.Show(
                        "O livro já estava cadastrado. A quantidade foi atualizada com sucesso!",
                        "Livro Atualizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return true;

                case ResultadoCadastro.Erro:
                    MessageBox.Show(
                        "Ocorreu um erro ao tentar cadastrar o livro.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return false;
            }

            return false;
        }


        public Livro BuscarLivroPorTitulo(string titulo)
        {
            return _livroService.BuscarLivroPorTitulo(titulo);
        }

        public Livro BuscarLivroPorIsbn(string isbn)
        {
            return _livroService.BuscarLivroPorIsbn(isbn);
        }

        public Livro BuscarLivroPorAutor(string autor)
        {
            return _livroService.BuscarLivroPorAutor(autor);
        }


        public bool ExcluirLivro(int id)
        {
            var resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este livro?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                bool sucesso = _livroService.ExcluirLivro(id);

                if (sucesso)
                {
                    MessageBox.Show(
                        "Livro excluído com sucesso!",
                        "Exclusão Realizada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return true;
                }
                else
                {
                    MessageBox.Show(
                        "Erro ao tentar excluir o livro. Tente novamente.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return false;
                }
            }

            return false;
        }
    }
}





