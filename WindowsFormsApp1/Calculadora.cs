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
    public partial class Calculadora : Form
    {
        double primeiro;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }


        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void tbxScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMutiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primeiro), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;

                case "-":
                    Res = obj2.Restar((primeiro), (segundo));
                    tbxScreen.Text = Res.ToString();
                    break;

                case "*":
                    Mul = obj3.Multiplicar((primeiro), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;

                case "/":
                    Div = obj4.Dividir((primeiro), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
       
            operador = "/";
            primeiro = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }
    }
}
