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
    public partial class TelaClientePerfilUsuario : Form
    {
        public TelaClientePerfilUsuario()
        {
            InitializeComponent();
          
        }

        private void TelaClientePerfilUsuario_Load(object sender, EventArgs e)
        {
            try
            {

                ControllerCliente controllerCliente = new ControllerCliente();

                

                DataTable userTable = controllerCliente.mostrarInformacoesUsuario(ControllerListaUserId.acessarLista()); ;
                if (userTable != null && userTable.Rows.Count > 0)
                {
                    DataRow userRow = userTable.Rows[0];
                    
                    // Retrieve the values from the DataRow
                    txtNome.Text = userRow["nome"].ToString();
                    txtPais.Text = userRow["pais"].ToString();
                    txtEstado.Text = userRow["estado"].ToString();
                    txtBairro.Text = userRow["bairro"].ToString();
                    txtRua.Text = userRow["rua"].ToString();
                    txtNumeroDaCasa.Text = userRow["numeroCasa"].ToString();
                    txtCPF.Text = userRow["cpf"].ToString();
                    txtNumeroDaConta.Text = userRow["numeroConta"].ToString();
                    txtEmail.Text  = userRow["email"].ToString();
                    txtSenha.Text = userRow["senha"].ToString();
                    txtCep.Text = userRow["cep"].ToString();


                    // Retrieve other columns as needed

                    // Assign the values to the text boxes
                  
                    // Assign other columns to respective text boxes
                    // ...
                }
                else
                {
                    // User with the given ID not found or an error occurred
                    // Handle the case appropriately
                    txtNome.Text = "";
                    txtPais.Text = "";
                    // Assign default or empty values to other text boxes
                    // ...
                }





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaCliente();
            frm.Show();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            ControllerCliente cliente = new ControllerCliente();

            cliente.deletarInformacoes(ControllerListaUserId.acessarLista());

            this.Close();
            TelaLoginCliente telaLoginCliente = new TelaLoginCliente();

            telaLoginCliente.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtPais.Enabled = true;
            txtEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtRua.Enabled = true;
            txtNumeroDaCasa.Enabled = true;
            txtCPF.Enabled = false;
            txtNumeroDaConta.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
            txtCep.Enabled = true;

             // Provide the user ID
            
           

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string pais = txtPais.Text;
            string estado = txtEstado.Text;
            string bairro = txtBairro.Text;
            string rua = txtRua.Text;
            int numeroCasa = int.Parse(txtNumeroDaCasa.Text);
            string cpf = txtCPF.Text;
            string numeroConta = txtNumeroDaConta.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            int cep = int.Parse(txtCep.Text);

            ControllerFuncionarioCliente controllerFuncionarioCliente = new ControllerFuncionarioCliente();

            // Call the editarCliente method and pass the values as parameters
            controllerFuncionarioCliente.editarCliente(nome, pais, estado, bairro, rua, numeroCasa, cep, cpf, numeroConta, email, senha);
        }
    }
}
