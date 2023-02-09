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
            if (!txtTela.Text.Contains(","))
            {
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
            else
            {
                txtTela.Text += botao.Text;
            }   
               
        }

        private void Operacao(object sender, EventArgs e)
        {
            var botaoOperador = ((Button)sender);
            operador = Convert.ToChar(botaoOperador.Tag);
            num1 = Convert.ToDouble(txtTela.Text);
            if (operador == '√')
            {
                num1 = Math.Sqrt(num1);
                num1 = Math.Round(num1, 2);
                txtTela.Text = num1.ToString();
            }
            else if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                txtTela.Text = num1.ToString();

            }else if(operador == '!')
            {
                int fatorial = Convert.ToInt16(num1);
                for (int i = fatorial - 1; i >= 1; i--)
                {
                    num1 *= i;
                }
                txtTela.Text = num1.ToString();
            }
            else
            {
                txtTela.Text = "0";
            }
        }

        private void Limpar(object sender, EventArgs e)
        {
            var botaoLimpar = ((Button)sender);
            if(botaoLimpar.Text == "C")
                txtTela.Text = "0";
            else if(botaoLimpar.Text == "CE")
            {
                txtTela.Text = "0";
                num1 = 0;
                num2 = 0;
            }
            else
            {
                if (txtTela.Text.Length == 1)
                    txtTela.Text = "0";
                else
                    txtTela.Text = txtTela.Text.Remove(1);
            }

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
            else if (operador == '%')
            {
                txtTela.Text = ((num1/100) * num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtTela.Text.Contains(","))
                txtTela.Text += ",";
        }

    }
}
