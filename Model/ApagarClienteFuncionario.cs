using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class ApagarClienteFuncionario
    {
        MySqlConnection Conexao = new MySqlConnection(@"server=LocalHost;port=3306;database=usuariodb;user=root;");
        MySqlCommand cmd = new MySqlCommand();

        public void apagarCliente(DataGridView data)
        {
            try
            {
                int selectedIndex = data.SelectedRows[12].Index;
                int PrimaryKey = Convert.ToInt32(data.Rows[selectedIndex].Cells["id"].Value);

           
                Conexao.Open();
                string sql = "DELETE FROM usuario WHERE id = @id";
                MySqlCommand command = new MySqlCommand(sql, Conexao);
                command.Parameters.AddWithValue("@id", PrimaryKey);
                command.ExecuteNonQuery();
                data.Rows.RemoveAt(selectedIndex);
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
