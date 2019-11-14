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
                MessageBox.Show("Login efetuado com sucesso!", "Login Efetuada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CadastroNotaFiscal cadastroNotaFiscal = new CadastroNotaFiscal();
                Hide();
                cadastroNotaFiscal.Show();
            } else
            {
                MessageBox.Show("Login não efetuado!", "Login não efetuado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarNotaFiscal cadastroVendedor = new ListarNotaFiscal();
            Hide();
            cadastroVendedor.Show();
        }
    }
}
