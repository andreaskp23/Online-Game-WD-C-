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
    public partial class Home : Form
    {
        string cashToRupiah = string.Format("Rp {0:N0}", Session.money);
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            textcoin.Text = Session.coin.ToString();
            textcash.Text = cashToRupiah;
            textmemberid.Text = Session.userid;
        }

        private void btgame1_Click(object sender, EventArgs e)
        {
            Odd odd = new Odd();
            odd.Show();
            this.Hide();
        }

        private void btgame2_Click(object sender, EventArgs e)
        {
            LuckySpin form1 = new LuckySpin();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Keno keno = new Keno();
            keno.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            convertcoin Convertcoin = new convertcoin();
            Convertcoin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginGeneral login = new loginGeneral();
            login.Show();
            this.Hide();
        }
    }
}
