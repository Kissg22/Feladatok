namespace ItalLap
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.italLapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sugoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlMenu,
            this.italLapMenu,
            this.galeriaMenu,
            this.sugoMenu,
            this.nevjegyMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlMenu
            // 
            this.fajlMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasMenu,
            this.mentesMenu,
            this.kilepesMenu});
            this.fajlMenu.Name = "fajlMenu";
            this.fajlMenu.Size = new System.Drawing.Size(37, 20);
            this.fajlMenu.Text = "Fájl";
            // 
            // megnyitasMenu
            // 
            this.megnyitasMenu.Name = "megnyitasMenu";
            this.megnyitasMenu.Size = new System.Drawing.Size(129, 22);
            this.megnyitasMenu.Text = "Megnyitás";
            this.megnyitasMenu.Click += new System.EventHandler(this.megnyitasMenu_Click_1);
            // 
            // mentesMenu
            // 
            this.mentesMenu.Name = "mentesMenu";
            this.mentesMenu.Size = new System.Drawing.Size(129, 22);
            this.mentesMenu.Text = "Mentés";
            this.mentesMenu.Click += new System.EventHandler(this.mentesMenu_Click_1);
            // 
            // kilepesMenu
            // 
            this.kilepesMenu.Name = "kilepesMenu";
            this.kilepesMenu.Size = new System.Drawing.Size(129, 22);
            this.kilepesMenu.Text = "Kilépés";
            this.kilepesMenu.Click += new System.EventHandler(this.kilepesMenu_Click);
            // 
            // italLapMenu
            // 
            this.italLapMenu.Name = "italLapMenu";
            this.italLapMenu.Size = new System.Drawing.Size(54, 20);
            this.italLapMenu.Text = "ItalLap";
            this.italLapMenu.Click += new System.EventHandler(this.italLapMenu_Click);
            // 
            // galeriaMenu
            // 
            this.galeriaMenu.Name = "galeriaMenu";
            this.galeriaMenu.Size = new System.Drawing.Size(55, 20);
            this.galeriaMenu.Text = "Galéria";
            this.galeriaMenu.Click += new System.EventHandler(this.galeriaMenu_Click);
            // 
            // sugoMenu
            // 
            this.sugoMenu.Name = "sugoMenu";
            this.sugoMenu.Size = new System.Drawing.Size(46, 20);
            this.sugoMenu.Text = "Súgó";
            this.sugoMenu.Click += new System.EventHandler(this.sugoMenu_Click);
            // 
            // nevjegyMenu
            // 
            this.nevjegyMenu.Name = "nevjegyMenu";
            this.nevjegyMenu.Size = new System.Drawing.Size(62, 20);
            this.nevjegyMenu.Text = "Névjegy";
            this.nevjegyMenu.Click += new System.EventHandler(this.nevjegyMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ItalLap.Properties.Resources.kocsma;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nyertes kocsma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlMenu;
        private System.Windows.Forms.ToolStripMenuItem italLapMenu;
        private System.Windows.Forms.ToolStripMenuItem megnyitasMenu;
        private System.Windows.Forms.ToolStripMenuItem mentesMenu;
        private System.Windows.Forms.ToolStripMenuItem kilepesMenu;
        private System.Windows.Forms.ToolStripMenuItem galeriaMenu;
        private System.Windows.Forms.ToolStripMenuItem sugoMenu;
        private System.Windows.Forms.ToolStripMenuItem nevjegyMenu;
    }
}

