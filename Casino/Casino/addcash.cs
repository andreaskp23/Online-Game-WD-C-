
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
    public partial class addcash : Form
    {
        public addcash()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            berandaAdmin berandaadmin = new berandaAdmin();
            berandaadmin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD checkmemberid = new CRUD();
            checkmemberid.memberID = textmembercheck.Text;
            checkmemberid.memberidcheck();

            textmembercash.Value = checkmemberid.membercash;
            textmembername.Text = checkmemberid.membername;
            textmemberID.Text = checkmemberid.memberID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textcashadd.Value > 0)
            {
                if (textmembername.Text != null)
                {
                    CRUD addcash = new CRUD();
                    addcash.memberID = textmemberID.Text;
                    addcash.cash = Convert.ToInt32(textcashadd.Value) + Convert.ToInt32(textmembercash.Value);

                    CRUD transaction = new CRUD();
                    DateTime currentDateTime = DateTime.Now;
                    string formattedDateTime = currentDateTime.ToString("yyMMddHHmmss");
                    transaction.transactionID = formattedDateTime + textmemberID.Text;
                    transaction.memberID = textmemberID.Text;
                    transaction.jumlah = Convert.ToInt32(textcashadd.Value);

                    addcash.addCash();
                    transaction.transaction();

                    textmemberID.Text = "";
                    textcashadd.Value = 0;
                    textmembercash.Value = 0;
                    textmembername.Text = "";
                }
                else
                {
                    MessageBox.Show("Mohon Cek member ID terlebih dahulu");
                }
            }
            else
            {
                MessageBox.Show("Mohon masukan Cash yang akan ditambah");
            }
        }
    }
}