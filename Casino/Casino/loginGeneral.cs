using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Casino
{
    public partial class loginGeneral : Form
    {
        public loginGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registerMember register = new registerMember();
            register.Show();
            this.Hide();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.memberID = txtloginmember.Text;

            login.masukMember();

            if (login.loginStatus == 1)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }

            else if (login.loginStatus == 2)
            {
                berandaAdmin admin = new berandaAdmin();
                admin.Show();
                this.Hide();
            }
        }

        private void txtloginmember_TextChanged(object sender, EventArgs e)
        {
            if (txtloginmember.Text.Length == 10)
            {
                Login login = new Login();
                login.memberID = txtloginmember.Text;

                login.masukMember();

                if (login.loginStatus == 1)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else if (login.loginStatus == 2)
                {
                    berandaAdmin admin = new berandaAdmin();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                // Tambahkan tindakan yang ingin Anda lakukan jika panjang data tidak sama dengan 10
            }
        }
    }
}
