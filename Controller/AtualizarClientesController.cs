using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AtualizarClientesController
    {
        public void atualizarClientesController(String nome, String pais, String estado,
        String bairro, String rua, int numeroCasa, int cep, String cpf, String numeroConta,
        String email, String senha) {
         

            EditarClientesFuncionarios editarClientesFuncionarios = new EditarClientesFuncionarios();

            editarClientesFuncionarios.EditarLivro( nome, pais, estado,
         bairro, rua,  numeroCasa,  cep, cpf, numeroConta,
        email, senha);


        }
    }
}
