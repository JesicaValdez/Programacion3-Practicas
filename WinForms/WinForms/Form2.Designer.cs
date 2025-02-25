namespace WinForms
{
    partial class ListB
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
            this.clbItems = new System.Windows.Forms.CheckedListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clbItems
            // 
            this.clbItems.CheckOnClick = true;
            this.clbItems.FormattingEnabled = true;
            this.clbItems.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres ",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"});
            this.clbItems.Location = new System.Drawing.Point(13, 13);
            this.clbItems.Name = "clbItems";
            this.clbItems.Size = new System.Drawing.Size(340, 364);
            this.clbItems.TabIndex = 0;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(359, 158);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 1;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(440, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(340, 368);
            this.listBox.TabIndex = 2;
            // 
            // ListB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 394);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.clbItems);
            this.Name = "ListB";
            this.Text = "ListBox y CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbItems;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.ListBox listBox;
    }
}