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

namespace BookHub.Forms
{
    public partial class FrmResumoAcervo : Form
    {
        private readonly LivroController _livroController = new LivroController();

        public FrmResumoAcervo()
        {
            InitializeComponent();
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
