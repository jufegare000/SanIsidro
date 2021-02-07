using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioHospital2.Formularios.Pacientes
{
    public partial class RegitrarPaciente : Form
    {
        public RegitrarPaciente()
        {
            InitializeComponent();
        }

        private void txtPermanenciaEnMeses_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtPermanenciaEnMeses.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrse solo números enteros porfavor");
                txtPermanenciaEnMeses.Text = txtPermanenciaEnMeses.Text.Remove(txtPermanenciaEnMeses.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dblPeso = Double.Parse(txtPeso.Text);
            double dblEstatura = Double.Parse(txtEstatura.Text);
            double dblEdad = Double.Parse(txtEdad.Text);

            if(dblPeso < 0.0)
            {
                MessageBox.Show("Ingrese un valor para PESO válido separando la parte real por un punto");
            }else if (dblEstatura < 0.0)
            {
                MessageBox.Show("Ingrese un valor para ESTATURA válido separando la parte real por un punto");
            }
            else if (dblEdad < 0.0)
            {
                MessageBox.Show("Ingrese un valor para EDAD válido");
            }
            else
            {
                calcularImc(dblPeso, dblEstatura, dblEdad);
            }
        }

        public void calcularImc(double peso, double estatura, double edad)
        {
            double imc = peso / (estatura * edad);
            double imcm = 10 * peso + (6.25 * estatura) - 5 * edad - 161;
            double imch = (10 * peso) + (6.25 * estatura) - (5 * edad) + 5;
            string clasificacion = "";

            if (imc < 16)
                clasificacion = "Infrapeso, delgadez severa";
            else if (imc >= 16 & imc < 17)
                clasificacion = "Infrapeso, delgadez moderada";
            else if (imc >= 17 & imc < 18.5)
                clasificacion = "Infrapeso, delgadez aceptable";
            else if (imc >= 18.5 & imc < 25)
                clasificacion = "Peso normal";
            else if (imc >= 25 & imc < 30)
                clasificacion = "Sobrepeso";
            else if (imc >= 30 & imc < 35)
                clasificacion = "Obeso tipo I";
            else if (imc >= 35 & imc < 40)
                clasificacion = "Obeso tipo II";
            else
                clasificacion = "Obeso tipo III";

            lbllIMCDescripcion.Text = clasificacion;
            lblIMC.Text =  Convert.ToString(imc);
            lblIMCM.Text = Convert.ToString(imcm);
            lblIMCH.Text = Convert.ToString(imch);
        }
    }
}
