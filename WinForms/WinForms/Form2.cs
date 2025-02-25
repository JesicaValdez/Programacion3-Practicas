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
    public partial class ListB : Form
    {
        public ListB()
        {
            InitializeComponent();

            //Con el método Add agregamos un ultimo Ítem a la
            //Colección de Ítems. Como parámetro la cadena de caracteres.
            listBox.Items.Add("Diez");
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            //Pregunta si la cantidad (Count) de elementos chequeados
            //en la colección de ítems chequeados(CheckedItems) es mayor a cero.
            if (clbItems.CheckedItems.Count > 0)
            {
                //Si es mayor a cero. Limpia los Ítem en el ListBox.
                listBox.Items.Clear();

                //La sentencia foreach recorre la colección de Ítems Seleccionados
                //Y los asigna de a uno a la variable ítem del tipo String.
                foreach (string item in clbItems.CheckedItems)
                {
                    //Agrega el ítem al ListBox.
                    listBox.Items.Add(item.ToString());
                }

                //Recorro todos los Ítems del CheckedListBox.
                for (int i = 0; i < clbItems.Items.Count; i++)
                    //Con el Método SetItemChecked, establezco en falso la
                    //casilla de verificación (No esta seleccionado).
                    //Como parámetros i-El índice y el valor de estado en este caso false.
                    clbItems.SetItemChecked(i, false);
            }
        }
    }
}
