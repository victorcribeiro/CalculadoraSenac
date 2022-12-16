using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form

    {
       string display = " ";
       string valor_display = "";
       string operacao = "";
       double resultado = 0;
       double valor1 = 0;
       double valor2 = 0;
       string valorlb = "";
       double v4 = 0;





        public Form1()
        {
            InitializeComponent();
            
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text  += "1";

        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
          
            textBox1.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "9";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "0";
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            
            operacao = "/";
            valorlb = textBox1.Text;
            lb1.Text = valorlb + " ÷";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            
        }

        private void bt_multiplicacao_Click(object sender, EventArgs e)
        {
            
            operacao = "x";
            valorlb = textBox1.Text;
            lb1.Text = valorlb + " x";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = null;


        }

        private void bt_subitrair_Click(object sender, EventArgs e)
        {
            
            operacao = "-";
            valorlb = textBox1.Text;
            lb1.Text = valorlb + " -";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = null;

        }

        private void bt_somar_Click(object sender, EventArgs e)
        {
            
            lb1.Text = textBox1.Text + " +";
            operacao = "+";
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
            


        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            
            valor2 = double.Parse(textBox1.Text);
            
            Calculadora();
            


        }

        private void bt_virgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void bt_maisomenos_Click(object sender, EventArgs e)
        {
            operacao = "+/-";
            if (valor1 == 0) { }
            else
            {
                valor1 = double.Parse(textBox1.Text);
                Calculadora();
            }
            
        }

        private void bt_apagar_Click(object sender, EventArgs e)
        {
         if(textBox1.Text.Length > 0)   
            
           textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            

            
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            lb1.Text = null;
            textBox1.Text = null;
            valor1 = 0;
            valor2 = 0;
            resultado = 0;

        }

        private void bt_ce_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            
        }

        private void bt_porcentagem_Click(object sender, EventArgs e)
        {
            operacao = "%";
            if (valor1 == 0)
            {

            }
            else
            {

                v4 = (valor1 * double.Parse(textBox1.Text)) / 100;


                textBox1.Text = v4.ToString();

            }

        }


        private void bt_raiz_Click(object sender, EventArgs e)
        {
            operacao = "√";
            if (valor1 == 0) { }

            else
            {
            lb1.Text = "√(" + textBox1.Text + ")";
                valor1 = double.Parse(textBox1.Text);
                Calculadora();
            }
            
        }

        private void bt_aoquadrado_Click(object sender, EventArgs e)
        {
            operacao = "²";
            if (valor1 == 0) { }
            else
            {
            lb1.Text = "sqr(" + textBox1.Text + ")";
                valor1 = double.Parse(textBox1.Text);
                Calculadora();
            }
            

        }

        private void bt_1x_Click(object sender, EventArgs e)
        {
            operacao = "1/x";
            if (valor1 == 0) { }

            else
            {
            lb1.Text = "1/(" + textBox1.Text + ")";
                valor1 = double.Parse(textBox1.Text);
                Calculadora();
            }
            

        }

       public void  Calculadora()
        {
            switch (operacao)
            {
                
                case "+":
                   
                    resultado = valor1 + valor2;
                    textBox1.Text = resultado.ToString();

                    break;

                    case "-":
                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();
                    
                    break ;

                    case "x":
                    resultado = valor1 * valor2;
                    textBox1.Text = resultado.ToString();

                    break;

                    case "/":
                    resultado = valor1 / valor2;
                    textBox1.Text = resultado.ToString();

                    break;

                    case "²":

                    resultado = valor1 * valor1;
                    textBox1.Text = resultado.ToString();

                    break;

                    case "√":
                    resultado = Math.Sqrt(valor1);
                    textBox1.Text = resultado.ToString();

                    break;

                    case "+/-":
                    resultado = valor1 * -1;
                    textBox1.Text = resultado.ToString();

                    break;

                    case "1/x":
                    resultado = 1/valor1;
                    textBox1.Text = resultado.ToString();


                    break;

                case "%":

                    resultado = (valor1 * double.Parse(textBox1.Text)) / 100;


                    textBox1.Text = resultado.ToString();


                    break;















            }

        }

        



        
    }
}
