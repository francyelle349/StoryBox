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
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();

            LivroController controller = new LivroController();
            dgvLivros.DataSource = controller.ListarLivrosDoBanco();
            dgvLivros.Columns["isnb"].ReadOnly = true;

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
            TelaFuncionarioCadastrarLivro frm = new TelaFuncionarioCadastrarLivro();

            frm.ShowDialog();

            frm = null;

            Livros telaFuncionarioLivros = new Livros();

            telaFuncionarioLivros.ShowDialog();
            

        }

        private void TelaFuncionarioLivros_Load(object sender, EventArgs e)
        {


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvLivros.Enabled = true;


        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvLivros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifica-se de que a linha clicada não seja o cabeçalho
            {
                try {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow row = dgvLivros.Rows[rowIndex];

                    // Acessar os valores da linha clicada
                    string isnb = row.Cells["isnb"].Value.ToString();
                    string titulo = row.Cells["titulo"].Value.ToString();
                    string autor = row.Cells["autor"].Value.ToString();
                    string descricao = row.Cells["descricao"].Value.ToString();
                    string genero = row.Cells["genero"].Value.ToString();
                    string estoque = row.Cells["estoque"].Value.ToString();
                    double precoUnitario = Convert.ToDouble(row.Cells["precoUnitario"].Value);

                   LivroController controller = new LivroController();

                    controller.atualizarLivros(titulo, autor, descricao, genero, long.Parse(estoque), precoUnitario, isnb);

                }catch(Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
                }
        
            

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            LivroController livro = new LivroController();

            livro.apagarLivro(dgvLivros);
        }
    }
}
