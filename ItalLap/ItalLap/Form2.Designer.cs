namespace ItalLap
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
            this.components = new System.ComponentModel.Container();
            this.btnRendel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szamlaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlValasztek = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRendel
            // 
            this.btnRendel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRendel.Location = new System.Drawing.Point(232, 484);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(106, 38);
            this.btnRendel.TabIndex = 0;
            this.btnRendel.Text = "Rendel";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szamlaMenu,
            this.fizetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // szamlaMenu
            // 
            this.szamlaMenu.Name = "szamlaMenu";
            this.szamlaMenu.Size = new System.Drawing.Size(134, 22);
            this.szamlaMenu.Text = "Számlát kér";
            this.szamlaMenu.Click += new System.EventHandler(this.szamlaMenu_Click);
            // 
            // fizetToolStripMenuItem
            // 
            this.fizetToolStripMenuItem.Name = "fizetToolStripMenuItem";
            this.fizetToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fizetToolStripMenuItem.Text = "Fizet";
            this.fizetToolStripMenuItem.Click += new System.EventHandler(this.fizetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Árlista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlValasztek
            // 
            this.pnlValasztek.AutoScroll = true;
            this.pnlValasztek.Location = new System.Drawing.Point(83, 99);
            this.pnlValasztek.Name = "pnlValasztek";
            this.pnlValasztek.Size = new System.Drawing.Size(461, 354);
            this.pnlValasztek.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 550);
            this.Controls.Add(this.pnlValasztek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRendel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "ItalLap";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlValasztek;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szamlaMenu;
        private System.Windows.Forms.ToolStripMenuItem fizetToolStripMenuItem;
    }
}