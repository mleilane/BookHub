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
        public FrmAcervoCompleto()
        {
            InitializeComponent();
            ConfigurarDgvTodosLivros();
            CarregarLivros();

        }

        //eventos

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            //criando uma instancia da tela Inicial
            FrmTelaInicial telaInicialForm = new FrmTelaInicial();

            //exibindo a tela inicial e fechando o AcervoCompleto 
            telaInicialForm.Show();
            this.Close(); // Fecha o formulário atual
        }

  

        //botao resumo acervo
        private void btnResumoAcervo_Click(object sender, EventArgs e)
        {
            //criando instancia 
            FrmResumoAcervo resumoAcervoForm = new FrmResumoAcervo();

            //exibindo o form ResumoAcervo
            resumoAcervoForm.ShowDialog();
        }


        //botao adicionar livro 
        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            //criando instancia 
            FrmCadastroDeLivros frmcadastroDeLivros = new FrmCadastroDeLivros();

            //exibindo o form CadastroDeLivros
            frmcadastroDeLivros.ShowDialog();
        }

        //metodos
        private void CarregarLivros()
        {
            LivroController livroController = new LivroController();
            List<Livro> livros = livroController.ObterTodosLivros();

            dgvTodosLivros.Rows.Clear(); // Limpa o DataGridView antes de popular

            foreach(var livro in livros)
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
    }
}
