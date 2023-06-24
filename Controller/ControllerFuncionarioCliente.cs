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
    public class ControllerFuncionarioCliente
    {
        public void controllerCadastrarCliente(String nome, String pais, String estado,
        String bairro, String rua, int numeroCasa, int cep, String cpf, String numeroConta,
        String email, String senha)
        {
            cadastrarCliente cadastrarCliente = new cadastrarCliente(nome,pais, estado,
        bairro, rua,  numeroCasa,  cep,  cpf, numeroConta,
        email, senha);

        }

        public DataTable ControllerMostrarCliente()
        {
            mostrarCliente mostrarCliente = new mostrarCliente();

            var clientes = mostrarCliente.listaGrid();

            return clientes;
        }

        public void ApagarCliente(DataGridView dataGrid)
        {
            ApagarClienteFuncionario apagarClienteFuncionario = new ApagarClienteFuncionario();

            apagarClienteFuncionario.apagarCliente(dataGrid);
        }

        public void editarCliente(String nome, String pais, String estado,
        String bairro, String rua, int numeroCasa, int cep, String cpf, String numeroConta,
        String email, String senha)

        {
            usuario usuario = new usuario();

            usuario.EditarLivro(nome, pais, estado,
        bairro, rua, numeroCasa, cep, cpf, numeroConta,
        email, senha);



        }
    }
}
