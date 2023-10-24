using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) + int.Parse(numero2);




            lbResultado.Text = total.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) - int.Parse(numero2);




            lbResultado.Text = total.ToString();
        }

        private void btndivisão_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

           float total = float.Parse(numero1) / float.Parse(numero2);




            lbResultado.Text = total.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) * int.Parse(numero2);




            lbResultado.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbnumero3.Text);

            if (numero3 < 0)
            {
                lbResultado.Text = "O numero digitado é menor que 0";

            }
            else
            {
                lbResultado.Text = "O numero digitado é maior que 0";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
