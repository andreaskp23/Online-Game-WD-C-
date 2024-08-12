using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Casino
{
    class CRUD
    {
        Koneksi koneksi = new Koneksi();
        public string username;
        public string winnerID;
        public string betID;
        public string email;
        public string memberID;
        public string game_id;
        public string membername;
        public string transactionID;
        public int membercash;
        public int coinupdate;
        public int cashupdate;
        public int jumlah_bet;
        public int jumlah_menang;
        public int cash;
        public int jumlah;

        //Create Member
        public void createMember()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO dbo.Member (member_id, nama_member, email, cash, coin) VALUES (@memberid, @membername, @memberemail, 0, 0);";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberid", memberID);
                com.Parameters.AddWithValue("@membername", username);
                com.Parameters.AddWithValue("@memberemail", email);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Akun berhasil dibuat, " + username);
                }
                else
                {
                    MessageBox.Show("Data gagal dimasukan");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID sudah digunakan");
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void memberidcheck()
        {
            koneksi.bukaKoneksi();
            try
            {
                string query = "SELECT nama_member, cash, member_id from Member WHERE member_id=@memberID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberID", memberID);
                SqlDataReader checkmember = com.ExecuteReader();
                if (checkmember.Read())
                {
                    string nama_member = checkmember[0].ToString();
                    int cash = Convert.ToInt32(checkmember[1].ToString());
                    string memberid = checkmember[2].ToString();
                    MessageBox.Show("Nama Member adalah " + nama_member + " Cash: " + cash);
                    membername = nama_member;
                    membercash = cash;
                    memberID = memberid;
                }
                else
                {
                    MessageBox.Show("Member tidak ada.");
                    membername = "";
                    membercash = 0;
                    memberID = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Data: " + ex.Message);
            }
            koneksi.tutupKoneksi();
        }

        public void addCash()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Member SET cash = @cash WHERE member_id = @memberid;";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberid", memberID);
                com.Parameters.AddWithValue("@cash", cash);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cash berhasil dimasukan. Saldo: " + cash);
                }
                else
                {
                    MessageBox.Show("Cash gagal dimasukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void transaction()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO dbo.Transactions (transaction_id, member_id, jumlah, tanggal_transaksi) VALUES (@transaction_id, @member_id, @jumlahtransaksi, GETDATE());";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@transaction_id", transactionID);
                com.Parameters.AddWithValue("@member_id", memberID);
                com.Parameters.AddWithValue("@jumlahtransaksi", jumlah);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
        public void betHistory()
        {
            try
            {
                koneksi.bukaKoneksi();
                memberID = Session.userid;
                string query = "INSERT INTO dbo.Bets (bet_id, member_id, game_id, jumlah_bet, tanggal_taruhan) VALUES (@betid, @member_id, @game_id, @jumlah_bet, GETDATE());";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@betid", betID);
                com.Parameters.AddWithValue("@member_id", memberID);
                com.Parameters.AddWithValue("@jumlah_bet", jumlah_bet);
                com.Parameters.AddWithValue("@game_id", game_id);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("history bet gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void winner()
        {
            try
            {
                koneksi.bukaKoneksi();
                memberID = Session.userid;
                string query = "INSERT INTO dbo.Winners (winner_id, jumlah_kemenangan, bet_id) VALUES (@winnerid, @kemenangan, @betid);";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@winnerid", winnerID);
                com.Parameters.AddWithValue("@betid", betID);
                com.Parameters.AddWithValue("@kemenangan", jumlah_menang);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("Winner bet error dan gagal masuk");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void coinUpdate()
        {
            try
            {
                koneksi.bukaKoneksi();
                memberID = Session.userid;
                string query = "UPDATE dbo.Member SET coin = @coin WHERE member_id = @memberid";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberid", memberID);
                com.Parameters.AddWithValue("@coin", coinupdate);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }

        public void cashUpdate()
        {
            try
            {
                koneksi.bukaKoneksi();
                memberID = Session.userid;
                string query = "UPDATE dbo.Member SET cash = @cash WHERE member_id = @memberid";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberid", memberID);
                com.Parameters.AddWithValue("@cash", cashupdate);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
    }
}