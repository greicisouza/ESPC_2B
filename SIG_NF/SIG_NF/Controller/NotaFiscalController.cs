using SIG_NF.DAO;
using SIG_NF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_NF.Controller
{
    class NotaFiscalController
    {
        public DaoNotaFiscal daoNotaFiscal = new DaoNotaFiscal();

        public void cadastrarVendedor(Vendedor vendedor)
        {
            daoNotaFiscal.AddVendedor(vendedor);
        }

        public void cadastrarCliente(Cliente cliente)
        {
            daoNotaFiscal.AddCliente(cliente);
        }

        public void cadastrarRegiao(Regiao regiao)
        {
            daoNotaFiscal.AddRegiao(regiao);
        }

        public void excluirVendedor(string vendedor)
        {
            daoNotaFiscal.ExcluirVendedor(vendedor);
        }

        public void excluirCliente(string cliente)
        {
            daoNotaFiscal.ExcluirCliente(cliente);
        }

        public void excluirRegiao(string regiao)
        {
            daoNotaFiscal.ExcluirRegiao(regiao);
        }

        public bool procurarVendedor(string email, string senha)
        {
            return daoNotaFiscal.procurarVendedor(email, senha);
        }

        public Regiao procurarRegiao(string regiao)
        {
            return daoNotaFiscal.procurarRegiao(regiao);
        }

        public List<Vendedor> listarVendedor()
        {
            return daoNotaFiscal.listarVendedor();
        }

        public List<Cliente> listarCliente()
        {
            return daoNotaFiscal.ListarCliente();
        }

        public List<Regiao> listarRegiao()
        {
            return daoNotaFiscal.ListarRegiao();
        }

        public Vendedor procurarVendedorNome(string nomeVendedor)
        {
            return daoNotaFiscal.procurarVendedorNome(nomeVendedor);
        }

        public string procurarVendedorCpf(string cpf)
        {
            return daoNotaFiscal.procurarVendedorCpf(cpf);
        }

        public void AddNotaFiscal(NotaFiscal notaFiscal)
        {
            daoNotaFiscal.AddNotaFiscal(notaFiscal);
        }

        public void AddRegiao(Regiao regiao)
        {
            daoNotaFiscal.AddRegiao(regiao);
        }

        public List<NotaFiscal> listarNota()
        {
            return daoNotaFiscal.listarNota();
        }

        public Cliente procurarCliente(string nomeCliente)
        {
            return daoNotaFiscal.procurarCliente(nomeCliente);
        }
    }
}
