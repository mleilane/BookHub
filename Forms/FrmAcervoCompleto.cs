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
    }
}
