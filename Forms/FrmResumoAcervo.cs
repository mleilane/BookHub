using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHub.Controller;
using BookHub.Models;

namespace BookHub.Forms
{
    public partial class FrmResumoAcervo : Form
    {
        private readonly LivroController _livroController = new LivroController();

        public FrmResumoAcervo()
        {
            InitializeComponent();
            ConfigurarDgvUltimosAdicionados();
            CarregarLivrosResumoAcervo();

        }

        private void CarregarLivrosResumoAcervo()
        {
            LivroController livroController = new LivroController();
            List<Livro> livros = livroController.ObterUltimosAdicionados();

            dgvUltimosAdicionados.Rows.Clear(); // Limpa o DataGridView antes de popular

            foreach (var livro in livros)
            {
                dgvUltimosAdicionados.Rows.Add(
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
        private void ConfigurarDgvUltimosAdicionados()
        {
            dgvUltimosAdicionados.EnableHeadersVisualStyles = false; //desabilita o estilo padrão

            //cabeçalho 
            dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold); //fonte 
            dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //centraliza o texto 
            dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); //cor de fundo  
            dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // cor do texto 

            // Desativa a seleção do cabeçalho (impede que ele fique azul)
            dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvUltimosAdicionados.ColumnHeadersDefaultCellStyle.BackColor;
            dgvUltimosAdicionados.DefaultCellStyle.SelectionBackColor = dgvUltimosAdicionados.DefaultCellStyle.BackColor; // Define a mesma cor do fundo
            dgvUltimosAdicionados.DefaultCellStyle.SelectionForeColor = dgvUltimosAdicionados.DefaultCellStyle.ForeColor; // Mantém a cor do texto


            //celulas
            dgvUltimosAdicionados.ClearSelection();  // Remove a seleção inicial da celula 
            dgvUltimosAdicionados.CurrentCell = null; // Remove o foco visual
            dgvUltimosAdicionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Define seleção por linha inteira
            dgvUltimosAdicionados.MultiSelect = false; // Impede múltiplas seleções
            dgvUltimosAdicionados.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.75F, FontStyle.Regular); //tamanho e espessura fonte 
            dgvUltimosAdicionados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // cor de fundo em linhas alternadas
            dgvUltimosAdicionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //ajuste automatico da largura das colunas
            dgvUltimosAdicionados.Columns["Título"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //centraliza  o texto
            dgvUltimosAdicionados.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUltimosAdicionados.Columns["ISBN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUltimosAdicionados.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUltimosAdicionados.Columns["Lido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUltimosAdicionados.Columns["Data_de_Registro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvUltimosAdicionados.Columns["Título"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; //deixa a coluna com autoajuste 


        }



        //eventos 
        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            //verifica se já existe uma instancia da TelaInicial aberta 
            Form telaInicialAberta = Application.OpenForms.OfType<FrmTelaInicial>().FirstOrDefault();

            if (telaInicialAberta != null)
            {
                // se ja existe, ativa o forms 
                Console.WriteLine("A TelaInicial já está aberta.");
                telaInicialAberta.BringToFront();
            }
            else
            {
                //se não existir, cria instancia e exibe 
                Console.WriteLine("Criando uma nova instância de TelaInicial.");

                FrmTelaInicial telaInicialForm = new FrmTelaInicial();
                telaInicialForm.Show();

            }

            this.Close(); // Fecha o formulário atual
        }

        private void btnAcervoCompleto_Click(object sender, EventArgs e)
        {
            //verifica se ja exite esse form aberto
            Form acervoCompletoAberto = Application.OpenForms.OfType<FrmAcervoCompleto>().FirstOrDefault();

            if (acervoCompletoAberto != null)
            {
                // se ja existe, ativa o forms 
                acervoCompletoAberto.BringToFront();
            }
            else
            {
                //se não existir, cria instancia e exibe
                FrmAcervoCompleto acervoCompleto = new FrmAcervoCompleto(); //criando instancia 
                acervoCompleto.Show(); //exibindo 
            }
            this.Close();// Fecha o formulário atual

        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            //criando instancia 
            FrmCadastroDeLivros cadastroDeLivros = new FrmCadastroDeLivros();

            //exibindo o form CadastroDeLivros
            cadastroDeLivros.ShowDialog();
        }

        private void FrmResumoAcervo_Load(object sender, EventArgs e)
        {
            var resumo = _livroController.ObterResumoAcervo();

            lblTotal.Text = resumo.total.ToString();
            lblQtdLidos.Text = resumo.lidos.ToString();
            lblPercLidos.Text = $"{resumo.percLidos:F0}%";

            lblQtdNaoLidos.Text = resumo.naoLidos.ToString();
            lblPercNaoLidos.Text = $"{resumo.percNaoLidos:F0}%";
        }

        
    }
}
