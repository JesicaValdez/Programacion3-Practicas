using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RadioButtonYCheckBox : Form
    {
        public RadioButtonYCheckBox()
        {
            InitializeComponent();
        }

        private void ValidarOK()
        {
            //Habilita el Botón, siempre y cuando txtNombre tenga datos.
            btnOK.Enabled = (textNombre.BackColor != Color.Red);
        }


        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
         
            TextBox tb = (TextBox)sender;
            
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
            }

            ValidarOK();
        }

        private void RadioButtonYCheckBox_Load(object sender, EventArgs e)
        {
            //Deshabilito el Botón Ok.
            btnOK.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Botón esta Habilitado es porque los datos son correctos.

            String salida; //Variable que almacenará la salida.

            salida = "Nombre: " + textNombre.Text + "\r\n"; //Agrego el nombre.
            salida += " Ocupacion: " + (string) (checkBProgramadaor.Checked ? "Programador" : "No Programador") + "\r\n"; //Agrego la ocupación.
            salida += " Sexo: " + (string) (rdbtnHombre.Checked ? "Masculino" : "Femenino") + "\r\n"; //Agrego el sexo.

            //Muestro la salida.
            txtSalida.Items.Add(salida);
        }
    }
}
