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
    public partial class TelaFuncionarioClientes : Form
    {
        public TelaFuncionarioClientes()
        {
            InitializeComponent();
            ControllerFuncionarioCliente controllerCliente = new ControllerFuncionarioCliente();
            dgvClientes.DataSource = controllerCliente.ControllerMostrarCliente();
            dgvClientes.Enabled = false;
            dgvClientes.Columns["email"].ReadOnly = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new Funcionario();
            frm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro frm = new Cadastro();


            frm.ShowDialog();


            frm = null;
            TelaFuncionarioClientes funcionarioClientes = new TelaFuncionarioClientes();
            funcionarioClientes.ShowDialog();

        }

        private void TelaFuncionarioClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ControllerFuncionarioCliente controllerCliente = new ControllerFuncionarioCliente();

            controllerCliente.ApagarCliente(dgvClientes);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvClientes.Enabled = true;
        }

        private void dgvClientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifica-se de que a linha clicada não seja o cabeçalho
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvClientes.Rows[rowIndex];
          

                // Acessar os valores da linha clicada
                string nome = row.Cells["nome"].Value.ToString();
                string pais = row.Cells["pais"].Value.ToString();
                string estado = row.Cells["estado"].Value.ToString();
                string bairro = row.Cells["bairro"].Value.ToString();
                string rua = row.Cells["rua"].Value.ToString();
                int numeroCasa = Convert.ToInt32(row.Cells["numeroCasa"].Value.ToString());
                int cep = Convert.ToInt32(row.Cells["cep"].Value.ToString());
                String cpf = row.Cells["cpf"].Value.ToString();
                String numeroConta = row.Cells["numeroConta"].Value.ToString();
                String email = row.Cells["email"].Value.ToString();
                String senha = row.Cells["senha"].Value.ToString();
                


                AtualizarClientesController atualizarClientesController = new AtualizarClientesController();

                atualizarClientesController.atualizarClientesController(nome,pais,estado,bairro,rua,numeroCasa,
                    cep,cpf,numeroConta,email,senha);

               

            }
        }
    }
}
