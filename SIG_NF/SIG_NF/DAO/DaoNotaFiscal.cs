using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIG_NF.Arquivos;
using SIG_NF.Model;

namespace SIG_NF.DAO
{
    class DaoNotaFiscal
    {

        private static List<NotaFiscal> listaNotaFiscal = new List<NotaFiscal>();
        Arquivo arquivo = new Arquivo();

        public void AddNotaFiscal(NotaFiscal notaFiscal)
        {
            listaNotaFiscal.Add(notaFiscal);
            arquivo.SalvarNotaFiscal(listaNotaFiscal);
            
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
    }
}
