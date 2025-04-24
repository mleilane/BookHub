using BookHub.Controller;
using BookHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub.Forms
{
    public partial class FrmAcervoCompleto : Form
    {
        LivroController controller = new LivroController();
        private Livro livroSelecionado;

        public FrmAcervoCompleto()
        {
            InitializeComponent();
            ConfigurarDgvTodosLivros();
            CarregarLivros();

        }


        #region ..:: METODOS ::..


        private void CarregarLivros()
        {
            LivroController livroController = new LivroController();
            List<Livro> livros = livroController.ObterTodosLivros();

            dgvTodosLivros.Rows.Clear(); // Limpa o DataGridView antes de popular

            foreach (var livro in livros)
            {
                dgvTodosLivros.Rows.Add(
                    livro.Id,
                    livro.Titulo,
                    livro.Autor,
                    livro.ISBN,
                    livro.Quantidade,
                    livro.Lido ? "Sim" : "Não",
                    livro.DataDeRegistro.ToString("dd/MM/yyyy")
                    );
            }
        }

        // Método de configuração do DataGridView
        private void ConfigurarDgvTodosLivros()
        {
            dgvTodosLivros.EnableHeadersVisualStyles = false; //desabilita o estilo padrão

            //cabeçalho 
            dgvTodosLivros.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold); //fonte 
            dgvTodosLivros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //centraliza o texto 
            dgvTodosLivros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); //cor de fundo  
            dgvTodosLivros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // cor do texto 

            // Desativa a seleção do cabeçalho (impede que ele fique azul)
            dgvTodosLivros.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvTodosLivros.ColumnHeadersDefaultCellStyle.BackColor;
            dgvTodosLivros.DefaultCellStyle.SelectionBackColor = dgvTodosLivros.DefaultCellStyle.BackColor; // Define a mesma cor do fundo
            dgvTodosLivros.DefaultCellStyle.SelectionForeColor = dgvTodosLivros.DefaultCellStyle.ForeColor; // Mantém a cor do texto


            //celulas
            dgvTodosLivros.ClearSelection();  // Remove a seleção inicial da celula 
            dgvTodosLivros.CurrentCell = null; // Remove o foco visual
            dgvTodosLivros.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Define seleção por linha inteira
            dgvTodosLivros.MultiSelect = false; // Impede múltiplas seleções
            dgvTodosLivros.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.75F, FontStyle.Regular); //tamanho e espessura fonte 
            dgvTodosLivros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // cor de fundo em linhas alternadas
            dgvTodosLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //ajuste automatico da largura das colunas
            dgvTodosLivros.Columns["Título"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //centraliza  o texto
            dgvTodosLivros.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodosLivros.Columns["ISBN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodosLivros.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodosLivros.Columns["Lido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodosLivros.Columns["Data_de_Registro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void LimparCamposBusca()
        {
            txtTituloLivro.Text = "";
            txtAutor.Text = "";
            txtIsbn.Text = "";
        }

        #endregion ..:: 

        #region ..:: EVENTOS ::..

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            //instancia da tela Inicial
            FrmTelaInicial telaInicialForm = new FrmTelaInicial();

            //exibi a tela inicial e fechando o AcervoCompleto 
            telaInicialForm.Show();
            this.Close(); // Fecha o form atual
        }

        private void btnResumoAcervo_Click(object sender, EventArgs e)
        {
            //criando instancia 
            FrmResumoAcervo resumoAcervoForm = new FrmResumoAcervo();

            //exibindo o form ResumoAcervo
            resumoAcervoForm.ShowDialog();
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            //criando instancia 
            FrmCadastroDeLivros frmcadastroDeLivros = new FrmCadastroDeLivros();

            //exibindo o form CadastroDeLivros
            frmcadastroDeLivros.ShowDialog();

            //recarrega a grid de livros
            CarregarLivros();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloLivro.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string isbn = txtIsbn.Text.Trim();


            Livro livroEncontrado = null;

            if (!string.IsNullOrEmpty(titulo))
            {
                livroEncontrado = controller.BuscarLivroPorTitulo(titulo);
            }
            else if (!string.IsNullOrEmpty(autor))
            {
                livroEncontrado = controller.BuscarLivroPorAutor(autor);
            }
            else if (!string.IsNullOrEmpty(isbn))
            {
                livroEncontrado = controller.BuscarLivroPorIsbn(isbn);
            }
            else
            {
                MessageBox.Show(
                    "Preencha ao menos um campo para buscar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (livroEncontrado != null)
            {
                //atualiza a gride com o livro pesquisado
                dgvTodosLivros.Rows.Clear();
                dgvTodosLivros.Rows.Add(
                    livroEncontrado.Id,
                    livroEncontrado.Titulo,
                    livroEncontrado.Autor,
                    livroEncontrado.ISBN,
                    livroEncontrado.Quantidade,
                    livroEncontrado.Quantidade,
                    livroEncontrado.Lido ? "Sim" : "Não",
                    livroEncontrado.DataDeRegistro.ToString("dd/MM/yyyy")
                );

                // Seleciona a linha automaticamente
                dgvTodosLivros.ClearSelection();
                if (dgvTodosLivros.Rows.Count > 0)
                {
                    dgvTodosLivros.Rows[0].Selected = true;
                }

                //preenche os campos 
                txtTituloLivro.Text = livroEncontrado.Titulo;
                txtAutor.Text = livroEncontrado.Autor;
                txtIsbn.Text = livroEncontrado.ISBN;
            }
            else
            {
                MessageBox.Show(
                    "Livro não encontrado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCamposBusca();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposBusca(); //limpa campos de pesquisa
            CarregarLivros(); //recarrega a  gride
            dgvTodosLivros.ClearSelection();  // Limpa qualquer seleção que sobrou
            livroSelecionado = null; // Remove referência ao livro que estava selecionado
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (livroSelecionado == null)
            {
                MessageBox.Show(
                    "Busque um livro antes de tentar excluir.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Chama o método da controller para excluir o livro
            bool sucesso = controller.ExcluirLivro(livroSelecionado.Id);

            if (sucesso)
            {
                livroSelecionado = null;
                LimparCamposBusca();
                CarregarLivros(); // Atualiza a grid
            }

        }
        #endregion ..:: 

        private void dgvTodosLivros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTodosLivros.SelectedRows.Count > 0)
            {
                int idLivroSelecionado = Convert.ToInt32(dgvTodosLivros.SelectedRows[0].Cells["Id"].Value);
                livroSelecionado = controller.BuscarLivroPorId(idLivroSelecionado);
            }
        }
    }
}
