namespace CalculadoraCP1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            menuSobre = new ToolStripMenuItem();
            visor = new TextBox();
            btnClear = new Button();
            btnRaiz = new Button();
            btnPotencia = new Button();
            btnResultado = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btnMultiplicacao = new Button();
            btnSub = new Button();
            btnSoma = new Button();
            btn0 = new Button();
            btnDivisao = new Button();
            btnVirgula = new Button();
            btnApagar = new Button();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            //
            // menuPrincipal
            //
            menuPrincipal.Items.AddRange(new ToolStripItem[] { menuSobre });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(284, 24);
            menuPrincipal.TabIndex = 21;
            //
            // menuSobre
            //
            menuSobre.Name = "menuSobre";
            menuSobre.Size = new Size(53, 20);
            menuSobre.Text = "Sobre";
            menuSobre.Click += menuSobreClick;
            //
            // visor
            //
            visor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            visor.BackColor = SystemColors.Menu;
            visor.BorderStyle = BorderStyle.FixedSingle;
            visor.Font = new Font("Segoe UI", 20F);
            visor.Location = new Point(12, 38);
            visor.MaxLength = 15;
            visor.Name = "visor";
            visor.ReadOnly = true;
            visor.Size = new Size(261, 43);
            visor.TabIndex = 0;
            visor.TabStop = false;
            visor.Text = "0";
            visor.TextAlign = HorizontalAlignment.Right;
            //
            // btnClear
            //
            btnClear.BackColor = SystemColors.Menu;
            btnClear.FlatAppearance.BorderColor = Color.Silver;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.WindowText;
            btnClear.Location = new Point(12, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 55);
            btnClear.TabIndex = 1;
            btnClear.TabStop = false;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClearClick;
            //
            // btnRaiz
            //
            btnRaiz.BackColor = SystemColors.Menu;
            btnRaiz.FlatAppearance.BorderColor = Color.Silver;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaiz.ForeColor = SystemColors.WindowText;
            btnRaiz.Location = new Point(78, 87);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(60, 55);
            btnRaiz.TabIndex = 2;
            btnRaiz.TabStop = false;
            btnRaiz.Text = "√x";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaizClick;
            //
            // btnPotencia
            //
            btnPotencia.BackColor = SystemColors.Menu;
            btnPotencia.FlatAppearance.BorderColor = Color.Silver;
            btnPotencia.FlatStyle = FlatStyle.Flat;
            btnPotencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.ForeColor = SystemColors.WindowText;
            btnPotencia.Location = new Point(144, 87);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(60, 55);
            btnPotencia.TabIndex = 3;
            btnPotencia.TabStop = false;
            btnPotencia.Text = "x^y";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnOperacaoClick;
            //
            // btnResultado
            //
            btnResultado.BackColor = SystemColors.Menu;
            btnResultado.FlatAppearance.BorderColor = Color.Silver;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.ForeColor = SystemColors.WindowText;
            btnResultado.Location = new Point(212, 331);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(60, 55);
            btnResultado.TabIndex = 4;
            btnResultado.TabStop = false;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnIgualClick;
            //
            // btn7
            //
            btn7.BackColor = SystemColors.Menu;
            btn7.FlatAppearance.BorderColor = Color.Silver;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.WindowText;
            btn7.Location = new Point(12, 148);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 55);
            btn7.TabIndex = 5;
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnDigitoClick;
            //
            // btn4
            //
            btn4.BackColor = SystemColors.Menu;
            btn4.FlatAppearance.BorderColor = Color.Silver;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.WindowText;
            btn4.Location = new Point(12, 209);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 55);
            btn4.TabIndex = 6;
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnDigitoClick;
            //
            // btn3
            //
            btn3.BackColor = SystemColors.Menu;
            btn3.FlatAppearance.BorderColor = Color.Silver;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.WindowText;
            btn3.Location = new Point(12, 270);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 55);
            btn3.TabIndex = 7;
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnDigitoClick;
            //
            // btn8
            //
            btn8.BackColor = SystemColors.Menu;
            btn8.FlatAppearance.BorderColor = Color.Silver;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.WindowText;
            btn8.Location = new Point(78, 148);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 55);
            btn8.TabIndex = 8;
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnDigitoClick;
            //
            // btn5
            //
            btn5.BackColor = SystemColors.Menu;
            btn5.FlatAppearance.BorderColor = Color.Silver;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.WindowText;
            btn5.Location = new Point(78, 209);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 55);
            btn5.TabIndex = 9;
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnDigitoClick;
            //
            // btn2
            //
            btn2.BackColor = SystemColors.Menu;
            btn2.FlatAppearance.BorderColor = Color.Silver;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.WindowText;
            btn2.Location = new Point(78, 270);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 55);
            btn2.TabIndex = 10;
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnDigitoClick;
            //
            // btn9
            //
            btn9.BackColor = SystemColors.Menu;
            btn9.FlatAppearance.BorderColor = Color.Silver;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.WindowText;
            btn9.Location = new Point(144, 148);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 55);
            btn9.TabIndex = 11;
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnDigitoClick;
            //
            // btn6
            //
            btn6.BackColor = SystemColors.Menu;
            btn6.FlatAppearance.BorderColor = Color.Silver;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.WindowText;
            btn6.Location = new Point(144, 209);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 55);
            btn6.TabIndex = 12;
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnDigitoClick;
            //
            // btn1
            //
            btn1.BackColor = SystemColors.Menu;
            btn1.FlatAppearance.BorderColor = Color.Silver;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.WindowText;
            btn1.Location = new Point(144, 270);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 55);
            btn1.TabIndex = 13;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnDigitoClick;
            //
            // btnMultiplicacao
            //
            btnMultiplicacao.BackColor = SystemColors.Menu;
            btnMultiplicacao.FlatAppearance.BorderColor = Color.Silver;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacao.ForeColor = SystemColors.WindowText;
            btnMultiplicacao.Location = new Point(212, 148);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(60, 55);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.TabStop = false;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnOperacaoClick;
            //
            // btnSub
            //
            btnSub.BackColor = SystemColors.Menu;
            btnSub.FlatAppearance.BorderColor = Color.Silver;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.ForeColor = SystemColors.WindowText;
            btnSub.Location = new Point(212, 209);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(60, 55);
            btnSub.TabIndex = 15;
            btnSub.TabStop = false;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnOperacaoClick;
            //
            // btnSoma
            //
            btnSoma.BackColor = SystemColors.Menu;
            btnSoma.FlatAppearance.BorderColor = Color.Silver;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.ForeColor = SystemColors.WindowText;
            btnSoma.Location = new Point(212, 270);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(60, 55);
            btnSoma.TabIndex = 16;
            btnSoma.TabStop = false;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnOperacaoClick;
            //
            // btn0
            //
            btn0.BackColor = SystemColors.Menu;
            btn0.FlatAppearance.BorderColor = Color.Silver;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.WindowText;
            btn0.Location = new Point(78, 331);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 55);
            btn0.TabIndex = 17;
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnDigitoClick;
            //
            // btnDivisao
            //
            btnDivisao.BackColor = SystemColors.Menu;
            btnDivisao.FlatAppearance.BorderColor = Color.Silver;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.ForeColor = SystemColors.WindowText;
            btnDivisao.Location = new Point(212, 87);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(60, 55);
            btnDivisao.TabIndex = 18;
            btnDivisao.TabStop = false;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnOperacaoClick;
            //
            // btnVirgula
            //
            btnVirgula.BackColor = SystemColors.Menu;
            btnVirgula.FlatAppearance.BorderColor = Color.Silver;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = SystemColors.WindowText;
            btnVirgula.Location = new Point(146, 331);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(60, 55);
            btnVirgula.TabIndex = 19;
            btnVirgula.TabStop = false;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgulaClick;
            //
            // btnApagar
            //
            btnApagar.BackColor = SystemColors.Menu;
            btnApagar.FlatAppearance.BorderColor = Color.Silver;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = SystemColors.WindowText;
            btnApagar.Location = new Point(12, 331);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(60, 55);
            btnApagar.TabIndex = 20;
            btnApagar.TabStop = false;
            btnApagar.Text = "⌫";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagarClick;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 398);
            Controls.Add(btnApagar);
            Controls.Add(btnVirgula);
            Controls.Add(btnDivisao);
            Controls.Add(btn0);
            Controls.Add(btnSoma);
            Controls.Add(btnSub);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn7);
            Controls.Add(btnResultado);
            Controls.Add(btnPotencia);
            Controls.Add(btnRaiz);
            Controls.Add(btnClear);
            Controls.Add(visor);
            Controls.Add(menuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuPrincipal;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Semi-Científica";
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem menuSobre;
        private TextBox visor;
        private Button btnClear;
        private Button btnRaiz;
        private Button btnPotencia;
        private Button btnResultado;
        private Button btn7;
        private Button btn4;
        private Button btn3;
        private Button btn8;
        private Button btn5;
        private Button btn2;
        private Button btn9;
        private Button btn6;
        private Button btn1;
        private Button btnMultiplicacao;
        private Button btnSub;
        private Button btnSoma;
        private Button btn0;
        private Button btnDivisao;
        private Button btnVirgula;
        private Button btnApagar;
    }
}
