using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SIG_NF.Model
{
    class NotaFiscal
    {
      
        public string NomeCliente { get; set; }
        public int NumNF { get; set; }        
        public string Regiao { get; set; }
       
        public string VendedorCPF { get; set; }

        public List<Produto> listaProdutos { get; set; }

        public double TotalNota { get; set; }

    }
}
