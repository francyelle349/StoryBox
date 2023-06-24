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
    public partial class TelaClienteCadastro : Form
    {
        public TelaClienteCadastro()
        {
            InitializeComponent();
            ControllerCliente cliente = new ControllerCliente();
            
         
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new  TelaLoginCliente();
            frm.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           ControllerCliente cliente = new ControllerCliente();


            cliente.cadastrarCliente(txtNome.Text, txtPais.Text, txtEstado.Text, txtBairro.Text,
                 txtRua.Text, int.Parse(txtNumeroDaCasa.Text), txtCPF.Text, txtNumeroDaConta.Text, txtEmail.Text, txtSenha.Text, int.Parse(txtCep.Text));
        }

        private void TelaClienteCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
