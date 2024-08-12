
namespace Casino
{
    partial class convertcoin
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cashresult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.coininput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cashresult2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.coininput2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.coinlabel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashlabel = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coininput)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashresult2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coininput2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinlabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashlabel)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(55, 549);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 66);
            this.button4.TabIndex = 30;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cashresult);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.coininput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(332, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 836);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 66);
            this.button1.TabIndex = 35;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 50);
            this.label6.TabIndex = 40;
            this.label6.Text = "Cash";
            // 
            // cashresult
            // 
            this.cashresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashresult.Location = new System.Drawing.Point(123, 430);
            this.cashresult.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cashresult.Name = "cashresult";
            this.cashresult.Size = new System.Drawing.Size(242, 45);
            this.cashresult.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 50);
            this.label3.TabIndex = 38;
            this.label3.Text = "Coin";
            // 
            // coininput
            // 
            this.coininput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coininput.Location = new System.Drawing.Point(179, 303);
            this.coininput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.coininput.Name = "coininput";
            this.coininput.Size = new System.Drawing.Size(120, 45);
            this.coininput.TabIndex = 37;
            this.coininput.ValueChanged += new System.EventHandler(this.coininput_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 45);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cash to Coin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 50);
            this.label2.TabIndex = 35;
            this.label2.Text = "1 Coin => 5000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cashresult2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.coininput2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(822, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 836);
            this.panel2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 66);
            this.button2.TabIndex = 41;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 50);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cash";
            // 
            // cashresult2
            // 
            this.cashresult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashresult2.Location = new System.Drawing.Point(104, 430);
            this.cashresult2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cashresult2.Name = "cashresult2";
            this.cashresult2.Size = new System.Drawing.Size(242, 45);
            this.cashresult2.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 50);
            this.label10.TabIndex = 43;
            this.label10.Text = "Coin";
            // 
            // coininput2
            // 
            this.coininput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coininput2.Location = new System.Drawing.Point(160, 303);
            this.coininput2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.coininput2.Name = "coininput2";
            this.coininput2.Size = new System.Drawing.Size(120, 45);
            this.coininput2.TabIndex = 42;
            this.coininput2.ValueChanged += new System.EventHandler(this.coininput2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Coin to Cash";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 50);
            this.label5.TabIndex = 37;
            this.label5.Text = "1 Coin => 4900";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 32);
            this.label7.TabIndex = 35;
            this.label7.Text = "Coins :";
            // 
            // coinlabel
            // 
            this.coinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinlabel.Location = new System.Drawing.Point(38, 150);
            this.coinlabel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.coinlabel.Name = "coinlabel";
            this.coinlabel.ReadOnly = true;
            this.coinlabel.Size = new System.Drawing.Size(238, 34);
            this.coinlabel.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cash :";
            // 
            // cashlabel
            // 
            this.cashlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashlabel.Location = new System.Drawing.Point(38, 240);
            this.cashlabel.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.cashlabel.Name = "cashlabel";
            this.cashlabel.ReadOnly = true;
            this.cashlabel.Size = new System.Drawing.Size(238, 34);
            this.cashlabel.TabIndex = 40;
            // 
            // convertcoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1282, 828);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cashlabel);
            this.Controls.Add(this.coinlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Name = "convertcoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "convertcoin";
            this.Load += new System.EventHandler(this.convertcoin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coininput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashresult2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coininput2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinlabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashlabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown cashresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown coininput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown coinlabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cashlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cashresult2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown coininput2;
    }
}