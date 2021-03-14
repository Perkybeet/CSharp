using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcualdora2
{
    public partial class Form1 : Form
    {

        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void btResultado_Click(object sender, EventArgs e)
        {
            //Recoje los valores que desposita el usuario en txt1 y txt2 y los almacena

            int valor1   = Int32.Parse(txt1.Text);
            int valor2   = Int32.Parse(txt2.Text);
            int resultado   = 0;

            switch (operador)
            {
                case "+":
                    resultado = suma(valor1, valor2);
                    break;
                case "-":
                    resultado = resta(valor1, valor2);
                    break;
                case "*":
                    resultado = multiplicacion(valor1, valor2);
                    break;
                case "/":
                    resultado = division(valor1, valor2);
                    break;
            }

            lblResultado.Text = resultado.ToString();
             
        }

        int suma(int uno, int dos)
        {
            int ResultSuma = uno + dos;
            return ResultSuma;
        }

        int resta(int uno, int dos)
        {
            int ResultResta = uno - dos;
            return ResultResta;
        }

        int multiplicacion(int uno, int dos)
        {
            int ResultMulti = uno * dos;
            return ResultMulti;
        }

        int division(int uno, int dos)
        {
            int ResultDivi = uno / dos;
            return ResultDivi;
        }

        private void opSuma_CheckedChanged(object sender, EventArgs e)
        {
             operador = "+";
        }

        private void opResta_CheckedChanged(object sender, EventArgs e)
        {
            operador = "-";
        }

        private void opMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            operador = "*";
        }

        private void opDivision_CheckedChanged(object sender, EventArgs e)
        {
            operador = "/";
        }

    }
}
