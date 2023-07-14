using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoCsharp.Ejercicios;

namespace CursoCsharp.Ejercicios
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void Ejercicio1()
        {
            panelvisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.title = button1.Text;
            ctl.Dock = DockStyle.Fill;
            panelvisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            panelvisor.Controls.Clear();
            Ejercicio2 ctl = new Ejercicio2();
            ctl.title = btnEj2.Text;
            ctl.Dock = DockStyle.Fill;
            panelvisor.Controls.Add(ctl);
            ctl.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            panelvisor.Controls.Clear();
            EjercicioN3 ctl = new EjercicioN3();
            ctl.title = btnej3.Text;
            ctl.Dock = DockStyle.Fill;
            panelvisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
