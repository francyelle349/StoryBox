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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaLoginFuncionario();
            frm.Show();
        }

        private void btnAcessoLivros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Livros frm = new Livros();


            frm.Show();
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new Generos();
            frm.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaFuncionarioRelatorios();
            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaFuncionarioClientes();
            frm.Show();
        }
    }
}
