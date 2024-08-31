namespace WinForm
{
    partial class Practica1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbFormulario = new System.Windows.Forms.Label();
            this.txtBnombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnviar.Location = new System.Drawing.Point(255, 211);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbFormulario
            // 
            this.lbFormulario.AutoSize = true;
            this.lbFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFormulario.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormulario.ForeColor = System.Drawing.SystemColors.Control;
            this.lbFormulario.Location = new System.Drawing.Point(59, 32);
            this.lbFormulario.Name = "lbFormulario";
            this.lbFormulario.Size = new System.Drawing.Size(81, 20);
            this.lbFormulario.TabIndex = 1;
            this.lbFormulario.Text = "Formulario";
            this.lbFormulario.MouseLeave += new System.EventHandler(this.lbFormulario_MouseLeave);
            this.lbFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbFormulario_MouseMove);
            // 
            // txtBnombre
            // 
            this.txtBnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBnombre.Location = new System.Drawing.Point(240, 95);
            this.txtBnombre.MaxLength = 30;
            this.txtBnombre.Name = "txtBnombre";
            this.txtBnombre.Size = new System.Drawing.Size(100, 20);
            this.txtBnombre.TabIndex = 2;
            this.txtBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBnombre_KeyPress);
            // 
            // Practica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 377);
            this.Controls.Add(this.txtBnombre);
            this.Controls.Add(this.lbFormulario);
            this.Controls.Add(this.btnEnviar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Practica1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Practica1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Practica1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbFormulario;
        private System.Windows.Forms.TextBox txtBnombre;
    }
}