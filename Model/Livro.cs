using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Livro
    {
        public String isbn;
        public String titulo;

        
        public String autor;
        public String Descricao;
        public String genero;
        public long Estoque;
        
        public double precoUnitario;

        public Livro(String isbn, String titulo, String autor, String descricao, String genero, long estoque, double precoUnitario)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            Descricao = descricao;
            this.genero = genero;
            Estoque = estoque;
            this.precoUnitario = precoUnitario;
        }
        public Livro()
        {

        }

        public String getTitulo() { return titulo; }

        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getAutor() { return autor; }

        public void setAutor(String autor)
        {
            this.autor = autor;
        }

        public double getPreco() { return precoUnitario; }

        public void setPreco(double preco)
        {
            this.precoUnitario = preco;
        }
        public String getDescricao() { return Descricao; }

        public void setDescricao(String descricao)
        {
            this.Descricao = descricao;
        }

        public String getGenero() { return genero; }

        public void setGenero(String genero)
        {
            this.genero = genero;
        }

        public String getIsbn() { return isbn; }

        public void setIsbn(String isbn)
        {
            this.isbn = isbn;
        }
        public long getEstoque() { return Estoque; }

        public void setEstoque(long Estoque)
        {
            this.Estoque = Estoque;
        }
        public double getprecoUnitario() { return precoUnitario; }

        public void setprecoUnitario(double precoUnitario)
        {
            this.precoUnitario = precoUnitario;
        }
        Conexao Conexao = new Conexao();



        // apagar livro 
        public void apagarLivros(DataGridView data)
        {
            try
            {
                int selectedIndex = data.SelectedRows[0].Index;
                string PrimaryKey = Convert.ToString(data.Rows[selectedIndex].Cells["isnb"].Value);



                Conexao.Conectar();
                string sql = "DELETE FROM livro WHERE isnb = @isnb";
                MySqlCommand command = new MySqlCommand(sql, Conexao.conexao);
                command.Parameters.AddWithValue("@isnb", PrimaryKey);
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

        // cadastrar o livro
       
            MySqlConnection conexao = new MySqlConnection(@"server=LocalHost;port=3306;database=livros;user=root;");
            MySqlCommand cmd = new MySqlCommand();
            public string mensagem;
            bool validacao = true;
            public void cadastroLivro(int isnb, string titulo, string autor, string descricao, string genero, int estoque, double precoUnitario)
            {




                if (validacao)
                {
                    // Comando SQL
                    cmd.CommandText = "INSERT INTO livro (isnb, titulo, autor, descricao, genero, estoque, precoUnitario)" +
                        " VALUES (@isnb, @titulo, @autor, @descricao, @genero, @estoque, @precoUnitario)";

                    // Parâmetros
                    cmd.Parameters.AddWithValue("@isnb", isnb);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@estoque", estoque);
                    cmd.Parameters.AddWithValue("@precoUnitario", precoUnitario);

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
            public bool ValidarISBN(int isnb)
            {
                // Comando SQL para verificar se o e-mail ou o CPF já existem no banco de dados
                cmd.CommandText = "SELECT COUNT(*) FROM livro WHERE isnb = @isnb";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@isnb", isnb);


                int count = 0;

                try
                {
                    // Abrir a conexão
                    conexao.Open();
                    cmd.Connection = conexao;

                    // Executar o comando e obter o resultado
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Fechar a conexão
                    conexao.Close();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + e.Message);
                }

                // Se o contador for maior que zero, significa que o e-mail ou o CPF já existem no banco de dados
                return count == 0;
            }
            public void EditarLivro(string titulo, string autor, string descricao, string genero, long estoque, double precoUnitario, String isnb)
            {
                string connectionString = "server=LocalHost;port=3306;database=livros;user=root;";
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                // Comando SQL para o update
                    string sql = "UPDATE livro SET titulo = @titulo, autor = @autor, descricao = @descricao, genero = @genero, estoque = @estoque, precoUnitario = @precoUnitario WHERE isnb = @isnb";

                    // Parâmetros para o comando SQL
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@estoque", estoque);
                    cmd.Parameters.AddWithValue("@precoUnitario", precoUnitario);
                    cmd.Parameters.AddWithValue("@isnb", isnb);

                    try
                    {
                        // Abrir a conexão
                        conexao.Open();

                        // Executar o comando SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                        string updateForeignKeySql = "UPDATE usuariodb.conexaoentretabelas SET frk_LivroId = @frk_LivroId WHERE frk_LivroId = @isnb";

                        // Parâmetros para o comando SQL de atualização da foreign key
                        MySqlCommand updateForeignKeyCmd = new MySqlCommand(updateForeignKeySql, conexao);
                        updateForeignKeyCmd.Parameters.AddWithValue("@frk_LivroId", isnb);
                        updateForeignKeyCmd.Parameters.AddWithValue("@isnb", isnb);
                        updateForeignKeyCmd.ExecuteNonQuery();
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

            private string striconn = @"server=LocalHost; port=3306;database=livros;user=root;"
            MySqlConnection objConnect = null;
            MySqlCommand objectCommannd = null;

            public DataTable listaDeLivros()
            {
                string stSQL = "SELECT * FROM livro";
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


        public DataTable listaDeLivrosGenero(string genre)
        {
            string stSQL = "SELECT * FROM livro WHERE genero = @genre";
            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            objectCommannd.Parameters.AddWithValue("@genre", genre);

            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);
                DataTable dtLista = new DataTable();
                objADP.Fill(dtLista);
                return dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
        }

        public DataTable listaDeLivrosPesquisa(string genre)
        {
            string stSQL = "SELECT * FROM livro WHERE titulo LIKE CONCAT('%', @titulo, '%')";

            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            objectCommannd.Parameters.AddWithValue("@titulo", genre);

            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);
                DataTable dtLista = new DataTable();
                objADP.Fill(dtLista);
                return dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
        }


        public void usuarioInformacao(string Nome, string Pais, string Estado, string Bairro, string Rua,
                             int NumeroCasa, string CPF, int NumeroConta, string Email,
                             string Senha, string CEP)
        {
            string connString = "server=LocalHost; port=3306;database=usuariodb;user=root;";
            string sql = "SELECT * FROM usuario";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Nome = reader.GetString("nome");
                        Pais = reader.GetString("pais");
                        Estado = reader.GetString("estado");
                        Bairro = reader.GetString("bairro");
                        Rua = reader.GetString("rua");
                        NumeroCasa = reader.GetInt32("numeroCasa");
                        CPF = reader.GetString("cpf");
                        NumeroConta = reader.GetInt32("numeroConta");
                        Email = reader.GetString("email");
                        Senha = reader.GetString("senha");
                        CEP = reader.GetString("cep");
                    }
                    else
                    {
                        // Clear the variables if no user information found
                        Nome = "";
                        Pais = "";
                        Estado = "";
                        Bairro = "";
                        Rua = "";
                        NumeroCasa = 0;
                        CPF = "";
                        NumeroConta = 0;
                        Email = "";
                        Senha = "";
                        CEP = "";
                    }
                }
                catch (Exception ex)
                {
                    // Display error message in one of the variables
                    Nome = "Error: " + ex.Message;
                }
            }
        }



    }

}
