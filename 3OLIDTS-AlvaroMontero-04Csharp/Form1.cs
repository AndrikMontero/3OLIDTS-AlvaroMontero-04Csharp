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
using System.Text.RegularExpressions; //Libreria para la validacion de formato de texto

namespace _3OLIDTS_AlvaroMontero_04Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            //Agregar controladores de eventos TextChanged a los campos
            /*tbEdad.TextChanged += ValidarEdad;
            tbEstatura.TextChanged += ValidarEstructura;
            tbTelefono.Leave += ValidarTelefono;
            tbNombre.TextChanged += ValidarNombre;
            tbApellidos.TextChanged += ValidarApellidos;*/

        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
            //return false;
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidode100Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$"); //Solo letras y espacios
        }

        private void ValidaNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre valido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidaApellido(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese apellidos validos (solo letras y espacios).", "Error". )
                textbox.Clear();
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
