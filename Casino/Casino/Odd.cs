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
    public partial class Odd : Form
    {
        int coin = Session.coin;
        int coinchoose;
        int choosecoin = 0;
        int win;
        public Odd()
        {
            InitializeComponent();
        }

        private void btodd_Click(object sender, EventArgs e)
        {
            if (coin >= coinchoose && coinchoose != 0)
            {
                Random random = new Random();
                randomnumber.Value = random.Next(1, 51);
                randomnumber2.Value = random.Next(1, 51);
                randomnumberresult.Value = randomnumber.Value + randomnumber2.Value;

                coinchoose = Convert.ToInt32(txchoosecoin.Text);
                coin = Convert.ToInt32(coinlabel.Text);
                int result = coin - coinchoose;
                coinlabel.Text = result.ToString();

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("yyMMddHHmmss");


                CRUD crud = new CRUD();
                crud.game_id = "103";
                Session.coin = Convert.ToInt32(coinlabel.Value);
                crud.coinupdate = Convert.ToInt32(coinlabel.Value);
                crud.coinUpdate();
                crud.betID = formattedDateTime + Session.userid;
                crud.jumlah_bet = coinchoose;
                crud.betHistory();

                if (randomnumberresult.Value % 2 == 1)
                {
                    MessageBox.Show("Kamu benar, +" + coinchoose*2 + " Coins");
                    coin = coin + coinchoose;
                    coinlabel.Value = coin;
                    win++;
                    textwincounter.Text = win.ToString();
                    crud.jumlah_menang = coinchoose * 2;
                    crud.winnerID = formattedDateTime + Session.userid + 7777;
                    crud.winner();
                }
                else
                {
                    MessageBox.Show("Kamu kalah");
                }
            }
            else
            {
                MessageBox.Show("Coin tidak cukup");
            }
        }

        private void bteven_Click(object sender, EventArgs e)
        {
            if (coin >= coinchoose && coinchoose != 0)
            {
                Random random = new Random();
                randomnumber.Value = random.Next(1, 51);
                randomnumber2.Value = random.Next(1, 51);
                randomnumberresult.Value = randomnumber.Value + randomnumber2.Value;

                coinchoose = Convert.ToInt32(txchoosecoin.Text);
                coin = Convert.ToInt32(coinlabel.Text);
                int result = coin - coinchoose;
                coinlabel.Text = result.ToString();

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("yyMMddHHmmss");


                CRUD crud = new CRUD();
                crud.game_id = "103";
                Session.coin = Convert.ToInt32(coinlabel.Value);
                crud.coinupdate = Convert.ToInt32(coinlabel.Value);
                crud.coinUpdate();
                crud.betID = formattedDateTime + Session.userid;
                crud.jumlah_bet = coinchoose;
                crud.betHistory();

                if (randomnumberresult.Value % 2 == 0)
                {
                    MessageBox.Show("Kamu benar, +" + coinchoose*2 + " Coins");
                    coin = coin + coinchoose;
                    coinlabel.Value = coin;
                    win++;
                    textwincounter.Text = win.ToString();
                    crud.jumlah_menang = coinchoose * 2;
                    crud.winnerID = formattedDateTime + Session.userid + 7777;
                    crud.winner();
                }
                else
                {
                    MessageBox.Show("Kamu kalah");
                }
            }
            else
            {
                MessageBox.Show("Coin tidak cukup / Pilih jumlah Taruhan");
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            randomnumber.Value = 0;
            randomnumber2.Value = 0;
            randomnumberresult.Value = randomnumber.Value + randomnumber2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coinchoose = 1;
            txchoosecoin.Text = coinchoose.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coinchoose = 2;
            txchoosecoin.Text = coinchoose.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coinchoose = 3;
            txchoosecoin.Text = coinchoose.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            coinchoose = 5;
            txchoosecoin.Text = coinchoose.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            coinchoose = 10;
            txchoosecoin.Text = coinchoose.ToString();
        }


        private void Odd_Load(object sender, EventArgs e)
        {
            txchoosecoin.Text = choosecoin.ToString();
            coinchoose = Convert.ToInt32(txchoosecoin.Text);
            win = 0;
            coinlabel.Value = Session.coin;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRUD updatecoin = new CRUD();
            Session.coin = Convert.ToInt32(coinlabel.Value);
            updatecoin.coinupdate = Convert.ToInt32(coinlabel.Value);
            updatecoin.coinUpdate();
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
