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
    public partial class StoryBox : Form
    {
        public StoryBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLoginCliente frm = new TelaLoginCliente();


            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLoginFuncionario frm = new TelaLoginFuncionario();


            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    }