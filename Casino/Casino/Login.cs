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
    class Login
    {
        public string memberID;
        public int loginStatus;

        Koneksi koneksi = new Koneksi();
        public void masukMember()
        {
            koneksi.bukaKoneksi();
            try
            {
                string query = "SELECT member_id, nama_member, email, coin, cash from Member WHERE member_id=@memberID";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@memberID", memberID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    string member_id = dr[0].ToString();
                    string nama_member = dr[1].ToString();
                    string email = dr[2].ToString();
                    String coin = dr[3].ToString();
                    String cash = dr[4].ToString();
                    MessageBox.Show("berhasil masuk, Halo " + email);
                    MessageBox.Show("berhasil masuk, Halo " + email);
                    Session.username = nama_member;
                    Session.Email = email;
                    Session.userid = member_id;
                    Session.coin = Convert.ToInt32(coin);
                    Session.money = Convert.ToInt32(cash);
                    loginStatus = 1;
                }
                else if (memberID == "admin")
                {
                    MessageBox.Show("Halo Admin");
                    MessageBox.Show("Halo Admin");
                    loginStatus = 2;
                }
                else
                {
                    MessageBox.Show("ID salah");
                    MessageBox.Show("ID salah");
                    loginStatus = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Data: " + ex.Message);
            }
            koneksi.tutupKoneksi();
        }
    }
}
