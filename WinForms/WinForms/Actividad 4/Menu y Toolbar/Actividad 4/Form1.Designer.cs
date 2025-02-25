namespace Actividad_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBoxText = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            nuevoToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            guardarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            boldToolStripButton = new ToolStripButton();
            italicToolStripButton = new ToolStripButton();
            underlineToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            fontsToolStripComboBox = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            ayudaToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelText = new ToolStripStatusLabel();
            toolStripStatusLabelBold = new ToolStripStatusLabel();
            toolStripStatusLabelItalic = new ToolStripStatusLabel();
            toolStripStatusLabelUnderline = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxText
            // 
            richTextBoxText.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxText.Location = new Point(0, 52);
            richTextBoxText.Name = "richTextBoxText";
            richTextBoxText.Size = new Size(800, 373);
            richTextBoxText.TabIndex = 0;
            richTextBoxText.Text = "";
            richTextBoxText.TextChanged += richTextBoxText_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "Format";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.CheckOnClick = true;
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(125, 22);
            boldToolStripMenuItem.Text = "Bold";
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.CheckOnClick = true;
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.Size = new Size(125, 22);
            italicToolStripMenuItem.Text = "Italic";
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.CheckOnClick = true;
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.Size = new Size(125, 22);
            underlineToolStripMenuItem.Text = "Underline";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripButton, abrirToolStripButton, guardarToolStripButton, imprimirToolStripButton, toolStripSeparator, boldToolStripButton, italicToolStripButton, underlineToolStripButton, toolStripSeparator1, fontsToolStripComboBox, toolStripSeparator3, ayudaToolStripButton, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(322, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // nuevoToolStripButton
            // 
            nuevoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nuevoToolStripButton.Image = (Image)resources.GetObject("nuevoToolStripButton.Image");
            nuevoToolStripButton.ImageTransparentColor = Color.Magenta;
            nuevoToolStripButton.Name = "nuevoToolStripButton";
            nuevoToolStripButton.Size = new Size(23, 22);
            nuevoToolStripButton.Text = "&Nuevo";
            nuevoToolStripButton.Click += newToolStripMenuItem_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += openToolStripMenuItem_Click;
            // 
            // guardarToolStripButton
            // 
            guardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            guardarToolStripButton.Image = (Image)resources.GetObject("guardarToolStripButton.Image");
            guardarToolStripButton.ImageTransparentColor = Color.Magenta;
            guardarToolStripButton.Name = "guardarToolStripButton";
            guardarToolStripButton.Size = new Size(23, 22);
            guardarToolStripButton.Text = "&Guardar";
            guardarToolStripButton.Click += saveToolStripMenuItem_Click;
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 22);
            imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // boldToolStripButton
            // 
            boldToolStripButton.CheckOnClick = true;
            boldToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldToolStripButton.Image = (Image)resources.GetObject("boldToolStripButton.Image");
            boldToolStripButton.ImageTransparentColor = Color.Magenta;
            boldToolStripButton.Name = "boldToolStripButton";
            boldToolStripButton.Size = new Size(23, 22);
            boldToolStripButton.Text = "Bold";
            boldToolStripButton.CheckedChanged += boldToolStripButton_CheckedChanged;
            // 
            // italicToolStripButton
            // 
            italicToolStripButton.CheckOnClick = true;
            italicToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicToolStripButton.Image = (Image)resources.GetObject("italicToolStripButton.Image");
            italicToolStripButton.ImageTransparentColor = Color.Magenta;
            italicToolStripButton.Name = "italicToolStripButton";
            italicToolStripButton.Size = new Size(23, 22);
            italicToolStripButton.Text = "Italic";
            italicToolStripButton.CheckedChanged += italicToolStripButton_CheckedChanged;
            // 
            // underlineToolStripButton
            // 
            underlineToolStripButton.CheckOnClick = true;
            underlineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineToolStripButton.Image = (Image)resources.GetObject("underlineToolStripButton.Image");
            underlineToolStripButton.ImageTransparentColor = Color.Magenta;
            underlineToolStripButton.Name = "underlineToolStripButton";
            underlineToolStripButton.Size = new Size(23, 22);
            underlineToolStripButton.Text = "Underline";
            underlineToolStripButton.CheckedChanged += underlineToolStripButton_CheckedChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // fontsToolStripComboBox
            // 
            fontsToolStripComboBox.BackColor = SystemColors.Window;
            fontsToolStripComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontsToolStripComboBox.FlatStyle = FlatStyle.System;
            fontsToolStripComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fontsToolStripComboBox.Items.AddRange(new object[] { "MS Sans Serif Times New Roman", "Verdana", "Calibri" });
            fontsToolStripComboBox.Name = "fontsToolStripComboBox";
            fontsToolStripComboBox.Size = new Size(100, 25);
            fontsToolStripComboBox.SelectedIndexChanged += fontsToolStripComboBox_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // ayudaToolStripButton
            // 
            ayudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ayudaToolStripButton.Image = (Image)resources.GetObject("ayudaToolStripButton.Image");
            ayudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ayudaToolStripButton.Name = "ayudaToolStripButton";
            ayudaToolStripButton.Size = new Size(23, 22);
            ayudaToolStripButton.Text = "&Ayuda";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelText, toolStripStatusLabelBold, toolStripStatusLabelItalic, toolStripStatusLabelUnderline });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelText
            // 
            toolStripStatusLabelText.AutoSize = false;
            toolStripStatusLabelText.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabelText.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelText.Name = "toolStripStatusLabelText";
            toolStripStatusLabelText.Size = new Size(259, 17);
            toolStripStatusLabelText.Text = "Clear this property";
            toolStripStatusLabelText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelBold
            // 
            toolStripStatusLabelBold.Enabled = false;
            toolStripStatusLabelBold.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelBold.Image = (Image)resources.GetObject("toolStripStatusLabelBold.Image");
            toolStripStatusLabelBold.Name = "toolStripStatusLabelBold";
            toolStripStatusLabelBold.Size = new Size(47, 17);
            toolStripStatusLabelBold.Text = "Bold";
            // 
            // toolStripStatusLabelItalic
            // 
            toolStripStatusLabelItalic.Enabled = false;
            toolStripStatusLabelItalic.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelItalic.Image = (Image)resources.GetObject("toolStripStatusLabelItalic.Image");
            toolStripStatusLabelItalic.Name = "toolStripStatusLabelItalic";
            toolStripStatusLabelItalic.Size = new Size(48, 17);
            toolStripStatusLabelItalic.Text = "Italic";
            // 
            // toolStripStatusLabelUnderline
            // 
            toolStripStatusLabelUnderline.Enabled = false;
            toolStripStatusLabelUnderline.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelUnderline.Image = (Image)resources.GetObject("toolStripStatusLabelUnderline.Image");
            toolStripStatusLabelUnderline.Name = "toolStripStatusLabelUnderline";
            toolStripStatusLabelUnderline.Size = new Size(76, 17);
            toolStripStatusLabelUnderline.Text = "Underline";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBoxText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripButton nuevoToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton guardarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton boldToolStripButton;
        private ToolStripButton italicToolStripButton;
        private ToolStripButton underlineToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ayudaToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripComboBox fontsToolStripComboBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelText;
        private ToolStripStatusLabel toolStripStatusLabelBold;
        private ToolStripStatusLabel toolStripStatusLabelItalic;
        private ToolStripStatusLabel toolStripStatusLabelUnderline;
    }
}
