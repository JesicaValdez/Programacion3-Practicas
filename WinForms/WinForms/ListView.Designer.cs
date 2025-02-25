namespace WinForms
{
    partial class frmListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.rdbDetalle = new System.Windows.Forms.RadioButton();
            this.rdbList = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActualdir = new System.Windows.Forms.Label();
            this.lvCarpetas = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTitulo);
            this.groupBox1.Controls.Add(this.rdbDetalle);
            this.groupBox1.Controls.Add(this.rdbList);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(524, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de Vista";
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.Location = new System.Drawing.Point(33, 187);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(51, 17);
            this.rdbTitulo.TabIndex = 4;
            this.rdbTitulo.Text = "Titulo";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            // 
            // rdbDetalle
            // 
            this.rdbDetalle.AutoSize = true;
            this.rdbDetalle.Location = new System.Drawing.Point(33, 153);
            this.rdbDetalle.Name = "rdbDetalle";
            this.rdbDetalle.Size = new System.Drawing.Size(58, 17);
            this.rdbDetalle.TabIndex = 3;
            this.rdbDetalle.Text = "Detalle";
            this.rdbDetalle.UseVisualStyleBackColor = true;
            this.rdbDetalle.CheckedChanged += new System.EventHandler(this.rdbDetalle_CheckedChanged);
            // 
            // rdbList
            // 
            this.rdbList.AutoSize = true;
            this.rdbList.Location = new System.Drawing.Point(33, 120);
            this.rdbList.Name = "rdbList";
            this.rdbList.Size = new System.Drawing.Size(47, 17);
            this.rdbList.TabIndex = 2;
            this.rdbList.Text = "Lista";
            this.rdbList.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "SmallIcon";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LargeIcon";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblActualdir
            // 
            this.lblActualdir.Location = new System.Drawing.Point(13, 13);
            this.lblActualdir.Name = "lblActualdir";
            this.lblActualdir.Size = new System.Drawing.Size(496, 23);
            this.lblActualdir.TabIndex = 2;
            this.lblActualdir.Text = "Directorio Actual";
            // 
            // lvCarpetas
            // 
            this.lvCarpetas.HideSelection = false;
            this.lvCarpetas.LargeImageList = this.imageListLarge;
            this.lvCarpetas.Location = new System.Drawing.Point(16, 27);
            this.lvCarpetas.Name = "lvCarpetas";
            this.lvCarpetas.Size = new System.Drawing.Size(493, 292);
            this.lvCarpetas.SmallImageList = this.imageListSmall;
            this.lvCarpetas.TabIndex = 3;
            this.lvCarpetas.UseCompatibleStateImageBehavior = false;
            this.lvCarpetas.View = System.Windows.Forms.View.Details;
            this.lvCarpetas.ItemActivate += new System.EventHandler(this.lvCarpetas_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Laboratorio III.png");
            this.imageListLarge.Images.SetKeyName(1, "Programacion III.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Laboratorio II.png");
            this.imageListSmall.Images.SetKeyName(1, "Programación II.png");
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 369);
            this.Controls.Add(this.lvCarpetas);
            this.Controls.Add(this.lblActualdir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListView";
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblActualdir;
        private System.Windows.Forms.ListView lvCarpetas;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.RadioButton rdbDetalle;
        private System.Windows.Forms.RadioButton rdbList;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}