namespace DatumRaadas
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
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrIdo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(53, 88);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(104, 20);
            this.dtTmPckrDatum.TabIndex = 0;
            this.dtTmPckrDatum.Value = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrIdo.Location = new System.Drawing.Point(203, 88);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.ShowUpDown = true;
            this.dtTmPckrIdo.Size = new System.Drawing.Size(82, 20);
            this.dtTmPckrIdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A találkozó ideje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A találkozó ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuális idő:";
            // 
            // btnErtekel
            // 
            this.btnErtekel.Location = new System.Drawing.Point(38, 253);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(75, 23);
            this.btnErtekel.TabIndex = 5;
            this.btnErtekel.Text = "Értékel";
            this.btnErtekel.UseVisualStyleBackColor = true;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click_1);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(121, 305);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 6;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(203, 253);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 7;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.BackColor = System.Drawing.Color.Transparent;
            this.lblErtekeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.Brown;
            this.lblErtekeles.Location = new System.Drawing.Point(2, 215);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(310, 23);
            this.lblErtekeles.TabIndex = 8;
            this.lblErtekeles.Text = "lblErtekeles";
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Location = new System.Drawing.Point(123, 156);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(35, 13);
            this.lblTalalkozo.TabIndex = 9;
            this.lblTalalkozo.Text = "label3";
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Location = new System.Drawing.Point(123, 187);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(35, 13);
            this.lblAktualis.TabIndex = 10;
            this.lblAktualis.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 359);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnErtekel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.dtTmPckrDatum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Találkozó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.DateTimePicker dtTmPckrIdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label lblAktualis;
    }
}

