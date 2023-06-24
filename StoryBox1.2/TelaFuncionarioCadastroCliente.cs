using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StoryBox
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
           
            InitializeComponent();
           
            ControllerCliente controllerCliente = new ControllerCliente();
        
        
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ControllerFuncionarioCliente controllerCliente = new ControllerFuncionarioCliente();
            controllerCliente.controllerCadastrarCliente(txtNome.Text, txtPais.Text,txtEstado.Text,
                txtBairro.Text, txtRua.Text, int.Parse(txtNumeroDaCasa.Text), int.Parse(txtCep.Text),
                txtCPF.Text, txtNumeroDaConta.Text,
                txtEmail.Text,txtSenha.Text);
        }

        private void TelaFuncionarioCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
