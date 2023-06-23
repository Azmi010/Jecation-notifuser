using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace notifuser
{
    internal class NotifuserController
    {
        private Form1 view;
        private KodeTransaksi kodetransaksi;
        private Notifsukses notifsukses;
        
        private KodePembayaran show;
        private KodeTransaksi kodep;
        private Notifsukses notif;

        public NotifuserController(Form1 view)
        {
            this.view = view;
            this.kodetransaksi = new KodeTransaksi();
            this.notifsukses = new Notifsukses();
        }
        public NotifuserController(KodePembayaran show)
        {
            this.show = show;
            this.kodep = new KodeTransaksi();
            this.notif = new Notifsukses();
        }
        public void kode()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
            string sql = "SELECT id_notifikasi_user, a.username_akun, k.nama_kamar, jumlah_malam, jumlah_kamar, total_harga " +
                "FROM notifikasi_user nu " +
                "JOIN akun a ON (nu.id_akun = a.id_akun) " +
                "JOIN kamar_penginapan k ON (nu.id_kamar = k.id_kamar) " +
                "WHERE nu.status = false " +
                "ORDER BY id_notifikasi_user ASC " +
                "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            kodetransaksi.Id = dr.GetInt32(0);
                            kodetransaksi.Username = dr.GetString(1);
                            kodetransaksi.NamaKamar = dr.GetString(2);
                            kodetransaksi.JumlahMalam = dr.GetInt32(3);
                            kodetransaksi.JumlahKamar = dr.GetInt32(4);
                            kodetransaksi.TotalHarga = dr.GetInt32(5);

                            view.newlabel15($"Pemesanan Anda Telah Dikonfirmasi\nUsername : {kodetransaksi.Username}\nNama Kamar : {kodetransaksi.NamaKamar}\nJumlah Malam : {kodetransaksi.JumlahMalam} Malam\nJumlah Kamar : {kodetransaksi.JumlahKamar} Kamar\nTotal Harga : {kodetransaksi.TotalHarga}");
                        }
                        else
                        {
                            view.newlabel15("Tidak ada pemesanan");
                            //view.ShowLabel12();
                            //view.HideButton1();
                            //view.HideButton2();
                            //konfirmasi();
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                }
            }
        }
        public void konfirmasi()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
            string sql = "SELECT id_kode_pembayaran, a.username_akun, k.kode_pembayaran " +
                         "FROM kode_pembayaran k " +
                         "JOIN notifikasi_user nu ON (nu.id_notifikasi_user = k.id_notifikasi_user) " +
                         "JOIN akun a ON (nu.id_akun = a.id_akun) " +
                         "WHERE k.status = true " +
                         "ORDER BY k.id_kode_pembayaran ASC " +
                         "LIMIT 1";

            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        NpgsqlDataReader dr = command.ExecuteReader();
                        if (dr.Read())
                        {
                            notifsukses.Id = dr.GetInt32(0);
                            notifsukses.Username = dr.GetString(1);
                            notifsukses.kodepembayaran = dr.GetInt32(2);

                            view.newlabel12($"Username : {notifsukses.Username,-20}\nKode Pembayaran : {notifsukses.kodepembayaran,-20}");

                        }
                        else
                        {
                            view.newlabel12("");
                            //view.HideButton3();
                        }

                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        view.ShowErrorMessage("Error: " + ex.Message);
                    }
                }
            }
        }
        public void kirimkode()
        {
            string connString = "Server=localhost;Port=5432;User Id=postgres;Password=Ululps01;Database=Rembangan";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    string insertquery = "INSERT INTO kode_pembayaran (id_notifikasi_user, kode_pembayaran) VALUES(@id_notifikasi_user, @kode_pembayaran)";
                    cmd.CommandText = insertquery;
                    cmd.Parameters.AddWithValue("@id_notifikasi_user", kodep.Id);
                    cmd.Parameters.AddWithValue("@kode_pembayaran", int.Parse(show.textboxvalue));
                    cmd.ExecuteNonQuery();

                    kode();
                }
                catch (Exception ex)
                {
                    view.ShowErrorMessage("Error: " + ex.Message);
                }
                conn.Close();
            }
        }
    }
}
