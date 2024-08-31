namespace WinForm
{
    partial class Form2
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
            this.lbapellido = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.lbresultado = new System.Windows.Forms.Label();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.listResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellido.Location = new System.Drawing.Point(21, 20);
            this.lbapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(64, 13);
            this.lbapellido.TabIndex = 0;
            this.lbapellido.Text = "APELLIDO";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(21, 46);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(56, 13);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "NOMBRE";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(21, 72);
            this.lbedad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(40, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "EDAD";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.Location = new System.Drawing.Point(21, 100);
            this.lbdireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(76, 13);
            this.lbdireccion.TabIndex = 3;
            this.lbdireccion.Text = "DIRECCION";
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(21, 146);
            this.lbresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(82, 13);
            this.lbresultado.TabIndex = 4;
            this.lbresultado.Text = "RESULTADO";
            // 
            // tbapellido
            // 
            this.tbapellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbapellido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbapellido.Location = new System.Drawing.Point(105, 12);
            this.tbapellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(530, 21);
            this.tbapellido.TabIndex = 5;
            this.tbapellido.TextChanged += new System.EventHandler(this.tbapellido_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(230, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(361, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(105, 38);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(530, 21);
            this.tbnombre.TabIndex = 9;
            this.tbnombre.TextChanged += new System.EventHandler(this.tbnombre_TextChanged);
            // 
            // tbedad
            // 
            this.tbedad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbedad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbedad.Location = new System.Drawing.Point(105, 66);
            this.tbedad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(49, 21);
            this.tbedad.TabIndex = 10;
            this.tbedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbedad_KeyPress);
            // 
            // tbdireccion
            // 
            this.tbdireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbdireccion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdireccion.Location = new System.Drawing.Point(105, 93);
            this.tbdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(530, 21);
            this.tbdireccion.TabIndex = 11;
            // 
            // listResultado
            // 
            this.listResultado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultado.FormattingEnabled = true;
            this.listResultado.Location = new System.Drawing.Point(25, 162);
            this.listResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(610, 160);
            this.listResultado.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.listResultado);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbapellido);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.ListBox listResultado;
    }
}