using BookHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Service
{


    internal class LivroService
    {
        private LivroRepository _livroRepository;



        public List<Livro> ObterTodosLivros()
        {
            return _livroRepository.ObterTodosLivros();
        }

        public Livro BuscarLivroPorTitulo(string titulo)
        {
            return _livroRepository.BuscarLivroPorTitulo(titulo);
        }

        public Livro BuscarLivroPorIsbn(string isbn)
        {
            return _livroRepository.BuscarLivroPorIsbn(isbn);
        }

        public Livro BuscarLivroPorAutor(string autor)
        {
            return _livroRepository.BuscarLivroPorAutor(autor);
        }


        public bool CadastrarLivro(Livro livro)
        {

            //verifica se já existe no bd
            Livro livroExistente = _livroRepository.BuscarLivroPorTitulo(livro.Titulo);

            if (livroExistente != null) //livroja existe no bd
            {
                //  atualiza a quantidade de livros
                livroExistente.Quantidade += livro.Quantidade;
                return _livroRepository.AtualizarLivro(livroExistente);

            }

            // Se não existir, cadastra o novo livro
            return _livroRepository.CadastrarLivro(livro);
        }

        public bool AtualizaLivro(Livro livro)
        {
            return _livroRepository.AtualizarLivro(livro);
        }

        public bool ExcluirLivro(int id)
        {
            return _livroRepository.ExcluirLivro(id);
        }
    }
}
