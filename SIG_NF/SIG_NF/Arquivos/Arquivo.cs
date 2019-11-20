using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIG_NF.Model;
using SIG_NF.DAO;
using Newtonsoft.Json;
using System.IO;

namespace SIG_NF.Arquivos
{
    class Arquivo
    {
        public void SalvarNotaFiscal(List<NotaFiscal> listaNotaFiscal)
        {
            string json = JsonConvert.SerializeObject(listaNotaFiscal.ToArray());

            File.WriteAllText(@".\listaNotas.txt", json);
        }

        public void LerNotaFiscal()
        {
            DaoNotaFiscal daoNotaFiscal = new DaoNotaFiscal();
            string jsonFilePath = @".\listaNotas.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                NotaFiscal[] listaNotaFiscal = JsonConvert.DeserializeObject<NotaFiscal[]>(json);

                daoNotaFiscal.AddNotaFiscalLer(listaNotaFiscal.ToList());

            }
        }

        public void SalvarVendedor(List<Vendedor> listaVendedor)
        {
            string json = JsonConvert.SerializeObject(listaVendedor.ToArray());

            File.WriteAllText(@".\listaVendedor.txt", json);
        }

        public void LerVendedor()
        {
            DaoNotaFiscal daoNotaFiscal = new DaoNotaFiscal();
            string jsonFilePath = @".\listaVendedor.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Vendedor[] listaVendedor = JsonConvert.DeserializeObject<Vendedor[]>(json);

                daoNotaFiscal.AddVendedorLer(listaVendedor.ToList());

            }
        }

        public void SalvarCliente(List<Cliente> listaCliente)
        {
            string json = JsonConvert.SerializeObject(listaCliente.ToArray());

            File.WriteAllText(@".\listaCliente.txt", json);
        }

        public void LerCliente()
        {
            DaoNotaFiscal daoNotaFiscal = new DaoNotaFiscal();
            string jsonFilePath = @".\listaCliente.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Cliente[] listaCliente = JsonConvert.DeserializeObject<Cliente[]>(json);

                daoNotaFiscal.AddClienteLer(listaCliente.ToList());

            }
        }

        public void SalvarRegiao(List<Regiao> listaRegiao)
        {
            string json = JsonConvert.SerializeObject(listaRegiao.ToArray());

            File.WriteAllText(@".\listaRegiao.txt", json);
        }

        public void LerRegiao()
        {
            DaoNotaFiscal daoNotaFiscal = new DaoNotaFiscal();
            string jsonFilePath = @".\listaRegiao.txt";

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);

                Regiao[] listaRegiao = JsonConvert.DeserializeObject<Regiao[]>(json);

                daoNotaFiscal.AddRegiaoLer(listaRegiao.ToList());

            }
        }

    }
}
