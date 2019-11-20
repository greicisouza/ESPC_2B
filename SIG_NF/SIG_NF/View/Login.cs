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

            btn_Entrar.FlatStyle = FlatStyle.Flat;
            btn_Entrar.FlatAppearance.BorderColor = Color.DarkCyan;
            btn_Entrar.FlatAppearance.BorderSize = 1;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.DarkCyan;
            button1.FlatAppearance.BorderSize = 1;
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if (controle.procurarVendedor(txtEmail.Text, txtSenha.Text) == true)
            {              
                ListarNotaFiscal cadastroNotaFiscal = new ListarNotaFiscal();
                Hide();
                cadastroNotaFiscal.Show();
            } else
            {
                MessageBox.Show("Login não efetuado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroVendedor cadastroVendedor = new CadastroVendedor();
            Hide();
            cadastroVendedor.Show();
        }
    }
}
