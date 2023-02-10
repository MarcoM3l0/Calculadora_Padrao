namespace Calculadora_Padrão
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTela = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnUmPorX = new System.Windows.Forms.Button();
            this.btnMMenos = new System.Windows.Forms.Button();
            this.btnMMais = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMaisOuMenos = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTela
            // 
            this.txtTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTela.Location = new System.Drawing.Point(9, 12);
            this.txtTela.MaxLength = 18;
            this.txtTela.Multiline = true;
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(254, 67);
            this.txtTela.TabIndex = 0;
            this.txtTela.Text = "0";
            this.txtTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTela.TextChanged += new System.EventHandler(this.NumeroAgregadoTeclado);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(9, 286);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 44);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(61, 286);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 44);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(113, 286);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 44);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(113, 236);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 44);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(61, 236);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 44);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(9, 236);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 44);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(113, 186);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(46, 44);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(61, 186);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 44);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(9, 186);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 44);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(9, 336);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(98, 44);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumeroAgregado);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(61, 136);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(46, 44);
            this.btnLimparTudo.TabIndex = 23;
            this.btnLimparTudo.Text = "CE";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.Limpar);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(9, 136);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(46, 44);
            this.btnApagar.TabIndex = 22;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.Limpar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(113, 136);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(46, 44);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.Limpar);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(114, 335);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(46, 44);
            this.btnVirgula.TabIndex = 12;
            this.btnVirgula.Tag = ",";
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(165, 335);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(46, 44);
            this.btnMais.TabIndex = 13;
            this.btnMais.Tag = "+";
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.Operacao);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(165, 286);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(46, 44);
            this.btnMenos.TabIndex = 14;
            this.btnMenos.Tag = "-";
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.Operacao);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(165, 187);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(46, 44);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.Operacao);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVezes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.Location = new System.Drawing.Point(165, 236);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(46, 44);
            this.btnVezes.TabIndex = 15;
            this.btnVezes.Tag = "*";
            this.btnVezes.Text = "*";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.Operacao);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(217, 286);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(46, 94);
            this.btnIgual.TabIndex = 21;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(217, 136);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(46, 44);
            this.btnRaiz.TabIndex = 18;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√x";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.Operacao);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.Location = new System.Drawing.Point(217, 186);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(46, 44);
            this.btnPorcentagem.TabIndex = 19;
            this.btnPorcentagem.Tag = "%";
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.Operacao);
            // 
            // btnUmPorX
            // 
            this.btnUmPorX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUmPorX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUmPorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUmPorX.Location = new System.Drawing.Point(217, 237);
            this.btnUmPorX.Name = "btnUmPorX";
            this.btnUmPorX.Size = new System.Drawing.Size(46, 44);
            this.btnUmPorX.TabIndex = 20;
            this.btnUmPorX.Tag = "²";
            this.btnUmPorX.Text = "x²";
            this.btnUmPorX.UseVisualStyleBackColor = false;
            this.btnUmPorX.Click += new System.EventHandler(this.Operacao);
            // 
            // btnMMenos
            // 
            this.btnMMenos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenos.Location = new System.Drawing.Point(218, 86);
            this.btnMMenos.Name = "btnMMenos";
            this.btnMMenos.Size = new System.Drawing.Size(46, 44);
            this.btnMMenos.TabIndex = 29;
            this.btnMMenos.Text = "M-";
            this.btnMMenos.UseVisualStyleBackColor = false;
            this.btnMMenos.Click += new System.EventHandler(this.Memoria);
            // 
            // btnMMais
            // 
            this.btnMMais.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMMais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMais.Location = new System.Drawing.Point(166, 85);
            this.btnMMais.Name = "btnMMais";
            this.btnMMais.Size = new System.Drawing.Size(46, 44);
            this.btnMMais.TabIndex = 28;
            this.btnMMais.Text = "M+";
            this.btnMMais.UseVisualStyleBackColor = false;
            this.btnMMais.Click += new System.EventHandler(this.Memoria);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(114, 86);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(46, 44);
            this.btnMS.TabIndex = 27;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.Memoria);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(62, 86);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(46, 44);
            this.btnMR.TabIndex = 26;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.Memoria);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(10, 86);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(46, 44);
            this.btnMC.TabIndex = 25;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.Memoria);
            // 
            // btnMaisOuMenos
            // 
            this.btnMaisOuMenos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMaisOuMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaisOuMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisOuMenos.Location = new System.Drawing.Point(166, 135);
            this.btnMaisOuMenos.Name = "btnMaisOuMenos";
            this.btnMaisOuMenos.Size = new System.Drawing.Size(46, 44);
            this.btnMaisOuMenos.TabIndex = 30;
            this.btnMaisOuMenos.Tag = "";
            this.btnMaisOuMenos.Text = "±";
            this.btnMaisOuMenos.UseVisualStyleBackColor = false;
            this.btnMaisOuMenos.Click += new System.EventHandler(this.btnMaisOuMenos_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.SystemColors.Window;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(209, 19);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(51, 24);
            this.lblErro.TabIndex = 31;
            this.lblErro.Text = "Erro!";
            this.lblErro.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(275, 391);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnMaisOuMenos);
            this.Controls.Add(this.txtTela);
            this.Controls.Add(this.btnMMenos);
            this.Controls.Add(this.btnMMais);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnUmPorX);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnUmPorX;
        private System.Windows.Forms.Button btnMMenos;
        private System.Windows.Forms.Button btnMMais;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMaisOuMenos;
        private System.Windows.Forms.Label lblErro;
    }
}

