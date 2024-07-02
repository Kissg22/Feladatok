namespace UszoVerseny
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.txtEletKor = new System.Windows.Forms.TextBox();
            this.rchTxtGyoztes = new System.Windows.Forms.RichTextBox();
            this.txtGyoztesIdo = new System.Windows.Forms.TextBox();
            this.btnGyoztesIdo = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "200 m-es pillangó úszás";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(201, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(201, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ország:";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(12, 134);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(140, 238);
            this.lstVersenyzok.TabIndex = 4;
            this.lstVersenyzok.SelectedIndexChanged += new System.EventHandler(this.lstVersenyzok_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(201, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Időeredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(201, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Életkor:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Enabled = false;
            this.txtRajtszam.Location = new System.Drawing.Point(304, 118);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(95, 20);
            this.txtRajtszam.TabIndex = 7;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Enabled = false;
            this.txtOrszag.Location = new System.Drawing.Point(304, 160);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(95, 20);
            this.txtOrszag.TabIndex = 8;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Enabled = false;
            this.txtIdoEredmeny.Location = new System.Drawing.Point(304, 198);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(95, 20);
            this.txtIdoEredmeny.TabIndex = 9;
            // 
            // txtEletKor
            // 
            this.txtEletKor.Enabled = false;
            this.txtEletKor.Location = new System.Drawing.Point(304, 236);
            this.txtEletKor.Name = "txtEletKor";
            this.txtEletKor.Size = new System.Drawing.Size(95, 20);
            this.txtEletKor.TabIndex = 10;
            // 
            // rchTxtGyoztes
            // 
            this.rchTxtGyoztes.Location = new System.Drawing.Point(204, 310);
            this.rchTxtGyoztes.Name = "rchTxtGyoztes";
            this.rchTxtGyoztes.Size = new System.Drawing.Size(195, 79);
            this.rchTxtGyoztes.TabIndex = 11;
            this.rchTxtGyoztes.Text = "";
            // 
            // txtGyoztesIdo
            // 
            this.txtGyoztesIdo.Enabled = false;
            this.txtGyoztesIdo.Location = new System.Drawing.Point(304, 284);
            this.txtGyoztesIdo.Name = "txtGyoztesIdo";
            this.txtGyoztesIdo.Size = new System.Drawing.Size(95, 20);
            this.txtGyoztesIdo.TabIndex = 12;
            // 
            // btnGyoztesIdo
            // 
            this.btnGyoztesIdo.Location = new System.Drawing.Point(201, 284);
            this.btnGyoztesIdo.Name = "btnGyoztesIdo";
            this.btnGyoztesIdo.Size = new System.Drawing.Size(75, 23);
            this.btnGyoztesIdo.TabIndex = 13;
            this.btnGyoztesIdo.Text = "Győztes";
            this.btnGyoztesIdo.UseVisualStyleBackColor = true;
            this.btnGyoztesIdo.Click += new System.EventHandler(this.btnGyoztesIdo_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(25, 415);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(117, 23);
            this.btnAdatBe.TabIndex = 14;
            this.btnAdatBe.Text = "Adatok beolvasása";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(261, 415);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 15;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnGyoztesIdo);
            this.Controls.Add(this.txtGyoztesIdo);
            this.Controls.Add(this.rchTxtGyoztes);
            this.Controls.Add(this.txtEletKor);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Úszóverseny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.TextBox txtEletKor;
        private System.Windows.Forms.RichTextBox rchTxtGyoztes;
        private System.Windows.Forms.TextBox txtGyoztesIdo;
        private System.Windows.Forms.Button btnGyoztesIdo;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
    }
}

