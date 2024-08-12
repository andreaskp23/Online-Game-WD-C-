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
    public partial class convertcoin : Form
    {
        public convertcoin()
        {
            InitializeComponent();
        }

        private void convertcoin_Load(object sender, EventArgs e)
        {
            coinlabel.Value = Session.coin;
            cashlabel.Value = Session.money;
        }

        private void coininput_ValueChanged(object sender, EventArgs e)
        {
            cashresult.Value = coininput.Value * 5000;
        }

        private void coininput2_ValueChanged(object sender, EventArgs e)
        {
            cashresult2.Value = coininput2.Value * 4900;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(coininput.Value > 0)
            {
                if (cashresult.Value <= Session.money)
                {
                    CRUD update = new CRUD();
                    Session.coin = Session.coin + Convert.ToInt32(coininput.Value);
                    Session.money = Session.money - Convert.ToInt32(cashresult.Value);

                    update.coinupdate = Session.coin;
                    update.cashupdate = Session.money;
                    update.coinUpdate();
                    update.cashUpdate();

                    MessageBox.Show("Coin exchange berhasil! Cash to Coin");
                    coinlabel.Value = Session.coin;
                    cashlabel.Value = Session.money;
                }
                else
                {
                    MessageBox.Show("Cash tidak cukup!");
                }
            }
            else
            {
                MessageBox.Show("Coin harus lebih dari 1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (coininput2.Value > 0)
            {
                if (coininput2.Value <= Session.coin)
                {
                    CRUD update = new CRUD();
                    Session.coin = Session.coin - Convert.ToInt32(coininput2.Value);
                    Session.money = Session.money + Convert.ToInt32(cashresult2.Value);

                    update.coinupdate = Session.coin;
                    update.cashupdate = Session.money;
                    update.coinUpdate();
                    update.cashUpdate();

                    MessageBox.Show("Coin exchange berhasil! Coin to Cash");
                    coinlabel.Value = Session.coin;
                    cashlabel.Value = Session.money;
                }
                else
                {
                    MessageBox.Show("Coin tidak cukup!");
                }
            }
            else
            {
                MessageBox.Show("Coin harus lebih dari 1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
