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

        public bool procurarVendedor(string email, string senha)
        {
            return daoNotaFiscal.procurarVendedor(email, senha);
        } 

        public List<Vendedor> listarVendedor()
        {
            return daoNotaFiscal.listarVendedor();
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

        public List<NotaFiscal> listarNota()
        {
            return daoNotaFiscal.listarNota();
        }
    }
}
