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
        private readonly  LivroService _livroService;

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
            bool resultado = _livroService.CadastrarLivro(livro);

            if (resultado)
            {
                // Exibe uma MessageBox indicando que o livro foi cadastrado com sucesso
                MessageBox.Show(
                    "Livro cadastrado com sucesso!",
                    "Cadastro Realizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return true; // Operação bem-sucedida
            }
            else
            {
                // Exibe a MessageBox caso o livro já exista no banco
                var resultadoMensagem = MessageBox.Show(
                    "O livro já está cadastrado. Deseja adicionar mais um na quantidade?",
                    "Livro já cadastrado",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (resultadoMensagem == DialogResult.OK)
                {
                    // Se o usuário clicar em OK, adiciona + um na  quantidade
                    bool atualizacao = _livroService.CadastrarLivro(livro); // Chama novamente a service para atualizar

                    if (atualizacao)
                    {
                        // Exibe uma MessageBox indicando que a quantidade foi atualizada
                        MessageBox.Show(
                            "Quantidade de livros atualizada com sucesso!",
                            "Atualização Realizada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        return true;
                    }
                    else
                    {
                        // Se houve um erro na atualização, exibe uma mensagem de erro
                        MessageBox.Show(
                            "Erro ao tentar atualizar a quantidade do livro. Tente novamente.",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }
                else
                {
                    // Se o usuário clicar em Cancelar, cancela a operação
                    return false;
                }
            }
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




