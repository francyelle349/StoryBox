using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Tabelas
    {
        private string striconn = @"server = LocalHost; port=3306;database=livros;user=root;";
        MySqlConnection objConnect = null;
        MySqlCommand objectCommannd = null;
        public DataTable LivrosEstoquesGenerosMaisAltos()
        {
            string stSQL = "call pr_BiggerEstoque";
            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);

                DataTable dtLista = new DataTable();

                objADP.Fill(dtLista);

                return dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("deu erro");
                return null;
            }

        }
        public DataTable LivrosEstoquesLivrosMaisAltos()
        {
            string stSQL = "call pr_tabelaMaioresEstoquesLivros";
            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);

                DataTable dtLista = new DataTable();

                objADP.Fill(dtLista);

                return dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("deu erro");
                return null;
            }

        }
    }

      
    }
