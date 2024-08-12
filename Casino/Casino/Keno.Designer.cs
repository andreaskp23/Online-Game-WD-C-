
namespace Casino
{
    partial class Keno
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
            this.btsubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.coinlabel = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.angka5 = new System.Windows.Forms.NumericUpDown();
            this.angka6 = new System.Windows.Forms.NumericUpDown();
            this.angka7 = new System.Windows.Forms.NumericUpDown();
            this.angka8 = new System.Windows.Forms.NumericUpDown();
            this.angka4 = new System.Windows.Forms.NumericUpDown();
            this.angka3 = new System.Windows.Forms.NumericUpDown();
            this.angka2 = new System.Windows.Forms.NumericUpDown();
            this.angka1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.coinlabel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angka5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka1)).BeginInit();
            this.SuspendLayout();
            // 
            // btsubmit
            // 
            this.btsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubmit.Location = new System.Drawing.Point(43, 149);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(192, 60);
            this.btsubmit.TabIndex = 10;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Coins :";
            // 
            // coinlabel
            // 
            this.coinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinlabel.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.coinlabel.Location = new System.Drawing.Point(44, 584);
            this.coinlabel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.coinlabel.Name = "coinlabel";
            this.coinlabel.ReadOnly = true;
            this.coinlabel.Size = new System.Drawing.Size(178, 34);
            this.coinlabel.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(43, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 60);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.angka5);
            this.panel1.Controls.Add(this.angka6);
            this.panel1.Controls.Add(this.angka7);
            this.panel1.Controls.Add(this.angka8);
            this.panel1.Controls.Add(this.angka4);
            this.panel1.Controls.Add(this.angka3);
            this.panel1.Controls.Add(this.angka2);
            this.panel1.Controls.Add(this.angka1);
            this.panel1.Location = new System.Drawing.Point(285, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 836);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPU\'s Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "User\'s Number";
            // 
            // angka5
            // 
            this.angka5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka5.Location = new System.Drawing.Point(750, 178);
            this.angka5.Name = "angka5";
            this.angka5.Size = new System.Drawing.Size(120, 75);
            this.angka5.TabIndex = 7;
            // 
            // angka6
            // 
            this.angka6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka6.Location = new System.Drawing.Point(557, 207);
            this.angka6.Name = "angka6";
            this.angka6.Size = new System.Drawing.Size(120, 75);
            this.angka6.TabIndex = 6;
            // 
            // angka7
            // 
            this.angka7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka7.Location = new System.Drawing.Point(366, 207);
            this.angka7.Name = "angka7";
            this.angka7.Size = new System.Drawing.Size(120, 75);
            this.angka7.TabIndex = 5;
            // 
            // angka8
            // 
            this.angka8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka8.Location = new System.Drawing.Point(183, 178);
            this.angka8.Name = "angka8";
            this.angka8.Size = new System.Drawing.Size(120, 75);
            this.angka8.TabIndex = 4;
            // 
            // angka4
            // 
            this.angka4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka4.Location = new System.Drawing.Point(750, 537);
            this.angka4.Name = "angka4";
            this.angka4.Size = new System.Drawing.Size(120, 75);
            this.angka4.TabIndex = 3;
            // 
            // angka3
            // 
            this.angka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka3.Location = new System.Drawing.Point(557, 516);
            this.angka3.Name = "angka3";
            this.angka3.Size = new System.Drawing.Size(120, 75);
            this.angka3.TabIndex = 2;
            // 
            // angka2
            // 
            this.angka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka2.Location = new System.Drawing.Point(366, 516);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(120, 75);
            this.angka2.TabIndex = 1;
            // 
            // angka1
            // 
            this.angka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka1.Location = new System.Drawing.Point(183, 537);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(120, 75);
            this.angka1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.BackgroundImage = global::Casino.Properties.Resources.keno_3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(322, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 148);
            this.panel2.TabIndex = 13;
            // 
            // Keno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1282, 828);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.coinlabel);
            this.Name = "Keno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keno";
            this.Load += new System.EventHandler(this.Keno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coinlabel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angka5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angka1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown angka1;
        private System.Windows.Forms.NumericUpDown angka2;
        private System.Windows.Forms.NumericUpDown angka3;
        private System.Windows.Forms.NumericUpDown angka4;
        private System.Windows.Forms.NumericUpDown angka5;
        private System.Windows.Forms.NumericUpDown angka6;
        private System.Windows.Forms.NumericUpDown angka7;
        private System.Windows.Forms.NumericUpDown angka8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown coinlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
    }
}