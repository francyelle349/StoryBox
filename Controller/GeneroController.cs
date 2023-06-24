using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class GeneroController
    {
        FuncoesGenero funcoes = new FuncoesGenero();

        public void ColocarGeneroNoBanco(string genero)
        {
            funcoes.AdicionarGeneroNoBanco(genero);
        }


        public DataTable mostrarGeneros()
        {
            return funcoes.listaGrid();
        }

        public void conectarGeneroaocadastro(ListBox lista)
        {
            DataTable dataTable = new DataTable();
           dataTable = funcoes.listaGridSomenteGenero();


            // consegui retirar as informacoes em formato string do datatable
            string row1 = "";
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                {
                   row1 = row[col].ToString();
                   lista.Items.Insert(i, row1);
                    i++;
                }
                
            }

            

        }

        public void removerGenero(DataGridView data)
        {
            FuncoesGenero funcoesGenero = new FuncoesGenero();

            funcoesGenero.removerGenero(data);
        }
        

      

    }
}
