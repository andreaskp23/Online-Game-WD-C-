
namespace Casino
{
    partial class loginGeneral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlogin = new System.Windows.Forms.Button();
            this.txtloginmember = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::Casino.Properties.Resources.Gambar_WhatsApp_2024_04_08_pukul_09_09_50_169580d2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btlogin);
            this.panel1.Controls.Add(this.txtloginmember);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 561);
            this.panel1.TabIndex = 5;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Transparent;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Location = new System.Drawing.Point(105, 254);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(223, 41);
            this.btlogin.TabIndex = 4;
            this.btlogin.Text = "login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // txtloginmember
            // 
            this.txtloginmember.BackColor = System.Drawing.Color.SeaShell;
            this.txtloginmember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginmember.ForeColor = System.Drawing.Color.Black;
            this.txtloginmember.Location = new System.Drawing.Point(48, 191);
            this.txtloginmember.Name = "txtloginmember";
            this.txtloginmember.Size = new System.Drawing.Size(320, 38);
            this.txtloginmember.TabIndex = 3;
            this.txtloginmember.TextChanged += new System.EventHandler(this.txtloginmember_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Belum punya akun? Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Member";
            // 
            // loginGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 557);
            this.Controls.Add(this.panel1);
            this.Name = "loginGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginMember";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloginmember;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}