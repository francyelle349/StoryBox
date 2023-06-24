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
    public partial class Generos : Form
    {
        public Generos()
        {
            InitializeComponent();
             dgvGeneros.Enabled = false;



            

     

          GeneroController controller = new GeneroController();
          dgvGeneros.DataSource =  controller.mostrarGeneros();
        }

      

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new Funcionario();
            frm.Show();
        }


        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGeneros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
     
                                                                           

        }

        private void TelaGenerosFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
           
            TelaFuncionarioAdicionarGenero frm = new TelaFuncionarioAdicionarGenero();


            frm.ShowDialog();

            frm = null;

            this.Show();

            
            Generos genero = new Generos();
            //fecha a pagina de telaGenerosFuncionario anterior e aparece outra atualizada
            this.Close();
            genero.ShowDialog();

        }

      

        private void btnEditar_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            GeneroController generoController = new GeneroController();
            generoController.removerGenero(dgvGeneros);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            dgvGeneros.Enabled = true;
            dgvGeneros.Columns["id"].ReadOnly = true;
        }
    }
}
