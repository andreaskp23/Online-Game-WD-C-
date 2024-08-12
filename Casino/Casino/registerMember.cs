using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class registerMember : Form
    {
        public registerMember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginGeneral login = new loginGeneral();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD createMember = new CRUD();
            createMember.username = registusername.Text;
            createMember.email = registemail.Text;
            createMember.memberID = registid.Text;
            createMember.createMember();
        }
    }
}
