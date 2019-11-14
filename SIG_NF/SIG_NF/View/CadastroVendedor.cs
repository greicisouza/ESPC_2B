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
    public partial class CadastroVendedor : Form
    {

        NotaFiscalController controle = new NotaFiscalController();

        public CadastroVendedor()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();

            vendedor.NomeVendedor = txtNome.Text;
            vendedor.Rg = Convert.ToDouble(txtRg.Value);
            vendedor.Cpf = txtCpf.Text;
            vendedor.Email = txtEmail.Text;
            vendedor.Senha = txtSenha.Text;
            vendedor.Numero = Convert.ToInt32(txtNumero.Value);
            vendedor.Cep = txtCep.Text;
            vendedor.Rua = txtRua.Text;
            vendedor.Bairro = txtBairro.Text;
            vendedor.Cidade = txtCidade.Text;
            vendedor.Estado = txtEstado.Text;

            controle.cadastrarVendedor(vendedor);

            MessageBox.Show("Cadastro Efetuado! Realize o login..","Cadastro Efetuado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInicial login = new FormInicial();
            Hide();
            login.Show();

        }
    }
}
