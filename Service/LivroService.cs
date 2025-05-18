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

        #region ..:: CONSTRUTOR E DEPENDÊNCIAS ::..
        public LivroService()
        {
            _livroRepository = new LivroRepository();
        }

        #endregion

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


        #endregion


        #region ..:: R (READ) - LER ::..

        public List<Livro> ObterTodosLivros()
        {
            return _livroRepository.ObterTodosLivros();
        }

        public List<Livro> ObterUltimosAdicionados()
        {
            return _livroRepository.ObterUltimosAdicionados();
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

        public Livro BuscarLivroPorId(int id)
        {
            return _livroRepository.BuscarLivroPorId(id);
        }

        //retorna uma tupla com 5 valores
        public (int total, int lidos, int naoLidos, double percLidos, double percNaoLidos) ObterResumoAcervo()
        {
            var livros = _livroRepository.ObterTodosLivros();
            int total = livros.Count;

            int lidos = 0;

            //percorre a lista de livros e soma os marcados como lidos
            foreach (var livro in livros)
            {
                if (livro.Lido)
                {
                    lidos++;
                }
            }


            int naoLidos = total - lidos;

            double percLidos = 0;
            double percNaoLidos = 0;

            if(total > 0)
            {
                percLidos = (lidos * 100.0) / total;
                percNaoLidos = (naoLidos * 100.0) / total;
            }

            return (total, lidos, naoLidos, percLidos, percNaoLidos);
        }


        #endregion 


        #region ..:: U (UPDATE) - ATUALIZAR ::..


        public bool AtualizaLivro(Livro livro)
        {
            return _livroRepository.AtualizarLivro(livro);
        }

        #endregion 


        #region ..:: D (DELETE) - EXCLUIR ::..

        public bool ExcluirLivro(int id)
        {
            return _livroRepository.ExcluirLivro(id);
        }

        #endregion 

    }
}
