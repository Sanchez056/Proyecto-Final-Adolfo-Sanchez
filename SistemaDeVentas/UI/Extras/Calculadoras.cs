using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SistemaDeVentas.UI.Extras
{
    public partial class Calculadoras : Form
    {
        public Calculadoras()
        {
            InitializeComponent();
        }

        bool numero=true;
        string operacion;
        double resultado;
        double resultado2;
        double resuMostrar;

        

        private void button21_Click(object sender, EventArgs e)
        {
            

            

        }


        private void Numero1button_Click(object sender, EventArgs e)
        {
            if(numero)
            {
                CampoOperaciontextBox.Text= "";
                CampoOperaciontextBox.Text = "1";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "1";
            }
            

        }

        private void Numero2button_Click(object sender, EventArgs e)
        {


            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "2";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "2";
            }
        }

        private void Numero3button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "3";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "3";
            }
        }

       
        private void Numero4button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "4";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "4";
            }
        }

        private void Numero5button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "5";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "5";
            }
        }
        private void Numero6button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "6";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "6";
            }
        }


       
       

        private void Numero7button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "7";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "7";
            }

        }
        private void Numero8button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "8";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "8";
            }
        }
        private void Numero9button_Click(object sender, EventArgs e)
        {

            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "9";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "9";
            }
        }

        private void Numero0button_Click(object sender, EventArgs e)
        {
            if (numero)
            {
                CampoOperaciontextBox.Text = "";
                CampoOperaciontextBox.Text = "0";
                numero = false;



            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text + "0";
            }

        }

        private void Dividirbutton_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero = true;
            resultado = double.Parse(CampoOperaciontextBox.Text);
        }

        private void Multiplicacionbutton_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero = true;
            resultado = double.Parse(CampoOperaciontextBox.Text);
        
        }

        private void Restabutton_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero = true;
            resultado = double.Parse(CampoOperaciontextBox.Text);
        }

        private void Sumabutton_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero = true;
            resultado = double.Parse(CampoOperaciontextBox.Text);
        }

        private void AlCuadradobutton_Click(object sender, EventArgs e)
        {
          
        }

        private void Raizbutton_Click(object sender, EventArgs e)
        {
            resuMostrar = double.Parse(CampoOperaciontextBox.Text);
            double raiz = Math.Sqrt(resuMostrar);
            CampoOperaciontextBox.Text = raiz.ToString();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            resultado2 = double.Parse(CampoOperaciontextBox.Text);
            numero = true;
            switch (operacion)
            {
                case "+":
                    resuMostrar = resultado + resultado2;
                    CampoOperaciontextBox.Text = resuMostrar.ToString();

                    break;
                case "-":
                    resuMostrar = resultado - resultado2;
                    CampoOperaciontextBox.Text = resuMostrar.ToString();

                    break;
                case "*":
                    resuMostrar = resultado * resultado2;
                    CampoOperaciontextBox.Text = resuMostrar.ToString();

                    break;
                case "/":
                    resuMostrar = resultado / resultado2;
                    CampoOperaciontextBox.Text = resuMostrar.ToString();

                    break;
            }

        }
        private void Cborrarbutton_Click(object sender, EventArgs e)
        {
            if(CampoOperaciontextBox.Text=="0")
            {
                return;
            }
            else
            {
                CampoOperaciontextBox.Text = CampoOperaciontextBox.Text = "0";
            }
            CampoOperaciontextBox.Text = "";
            numero = true;
            CampoOperaciontextBox.Text = "0";
        }

        private void CampoOperaciontextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

