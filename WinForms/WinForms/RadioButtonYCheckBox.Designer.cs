namespace WinForms
{
    partial class RadioButtonYCheckBox
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
            this.lbnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbtnHombre = new System.Windows.Forms.RadioButton();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.checkBProgramadaor = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalida = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(32, 40);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(44, 13);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rdbtnHombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(35, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(294, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Mujer";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbtnHombre
            // 
            this.rdbtnHombre.AutoSize = true;
            this.rdbtnHombre.Checked = true;
            this.rdbtnHombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbtnHombre.Location = new System.Drawing.Point(127, 32);
            this.rdbtnHombre.Name = "rdbtnHombre";
            this.rdbtnHombre.Size = new System.Drawing.Size(62, 17);
            this.rdbtnHombre.TabIndex = 0;
            this.rdbtnHombre.TabStop = true;
            this.rdbtnHombre.Text = "Hombre";
            this.rdbtnHombre.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(114, 32);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(365, 20);
            this.textNombre.TabIndex = 3;
            this.textNombre.Validating += new System.ComponentModel.CancelEventHandler(this.textNombre_Validating);
            // 
            // checkBProgramadaor
            // 
            this.checkBProgramadaor.AutoSize = true;
            this.checkBProgramadaor.Checked = true;
            this.checkBProgramadaor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBProgramadaor.Location = new System.Drawing.Point(114, 72);
            this.checkBProgramadaor.Name = "checkBProgramadaor";
            this.checkBProgramadaor.Size = new System.Drawing.Size(15, 14);
            this.checkBProgramadaor.TabIndex = 4;
            this.checkBProgramadaor.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(495, 29);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salida";
            // 
            // txtSalida
            // 
            this.txtSalida.HideSelection = false;
            this.txtSalida.Location = new System.Drawing.Point(38, 231);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(441, 135);
            this.txtSalida.TabIndex = 7;
            this.txtSalida.UseCompatibleStateImageBehavior = false;
            this.txtSalida.View = System.Windows.Forms.View.List;
            // 
            // RadioButtonYCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 384);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBProgramadaor);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnombre);
            this.Name = "RadioButtonYCheckBox";
            this.Text = "RadioButton y CheckBox";
            this.Load += new System.EventHandler(this.RadioButtonYCheckBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.CheckBox checkBProgramadaor;
        private System.Windows.Forms.RadioButton rdbtnHombre;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView txtSalida;
    }
}