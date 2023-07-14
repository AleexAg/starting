using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        double radio;
        double area;
        double pi = Math.PI;
        double longitud;
        public string title;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            AsignacionDatos();
            Radio();
            Longitud();
        }

        private void AsignacionDatos()
        {
            try
            {
                txtarea.Text = txtarea.Text.Replace(".", ",");
                area = Convert.ToDouble(txtarea.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Radio()
        {
            radio = Math.Sqrt(area / pi);

            lblradio1.Text = radio.ToString(("N2"));
            lblradio2.Text = radio.ToString("N2");
            lblresultradio.Text = radio.ToString("N2");
        }

        private void Longitud()
        {
            longitud = 2 * pi * radio;
            lblresultlong.Text = longitud.ToString("N2");
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblejercicio2.Text = title;
        }

        private void lblejercicio_Click(object sender, EventArgs e)
        {

        }
    }
}
