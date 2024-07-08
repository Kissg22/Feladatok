namespace UszoVersenyMenuVezerelt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versenytoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenytoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegytoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.versenytoolStripMenuItem2,
            this.eredmenytoolStripMenuItem3,
            this.nevjegytoolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasToolStripMenuItem,
            this.mentesToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "Fájl";
            // 
            // megnyitasToolStripMenuItem
            // 
            this.megnyitasToolStripMenuItem.Name = "megnyitasToolStripMenuItem";
            this.megnyitasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitasToolStripMenuItem.Text = "Megnyitás";
            this.megnyitasToolStripMenuItem.Click += new System.EventHandler(this.megnyitasToolStripMenuItem_Click);
            // 
            // mentesToolStripMenuItem
            // 
            this.mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            this.mentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentesToolStripMenuItem.Text = "Mentés";
            this.mentesToolStripMenuItem.Click += new System.EventHandler(this.mentesToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilepesToolStripMenuItem.Text = "Kilépés";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // versenytoolStripMenuItem2
            // 
            this.versenytoolStripMenuItem2.Name = "versenytoolStripMenuItem2";
            this.versenytoolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.versenytoolStripMenuItem2.Text = "Verseny";
            this.versenytoolStripMenuItem2.Click += new System.EventHandler(this.versenytoolStripMenuItem2_Click);
            // 
            // eredmenytoolStripMenuItem3
            // 
            this.eredmenytoolStripMenuItem3.Name = "eredmenytoolStripMenuItem3";
            this.eredmenytoolStripMenuItem3.Size = new System.Drawing.Size(72, 20);
            this.eredmenytoolStripMenuItem3.Text = "Eredmény";
            this.eredmenytoolStripMenuItem3.Click += new System.EventHandler(this.eredmenytoolStripMenuItem3_Click);
            // 
            // nevjegytoolStripMenuItem4
            // 
            this.nevjegytoolStripMenuItem4.Name = "nevjegytoolStripMenuItem4";
            this.nevjegytoolStripMenuItem4.Size = new System.Drawing.Size(62, 20);
            this.nevjegytoolStripMenuItem4.Text = "Névjegy";
            this.nevjegytoolStripMenuItem4.Click += new System.EventHandler(this.nevjegytoolStripMenuItem4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UszoVersenyMenuVezerelt.Properties.Resources.uszas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 351);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Úszóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem versenytoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eredmenytoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem nevjegytoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem megnyitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

