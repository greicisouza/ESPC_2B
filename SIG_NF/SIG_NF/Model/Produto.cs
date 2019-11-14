using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_NF.Model
{
    class Produto
    {
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quant { get; set; }
        public double Total { get; set; }
    }
}
