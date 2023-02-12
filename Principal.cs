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
        // Variáveis globais.
        private double primeiroNumero = 0, segundoNumero = 0, memoria = 0; // Variáveis para armazenar os números da operação.
        private char operador; // Variável para armazenar o operador da operação.
        private int posicaoCursor; // Variável para armazenar a posição do cursor. 
        private string caracteresNumericoEVirgula = ",0123456789"; // Variável para armazenar caracteres numéricos e uma vírgula.
        private string caracteresOperadores = "Xx*-+/"; // Variável para armazenar caracteres operadores.
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

            char caractere = e.KeyChar; // Capturar o caractere pressionado pelo usuário.

            // Verificar se o caractere é o sinal de igualdade ou a tecla Enter.
            if (caractere == '=' || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Impedir que o caractere seja inserido na tela.
                btnIgual_Click(this, new EventArgs()); // Simular o clique do botão "Igual".
            }

            // Verificar se o caractere é um operador matemático.
            if (caracteresOperadores.Contains(caractere))
            {
                e.Handled = true; // Impedir que o caractere seja inserido na tela.

                // Identificar qual operador foi pressionado.
                string mult = "Xx*";
                if (mult.Contains(caractere))
                    OperacaoTeclado('*');
                else if (caractere == '-')
                    OperacaoTeclado('-');
                else if (caractere == '+')
                    OperacaoTeclado('+');
                else if (caractere == '/')
                    OperacaoTeclado('/');

                txtTela.SelectionStart = txtTela.Text.Length; // Definir a posição do cursor na extremidade direita do texto.
            }

            // Verificar se o caractere é a tecla "Backspace".
            if (e.KeyChar == '\b' && txtTela.Text.Length == 1)
            {
                e.Handled = true; // Impedir que o caractere seja inserido na tela.
                txtTela.Text = "0"; // Limpar o texto da tela.
                txtTela.SelectionStart = txtTela.TextLength; // Definir a posição do cursor na extremidade direita do texto.
            }

            // Verificar se o caractere é uma vírgula.
            if (caractere == ',' && txtTela.Text.Contains(","))
            {
                e.Handled = true; // Impedir que o caractere seja inserido na tela.
            }

            // Verificar se o caractere é um número ou uma vírgula.
            if (caracteresNumericoEVirgula.Contains(caractere))
            {
                // Verificar se o texto da tela já possui uma vírgula.
                if (!txtTela.Text.Contains(","))
                {
                    // Se a string na tela não possui vírgula e seu tamanho é igual a 1 e seu conteúdo é 0.
                    if (txtTela.Text.Length == 1 && txtTela.Text == "0" && caractere == '0')
                    {
                        e.Handled = true; // Impedir que o caractere seja inserido na tela.
                    }
                    else
                    {
                        // Se a string na tela tem tamanho igual a 1, conteúdo igual a 0 e caractere diferente de ','.
                        if (txtTela.Text.Length == 1 && txtTela.Text == "0" && caractere != ',')
                        {
                            txtTela.Text = ""; // Gambiarra para evitar que zera permaneça travado na tela.
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
            lblErro.Visible = false; // Esconder o label de erro.

            var botaoNumerico = ((Button)sender); // Identificar o botão numérico clicado.
            int cursorPosicao = txtTela.SelectionStart; // Obter a posição do cursor na textbox.
            StringBuilder sb = new StringBuilder(txtTela.Text); // StringBuilder para manipular a string da textbox.

            // Verifica se a textbox já tem uma vírgula.
            if (!txtTela.Text.Contains(","))
            {

                // Se a textbox já tiver um "0", mas o botão clicado não for uma vírgula.
                if (txtTela.Text.Length == 1 && txtTela.Text == "0" && botaoNumerico.Text == "0")
                    txtTela.Text = "0";

                
                else
                {
                    // Se a textbox só tiver um "0".
                    if (txtTela.Text.Length == 1 && txtTela.Text == "0")
                    {
                        // Substituir "0" pelo número clicado.
                        sb.Replace("0", botaoNumerico.Text);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosicao + 1;
                    }
                    else
                    {
                        // Inserir o número clicado na textbox.
                        sb.Insert(cursorPosicao, botaoNumerico.Text);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosicao + 1;
                    }
                }
            }

            // Se a textbox já tiver uma vírgula.
            else
            {
                // Inserir o número clicado na textbox.
                sb.Insert(cursorPosicao, botaoNumerico.Text);
                txtTela.Text = sb.ToString();
                txtTela.SelectionStart = cursorPosicao + 1;
            }
               
        }

        
        private void Operacao(object sender, EventArgs e)
        {
            var botaoOperador = ((Button)sender); // Armazena o botão clicado pelo usuário na variável botaoOperador.
            operador = Convert.ToChar(botaoOperador.Tag); // Armazena o operador matemático na variável operador.
            primeiroNumero = Convert.ToDouble(txtTela.Text); // Armazena o primeiro número digitado pelo usuário na variável primeiroNumero.


            // Verifica se o operador é a raiz quadrada (√). E calcula a raiz quadrada do primeiro número.
            if (operador == '√')
            {
                primeiroNumero = Math.Sqrt(primeiroNumero);
                primeiroNumero = Math.Round(primeiroNumero, 2);  
                txtTela.Text = primeiroNumero.ToString();

                txtTela.SelectionStart = txtTela.Text.Length;
            }
            // Verifica se o operador é o quadrado (²). E calcula o quadrado do primeiro número.
            else if (operador == '²')
            {
                primeiroNumero = Math.Pow(primeiroNumero, 2);
                txtTela.Text = primeiroNumero.ToString();

                txtTela.SelectionStart = txtTela.Text.Length;
            }
            // Se não for nem raiz quadrada nem quadrado, coloca o texto da tela como 0 e o programa espera a digitação do segundo número.
            else
                txtTela.Text = "0";

            txtTela.SelectionStart = txtTela.Text.Length; // Coloca o cursor na posição final do texto.
        }

        private void OperacaoTeclado(char Operador)
        {
            operador = Operador;
            primeiroNumero = Convert.ToDouble(txtTela.Text);
            txtTela.Text = "0";
        }

        
        private void Limpar(object sender, EventArgs e)
        {

            
            var botaoLimpar = ((Button)sender); //Armazena o objeto do botão clicado na variável botaoLimpar.

            lblErro.Visible = false; //Esconde o rótulo de erro.

            //Verifica se o botão [C].
            if (botaoLimpar.Text == "C")
            {
                txtTela.Text = "0"; //Se for, limpa a tela de exibição da calculadora, colocando "0" nela.
                txtTela.SelectionStart = txtTela.Text.Length; //Coloca o cursor no final do texto da tela.
            }

            //Verifica se o botão [CE].
            else if (botaoLimpar.Text == "CE")
            {
                //Se for, limpa todos os valores usados na calculadora, incluindo a tela, o primeiro número,
                //o segundo número, o operador e a memória.
                txtTela.Text = "0";
                primeiroNumero = 0;
                segundoNumero = 0;
                operador = '\0';
                memoria = 0;

                txtTela.SelectionStart = txtTela.Text.Length; //Coloca o cursor no final do texto da tela.
            }

            else 
            {

                //Verifica se o botão [←].
                //remove o último caractere da tela, se o comprimento da string for maior ou igual a 1.
                if (txtTela.Text.Length == 1 || txtTela.Text.Length == 0)
                    txtTela.Text = "0";

                else
                {
                    int cursorPosition = txtTela.SelectionStart; //Obtém a posição atual do cursor.

                    //Se a posição do cursor for maior que 0, remove o caractere anterior a ele.
                    if (cursorPosition > 0)
                    {
                        string textoDaTela = txtTela.Text;
                        StringBuilder sb = new StringBuilder(textoDaTela);
                        sb.Remove(cursorPosition - 1, 1);
                        txtTela.Text = sb.ToString();
                        txtTela.SelectionStart = cursorPosition - 1;

                        //Se a posição do cursor for 1, coloca o cursor no final do texto.
                        if (cursorPosition == 1)
                        {
                            txtTela.SelectionStart = txtTela.Text.Length;
                        }

                        //Caso contrário, mantém o cursor na posição anterior.
                        else
                        {
                            txtTela.SelectionStart = cursorPosition - 1;
                        }
                    }
                }
            }
        }

        
        private void Memoria(object sender, EventArgs e)
        {
            
            var botaoMemoria = ((Button)sender); // Recupera o botão que foi clicado.

            // Verifica qual botão foi clicado e realiza a ação correspondente.
            if (botaoMemoria.Text == "MC") // Zerar a memória.
                memoria = 0;

            else if (botaoMemoria.Text == "MR") // Recuperar o valor da memória e exibir na tela.
            {
                txtTela.Text = memoria.ToString();
                txtTela.SelectionStart = txtTela.Text.Length;
            } 

            else if (botaoMemoria.Text == "MS") // Salvar o valor na memória.
                memoria = Convert.ToDouble(txtTela.Text);

            else if (botaoMemoria.Text == "M+") // Adicionar o valor na tela ao valor na memória.
                memoria += Convert.ToDouble(txtTela.Text);

            else // Subtrair o valor na tela do valor na memória.
                memoria -= Convert.ToDouble(txtTela.Text);
        }

        
        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            segundoNumero = Convert.ToDouble(txtTela.Text); // Armazena o segundo número digitado pelo usuário na tela da calculadora.

            // Verifica qual operação deve ser realizada com base no operador armazenado.
            if (operador == '+') // Realiza a operação de adição.
            {
                txtTela.Text = (primeiroNumero + segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '-') // Realiza a operação de subtração.
            {
                txtTela.Text = (primeiroNumero - segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '*') // Realiza a operação de multiplicação.
            {
                txtTela.Text = (primeiroNumero * segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }
            else if (operador == '/') // Realiza a operação de divisão.
            {

                // Verifica se o segundo número é zero, o que resultaria em uma divisão por zero.
                if (txtTela.Text != "0")
                {
                    // Realiza a operação de divisão.
                    txtTela.Text = (primeiroNumero / segundoNumero).ToString();
                    primeiroNumero = Convert.ToDouble(txtTela.Text);
                }
                // Exibe uma mensagem de erro se a divisão for por zero.
                else
                    lblErro.Visible = true; 
            }
            else if (operador == '%') // Realiza a operação de porcentagem.
            {
                txtTela.Text = ((primeiroNumero/100) * segundoNumero).ToString();
                primeiroNumero = Convert.ToDouble(txtTela.Text);
            }

            txtTela.SelectionStart = txtTela.Text.Length; // Coloca o cursor no final do texto na tela da calculadora.
        }

        //Deixa o foco sempre no txtTela.
        private void txtTela_Leave(object sender, EventArgs e)
        {
            posicaoCursor = txtTela.SelectionStart;
            txtTela.Focus();
            txtTela.SelectionStart = posicaoCursor;
        }

        // Inverter o valor de positivo para negativo, ou vice-versa, do número. 
        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            primeiroNumero = Convert.ToDouble(txtTela.Text);
            primeiroNumero *= -1;
            txtTela.Text = primeiroNumero.ToString();

            txtTela.SelectionStart = txtTela.Text.Length;
        }

        
        private void btnVirgula_Click(object sender, EventArgs e)
        {

            int cursorPosicao = txtTela.SelectionStart; // Armazenando a posição atual do cursor na tela.
            StringBuilder sb = new StringBuilder(txtTela.Text); // Criando um objeto StringBuilder com o texto atual na tela.

            // Verificando se já existe uma vírgula na string.
            if (!txtTela.Text.Contains(","))
            {
                // Caso a string seja igual a "0".
                if (txtTela.Text == "0")
                {
                    sb.Replace("0", "0,"); // Substituindo "0" por "0,". Essa outra gambiarra, pois a virgula tava apagando o "0" e so ficando ",".
                    txtTela.Text = sb.ToString();
                    txtTela.SelectionStart = cursorPosicao + 1; // Movendo o cursor para a posição correta.
                }
                else
                {
                    sb.Insert(cursorPosicao, ","); // Inserindo uma vírgula na posição do cursor.
                    txtTela.Text = sb.ToString();
                    txtTela.SelectionStart = cursorPosicao + 1; // Movendo o cursor para a posição correta.
                }
            }
        }
    }
}
