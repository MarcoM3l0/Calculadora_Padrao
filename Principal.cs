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

        private void NumeroAgregadoTeclado(object sender, EventArgs e)
        {
            string caracteresPermitidos = "0123456789,+-*/";
            string texto = txtTela.Text;

            // Obtém o caractere digitado pelo usuário
            char caractere = ((KeyPressEventArgs)e).KeyChar;

            // Verifica se o caractere digitado é permitido
            if (caracteresPermitidos.Contains(caractere))
            {
                // Verifica se o texto já contém uma vírgula
                if (!texto.Contains(",") || caractere == ',')
                {
                    // Verifica se o texto não começa com zero
                    if (texto.Length == 1 && texto[0] == '0' && caractere != ',')
                    {
                        txtTela.Text = caractere.ToString();
                    }
                    else
                    {
                        txtTela.Text += caractere;
                    }
                }
            }

            //string caracteresPermitidos = ",Xx*-+/0123456789";
            //string caracteresNaoPermitidos = "Xx*/+-";
            //string texto = txtTela.Text;
            //string novoTexto = "";

            //foreach (char c in texto)
            //{
            //    if (caracteresPermitidos.Contains(c))
            //    {
            //        novoTexto += c;

            //        if (!novoTexto.Contains(","))
            //        {
            //            txtTela.Text += ",";
            //            novoTexto = "";
            //        }

            //        if (!caracteresNaoPermitidos.Contains(novoTexto))
            //        {
            //            if (!novoTexto.Contains(","))
            //            {
            //                if ((txtTela.Text.Length == 1 && txtTela.Text == "0") && novoTexto == "0")
            //                {
            //                    txtTela.Text = "0";
            //                    novoTexto = "";
            //                }

            //                else
            //                {
            //                    if ((txtTela.Text.Length == 1 && txtTela.Text == "0") && novoTexto != "0")
            //                    {
            //                        txtTela.Text = novoTexto;
            //                        novoTexto = "";
            //                    }
            //                    else
            //                    {
            //                        txtTela.Text += novoTexto;
            //                        novoTexto = "";
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                txtTela.Text += novoTexto;
            //                novoTexto = "";
            //            }
            //        }
            //    }
            //}

        }

        private void NumeroAgregado(object sender, EventArgs e)
        {

            lblErro.Visible = false;
            var botaoNumerico = ((Button)sender);

            // Verifica se a tela já contém uma vírgula
            if (!txtTela.Text.Contains(","))
            {
                // Verifica se o usuário está digitando 0 ou não.
                // Se o usuário ficar apertando 0 ele não irá adicionar, só terá um 0 na tela.
                if ((txtTela.Text.Length == 1 && txtTela.Text == "0") && botaoNumerico.Text == "0")
                    txtTela.Text = "0";

                // Não apertou 0 para ser o primeiro dígito do número, irá adicionar os número normalmente.
                else
                {
                    if((txtTela.Text.Length == 1 && txtTela.Text == "0") && botaoNumerico.Text != "0")
                        txtTela.Text = botaoNumerico.Text;
                    else
                        txtTela.Text += botaoNumerico.Text;
                }
            }

            // Tem uma vírgula na tela e adiciona um número após vírgula.
            else
                txtTela.Text += botaoNumerico.Text;
               
        }

        // Verifica qual operação matemática o usuário vai fazer.
        private void Operacao(object sender, EventArgs e)
        {
            var botaoOperador = ((Button)sender);
            operador = Convert.ToChar(botaoOperador.Tag);
            num1 = Convert.ToDouble(txtTela.Text);

            // Esses operadores já dará o resultado sem a necessidade de clicar no botão igual.
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
                txtTela.Text = "0";

        }

        // Esse método faz a limpeza, dos números da tela, de tudo incluindo o que tiver na memória ou de um em um caractere.
        private void Limpar(object sender, EventArgs e)
        {
            var botaoLimpar = ((Button)sender);
            lblErro.Visible = false;

            // Apaga somente o número que está na tela. Botão: C.
            if (botaoLimpar.Text == "C")
                txtTela.Text = "0";

            // Apaga tudo. Botão: CE.
            else if (botaoLimpar.Text == "CE")
            {
                txtTela.Text = "0";
                num1 = 0;
                num2 = 0;
                operador = '\0';
                memoria = 0;
            }

            // Apaga o último caractere do número que está na tela. Botão: ←.
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
                        texto = texto.Substring(0, comprimento - 1);
                    else
                        texto = texto.Remove(1);

                    txtTela.Text = texto;
                }
            }
        }

        // Botões de memória: MC, MR, MS, M+ e M-.
        private void Memoria(object sender, EventArgs e)
        {
            var botaoMemoria = ((Button)sender);

            // Apaga todos os números salvos na memória. Botão: MC.
            if (botaoMemoria.Text == "MC")
                memoria = 0;

            // Recupera o último número salvo na memória. Botão: MR.
            else if (botaoMemoria.Text == "MR") 
                txtTela.Text = memoria.ToString();

            // Salva um novo número na memória. Botão: MS.
            else if (botaoMemoria.Text == "MS")
                memoria = Convert.ToDouble(txtTela.Text);

            // Soma o número que está na tela com o último número salvo. Botão: M+.
            else if (botaoMemoria.Text == "M+")
                memoria += Convert.ToDouble(txtTela.Text);

            // Subtrai o número que está na tela com o último número salvo. Botão: M-.
            else
                memoria -= Convert.ToDouble(txtTela.Text);
        }

        // Faz os cálculos matemáticos solicitados ao clicar no botão igual.
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Número digitado após a escolha da operação matemática.
            num2 = Convert.ToDouble(txtTela.Text);

            // Calcula de acordo com a operação.
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
                // Verifica se o cálculo da divisão pode ser feito ou não.
                // Se não, vai habilitar uma mensagem de erro na tela.
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

        // Inverter o número de positivo para negativo ou vice-versa.
        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtTela.Text);
            num1 *= -1;
            txtTela.Text = num1.ToString();
        }

        // Colocar vírgula no número ao clicar no botão da vírgula.
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtTela.Text.Contains(","))
                txtTela.Text += ",";
        }
    }
}
