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
        double num1 = 0, num2 = 0, memoria = 0;
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
            lblErro.Visible = false;
            var botaoNumerico = ((Button)sender);

            // Verifica se a tela já contém uma vírgula
            if (!txtTela.Text.Contains(","))
            {
                // Verifica se o usuário está digitando 0 ou não.
                if ((txtTela.Text.Length == 1 && txtTela.Text == "0") && botaoNumerico.Text == "0")
                    txtTela.Text = "0";
                else
                {
                    if((txtTela.Text.Length == 1 && txtTela.Text == "0") && botaoNumerico.Text != "0")
                        txtTela.Text = botaoNumerico.Text;
                    else
                        txtTela.Text += botaoNumerico.Text;
                }
            }

            else if(txtTela.Text == "-")
                txtTela.Text = botaoNumerico.Text;

            // Tem uma vírgula na tela e adiciona um número após vírgula.
            else
            {
                txtTela.Text += botaoNumerico.Text;
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

            }
            else
            {
                txtTela.Text = "0";
            }

        }

        private void Limpar(object sender, EventArgs e)
        {
            var botaoLimpar = ((Button)sender);
            lblErro.Visible = false;
            if (botaoLimpar.Text == "C")
                txtTela.Text = "0";
            else if (botaoLimpar.Text == "CE")
            {
                txtTela.Text = "0";
                num1 = 0;
                num2 = 0;
                operador = '\0';
                memoria = 0;
            }
            else
            {
                if (txtTela.Text.Length == 1)
                    txtTela.Text = "0";
                else
                {
                    string texto = txtTela.Text;
                    int comprimento = texto.Length;
                    int index = texto.LastIndexOf(",");

                    if (index > 0 && Char.IsDigit(texto[index - 1]))
                    {
                        texto = texto.Substring(0, comprimento - 1);
                    }
                    else
                    {
                        texto = texto.Remove(1);
                    }
                    txtTela.Text = texto;
                }

            }

        }

        
        private void Memoria(object sender, EventArgs e)
        {
            var botaoMemoria = ((Button)sender);

            if (botaoMemoria.Text == "MC")
                memoria = 0;

            else if (botaoMemoria.Text == "MR") 
                txtTela.Text = memoria.ToString();

            else if (botaoMemoria.Text == "MS")
                memoria = Convert.ToDouble(txtTela.Text);

            else if (botaoMemoria.Text == "M+")
                memoria += Convert.ToDouble(txtTela.Text);

            else
                memoria -= Convert.ToDouble(txtTela.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtTela.Text);

            if (operador == '+')
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
                if (txtTela.Text != "0")
                {
                    txtTela.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txtTela.Text);
                }
                else
                    lblErro.Visible = true;
            }
            else if (operador == '%')
            {
                txtTela.Text = ((num1/100) * num2).ToString();
                num1 = Convert.ToDouble(txtTela.Text);
            }
        }

        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtTela.Text);
            num1 *= -1;
            txtTela.Text = num1.ToString();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtTela.Text.Contains(","))
                txtTela.Text += ",";
        }

    }
}
