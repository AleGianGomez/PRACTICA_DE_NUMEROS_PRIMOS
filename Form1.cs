using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ejemplo_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);

            int suma = Sumar(numero1, numero2);
            int resta = Restar(numero1, numero2);
            int multiplicacion = Multiplicar(numero1, numero2);
            double division = Dividir(numero1, numero2);

            MessageBox.Show($"La suma es: {suma}\n" +
                $"La resta es: {resta}\n" +
                $"La multiplicacion es: {multiplicacion}\n" +
                $"La division es: {division}");
        }

        private double Dividir(int numero1, int numero2)
        {
            return numero1 / (double)numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            //TODO Dado un rango de valores (numero1 - numero2), mostrar en 
            //es un mensaje (MessageBox.Show) los numeros primos dentro el trando
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);

            Primos(numero1, numero2);

        }
        private void Primos(int numero1, int numero2)
        {
            int control = 0;
            string res = "";
            if (numero2 > numero1)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    control = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                control = 1;
                                break;
                            }
                        }
                        if (control == 0)
                        {
                            res = res + i + "-" ;
                        }
                    }
                }
            }
            else if (numero1 > numero2) {
                for (int i = numero2; i <= numero1; i++)
                {
                    control = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                control = 1;
                                break;
                            }
                        }
                        if (control == 0)
                        {
                            res = res + i + "-";
                        }
                    }
                }
            }  
            MessageBox.Show("Los numeros primos en ese intervalo son:\n"+ res);
        }
    }
}
