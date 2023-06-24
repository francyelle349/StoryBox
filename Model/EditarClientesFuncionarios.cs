using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class EditarClientesFuncionarios
    {
        
        public void EditarLivro(String nome, String pais, String estado,
        String bairro, String rua, int numeroCasa, int cep, String cpf, String numeroConta,
        String email, String senha)
        {
            string connectionString = "server=localhost;port=3306;database=usuariodb;user=root;";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                // Comando SQL para o update
                string sql = "UPDATE usuario SET nome = @nome, pais = @pais, estado = @estado, bairro = @bairro, rua = @rua, numeroCasa = @numeroCasa," +
                    " cpf = @cpf, cep = @cep, numeroConta = @numeroConta, " +
                    "email = @email, senha = @senha WHERE email = @email";

                // Parâmetros para o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numeroCasa", numeroCasa);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@numeroConta", numeroConta);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

            
                try
                {
                    // Abrir a conexão
                    conexao.Open();

                    // Executar o comando SQL
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi atualizado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }

            }
        }

        public void apagarCliente(DataGridView data)
        {
            try
            {
                int selectedIndex = data.SelectedRows[11].Index;
                string PrimaryKey = Convert.ToString(data.Rows[selectedIndex].Cells["id"].Value);
                string connectionString = "server=localhost;port=3306;database=usuariodb;user=root;";

                Conexao.Conectar();
                string sql = "DELETE FROM usuario WHERE id = @id";
                MySqlCommand command = new MySqlCommand(sql, Conexao.conexao);
                command.Parameters.AddWithValue("@id", PrimaryKey);
                command.ExecuteNonQuery();
                data.Rows.RemoveAt(selectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
