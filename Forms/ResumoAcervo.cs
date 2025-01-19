using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHub.Forms
{
    public partial class ResumoAcervo : Form
    {
        public ResumoAcervo()
        {
            InitializeComponent();
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            //verifica se já existe uma instancia da TelaInicial aberta 
            Form telaInicialAberta = Application.OpenForms.OfType<TelaInicial>().FirstOrDefault();

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

                TelaInicial telaInicialForm = new TelaInicial();
                telaInicialForm.Show();

            }

            this.Close(); // Fecha o formulário atual
        }

        private void btnAcervoCompleto_Click(object sender, EventArgs e)
        {
            //verifica se ja exite esse form aberto
            Form acervoCompletoAberto = Application.OpenForms.OfType<AcervoCompleto>().FirstOrDefault();

            if (acervoCompletoAberto != null)
            {
                // se ja existe, ativa o forms 
                acervoCompletoAberto.BringToFront();
            }
            else
            {
                //se não existir, cria instancia e exibe
                AcervoCompleto acervoCompleto = new AcervoCompleto(); //criando instancia 
                acervoCompleto.Show(); //exibindo 
            }
            this.Close();// Fecha o formulário atual

        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            //criando instancia 
            CadastroDeLivros cadastroDeLivros = new CadastroDeLivros();

            //exibindo o form CadastroDeLivros
            cadastroDeLivros.ShowDialog();
        }
    }
}
