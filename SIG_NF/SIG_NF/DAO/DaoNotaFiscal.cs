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

        Arquivo arquivo = new Arquivo();

        public void AddNotaFiscal(NotaFiscal notaFiscal)
        {
            listaNotaFiscal.Add(notaFiscal);
            arquivo.SalvarNotaFiscal(listaNotaFiscal);
            
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

        public List<NotaFiscal> ListarNotaFiscal()
        {
            return listaNotaFiscal;
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

        public string procurarVendedorCpf(string cpf)
        {
            var pesquisa = listaVendedor.Find(x => x.Cpf == cpf);
            return pesquisa.NomeVendedor;
        }

        public List<NotaFiscal> listarNota()
        {
            return listaNotaFiscal;
        }
    }
}
