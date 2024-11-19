using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            if((!rdbtnUrgente.Checked && !rdbtnOrdinario.Checked))
            {
                MessageBox.Show("Por favor, seleccione el tipo de telegrama");
                return;
            }
            // telegrama urgente?
            if (rdbtnUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            //Obtengo el número de palabras que forma el telegrama
            string[] palabras = textoTelegrama.Split(' '); 
            //Separa las palabras y las introduce en una estructura
            numPalabras = palabras.Length; 
            //Obtiene la longitud de la estructura, que será el número de palabras
            //Si el telegrama es ordinario
            if (rdbtnOrdinario.Checked)
            {
                tipoTelegrama = ' ';
                if (numPalabras <= 10)
                {
                    coste = 3;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else 
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 6 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}