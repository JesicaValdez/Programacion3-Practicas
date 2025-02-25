namespace WinForms
{
    partial class Form1
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
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnCentrado = new System.Windows.Forms.Button();
            this.lbFuente = new System.Windows.Forms.Label();
            this.txtBFuente = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNegrita
            // 
            this.btnNegrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNegrita.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNegrita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNegrita.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNegrita.Location = new System.Drawing.Point(44, 27);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 23);
            this.btnNegrita.TabIndex = 0;
            this.btnNegrita.Text = "Negrita";
            this.btnNegrita.UseVisualStyleBackColor = false;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubrayado.Location = new System.Drawing.Point(168, 27);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 23);
            this.btnSubrayado.TabIndex = 1;
            this.btnSubrayado.Text = "Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = true;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCursiva.Location = new System.Drawing.Point(289, 27);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 23);
            this.btnCursiva.TabIndex = 2;
            this.btnCursiva.Text = "Cursiva";
            this.btnCursiva.UseVisualStyleBackColor = true;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnCentrado
            // 
            this.btnCentrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCentrado.Location = new System.Drawing.Point(412, 27);
            this.btnCentrado.Name = "btnCentrado";
            this.btnCentrado.Size = new System.Drawing.Size(75, 23);
            this.btnCentrado.TabIndex = 3;
            this.btnCentrado.Text = "Centrado";
            this.btnCentrado.UseVisualStyleBackColor = true;
            this.btnCentrado.Click += new System.EventHandler(this.btnCentrado_Click);
            // 
            // lbFuente
            // 
            this.lbFuente.AutoSize = true;
            this.lbFuente.Location = new System.Drawing.Point(181, 89);
            this.lbFuente.Name = "lbFuente";
            this.lbFuente.Size = new System.Drawing.Size(82, 13);
            this.lbFuente.TabIndex = 4;
            this.lbFuente.Text = "Tamaño Fuente";
            // 
            // txtBFuente
            // 
            this.txtBFuente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBFuente.Location = new System.Drawing.Point(270, 81);
            this.txtBFuente.MaxLength = 2;
            this.txtBFuente.Name = "txtBFuente";
            this.txtBFuente.Size = new System.Drawing.Size(67, 20);
            this.txtBFuente.TabIndex = 5;
            this.txtBFuente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBFuente_KeyPress);
            this.txtBFuente.Validated += new System.EventHandler(this.txtBFuente_Validated);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 107);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(588, 429);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox_LinkClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(188, 542);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbrir.Location = new System.Drawing.Point(313, 542);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 589);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.txtBFuente);
            this.Controls.Add(this.lbFuente);
            this.Controls.Add(this.btnCentrado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnNegrita);
            this.MinimumSize = new System.Drawing.Size(402, 628);
            this.Name = "Form1";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnCentrado;
        private System.Windows.Forms.Label lbFuente;
        private System.Windows.Forms.TextBox txtBFuente;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrir;
    }
}