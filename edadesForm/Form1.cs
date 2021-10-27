using System;
using System.Windows.Forms;

namespace edadesForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //proceso de variable
            String nombres, apellido;
            nombres = txtNombres.Text.ToUpper();
            apellido = txtApellidos.Text.ToUpper();

            int edad = DateTime.Now.Year - dateEdad.Value.Year;

            //agregamos edad..
            DateTime nacimientoAhora = dateEdad.Value.AddYears(edad);

            //Condicional la cual decrementa en 1...
            if (DateTime.Now.CompareTo(nacimientoAhora) > 0)
            {
                edad = edad - 1 + 1;

            }

            else
            {
                edad = edad - 1;
            }

            txtedad.Text = Convert.ToString("La edad es:" + edad);

            txtn.Text = Convert.ToString("El nombre completo es: " + nombres + " " + apellido + " ");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtn.Text = " ";
            txtedad.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
