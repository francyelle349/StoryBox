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
    public partial class TelaLoginFuncionario : Form
    {
        public TelaLoginFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new StoryBox();
            frm.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
          

        }

        private void TelaLoginFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerValidarLogin controllerValidarLogin = new controllerValidarLogin();
            Funcionario telafuncionario = new Funcionario();

            controllerValidarLogin.validarLogin(txtEmail.Text, txtSenha.Text, telafuncionario, this);
        }
    }
}
