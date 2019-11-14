using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SIG_NF.Arquivos;

namespace SIG_NF
{
    static class Program
    {
        public static Arquivo arquivo = new Arquivo();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            arquivo.LerNotaFiscal();
            arquivo.LerVendedor();

            Application.Run(new FormInicial());
        }
    }
}
