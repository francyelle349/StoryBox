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
    public class ControllerCliente
    {
        ClientePerfil clientePerfil = new ClientePerfil();
        Livro livro = new Livro();
        public void MostrarDataTable(DataGridView dataGridView)
        {


            dataGridView.DataSource = clientePerfil.mostrarLivros();
        }
        public void adicionarTabela(int id, String isnb, int estoque)
        {

            clientePerfil.adicionarNaTabela(id, isnb, estoque);
        }
        public DataTable mostrarLivrosCarrinho(int id)
        {

            return clientePerfil.listaDeLivrosCarrinho(id);
        }
        public decimal somaEstoque(int id)
        {

            return ClientePerfil.SomaPrecoPorUsuario(id);
        }

        public void SubtrairLivrosNaCompra(int usuarioid, String isnb)
        {
            ClientePerfil.SubtractFromEstoqueAndRemove(usuarioid, isnb);
        }
        public void cadastrarCliente(string nome, string pais, string estado, string bairro, string rua, int numeroCasa, string cpf, string numeroConta, string email, string senha, int cep)
        {
            usuario usuario = new usuario();
            usuario.InserirUsuario(nome, pais, estado, bairro, rua, numeroCasa, cpf, numeroConta, email, senha, cep);

        }

        public DataTable pesquisarPorGenero(string genre)
        {

            return livro.listaDeLivrosGenero(genre);
        }
        public DataTable pesquisarTitulo(string genre)
        {

            return livro.listaDeLivrosPesquisa(genre);
        }

        public DataTable mostrarInformacoesUsuario(int userId)
        {
            usuario usuario = new usuario();

           return usuario.verInformacoesDeUmUsuario(userId);

        }

        public void deletarInformacoes(int userId)
        {
            usuario usuario = new usuario();

            usuario.DeletarInformacoes(userId);

        }

    }

    

}