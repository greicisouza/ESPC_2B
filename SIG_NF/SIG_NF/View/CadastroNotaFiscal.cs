using SIG_NF.Controller;
using SIG_NF.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_NF.View
{
    public partial class CadastroNotaFiscal : Form
    {
        public int numNotaFiscal = 0;
        public int numero = 0;
        NotaFiscalController controle = new NotaFiscalController();

        private static List<Cliente> listaCliente = new List<Cliente>();
        private static List<Produto> listaProdutos = new List<Produto>();

        public double Total = 0;
        
        public CadastroNotaFiscal()
        {
            InitializeComponent();

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DarkCyan;
            button1.FlatAppearance.BorderSize = 1;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.ForestGreen;
            button2.FlatAppearance.BorderSize = 1;

            btn_Entrar.FlatStyle = FlatStyle.Flat;
            btn_Entrar.FlatAppearance.BorderColor = Color.DarkCyan;
            btn_Entrar.FlatAppearance.BorderSize = 1;

            Preencher();
            Random numRandNotaFiscal = new Random();
            numNotaFiscal = numRandNotaFiscal.Next(1000000000, 1999999999);
            txtNF.Value = numNotaFiscal;
            txtNF.Enabled = false;
        }

        public void Preencher()
        {
            var listaVendedor = controle.listarVendedor();
            foreach (Vendedor vendedor in listaVendedor)
            {
                txtVendedor.Items.Add(vendedor.NomeVendedor);
            }
        }        
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Produto produtinho = new Produto();
      
            produtinho.Numero = numero;
            produtinho.Nome = txtNomeProduto.Text;
            produtinho.PrecoUnitario = Convert.ToDouble(txtPreco.Value);
            produtinho.PrecoUnitario.ToString("F2", CultureInfo.InvariantCulture);
            produtinho.Quant = Convert.ToInt32(txtQuant.Value);
            produtinho.Total = Convert.ToDouble(txtPreco.Value) * Convert.ToInt32(txtQuant.Value);

            Total += Convert.ToDouble(txtPreco.Value) * Convert.ToInt32(txtQuant.Value);
       
            listaProdutos.Add(produtinho);

            txtNomeProduto.Text = "";
            txtPreco.Value = 0;
            txtQuant.Value = 0;
            listar();
            numero++;
        }
       
        public void listar()
        {
            
            var novaListUsuario = listaProdutos.Select(nota => new
            {
                Item = nota.Numero,
                Descrição = nota.Nome,
                Qtd = nota.Quant,
                ValorUnitário = nota.PrecoUnitario,
                ValorItem = nota.Total
            }).ToList();

            tabela.DataSource = novaListUsuario;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;

            txtTotal.Value = Convert.ToDecimal(Total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            Cliente clientinho = new Cliente();
            Regiao regiao = new Regiao();

            var pesquisa = controle.procurarVendedorNome(txtVendedor.Text);

            notaFiscal.NomeCliente = txtCliente.Text;
            notaFiscal.VendedorCPF = pesquisa.Cpf;
            notaFiscal.NumNF = Convert.ToInt32(txtNF.Value);
            notaFiscal.Regiao = txtRegiao.Text;
            notaFiscal.listaProdutos = listaProdutos;
            notaFiscal.TotalNota = Total;

            double auxiliar = pesquisa.TotalVendas;
            pesquisa.TotalVendas = auxiliar + Total;

            var pesquisa1 = controle.procurarCliente(txtCliente.Text);

            if (pesquisa1 == null)
            {
                clientinho.Nome = txtCliente.Text;
                clientinho.Total = Total;

                controle.cadastrarCliente(clientinho);
            } else {
                double auxiliar1 = pesquisa1.Total + Total;
                pesquisa1.Total = auxiliar1;

                controle.excluirCliente(pesquisa1.Nome);
                controle.cadastrarCliente(pesquisa1);
            }

            var pesquisa2 = controle.procurarRegiao(txtRegiao.Text);


            if (pesquisa2 == null)
            {
                regiao.NomeRegiao = txtRegiao.Text;
                regiao.Total = Total;

                controle.cadastrarRegiao(regiao);
            }
            else
            {
                double auxiliar2 = pesquisa2.Total + Total;
                pesquisa2.Total = auxiliar2;

                controle.excluirRegiao(pesquisa2.NomeRegiao);
                controle.cadastrarRegiao(pesquisa2);
            }

            controle.excluirVendedor(pesquisa.Cpf);
            controle.cadastrarVendedor(pesquisa);

            controle.AddNotaFiscal(notaFiscal);
            MessageBox.Show("Nota Fiscal Gerada!", "Nota Fiscal Gerada!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listaProdutos.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            ListarNotaFiscal listarNotaFiscal = new ListarNotaFiscal();
            Hide();
            listarNotaFiscal.Show();
        }
    }
}
