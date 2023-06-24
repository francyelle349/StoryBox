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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
           
            InitializeComponent();
            ControllerCliente controllerCliente = new ControllerCliente();
            controllerCliente.MostrarDataTable(dgvLivros);
            GeneroController controller = new GeneroController();
            controller.conectarGeneroaocadastro(txtGenero);


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaLoginCliente();
            frm.Show();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaClientePerfilUsuario frm = new TelaClientePerfilUsuario();


            frm.Show();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaClienteCarrinho frm = new TelaClienteCarrinho();


            frm.Show();
        }

        private void TelaCliente_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (number >= 0)
            {
                DataGridViewRow row = dgvLivros.Rows[number];

                // Extract the desired column value
                string isnb = row.Cells["isnb"].Value.ToString();
                string estoque = row.Cells["estoque"].Value.ToString();

                ControllerCliente controllerCliente = new ControllerCliente();
                int id = ControllerListaUserId.acessarLista();
                controllerCliente.adicionarTabela(id, isnb,int.Parse(estoque));

              
            }
           

        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int number = 0;
        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = e.RowIndex;

            this.number = number;
        }

        private void txtGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (txtGenero.SelectedItem != null)
            {
                string selectedText = txtGenero.SelectedItem.ToString();
                // Perform the desired action with the selected text
               
                ControllerCliente controllerCliente = new ControllerCliente();

             dgvLivros.DataSource =   controllerCliente.pesquisarPorGenero(selectedText);
            }
        }

        private void btnTodosOsLivros_Click(object sender, EventArgs e)
        {
            ControllerCliente controllerCliente = new ControllerCliente();
            controllerCliente.MostrarDataTable(dgvLivros);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
                string selectedText = txtPesquisar.Text.ToString();
                // Perform the desired action with the selected text

                ControllerCliente controllerCliente = new ControllerCliente();

                dgvLivros.DataSource = controllerCliente.pesquisarTitulo(selectedText);
            }
        }
    }

