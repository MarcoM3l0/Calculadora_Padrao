using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Padrão
{
    public partial class frmPrincipal : Form
    {
        // Variáveis de nivel global
        double num1 = 0, num2 = 0;
        char operador;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void NumeroAgregado(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            if ((txtTela.Text.Length == 0 || (txtTela.Text.Length == 1 && txtTela.Text == "0")) && botao.Text == "0")
                txtTela.Text = "0";
            else
            {
                if((txtTela.Text.Length == 1 && txtTela.Text == "0") && botao.Text != "0")
                    txtTela.Text = botao.Text;
                else
                    txtTela.Text += botao.Text;
            }
               
        }

        private void Operacao(object sender, EventArgs e)
        {
            var botaoOperador = ((Button)sender);
            num1 = Convert.ToDouble(txtTela.Text);
            operador = Convert.ToChar(botaoOperador.Text);
            txtTela.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtTela.Text);
            if(operador == '+')
            {
                txtTela.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '-')
            {
                txtTela.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '*')
            {
                txtTela.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '/')
            {
                txtTela.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtTela.Text = "";
            num1 = 0;
            num2 = 0;
        }

    }
}
