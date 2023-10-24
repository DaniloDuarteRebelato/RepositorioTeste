namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btndivisão = new System.Windows.Forms.Button();
            this.resultado3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnumero3 = new System.Windows.Forms.TextBox();
            this.btnMaiorMenor = new System.Windows.Forms.Button();
            this.btnimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(255, 80);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 41);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(130, 80);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 20);
            this.txbNumero1.TabIndex = 1;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(130, 123);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 20);
            this.txbNumero2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "numero 2";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(127, 155);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(50, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "resultado";
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // btnsubtrair
            // 
            this.btnsubtrair.Location = new System.Drawing.Point(255, 127);
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.Size = new System.Drawing.Size(119, 41);
            this.btnsubtrair.TabIndex = 6;
            this.btnsubtrair.Text = "Subtrair";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btndivisão
            // 
            this.btndivisão.Location = new System.Drawing.Point(255, 174);
            this.btndivisão.Name = "btndivisão";
            this.btndivisão.Size = new System.Drawing.Size(119, 41);
            this.btndivisão.TabIndex = 7;
            this.btndivisão.Text = "Divisão";
            this.btndivisão.UseVisualStyleBackColor = true;
            this.btndivisão.Click += new System.EventHandler(this.btndivisão_Click);
            // 
            // resultado3
            // 
            this.resultado3.AutoSize = true;
            this.resultado3.Location = new System.Drawing.Point(269, 212);
            this.resultado3.Name = "resultado3";
            this.resultado3.Size = new System.Drawing.Size(0, 13);
            this.resultado3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Multiplicação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Digite um numero";
            // 
            // txbnumero3
            // 
            this.txbnumero3.Location = new System.Drawing.Point(395, 80);
            this.txbnumero3.Name = "txbnumero3";
            this.txbnumero3.Size = new System.Drawing.Size(100, 20);
            this.txbnumero3.TabIndex = 20;
            // 
            // btnMaiorMenor
            // 
            this.btnMaiorMenor.Location = new System.Drawing.Point(255, 268);
            this.btnMaiorMenor.Name = "btnMaiorMenor";
            this.btnMaiorMenor.Size = new System.Drawing.Size(119, 40);
            this.btnMaiorMenor.TabIndex = 21;
            this.btnMaiorMenor.Text = "Menor Maior";
            this.btnMaiorMenor.UseVisualStyleBackColor = true;
            this.btnMaiorMenor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnimpar
            // 
            this.btnimpar.Location = new System.Drawing.Point(255, 314);
            this.btnimpar.Name = "btnimpar";
            this.btnimpar.Size = new System.Drawing.Size(119, 37);
            this.btnimpar.TabIndex = 22;
            this.btnimpar.Text = "Impar ou par";
            this.btnimpar.UseVisualStyleBackColor = true;
            this.btnimpar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnimpar);
            this.Controls.Add(this.btnMaiorMenor);
            this.Controls.Add(this.txbnumero3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado3);
            this.Controls.Add(this.btndivisão);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btndivisão;
        private System.Windows.Forms.Label resultado3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbnumero3;
        private System.Windows.Forms.Button btnMaiorMenor;
        private System.Windows.Forms.Button btnimpar;
    }
}

