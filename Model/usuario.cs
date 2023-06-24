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
    public class usuario
    {
        private string nome;
        private string pais;
        private string estado;
        private string bairro;
        private string rua;
        private int numeroCasa;
        private string cpf;
        private string numeroConta;
        private string email;
        private string senha;
        private int cep;
        private int id;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string value)
        {
            nome = value;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string value)
        {
            pais = value;
        }

        public string GetEstado()
        {
            return estado;
        }

        public void SetEstado(string value)
        {
            estado = value;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public void SetBairro(string value)
        {
            bairro = value;
        }

        public string GetRua()
        {
            return rua;
        }

        public void SetRua(string value)
        {
            rua = value;
        }

        public int GetNumeroCasa()
        {
            return numeroCasa;
        }

        public void SetNumeroCasa(int value)
        {
            numeroCasa = value;
        }

        public string GetCPF()
        {
            return cpf;
        }

        public void SetCPF(string value)
        {
            cpf = value;
        }

        public string GetNumeroConta()
        {
            return numeroConta;
        }

        public void SetNumeroConta(string value)
        {
            numeroConta = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetSenha(string value)
        {
            senha = value;
        }

        public int GetCEP()
        {
            return cep;
        }

        public void SetCEP(int value)
        {
            cep = value;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        // Constructor with all data
        public usuario(string nome, string pais, string estado, string bairro, string rua, int numeroCasa, string cpf, string numeroConta, string email, string senha, int cep, int id)
        {
            this.nome = nome;
            this.pais = pais;
            this.estado = estado;
            this.bairro = bairro;
            this.rua = rua;
            this.numeroCasa = numeroCasa;
            this.cpf = cpf;
            this.numeroConta = numeroConta;
            this.email = email;
            this.senha = senha;
            this.cep = cep;
            this.id = id;
        }
        public usuario(string nome, string pais, string estado, string bairro, string rua, int numeroCasa, string cpf, string numeroConta, string email, string senha, int cep)
        {
            this.nome = nome;
            this.pais = pais;
            this.estado = estado;
            this.bairro = bairro;
            this.rua = rua;
            this.numeroCasa = numeroCasa;
            this.cpf = cpf;
            this.numeroConta = numeroConta;
            this.email = email;
            this.senha = senha;
            this.cep = cep;

        }


        // Constructor with email, senha, and id only
        public usuario(string email, string senha, int id)
        {
            this.email = email;
            this.senha = senha;
            this.id = id;
        }

        public usuario()
        {

        }
        public void InserirUsuario(string nome, string pais, string estado, string bairro, string rua, int numeroCasa, string cpf, string numeroConta, string email, string senha, int cep)
        {
            string connectionString = "server=LocalHost;port=3306;database=usuariodb;user=root";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                // Comando SQL para a inserção
                string sql = "INSERT INTO usuario (nome, pais, estado, bairro, rua, numeroCasa, cpf, numeroConta, email, senha, cep) " +
                             "VALUES (@nome, @pais, @estado, @bairro, @rua, @numeroCasa, @cpf, @numeroConta, @email, @senha, @cep )";

                // Parâmetros para o comando SQL
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numeroCasa", numeroCasa);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@numeroConta", numeroConta);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cep", cep);


                try
                {
                    // Abrir a conexão
                    conexao.Open();

                    // Executar o comando SQL para inserir o registro na tabela 'usuario'
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuário inserido com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro foi inserido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }
        private string striconn = @"server =LocalHost; port=3306;database=usuariodb;user=root;";
        MySqlConnection objConnect = null;
        MySqlCommand objectCommannd = null;
        public DataTable verInformacoesDeUmUsuario(int userId)
        {
            string stSQL = "SELECT * FROM usuario WHERE id = @userId";
            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            objectCommannd.Parameters.AddWithValue("@userId", userId);

            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);
                DataTable dtLista = new DataTable();
                objADP.Fill(dtLista);

                return dtLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
                return null;
            }
        }

        public void DeletarInformacoes(int userId)
        {
            string stSQL = "delete from usuario WHERE id = @userId";
            objConnect = new MySqlConnection(striconn);
            objectCommannd = new MySqlCommand(stSQL, objConnect);
            objectCommannd.Parameters.AddWithValue("@userId", userId);

            try
            {
                MySqlDataAdapter objADP = new MySqlDataAdapter(objectCommannd);
                DataTable dtLista = new DataTable();
                objADP.Fill(dtLista);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);

            }
        }

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
                    "email = @email, senha = @senha WHERE cpf = @cpf";

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
                        MessageBox.Show("Perfil atualizado.");
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

    }
}


