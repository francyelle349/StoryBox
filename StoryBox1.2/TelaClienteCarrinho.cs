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
    public partial class TelaClienteCarrinho : Form
    {
        public TelaClienteCarrinho()
        {
            InitializeComponent();
            ControllerCliente controllerCliente = new ControllerCliente();
           dgvLivros.DataSource = controllerCliente.mostrarLivrosCarrinho(ControllerListaUserId.acessarLista());
            

           txtValorTotal.Text =  controllerCliente.somaEstoque(ControllerListaUserId.acessarLista()).ToString();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaCliente();
            frm.Show();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            bool estoqueMaiorQueZero = false;
            ControllerCliente controllerCliente = new ControllerCliente();
            foreach (DataGridViewRow row in dgvLivros.Rows)
            {
                
                    DataGridViewCell cell = row.Cells["isnb"];

                    DataGridViewCell cellEstoque = row.Cells["estoque"];

                    if (cellEstoque != null && cellEstoque.Value != null && int.Parse(cellEstoque.Value.ToString()) >= 0)
                    {
                        if (cell != null && cell.Value != null)
                        {

                            string livroId = cell.Value.ToString();
                            int usuarioId = ControllerListaUserId.acessarLista(); // Replace with the appropriate method or variable to retrieve the usuarioId

                            controllerCliente.SubtrairLivrosNaCompra(usuarioId, livroId);
                        estoqueMaiorQueZero = true;
                        }

                    }

                    
               
            }

            if (!estoqueMaiorQueZero)
            {
                MessageBox.Show("Fora de Estoque");
            }

            MessageBox.Show("Produtos comprados com sucesso", "Parabéns", MessageBoxButtons.OK);


        }


    

        private void TelaClienteCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    private void txtValorTotal_TextChanged(object sender, EventArgs e)
    {

    }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
        }

        private void btnComprarCarrinho_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
