using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Model
{
    public class cadastrarCliente
    {
        MySqlConnection conexao = new MySqlConnection(@"server=LocalHost;port=3306;database=usuariodb;user=root;");
        MySqlCommand cmd = new MySqlCommand();
        public string mensagem;
        
        public cadastrarCliente(String nome, String pais, String estado,
        String bairro, String rua, int numeroCasa, int cep, String cpf, String numeroConta,
        String email, String senha)
        {
            bool Validacao = true;

            // Verificar se o e-mail e o CPF são únicos
            if (!ValidarEmailCPFUnicos(email, cpf))
            {
                Validacao = false;
                MessageBox.Show("Erro, e-mail ou CPF já existem no banco de dados.");
            }

            
            if (Validacao)
            {
                // Comando SQL
                cmd.CommandText = "INSERT INTO usuario (nome,  pais, estado, bairro, rua, numeroCasa, cpf, numeroConta, email, senha, cep)" +
                    " VALUES (@nome, @pais, @estado, @bairro, @rua, @numeroCasa, @cpf, @numeroConta, @email, @senha, @cep)";

                // Parâmetros
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numeroCasa", numeroCasa);
               
                cmd.Parameters.AddWithValue("@numeroConta", numeroConta);
                
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@cep", cep);




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
        public bool ValidarEmailCPFUnicos(string email, string cpf)
        {
            // Comando SQL para verificar se o e-mail ou o CPF já existem no banco de dados
            cmd.CommandText = "SELECT COUNT(*) FROM usuario WHERE email = @email OR cpf = @cpf";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cpf", cpf);

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
    }

}
