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
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void Practica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Goodbye World!");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparó el evento click del botón Enviar", "Atención");
            //this.BackColor = Color.Red;

            if (txtBnombre.Text == "")
                txtBnombre.BackColor = Color.Red;
            else 
                txtBnombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void Practica1_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Presiono el botón Derecho", "Atención");
            }
            else if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presiono el botón central", "Atención");
            }


        }

        private void lbFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            lbFormulario.BackColor = Color.Cyan;
            lbFormulario.Cursor = Cursors.Hand;
        }

        private void lbFormulario_MouseLeave(object sender, EventArgs e)
        {
            lbFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lbFormulario.Cursor = Cursors.Default;
        }

        private void txtBnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48 || e.KeyChar >57) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
