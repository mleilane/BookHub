using BookHub.Controller;
using BookHub.Models;
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
    public partial class FrmCadastroDeLivros : Form
    {
        public FrmCadastroDeLivros()
        {
            InitializeComponent();
        }

        private void btnAddLivro_Click(object sender, EventArgs e)
        {
            var novoLivro = new Livro
            {
                Titulo = txtTituloAddLivro.Text,
                Autor = txtAutorAddLivro.Text,
                ISBN = txtIsbnAddLivro.Text,
                Quantidade = int.Parse(txtQtdAddLivro.Text),
                Lido = rbtnSim.Checked, // Se "Sim" estiver selecionado, Lido = true, senão Lido = false
                DataDeRegistro = DateTime.Now

            };

            var livroController = new LivroController();
            bool sucesso = livroController.CadastrarLivro(novoLivro);

            LimparCampos();

        }

        //limpeza dos campos
        private void LimparCampos()
        {
            txtTituloAddLivro.Text = "";
            txtAutorAddLivro.Text = "";
            txtIsbnAddLivro.Text = "";
            txtQtdAddLivro.Text = "";

            rbtnSim.Checked = false;
            rbtnNao.Checked = false;
        }

        private void btnCancelarLivro_Click(object sender, EventArgs e)
        {
            this.Close(); //fecha o form
        }
    }
}
