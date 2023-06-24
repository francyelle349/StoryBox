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
    public partial class TelaFuncionarioAdicionarGenero : Form
    {
        public TelaFuncionarioAdicionarGenero()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            GeneroController controller = new GeneroController();

            controller.ColocarGeneroNoBanco(txtRegistroGenero.Text);
        }

        private void TelaFuncionarioAdicionarGenero_Load(object sender, EventArgs e)
        {

        }
    }
}
