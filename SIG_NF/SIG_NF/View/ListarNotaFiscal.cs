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
    public partial class ListarNotaFiscal : Form
    {
        NotaFiscalController controle = new NotaFiscalController();

        public ListarNotaFiscal()
        {
            InitializeComponent();
            Preencher();
        }

        public void Preencher()
        {
            List<NotaFiscal> lstUsr = controle.listarNota();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Numero = usuario.NumNF,
                Vendedor = controle.procurarVendedorCpf(usuario.VendedorCPF),
                Região = usuario.Regiao,
                Total = usuario.TotalNota
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }

        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroNotaFiscal cadastroVendedor = new CadastroNotaFiscal();
            Hide();
            cadastroVendedor.Show();
        }
    }
}
