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
        public string NomeProduto { get; set; }
        public int QtdProduto { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }

    }
}
