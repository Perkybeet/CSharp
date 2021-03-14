using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3
{
    public partial class Form1 : Form
    {
        double primervalor = 0;
        double segundovalor = 0;
        double resultado;
        string operador = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            segundovalor = double.Parse(txtResultado.Text);

            switch (operador)
            {
                case "+":
                    suma(primervalor, segundovalor);
                    txtResultado.Text = resultado.ToString();
                        break;

                case "-":
                    resta(primervalor, segundovalor);
                    txtResultado.Text = resultado.ToString();
                    break;

                case "*":
                    multiplicacion(primervalor, segundovalor);
                    txtResultado.Text = resultado.ToString();
                        break;

                case "/":
                    division(primervalor, segundovalor);
                    txtResultado.Text = resultado.ToString();
                    break;

            }
            
            Clipboard.SetText(resultado.ToString());

            //MessageBox.Show(resultado.ToString());
        }

        double suma(double uno, double dos)
        {
            resultado = uno + dos;
            return resultado;
        }

        double resta(double uno, double dos)
        {
            resultado = uno - dos;
            return resultado;
        }

        double multiplicacion(double uno, double dos)
        {
            resultado = uno * dos;
            return resultado;
        }

        double division(double uno, double dos)
        {
            resultado = uno / dos;
            return resultado;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            primervalor = 0;
            segundovalor = 0;
            resultado = 0;
            txtResultado.Clear();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            primervalor = double.Parse(txtResultado.Text);
            operador = "+";
            txtResultado.Text = "";
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            primervalor = double.Parse(txtResultado.Text);
            operador = "-";
            txtResultado.Text = "";
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            primervalor = double.Parse(txtResultado.Text);
            operador = "*";
            txtResultado.Text = "";
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            primervalor = double.Parse(txtResultado.Text);
            operador = "/";
            txtResultado.Text = "";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ",";
        }
    }

}
