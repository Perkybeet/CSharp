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
            txtResultado.Text="0";
            txtResultado.Font = new Font(Font.OriginalFontName, 43);
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
            AddNumero("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AddNumero("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            AddNumero("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            AddNumero("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            AddNumero("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            AddNumero("6");
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            AddNumero("0");
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            AddNumero(",");
        }

        private void AddNumero(string numero)
        {

            //Si en pantalla ya hay 13 caracteres no hace nada
            if (txtResultado.Text.Length == 13) { return; }

            switch (txtResultado.Text)
            {
                case "0":

                    switch (numero)
                    {
                        case ".":
                        case ",":
                            txtResultado.Text += ",";
                            break;

                        default:
                            txtResultado.Text = numero;
                            break;
                    }

                    break;


                default:
                    switch (numero)
                    {
                        case ".":
                        case ",":

                            if (txtResultado.Text.Contains(",") == true)
                            {
                                return;
                            }
                            else
                            {
                                if (txtResultado.Text.Length == 11) { return; }
                                else { txtResultado.Text += ","; }
                            }
                            break;

                        default:
                            txtResultado.Text += numero;
                            break;
                    }
                    break;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length >= 10)
            {
                txtResultado.Font = new Font(Font.OriginalFontName, 35);
            }
            if (txtResultado.Text.Length >= 12)
            {
                txtResultado.Font = new Font(Font.OriginalFontName, 28);
            }
            if (txtResultado.Text.Length >= 15)
            {
                txtResultado.Font = new Font(Font.OriginalFontName, 23);
            }
            if (txtResultado.Text.Length >= 17)
            {
                bt0.Enabled = false;
                bt1.Enabled = false;
                bt2.Enabled = false;
                bt3.Enabled = false;
                bt4.Enabled = false;
                bt5.Enabled = false;
                bt6.Enabled = false;
                bt7.Enabled = false;
                bt8.Enabled = false;
                bt9.Enabled = false;
                btSuma.Enabled = false;
                btResta.Enabled = false;
                btMultiplicacion.Enabled = false;
                btDivision.Enabled = false;
                btComa.Enabled = false;
                btResultado.Enabled = false;


            }
            else
            {
                bt0.Enabled = true;
                bt1.Enabled = true;
                bt2.Enabled = true;
                bt3.Enabled = true;
                bt4.Enabled = true;
                bt5.Enabled = true;
                bt6.Enabled = true;
                bt7.Enabled = true;
                bt8.Enabled = true;
                bt9.Enabled = true;
                btSuma.Enabled = true;
                btResta.Enabled = true;
                btMultiplicacion.Enabled = true;
                btDivision.Enabled = true;
                btComa.Enabled = true;
                btResultado.Enabled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString ())
            {
                case "1":
                    bt1.PerformClick();
                    bt1.Focus();
                    break;

                case "2":
                    bt2.PerformClick();
                    bt2.Focus();
                    break;

                case "3":
                    bt3.PerformClick();
                    bt3.Focus();
                    break;

                case "4":
                    bt4.PerformClick();
                    bt4.Focus();
                    break;

                case "5":
                    bt5.PerformClick();
                    bt5.Focus();
                    break;

                case "6":
                    bt6.PerformClick();
                    bt6.Focus();
                    break;

                case "7":
                    bt7.PerformClick();
                    bt7.Focus();
                    break;

                case "8":
                    bt8.PerformClick();
                    bt8.Focus();
                    break;

                case "9":
                    bt9.PerformClick();
                    bt9.Focus();
                    break;

                case "0":
                    bt0.PerformClick();
                    bt0.Focus();
                    break;

                case ".":
                case ",":
                    btComa.PerformClick();
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt9_Click_1(object sender, EventArgs e)
        {
            AddNumero("9");
        }

        private void bt8_Click_1(object sender, EventArgs e)
        {
            AddNumero("8");
        }

        private void bt7_Click_1(object sender, EventArgs e)
        {
            AddNumero("7");
        }
    }

}
