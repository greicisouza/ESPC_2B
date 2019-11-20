using SIG_NF.Controller;
using SIG_NF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_NF.View
{
    public partial class ListarPesquisa : Form
    {
        NotaFiscalController controle = new NotaFiscalController();

        public ListarPesquisa(string item)
        {
            InitializeComponent();


            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderColor = Color.DarkCyan;
            btnVoltar.FlatAppearance.BorderSize = 1;


            if (item == "Vendedor")
            {
                label6.Text = "Lista de Vendedores";
                PreencherVendedor();
            } else
            {
                PreencherCliente();
                label6.Text = "Lista de Clientes";
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            ListarNotaFiscal listar = new ListarNotaFiscal();
            Hide();
            listar.Show();
        }

        private void PreencherVendedor()
        {
            List<Vendedor> lstUsr = controle.listarVendedor();
            var novaListUsuario = lstUsr.Select(vendedor => new
            {
                Vendedor = vendedor.NomeVendedor,
                CPF = vendedor.Cpf,
                Total = vendedor.TotalVendas
            }).ToList();

            lstUsr.OrderByDescending(x => x.TotalVendas).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
        }

        private void PreencherCliente()
        {
            List<Cliente> lstUsr = controle.listarCliente();
            var novaListUsuario = lstUsr.Select(cliente => new
            {
                Nome = cliente.Nome,
                Total = cliente.Total
            }).ToList();

            lstUsr.OrderByDescending(x => x.Total).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
        }
    }
}
