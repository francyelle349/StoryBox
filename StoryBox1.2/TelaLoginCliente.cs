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
    public partial class TelaLoginCliente : Form
    {
        public TelaLoginCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            
            TelaCliente frm = new TelaCliente();
            controllerValidarLogin controllerValidarLogin = new controllerValidarLogin();

            controllerValidarLogin.validarLoginCliente(txtEmail.Text, txtSenha.Text, frm, this);

        }

        private void btnNaoTemCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaClienteCadastro frm = new TelaClienteCadastro();


            frm.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StoryBox frm = new StoryBox();


            frm.Show();
        }
    }
}
