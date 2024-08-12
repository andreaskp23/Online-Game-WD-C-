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
    public partial class Keno : Form
    {
        int coin = Session.coin;
        public Keno()
        {
            InitializeComponent();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (coin > 0) {
                coin = int.Parse(coinlabel.Text);
                int result = coin - 1;
                coinlabel.Text = result.ToString();

                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("yyMMddHHmmss");


                CRUD crud = new CRUD();
                crud.game_id = "102";
                Session.coin = Convert.ToInt32(coinlabel.Value);
                crud.coinupdate = Convert.ToInt32(coinlabel.Value);
                crud.coinUpdate();
                crud.betID = formattedDateTime + Session.userid;
                crud.jumlah_bet = 1;
                crud.betHistory();

                Random random = new Random();
                int[] generatedNumbers = new int[4];
                bool isAngka1Match = false;
                bool isAngka2Match = false;
                bool isAngka3Match = false;
                bool isAngka4Match = false;

                // Generate random numbers
                for (int i = 0; i < generatedNumbers.Length; i++)
                {
                    generatedNumbers[i] = random.Next(0, 30);
                }

                // Display generated numbers
                angka8.Value = generatedNumbers[0];
                angka7.Value = generatedNumbers[1];
                angka6.Value = generatedNumbers[2];
                angka5.Value = generatedNumbers[3];

                // Check if angka1 matches any generated number
                foreach (int number in generatedNumbers)
                {
                    if (angka1.Value == number)
                    {
                        isAngka1Match = true;
                        break;
                    }
                }

                // Check if angka2 matches any generated number
                foreach (int number in generatedNumbers)
                {
                    if (angka2.Value == number)
                    {
                        isAngka2Match = true;
                        break;
                    }
                }

                // Check if angka3 matches any generated number
                foreach (int number in generatedNumbers)
                {
                    if (angka3.Value == number)
                    {
                        isAngka3Match = true;
                        break;
                    }
                }

                // Check if angka4 matches any generated number
                foreach (int number in generatedNumbers)
                {
                    if (angka4.Value == number)
                    {
                        isAngka4Match = true;
                        break;
                    }
                }

                // Perform actions based on the results
                if (isAngka1Match && isAngka2Match && isAngka3Match && isAngka4Match)
                {
                    MessageBox.Show("HOKI!!!! DATPAT 500 COIN");
                    coin = coin + 499;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 500;
                    crud.winnerID = formattedDateTime + Session.userid + 8888;
                    crud.winner();
                }
                else if ((isAngka1Match && isAngka2Match && isAngka3Match) || (isAngka1Match && isAngka2Match && isAngka4Match) || (isAngka1Match && isAngka3Match && isAngka4Match) || (isAngka2Match && isAngka3Match && isAngka4Match))
                {
                    MessageBox.Show("Kamu berhasil benar 3! Dapat 8 Coin");
                    coin = coin + 7;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 8;
                    crud.winnerID = formattedDateTime + Session.userid + 8888;
                    crud.winner();
                }
                else if (isAngka1Match && isAngka2Match || isAngka1Match && isAngka3Match || isAngka1Match && isAngka4Match || isAngka2Match && isAngka3Match || isAngka2Match && isAngka4Match || isAngka3Match && isAngka4Match)
                {
                    MessageBox.Show("Kamu berhasil benar 2! Dapat 4 Coin");
                    coin = coin + 3;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 4;
                    crud.winnerID = formattedDateTime + Session.userid + 8888;
                    crud.winner();
                }
                else if (isAngka1Match || isAngka2Match || isAngka3Match || isAngka4Match)
                {
                    MessageBox.Show("Kamu berhasil benar 1! Dapat 2 Coin");
                    coin = coin + 1;
                    coinlabel.Value = coin;
                    crud.jumlah_menang = 2;
                    crud.winnerID = formattedDateTime + Session.userid + 8888;
                    crud.winner();
                }
                else
                {
                    MessageBox.Show("Kamu gagal!");
                }
            }
            else
            {
                MessageBox.Show("Coin tidak cukup");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            angka1.Value = random.Next(0, 30);
            angka2.Value = random.Next(0, 30);
            angka3.Value = random.Next(0, 30);
            angka4.Value = random.Next(0, 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD updatecoin = new CRUD();
            Session.coin = Convert.ToInt32(coinlabel.Value);
            updatecoin.coinupdate = Convert.ToInt32(coinlabel.Value);
            updatecoin.coinUpdate();
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Keno_Load(object sender, EventArgs e)
        {
            coinlabel.Value = Session.coin;
        }
    }
}
