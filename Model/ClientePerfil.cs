using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class ClientePerfil
    {
        private string striconn = @"server=LocalHost; port=3306;database=livros;user=root;";
        MySqlConnection objConnect = null;
        MySqlCommand objectCommannd = null;

        public DataTable mostrarLivros()
        {
            string stSQL = "select isnb,titulo,autor,descricao,genero,precoUnitario,estoque from livro";
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

        public void pesquisarLivros()
        {

        }

         

        


        private string striconn2 = @"server=LocalHost; port=3306;database=usuariodb;user=root;";

        public DataTable listaDeLivrosCarrinho(int id)
        {
            string stSQL = "CALL pr_UsuarioVerCarrinho10(@frk_UsuarioId)";
            using (MySqlConnection objConnect = new MySqlConnection(striconn2))
            {
                using (MySqlCommand objectCommand = new MySqlCommand(stSQL, objConnect))
                {
                    objectCommand.Parameters.AddWithValue("@frk_UsuarioId", id);

                    try
                    {
                        using (MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommand))
                        {
                            DataTable dtLista = new DataTable();
                            objADP.Fill(dtLista);
                            return dtLista;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return null;
                    }
                }
            }
        }



        public static decimal SomaPrecoPorUsuario(int usuarioId)
{
    string connString = @"server=LocalHost; port=3306;database=usuariodb;user=root;";
    decimal totalPreco = 0;

    string sql = "SELECT SUM(livro.precoUnitario) " +
                 "FROM livros.livro " +
                 "JOIN usuariodb.conexaoentretabelas ON conexaoentretabelas.frk_LivroId = livros.livro.isnb " +
                 "WHERE conexaoentretabelas.frk_UsuarioId = @usuarioId";

    using (MySqlConnection conn = new MySqlConnection(connString))
    {
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@usuarioId", usuarioId);

        try
        {
            conn.Open();
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                totalPreco = Convert.ToDecimal(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    return totalPreco;
}

        public static void SubtractFromEstoqueAndRemove(int usuarioId, string frk_LivroId)
        {
            string connString = @"server=LocalHost; port=3306;database=usuariodb;user=root;";

            // Subtract from 'estoque' in 'livro' table
            string updateSql = "SET FOREIGN_KEY_CHECKS = 0;"+"UPDATE livros.livro SET estoque = estoque - 1 WHERE isnb = @frk_LivroId";

            // Remove row from 'conexaoentretabelas' table
            string deleteSql = "DELETE FROM conexaoentretabelas WHERE frk_UsuarioId = @usuarioId";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                // Subtract from 'estoque'
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@frk_LivroId", frk_LivroId);
                updateCmd.ExecuteNonQuery();

                // Remove row from 'conexaoentretabelas'
                MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn);
                deleteCmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                deleteCmd.ExecuteNonQuery();
            }
        }




        public void verInformacoesDePerfil()
        {

        }
        public void excluirPerfil()
        {

        }
        public void editarPerfil()
        {

        }
        public void MostrarLivrosPeloGenero(String genero)
        {

        }
        MySqlConnection conexao = new MySqlConnection(@"server=LocalHost;port=3306;database=usuariodb;user=root;");
        MySqlCommand cmd = new MySqlCommand();

        public string mensagem;
        bool validacao = true;
        public void adicionarNaTabela(int id, String isnb, int estoque)
        {
            //
            //id e o id do livro que eu quero
            //adicionar no banco de dados DA CONEXAO


            if (validacao)
            {
                // Comando SQL
                cmd.CommandText = "insert into conexaoentretabelas(frk_UsuarioId, frk_LivroId,frk_EstoqueLivro) values(@id, @isnb, @estoque)";

                // Parâmetros
                cmd.Parameters.AddWithValue("@isnb", isnb);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@estoque", estoque);


                try
                {
                    // Abrir a conexão
                    conexao.Open();
                    cmd.Connection = conexao;

                    // Executar o comando
                    cmd.ExecuteNonQuery();

                    // Fechar a conexão
                    conexao.Close();

                    MessageBox.Show("Cadastrado com sucesso!");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + e.Message);
                }


            }
        }

        // NÃO DEU CERTO PORQUE O TXTBOX NÃO RETIRAVA AS INFORMACÇÕES DAQUI
        public void VerInformacoesUsuario(int userId, string nome, string pais, string estado, string bairro,
            string rua, string numeroCasa, string cpf, String numeroConta, string email, string senha, string cep)
        {
            string connString = @"server=LocalHost; port=3306;database=usuariodb;user=root;";
            string sql = "SELECT usuario.* FROM usuario WHERE usuario.id = userId";

            MySqlConnection conn = new MySqlConnection(connString);
            
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@userId", userId);
                

            using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nome = reader["nome"].ToString();
                        pais = reader["pais"].ToString();
                        estado = reader["estado"].ToString();
                        bairro = reader["bairro"].ToString();
                        rua = reader["rua"].ToString();
                        numeroCasa =(string) reader["numeroCasa"].ToString();
                        cpf = reader["cpf"].ToString();
                        numeroConta = reader["numeroConta"].ToString();
                        email = reader["email"].ToString();
                        senha = reader["senha"].ToString();
                        cep = (string) reader["cep"].ToString();
                    }
                    else
                    {

                        nome = "";
                        pais = "";
                        estado = "";
                        bairro = "";
                        rua = "";
                        numeroCasa = "";
                        cpf = "";
                        numeroConta = "";
                        email = "";
                        senha = "";
                        cep = "";
                        
                    }
                    conn.Close();
                }
            }
        }


    }




    
