using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class ValidarLogin
    {
        public void validarLogin(string user, string senha, Form form, Form form1)
        {
            if(user == "francyelle5849@gmail.com" && senha == "123")
            {
                form1.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("user ou senha errada, tente novamente!");
            }
        }
        public void validarLoginCliente(string email, string senha, Form form, Form form1)
        {
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;port=3306;database=usuariodb;user=root;");
            string sql = "SELECT email, senha, id FROM usuario";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            conexao.Open();
            List<usuario> listaUsuarios = new List<usuario>();

            try
            {
                MySqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string username = myReader.GetString("email");
                    string senhaUser = myReader.GetString("senha");
                    int id = myReader.GetInt32("id");
                    usuario usuario = new usuario(username, senhaUser, id);
                    listaUsuarios.Add(usuario);
                }

                myReader.Close();
            }
            finally
            {
                conexao.Close();
            }

            bool loginValidated = false;
            int idPerson = 0;
            foreach (usuario usuario in listaUsuarios)
            {
                if (email == usuario.GetEmail() && senha == usuario.GetSenha())
                {
                    idPerson = usuario.GetId();
                    EstaticoConectarIdUserCarrinho.Lista(idPerson);

                    
                    loginValidated = true;
                    break;
                }
            }

            if (loginValidated)
            {
                form1.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente!");
            }
        }

    }
}
