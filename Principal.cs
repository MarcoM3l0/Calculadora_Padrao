using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Padrão
{
    public partial class frmPrincipal : Form
    {
        // Variáveis de nivel global
        private double primeiroNumero = 0, segundoNumero = 0, memoria = 0;
        private char operador;
        private int posicaoCursor;
        private string caracteresNumericoEVirgula = ",0123456789";
        private string caracteresOperadores = "Xx*-+/";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            txtTela.Text = "0";
            txtTela.SelectionStart = txtTela.Text.Length;
            txtTela.ScrollToCaret();
        }

        private void TeclaPressionada(object sender, KeyPressEventArgs e)
        {

            char caractere = e.KeyChar;
            if (caractere == '=' || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnIgual_Click(this, new EventArgs());
            }

            if (caracteresOperadores.Contains(caractere))
            {
                e.Handled = true;
                string mult = "Xx*";
                if (mult.Contains(caractere))
                    OperacaoTeclado('*');
                else if (caractere == '-')
                    OperacaoTeclado('-');
                else if (caractere == '+')
                    OperacaoTeclado('+');
                else if (caractere == '/')
                    OperacaoTeclado('/');

                txtTela.SelectionStart = txtTela.Text.Length;
            }

            if(e.KeyChar == '\b' && txtTela.Text.Length == 1)
            {
                e.Handled = true;
                txtTela.Text = "0";
                txtTela.SelectionStart = txtTela.TextLength;
                txtTela.ScrollToCaret();
            }

            if (caractere == ',' && txtTela.Text.Contains(","))
            {
                e.Handled = true;
            }

            if (caracteresNumericoEVirgula.Contains(caractere))
            {
                if (!txtTela.Text.Contains(","))
                {
                    if (txtTela.Text.Length == 1 && txtTela.Text == "0" && caractere == '0')
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (txtTela.Text.Length == 1 && txtTela.Text == "0" && caractere != ',')
                        {
                            txtTela.Text = "";
                            e.Handled = false;
                        }
                        else if (caractere != ',')
                            e.Handled = false;
                    }
                }
                else if (caractere != ',')
                {
                    e.Handled = false;
                }
            }

        }

        private void NumeroAgregado(object sender, EventArgs e)
        {
            // Esconde o label de erro
            lblErro.Visible = false;

            // Obtém o botão que foi clicado
            var botaoNumerico = ((Button)sender);
            int cursorPosicao = txtTela.SelectionStart;
            StringBuilder sb = new StringBuilder(txtTela.Text);

            // Verifica se a tela já contém uma vírgula
            if (!txtTela.Text.Contains(","))
            {
                // Verifica se o usuário está digitando 0 ou não.
                // Se o usuário ficar apertando 0 ele não irá adicionar, só terá um 0 na tela.
                if (txtTela.Text.Length == 1 && txtTela.Text == "0" && botaoNumerico.Text == "0")
                    txtTela.Text = "0";

                // Não apertou 0 para ser o primeiro dígito do número, irá adicionar os número normalmente.
                else
                {
                    if(txtTela.Text.Length == 1 && txtTela.Text == "0")
                    {
                        sb.Replace("0", botaoNumerico.Text);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosicao + 1;
                    }
                    else
                    {
                        sb.Insert(cursorPosicao, botaoNumerico.Text);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosicao + 1;
                    }
                }
            }

            // Tem uma vírgula na tela e adiciona um número após vírgula.
            else
            {
                sb.Insert(cursorPosicao, botaoNumerico.Text);
                txtTela.Text = sb.ToString();
                txtTela.SelectionStart = cursorPosicao + 1;
            }
               
        }

        // Verifica qual operação matemática o usuário vai fazer.
        private void Operacao(object sender, EventArgs e)
        {
            var botaoOperador = ((Button)sender);
            operador = Convert.ToChar(botaoOperador.Tag);
            primeiroNumero = Convert.ToDouble(txtTela.Text);


            // Esses operadores já dará o resultado sem a necessidade de clicar no botão igual.
            if (operador == '√')
            {
                primeiroNumero = Math.Sqrt(primeiroNumero);
                primeiroNumero = Math.Round(primeiroNumero, 2);
                txtTela.Text = primeiroNumero.ToString();

                txtTela.SelectionStart = txtTela.Text.Length;
            }
            else if (operador == '²')
            {
                primeiroNumero = Math.Pow(primeiroNumero, 2);
                txtTela.Text = primeiroNumero.ToString();

                txtTela.SelectionStart = txtTela.Text.Length;
            }
            else
                txtTela.Text = "0";

            txtTela.SelectionStart = txtTela.Text.Length;
        }

        private void OperacaoTeclado(char Operador)
        {
            operador = Operador;
            primeiroNumero = Convert.ToDouble(txtTela.Text);

            txtTela.Text = "0";

        }

        // Esse método faz a limpeza, dos números da tela, de tudo incluindo o que tiver na memória ou de um em um caractere.
        private void Limpar(object sender, EventArgs e)
        {

            // Obtém o botão que foi clicado
            var botaoLimpar = ((Button)sender);

            // Esconde o label de erro
            lblErro.Visible = false;

            // Verifica o texto do botão e realiza a ação apropriada
            if (botaoLimpar.Text == "C")
            {
                txtTela.Text = "0"; // Botão "C" - apaga somente o número que está na tela

                txtTela.SelectionStart = txtTela.Text.Length;
            }

            else if (botaoLimpar.Text == "CE")
            {
                // Botão "C" - apaga somente o número que está na tela
                txtTela.Text = "0";
                primeiroNumero = 0;
                segundoNumero = 0;
                operador = '\0';
                memoria = 0;

                txtTela.SelectionStart = txtTela.Text.Length;
            }

            else // Botão "←" - apaga o último caractere do número que está na tela
            {

                // Se o texto na tela tem apenas 1 caractere, seta para "0"
                if (txtTela.Text.Length == 1 || txtTela.Text.Length == 0)
                    txtTela.Text = "0";

                else
                {
                    int cursorPosition = txtTela.SelectionStart;
                    if (cursorPosition > 0)
                    {
                        string textoDaTela = txtTela.Text;
                        StringBuilder sb = new StringBuilder(textoDaTela);
                        sb.Remove(cursorPosition - 1, 1);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosition - 1;

                        if (cursorPosition == 1)
                        {
                            txtTela.SelectionStart = txtTela.Text.Length;
                        }
                        else
                        {
                            txtTela.SelectionStart = cursorPosition - 1;
                        }
                    }
                }
            }
        }

        // Botões de memória: MC, MR, MS, M+ e M-.
        private void Memoria(object sender, EventArgs e)
        {
            // Obtém o botão que foi clicado
            var botaoMemoria = ((Button)sender);

            // Apaga todos os números salvos na memória. Botão: MC.
            if (botaoMemoria.Text == "MC")
                memoria = 0;

            // Recupera o último número salvo na memória. Botão: MR.
            else if (botaoMemoria.Text == "MR")
            {
                txtTela.Text = memoria.ToString();
                txtTela.SelectionStart = txtTela.Text.Length;
            } 

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
            segundoNumero = Convert.ToDouble(txtTela.Text);

            // Calcula de acordo com a operação.
            if (operador == '+')
            {
                txtTela.Text = (primeiroNumero + segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '-')
            {
                txtTela.Text = (primeiroNumero - segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '*')
            {
                txtTela.Text = (primeiroNumero * segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '/')
            {
                // Verifica se o cálculo da divisão pode ser feito ou não.
                // Se não, vai habilitar uma mensagem de erro na tela.
                if (txtTela.Text != "0")
                {
                    txtTela.Text = (primeiroNumero / segundoNumero).ToString();
                    primeiroNumero = Convert.ToDouble(txtTela.Text);
                }
                else
                    lblErro.Visible = true;
            }
            else if (operador == '%')
            {
                txtTela.Text = ((primeiroNumero/100) * segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }

            txtTela.SelectionStart = txtTela.Text.Length;
        }

        private void txtTela_Leave(object sender, EventArgs e)
        {
            posicaoCursor = txtTela.SelectionStart;
            txtTela.Focus();
            txtTela.SelectionStart = posicaoCursor;
        }

        // Inverter o número de positivo para negativo ou vice-versa.
        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            primeiroNumero = Convert.ToDouble(txtTela.Text);
            primeiroNumero *= -1;
            txtTela.Text = primeiroNumero.ToString();

            txtTela.SelectionStart = txtTela.Text.Length;
        }

        // Colocar vírgula no número ao clicar no botão da vírgula.
        private void btnVirgula_Click(object sender, EventArgs e)
        {

            int cursorPosicao = txtTela.SelectionStart;
            StringBuilder sb = new StringBuilder(txtTela.Text);
            if (!txtTela.Text.Contains(","))
            {
                if (txtTela.Text == "0")
                {
                    sb.Replace("0", "0,");
                    txtTela.Text = sb.ToString();
                    txtTela.SelectionStart = cursorPosicao + 1;
                }
                else
                {
                    sb.Insert(cursorPosicao, ",");
                    txtTela.Text = sb.ToString();
                    txtTela.SelectionStart = cursorPosicao + 1;
                }
            }
        }
    }
}
