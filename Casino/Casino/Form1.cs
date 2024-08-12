using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Casino
{
    public partial class LuckySpin : Form
    {
        int coin = Session.coin;
        public LuckySpin()
        {
            InitializeComponent();
        }

        private void btspin_Click(object sender, EventArgs e)
        {
            if (coin > 0)
            {
                coin = int.Parse(coinlabel.Text);
                int result = coin - 1;
                coinlabel.Text = result.ToString();

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("yyMMddHHmmss");


                CRUD crud = new CRUD();
                crud.game_id = "101";
                Session.coin = Convert.ToInt32(coinlabel.Value);
                crud.coinupdate = Convert.ToInt32(coinlabel.Value);
                crud.coinUpdate();
                crud.betID = formattedDateTime + Session.userid;
                crud.jumlah_bet = 1;
                crud.betHistory();

                Random random = new Random();
                label1.Text = (random.Next(0, 10)).ToString();
                label2.Text = (random.Next(0, 10)).ToString();
                label3.Text = (random.Next(0, 10)).ToString();
                if (label1.Text == label2.Text && label2.Text == label3.Text)
                {
                    MessageBox.Show("Kamu Menang! Saldo mu X10!");
                    coin = coin + 9;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 10;
                    crud.winnerID = formattedDateTime + Session.userid + 9999;
                    crud.winner();
                }
                else if (label1.Text == label2.Text || label2.Text == label3.Text)
                {
                    MessageBox.Show("Kamu Menang! Saldo mu X5!");
                    coin = coin + 4;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 5;
                    crud.winnerID = formattedDateTime + Session.userid + 9999;
                    crud.winner();
                }
                else
                {
                    MessageBox.Show("Kamu kalah, coba lagi!");
                }
            }
            else
            {
                MessageBox.Show("Coin tidak cukup");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btreset_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            label2.Text = "1";
            label3.Text = "1";
        }

        private void Slot_Load(object sender, EventArgs e)
        {
            label1.Text = "1";
            label2.Text = "1";
            label3.Text = "1";
            coinlabel.Value = coin;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
