using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class EjercicioN3 : UserControl
    {
        public EjercicioN3()
        {
            InitializeComponent();
        }

        double peso;
        double altura;
        double imc;
        public string title;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Datos();
            IMC();
            Condicionar();
        }

        private void Datos()
        {
            try
            {
                txtpeso.Text = txtpeso.Text.Replace(".", ",");
                textaltura.Text = textaltura.Text.Replace(".", ",");
                peso = Convert.ToDouble(txtpeso.Text);
                altura = Convert.ToDouble(textaltura.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void IMC()
        {
            imc = peso / Math.Pow(altura, 2);
            lblimc.Text = imc.ToString("N2");
        }

        private void EjercicioN3_Load(object sender, EventArgs e)
        {
            lblejercicio3.Text = title;
        }

        private void Condicionar()
        {
            if (imc < 18.5)
            {
                lblcondicion.Text = "Por debajo";
            }
            if(imc >=18.5 && imc <= 24.9)
            {
                lblcondicion.Text = "Saludable";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                lblcondicion.Text = "Sobrepeso";
            }
            if (imc >30)
            {
                lblcondicion.Text = "Obecidad";
            }
        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
