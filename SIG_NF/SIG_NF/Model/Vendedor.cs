using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG_NF.Model
{
    class Vendedor
    {
        public string NomeVendedor { get; set; }
        public double Rg { get; set; }
        public double Cpf { get; set; }        
        public string NomeRua { get; set; }
        public int NumCasa { get; set; }
        public double Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; } 

    }
}
