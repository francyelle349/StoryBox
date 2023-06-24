using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerTabelas
    {
        public void LivrosEstoquesLivrosMaisAltos(DataGridView dataGridView)
        {
            Tabelas tabelas = new Tabelas();
            dataGridView.DataSource = tabelas.LivrosEstoquesLivrosMaisAltos();
        }
        public void LivrosEstoquesGenerosMaisAltos(DataGridView dataGridView)
        {
            Tabelas tabelas = new Tabelas();
            dataGridView.DataSource = tabelas.LivrosEstoquesGenerosMaisAltos();
        }
    }
}
