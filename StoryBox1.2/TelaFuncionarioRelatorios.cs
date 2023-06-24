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
    public partial class TelaFuncionarioRelatorios : Form
    {
        public TelaFuncionarioRelatorios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new Funcionario();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaiorEstoqueGeneros_Click(object sender, EventArgs e)
        {
            ControllerTabelas tabelas = new ControllerTabelas();

            tabelas.LivrosEstoquesGenerosMaisAltos(dgvRelatorio);
        }

        private void btnMaiorEstoqueLivros_Click(object sender, EventArgs e)
        {
            ControllerTabelas tabelas = new ControllerTabelas();

            tabelas.LivrosEstoquesLivrosMaisAltos(dgvRelatorio);
        }
    }
}
