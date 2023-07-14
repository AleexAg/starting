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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;
        double resultado;
        public string title;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Datos();
            Calculate();
        }

        private void Datos()
        {
            try
            {
                txta.Text = txta.Text.Replace(",", ".");
                textB.Text = textB.Text.Replace(",", ".");
                textC.Text = textC.Text.Replace(",", ".");
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(textB.Text);
                c = Convert.ToDouble(textC.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate()
        {
            resultado = (((c + 5) * (Math.Pow(b, 2) - 3 * a * c)) * Math.Pow(a, 2)) / (4 * a);

            lblresultado.Text = resultado.ToString();
        }


        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = title;
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
