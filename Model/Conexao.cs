using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   // conectar 
        public class Conexao
        {
            public static MySqlConnection conexao = new MySqlConnection(@"server=LocalHost;port=3306;database=livros;user=root;");

            public static MySqlConnection Conectar()
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
                return conexao;
            }

            public static void Desconectar()
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }

