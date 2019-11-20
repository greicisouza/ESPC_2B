using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIG_NF.Arquivos;
using SIG_NF.Model;
using SIG_NF.View;

namespace SIG_NF.DAO
{
    class DaoNotaFiscal
    {

        private static List<NotaFiscal> listaNotaFiscal = new List<NotaFiscal>();
        private static List<Vendedor> listaVendedor = new List<Vendedor>();
        private static List<Cliente> listaCliente = new List<Cliente>();
        private static List<Regiao> listaRegiao = new List<Regiao>();

        Arquivo arquivo = new Arquivo();

        public void AddNotaFiscal(NotaFiscal notaFiscal)
        {
            listaNotaFiscal.Add(notaFiscal);
            arquivo.SalvarNotaFiscal(listaNotaFiscal);
            
        }

        public void AddCliente(Cliente cliente)
        {
            listaCliente.Add(cliente);
            arquivo.SalvarCliente(listaCliente);

        }

        public void AddRegiao(Regiao regiao)
        {
            listaRegiao.Add(regiao);
            arquivo.SalvarRegiao(listaRegiao);

        }

        public void ExcluirVendedor(string vendedor)
        {
            listaVendedor.RemoveAll(x => x.Cpf == vendedor);
            arquivo.SalvarVendedor(listaVendedor);
        }

        public void ExcluirCliente(string cliente)
        {
            listaCliente.RemoveAll(x => x.Nome == cliente);
            arquivo.SalvarCliente(listaCliente);
        }

        public void ExcluirRegiao(string regiao)
        {
            listaRegiao.RemoveAll(x => x.NomeRegiao == regiao);
            arquivo.SalvarRegiao(listaRegiao);
        }

        public  bool procurarVendedor(string email,string senha)
        {
            var pesquisa = listaVendedor.Find(x => x.Email == email);

            if (pesquisa != null)
            {
                if (pesquisa.Senha == senha)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void AddNotaFiscalLer(List<NotaFiscal> notaFiscal)
        {
            listaNotaFiscal = notaFiscal;
            arquivo.SalvarNotaFiscal(listaNotaFiscal);
        }

        public void AddClienteLer(List<Cliente> cliente)
        {
            listaCliente = cliente;
            arquivo.SalvarCliente(listaCliente);
        }

        public void AddRegiaoLer(List<Regiao> regiao)
        {
            listaRegiao = regiao;
            arquivo.SalvarRegiao(listaRegiao);
        }

        public List<NotaFiscal> ListarNotaFiscal()
        {
            return listaNotaFiscal;
        }

        public List<Cliente> ListarCliente()
        {
            return listaCliente;
        }

        public List<Regiao> ListarRegiao()
        {
            return listaRegiao.OrderByDescending(x => x.Total).ToList();
        }

        public void AddVendedor(Vendedor vendedor)
        {
            listaVendedor.Add(vendedor);
            arquivo.SalvarVendedor(listaVendedor);

        }

        public void AddVendedorLer(List<Vendedor> vendedor)
        {
            listaVendedor = vendedor;
            arquivo.SalvarVendedor(listaVendedor);
        }

        public List<Vendedor> listarVendedor()
        {
            return listaVendedor;
        }

        public Vendedor procurarVendedorNome(string nomeVendedor)
        {
            return listaVendedor.Find(x => x.NomeVendedor == nomeVendedor);
        }

        public Cliente procurarCliente(string nomeCliente)
        {
            return listaCliente.Find(x => x.Nome == nomeCliente);
        }

        public string procurarVendedorCpf(string cpf)
        {
            var pesquisa = listaVendedor.Find(x => x.Cpf == cpf);
            return pesquisa.NomeVendedor;
        }

        public Regiao procurarRegiao(string regiao)
        {
            return listaRegiao.Find(x => x.NomeRegiao == regiao);
        }

        public List<NotaFiscal> listarNota()
        {
            return listaNotaFiscal;
        }

    }
}
