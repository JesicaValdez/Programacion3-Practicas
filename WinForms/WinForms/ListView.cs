using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForms
{
    public partial class frmListView : Form
    {
        private System.Collections.Specialized.StringCollection carpetacol;
        public frmListView()
        {
            InitializeComponent();
            carpetacol = new System.Collections.Specialized.StringCollection();
            CrearCabecerayLlenarListView();
            DibujarListView(@"C:\");
            carpetacol.Add(@"C:\");
        }

        private void CrearCabecerayLlenarListView()
        {
            ColumnHeader colCab; //Declaro un objeto ColumnHeader.
            colCab = new ColumnHeader(); //Instancio el objeto ColumnHeader.
            colCab.Text = "Nombre Archivo";
            lvCarpetas.Columns.Add(colCab); // Inserto la Cabecera Nombre Archivo.
            colCab = new ColumnHeader();
            colCab.Text = "Tamaño";
            lvCarpetas.Columns.Add(colCab); // Inserto la Cabecera Tamaño.
            colCab = new ColumnHeader();
            colCab.Text = "Ultima Modificacion";
            lvCarpetas.Columns.Add(colCab); // Inserto la Cabecera Ultima Modificacion.
        }

        private void DibujarListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root))
                    return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                lvCarpetas.Items.Clear();
                lblActualdir.Text = root;
                lvCarpetas.BeginUpdate();
                
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvCarpetas.Items.Add(lvi);
                }
                
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvCarpetas.Items.Add(lvi);
                }
                lvCarpetas.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }


        private void lvCarpetas_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                DibujarListView(filename);
                carpetacol.Add(filename);
            }

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvCarpetas.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                lvCarpetas.View = View.SmallIcon;
        }

        private void rdbList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                lvCarpetas.View = View.List;
        }

        private void rdbDetalle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                lvCarpetas.View = View.Details;
        }

        private void rdbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                lvCarpetas.View = View.Tile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //al hacer click en el boton redirige a la direccion anterior:
            if (carpetacol.Count > 1)
            {
                carpetacol.RemoveAt(carpetacol.Count - 1);
                DibujarListView(carpetacol[carpetacol.Count - 1]);
            }
            else {
                MessageBox.Show("No hay mas directorios anteriores");
            }
        }
    }
}
