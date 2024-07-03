namespace PizzeriaKG
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
            this.pnlkozponti = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadatBe = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFizetendo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlkozponti
            // 
            this.pnlkozponti.AutoScroll = true;
            this.pnlkozponti.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlkozponti.Location = new System.Drawing.Point(35, 92);
            this.pnlkozponti.Name = "pnlkozponti";
            this.pnlkozponti.Size = new System.Drawing.Size(677, 245);
            this.pnlkozponti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(214, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENÜVÁLASZTÉK";
            // 
            // btnadatBe
            // 
            this.btnadatBe.Location = new System.Drawing.Point(260, 415);
            this.btnadatBe.Name = "btnadatBe";
            this.btnadatBe.Size = new System.Drawing.Size(183, 23);
            this.btnadatBe.TabIndex = 2;
            this.btnadatBe.Text = "Adatbevitel";
            this.btnadatBe.UseVisualStyleBackColor = true;
            this.btnadatBe.Click += new System.EventHandler(this.btnadatBe_Click);
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(35, 365);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(85, 23);
            this.btnSzamol.TabIndex = 3;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(35, 415);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(85, 23);
            this.btnTorol.TabIndex = 4;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(613, 415);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(99, 23);
            this.btnBezar.TabIndex = 5;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(176, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fizetendő:";
            // 
            // txtFizetendo
            // 
            this.txtFizetendo.Location = new System.Drawing.Point(313, 365);
            this.txtFizetendo.Name = "txtFizetendo";
            this.txtFizetendo.Size = new System.Drawing.Size(100, 20);
            this.txtFizetendo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = global::PizzeriaKG.Properties.Resources.pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.txtFizetendo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.btnadatBe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlkozponti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlkozponti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadatBe;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFizetendo;
    }
}

