using SIG_NF.Controller;
using SIG_NF.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIG_NF
{
    public partial class FormInicial : Form
    {
        NotaFiscalController controle = new NotaFiscalController();

        public FormInicial()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (controle.procurarVendedor(txtEmail.Text, txtSenha.Text) == true)
            {              
                CadastroNotaFiscal cadastroNotaFiscal = new CadastroNotaFiscal();
                Hide();
                cadastroNotaFiscal.Show();
            } else
            {
                MessageBox.Show("Login não efetuado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroVendedor cadastroVendedor = new CadastroVendedor();
            Hide();
            cadastroVendedor.Show();
        }
    }
}
