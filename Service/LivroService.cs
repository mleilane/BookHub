using BookHub.Models;
using BookHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub.Service
{
    #region ..:: ENUM ::..
    public enum ResultadoCadastro
    {
        NovoCadastro,
        AtualizacaoQuantidade,
        Erro
    }
    #endregion ..:: 

    internal class LivroService
    {
        private LivroRepository _livroRepository;


        public LivroService()
        {
            _livroRepository = new LivroRepository();
        }

        #region ..:: C (CREATE) - CRIAR ::..

        //cadastrar novo livro ou atualizar a quantidade (caso ja exista) 
        public ResultadoCadastro CadastrarLivro(Livro livro)
        {

            //verifica se já existe no bd
            Livro livroExistente = _livroRepository.BuscarLivroPorTitulo(livro.Titulo);

            if (livroExistente != null) //livroja existe no bd
            {
                //  atualiza a quantidade de livros
                livroExistente.Quantidade += livro.Quantidade;
                bool atualizado = _livroRepository.AtualizarLivro(livroExistente);

                if (atualizado)
                {
                    return ResultadoCadastro.AtualizacaoQuantidade;
                }
                else
                {
                    return ResultadoCadastro.Erro;
                }

            }

            //se ainda não existe, faz o cadastro 
            bool cadastrado = _livroRepository.CadastrarLivro(livro);

            if (cadastrado)
            {
                return ResultadoCadastro.NovoCadastro;
            }
            else
            {
                return ResultadoCadastro.Erro;
            }



        }


        #endregion ..:: C (CREATE) - CRIAR ::..


        #region ..:: R (READ) - LER ::..

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


        #endregion ..:: R (READ) - LER ::..


        #region ..:: U (UPDATE) - ATUALIZAR ::..


        public bool AtualizaLivro(Livro livro)
        {
            return _livroRepository.AtualizarLivro(livro);
        }

        #endregion ..:: U (UPDATE) - ATUALIZAR ::..


        #region ..:: D (DELETE) - EXCLUIR ::..

        public bool ExcluirLivro(int id)
        {
            return _livroRepository.ExcluirLivro(id);
        }

        #endregion 

    }
}
