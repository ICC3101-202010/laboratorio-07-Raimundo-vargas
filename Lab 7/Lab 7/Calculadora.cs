using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Calculadora : Form
    {
        double n1;
        double n2;
        double resultado;
        string operacion;
        double resultado2;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dply.Text = "";
            n1 = 0;
            n2 = 0;
        }

        

        private void btnigual_Click(object sender, EventArgs e)
        {
            dply.Text = resultado2.ToString();
            n1 = 0;
            n2 = 0;
        }

        private void dply_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR"&&dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "0";
            }
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "3";
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "6";
            }

        }
        //Boton 7
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "7";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                dply.Text = dply.Text + "9";
            }

        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
               dply.Text = dply.Text + ",";
            }

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            try
            {
                n1 = double.Parse(dply.Text);
                dply.Clear();
            }
            catch
            {
                dply.Text = "Syntax ERROR";
            }

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            try
            {
                n1 = double.Parse(dply.Text);
                dply.Clear();
            }
            catch
            {
                dply.Text = "Syntax ERROR";
            }
            
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            try
            {
                n1 = double.Parse(dply.Text);
                dply.Clear();
            }
            catch
            {
                dply.Text = "Syntax ERROR";
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            
            operacion = "/";
            try
            {
                n1 = double.Parse(dply.Text);
                dply.Clear();
            }
            catch
            {
                dply.Text = "Syntax ERROR";
            }
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnigual_Click_1(object sender, EventArgs e)
        {
            try
            {
                n2 = double.Parse(dply.Text);
                switch (operacion)
                {
                    case "+":
                        resultado = n1 + n2;
                        dply.Text = resultado.ToString();
                        resultado2 = resultado;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        dply.Text = resultado.ToString();
                        resultado2 = resultado;
                        break;
                    case "*":
                        resultado = n1 * n2;
                        dply.Text = resultado.ToString();
                        resultado2 = resultado;
                        break;
                    case "/":
                        if (n2 == 0)
                        {
                            dply.Text = "Math ERROR";
                        }
                        else
                        {
                            resultado = n1 / n2;
                            dply.Text = resultado.ToString();
                            resultado2 = resultado;
                        }
                        break;
                }
            }
            catch
            {
                dply.Text = "Syntax ERROR";
            }
            
            
                
        }

        private void btnborrar1_Click(object sender, EventArgs e)
        {
            if (dply.Text != "Syntax ERROR" && dply.Text != "Math ERROR")
            {
                try
                {
                    dply.Text = dply.Text.Remove(dply.Text.Length - 1, 1);
                }
                catch
                {
                    dply.Clear();
                }
            }
        }
    }
}
