using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido! Ingresando al formulario... ");
        }

        private void tbapellido_TextChanged(object sender, EventArgs e)
        {
            //logica para que solo se ingresen letras:
            if (System.Text.RegularExpressions.Regex.IsMatch(tbapellido.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Por favor, ingrese solo letras.");
                tbapellido.Text = tbapellido.Text.Remove(tbapellido.Text.Length - 1);
            }
            //codigo para que el texto ingresado se convierta en mayusculas:
            tbapellido.CharacterCasing = CharacterCasing.Upper;


        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {
            //logica para que solo se ingresen letras:
            if (System.Text.RegularExpressions.Regex.IsMatch(tbnombre.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Por favor, ingrese solo letras.");
                tbnombre.Text = tbnombre.Text.Remove(tbnombre.Text.Length - 1);
            }
            //codigo para que el texto ingresado se convierta en mayusculas:
            tbnombre.CharacterCasing = CharacterCasing.Upper;

        }

        private void tbedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbapellido.Text == "" || tbnombre.Text == "" || tbedad.Text == "" || tbdireccion.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string apellido = tbapellido.Text;
            listResultado.Items.Add("Apellido: " + apellido);
            string nombre = tbnombre.Text;
            listResultado.Items.Add("Nombre: " + nombre);
            string edad = tbedad.Text;
            listResultado.Items.Add("Edad: " + edad);
            string direccion = tbdireccion.Text;
            listResultado.Items.Add("Direccion: " + direccion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        

       




        

        
    
}
