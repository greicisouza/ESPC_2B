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

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DarkCyan;
            button1.FlatAppearance.BorderSize = 1;

            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.FlatAppearance.BorderColor = Color.ForestGreen;
            btnCadastrar.FlatAppearance.BorderSize = 1;

            btnPorVendedor.FlatStyle = FlatStyle.Flat;
            btnPorVendedor.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPorVendedor.FlatAppearance.BorderSize = 1;

            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.FlatAppearance.BorderColor = Color.DarkCyan;
            btnClientes.FlatAppearance.BorderSize = 1;

            Preencher();

            DataGridViewButtonColumn editar = new DataGridViewButtonColumn();

            editar.Name = "Editar";

            editar.FlatStyle = FlatStyle.Flat;

            editar.UseColumnTextForButtonValue = true;

            editar.Text = "Editar";

            int columnIndex1 = 4;

            if (tabela.Columns["Editar"] == null){

                tabela.Columns.Insert(columnIndex1, editar);

            }
        }
      
        public void Preencher()
        {
            var pesquisa = controle.listarRegiao();

            if (pesquisa.Count >= 1) {
                
                label2.Text = "O maior número de vendas ocorre na Região " + pesquisa[0].NomeRegiao + " - Total de Vendas : " + pesquisa[0].Total;
            }

            List<NotaFiscal> lstUsr = controle.listarNota();
            var novaListUsuario = lstUsr.Select(usuario => new
            {
                Numero = usuario.NumNF,                
                Vendedor = controle.procurarVendedorCpf(usuario.VendedorCPF),
                Região = usuario.Regiao,
                Total = usuario.TotalNota
            }).ToList();

            lstUsr.OrderBy(x => x.NumNF).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            tabela.CellClick += tabela_CellClick;
        }
        
        private void tabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabela.Columns["Editar"].Index){

                CadastroNotaFiscal visualizarNota = new CadastroNotaFiscal(Convert.ToInt32(tabela.CurrentRow.Cells[1].Value.ToString()));
                Hide();
                visualizarNota.Show();

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            CadastroNotaFiscal cadastroNF = new CadastroNotaFiscal(0);
            Hide();
            cadastroNF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja encerrar a aplicação?", "Atenção!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void BtnPorVendedor_Click(object sender, EventArgs e)
        {
            ListarPesquisa listaPesquisa = new ListarPesquisa("Vendedor");
            Hide();
            listaPesquisa.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ListarPesquisa listaPesquisa = new ListarPesquisa("Cliente");
            Hide();
            listaPesquisa.Show();
        }
    }
}
