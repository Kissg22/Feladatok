namespace ItalLap
{
    partial class Form4
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
            this.richTextBoxSzamla = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxSzamla
            // 
            this.richTextBoxSzamla.Location = new System.Drawing.Point(115, 65);
            this.richTextBoxSzamla.Name = "richTextBoxSzamla";
            this.richTextBoxSzamla.Size = new System.Drawing.Size(420, 332);
            this.richTextBoxSzamla.TabIndex = 0;
            this.richTextBoxSzamla.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.richTextBoxSzamla);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Számla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSzamla;
    }
}