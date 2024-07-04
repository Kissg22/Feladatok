namespace DiakkezeloBResz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.lstKivalasztottak = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkiiras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(399, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Születési év";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 277);
            this.listBox1.TabIndex = 3;
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(76, 406);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 4;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlEvek
            // 
            this.pnlEvek.AutoScroll = true;
            this.pnlEvek.BackColor = System.Drawing.Color.SeaShell;
            this.pnlEvek.Location = new System.Drawing.Point(307, 95);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(333, 66);
            this.pnlEvek.TabIndex = 5;
            // 
            // lstKivalasztottak
            // 
            this.lstKivalasztottak.FormattingEnabled = true;
            this.lstKivalasztottak.Location = new System.Drawing.Point(307, 225);
            this.lstKivalasztottak.Name = "lstKivalasztottak";
            this.lstKivalasztottak.Size = new System.Drawing.Size(333, 147);
            this.lstKivalasztottak.TabIndex = 6;
            this.lstKivalasztottak.SelectedIndexChanged += new System.EventHandler(this.lstKivalasztottak_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "A keresés eredménye:";
            // 
            // lblkiiras
            // 
            this.lblkiiras.AutoSize = true;
            this.lblkiiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblkiiras.Location = new System.Drawing.Point(303, 406);
            this.lblkiiras.Name = "lblkiiras";
            this.lblkiiras.Size = new System.Drawing.Size(14, 20);
            this.lblkiiras.TabIndex = 8;
            this.lblkiiras.Text = "-";
            this.lblkiiras.Click += new System.EventHandler(this.lblkiiras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.lblkiiras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKivalasztottak);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Panel pnlEvek;
        private System.Windows.Forms.ListBox lstKivalasztottak;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkiiras;
    }
}

