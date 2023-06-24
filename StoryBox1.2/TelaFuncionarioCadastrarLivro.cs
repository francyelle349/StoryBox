using Controller;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryBox
{
    public partial class TelaFuncionarioCadastrarLivro : Form
    {
        public TelaFuncionarioCadastrarLivro()
        {
            InitializeComponent();
            GeneroController controller = new GeneroController();
            controller.conectarGeneroaocadastro(txtGenero);
           


        }

        private void TelaFuncionarioCadastrarLivro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try {
               LivroController controller = new LivroController();

                controller.CadastroLivro(int.Parse(txtIsbn.Text), txtTitulo.Text, txtAutor.Text, txtDescricao.Text, txtGenero.Text, int.Parse(txtEstoque.Text), double.Parse(txtSaldoUnitario.Text));
            }
            catch {
                MessageBox.Show("Revise suas informações");
            }
            }

        private void txtGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
