using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Libreria para lectura y escritura de archivos

namespace _3OLIDTS_AlvaroMontero_04Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbApellidos_Click(object sender, EventArgs e)
        {

        }

        private void lbTelefono_Click(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEstatura_Click(object sender, EventArgs e)
        {

        }

        private void tbEstatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEdad_Click(object sender, EventArgs e)
        {

        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
         //Codigo para funcionalidad del boton limpiar, borra todo
            tbApellidos.Clear();
            tbEdad.Clear(); 
            tbNombre.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
         //Codigo para funcionalidad del boton guardar, guarda lo de los textbox
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;
            string genero = "";
            if(rbFemenino.Checked)
            {
                genero = "Femenino";
            } else if(rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            string datos = $"Nombre : {nombres}\n\rApellidos :  {apellidos}\r\n" +
                $"Edad : {edad}\r\nEstatura : {estatura}\r\nTelefono : {telefono}\r\n" +
                $"Genero : {genero}\r\n";
            string ruta ="C:\\Users\\KatPC\\Documents\\Tareastercersemestre\\3OLIDTS2025.txt";
            //string ruta = @"C:\Users\KatPC\Documents\Tareastercersemestre\3OLIDTS2025.txt";
            bool archivoExiste = File.Exists(ruta);
            using (StreamWriter writer = new StreamWriter(ruta, true)) 
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show(datos, "Valores ingresados",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
