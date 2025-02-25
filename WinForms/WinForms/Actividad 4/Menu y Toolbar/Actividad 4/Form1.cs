
namespace Actividad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontsToolStripComboBox.SelectedIndex = 0;
        }

        private void showHelpMenúToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            helpToolStripMenuItem.Visible = item.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile("Example.rtf");
            }
            catch { }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile(@"Example.rtf");
            }
            catch { }
        }

        private void boldToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            boldToolStripMenuItem.CheckedChanged -= new
            EventHandler(boldToolStripButton_CheckedChanged);
            boldToolStripMenuItem.Checked = checkState;
            boldToolStripMenuItem.CheckedChanged += new
            EventHandler(boldToolStripButton_CheckedChanged);


            boldToolStripButton.Checked = boldToolStripMenuItem.Checked;


            toolStripStatusLabelBold.Enabled = checkState;

        }

        private void italicToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            italicToolStripMenuItem.CheckedChanged -= new
            EventHandler(italicToolStripButton_CheckedChanged);
            italicToolStripMenuItem.Checked = checkState;
            italicToolStripMenuItem.CheckedChanged += new
            EventHandler(italicToolStripButton_CheckedChanged);

            italicToolStripButton.Checked = italicToolStripMenuItem.Checked;

            toolStripStatusLabelItalic.Enabled = checkState;
        }

        private void underlineToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            bool checkState = ((ToolStripButton)sender).Checked;
            oldFont = this.richTextBoxText.SelectionFont;
            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            richTextBoxText.SelectionFont = newFont;
            richTextBoxText.Focus();
            underlineToolStripMenuItem.CheckedChanged -= new
            EventHandler(underlineToolStripButton_CheckedChanged);
            underlineToolStripMenuItem.Checked = checkState;
            underlineToolStripMenuItem.CheckedChanged += new
            EventHandler(underlineToolStripButton_CheckedChanged);

            underlineToolStripButton.Checked = underlineToolStripMenuItem.Checked;

            toolStripStatusLabelUnderline.Enabled = checkState;
        }

        private void fontsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            Font newFont = null;

            if (richTextBoxText.SelectionFont == null)
            {
                newFont = new Font(text, richTextBoxText.Font.Size);
            }
            else
            {
                newFont = new Font(text, richTextBoxText.SelectionFont.Size,
                richTextBoxText.SelectionFont.Style);
                richTextBoxText.SelectionFont = newFont;
            }
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelText.Text = "Number of characters: " +
            richTextBoxText.Text.Length;
        }
    }
}
