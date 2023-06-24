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
    public class FuncoesGenero
    {
        string mensagem = "";
        MySqlConnection conexao = new MySqlConnection(@"server=localhost;port=3306;database=livros;user=root;");
        MySqlCommand cmd = new MySqlCommand();
        public void AdicionarGeneroNoBanco(string genero)
        {
            if (genero.Equals(""))
            {
                MessageBox.Show("Elemento inválido, tente novamente");
            }
            else
            {
                // Comando SQL
                cmd.CommandText = "INSERT INTO genero (genero)" +
                    " VALUES (@genero)";

                // Parâmetros
                cmd.Parameters.AddWithValue("@genero", genero);


                try
                {
                    // Abrir a conexão
                    conexao.Open();
                    cmd.Connection = conexao;

                    // Executar o comando
                    cmd.ExecuteNonQuery();

                    // Fechar a conexão
                    conexao.Close();

                    this.mensagem = "Cadastrado com sucesso!";
                }
                catch (MySqlException e)
                {
                    this.mensagem = "Erro ao conectar com o banco de dados: " + e.Message;
                }
            }
        }

        
        public DataTable listaGrid()
        {
            string stSQL = "SELECT * FROM genero";
           
            cmd = new MySqlCommand(stSQL, conexao);

            
            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(cmd);

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

        public DataTable listaGridSomenteGenero()
        {
            string stSQL = "SELECT genero FROM genero";

            cmd = new MySqlCommand(stSQL, conexao);


            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(cmd);

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

        public void removerGenero(DataGridView data)
        {
            try
            {
                int selectedIndex = data.SelectedRows[0].Index;
            int PrimaryKey = Convert.ToInt32(data.Rows[selectedIndex].Cells["id"].Value);

            
                conexao.Open();
                string sql = "DELETE FROM genero WHERE id = @id";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                command.Parameters.AddWithValue("@id", PrimaryKey);
                command.ExecuteNonQuery();
                data.Rows.RemoveAt(selectedIndex);
                conexao.Close();
            }
            catch (Exception ex)
            {
                // Trate a exceção conforme necessário
            }
            finally
            {
                conexao.Close();
            }
        }




    }
}

