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
        NotaFiscalController controle = new NotaFiscalController();
        

        private static List<Produto> listaProdutos = new List<Produto>();

        public double Total = 0;
        
        public CadastroNotaFiscal()
        {
            InitializeComponent();
            Preencher();
            Random numRandNotaFiscal = new Random();
            numNotaFiscal = numRandNotaFiscal.Next(1000000000, 1999999999);
            txtNF.Value = numNotaFiscal;

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

            produtinho.Nome = txtNomeProduto.Text;
            produtinho.PrecoUnitario = Convert.ToDouble(txtPreco.Value);
            produtinho.PrecoUnitario.ToString("F2", CultureInfo.InvariantCulture);
            produtinho.Quant = Convert.ToInt32(txtQuant.Value);
            produtinho.Total = Convert.ToDouble(txtPreco.Value) * Convert.ToInt32(txtQuant.Value);
            produtinho.Total.ToString("F2", CultureInfo.InvariantCulture);


            Total += Convert.ToDouble(txtPreco.Value) * Convert.ToInt32(txtQuant.Value);
            Total.ToString("F2", CultureInfo.InvariantCulture);
            
            listaProdutos.Add(produtinho);

            txtNomeProduto.Text = "";
            txtPreco.Value = 0;
            txtQuant.Value = 0;
            listar();
            
        }
        //mudar a richTB por uma datagridview
        public void listar()
        {
            richTextBox1.Clear();
            foreach (var produto in listaProdutos)
            {
                richTextBox1.AppendText("Nome: " + produto.Nome + "\n");
                richTextBox1.AppendText("Preço Unitário: " + produto.PrecoUnitario + "\n");
                richTextBox1.AppendText("Quantidade: " + produto.Quant + "\n");
                richTextBox1.AppendText("Preço Total: " + produto.Total + "\n\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotaFiscal notaFiscal = new NotaFiscal();

            var pesquisa = controle.procurarVendedorNome(txtVendedor.Text);

            notaFiscal.NomeCliente = txtCliente.Text;
            notaFiscal.VendedorCPF = pesquisa.Cpf;
            notaFiscal.NumNF = Convert.ToInt32(txtNF.Value);
            notaFiscal.Regiao = txtRegiao.Text;
            notaFiscal.listaProdutos = listaProdutos;
            notaFiscal.TotalNota = Total;

            controle.AddNotaFiscal(notaFiscal);
            MessageBox.Show("Nota Fiscal Gerada!", "Nota Fiscal Gerada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            ListarNotaFiscal listarNotaFiscal = new ListarNotaFiscal();
            Hide();
            listarNotaFiscal.Show();
        }
    }
}
