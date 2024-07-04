namespace Diakkezelo
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
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlDiakok = new System.Windows.Forms.Panel();
            this.lstKivalasztottak = new System.Windows.Forms.ListBox();
            this.lstLegidosebbek = new System.Windows.Forms.ListBox();
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
            this.label1.Location = new System.Drawing.Point(122, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Blackadder ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(490, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiválasztottak";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(41, 388);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 2;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Location = new System.Drawing.Point(228, 388);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 3;
            this.btnKivalaszt.Text = "Kiválasztás";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlDiakok
            // 
            this.pnlDiakok.AutoScroll = true;
            this.pnlDiakok.BackColor = System.Drawing.Color.Bisque;
            this.pnlDiakok.Location = new System.Drawing.Point(41, 124);
            this.pnlDiakok.Name = "pnlDiakok";
            this.pnlDiakok.Size = new System.Drawing.Size(262, 246);
            this.pnlDiakok.TabIndex = 4;
            // 
            // lstKivalasztottak
            // 
            this.lstKivalasztottak.FormattingEnabled = true;
            this.lstKivalasztottak.Location = new System.Drawing.Point(460, 124);
            this.lstKivalasztottak.Name = "lstKivalasztottak";
            this.lstKivalasztottak.Size = new System.Drawing.Size(250, 95);
            this.lstKivalasztottak.TabIndex = 5;
            // 
            // lstLegidosebbek
            // 
            this.lstLegidosebbek.FormattingEnabled = true;
            this.lstLegidosebbek.Location = new System.Drawing.Point(460, 275);
            this.lstLegidosebbek.Name = "lstLegidosebbek";
            this.lstLegidosebbek.Size = new System.Drawing.Size(250, 95);
            this.lstLegidosebbek.TabIndex = 6;
            this.lstLegidosebbek.SelectedIndexChanged += new System.EventHandler(this.lstLegidosebbek_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(457, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Legidősebbek:";
            // 
            // lblkiiras
            // 
            this.lblkiiras.AutoSize = true;
            this.lblkiiras.Location = new System.Drawing.Point(457, 413);
            this.lblkiiras.Name = "lblkiiras";
            this.lblkiiras.Size = new System.Drawing.Size(10, 13);
            this.lblkiiras.TabIndex = 8;
            this.lblkiiras.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.lblkiiras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLegidosebbek);
            this.Controls.Add(this.lstKivalasztottak);
            this.Controls.Add(this.pnlDiakok);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlDiakok;
        private System.Windows.Forms.ListBox lstKivalasztottak;
        private System.Windows.Forms.ListBox lstLegidosebbek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkiiras;
    }
}

