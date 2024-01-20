using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tugas_Besar_PBO.Model
{
    internal class M_Jasa
    {
        string jenis_jasa, rank, harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun;
        public M_Jasa()
        {
        }
        public M_Jasa(string jenis_jasa,string rank, string harga, string penjoki, string metode_pembayaran, string no_whatsapp, string email,string password, string jenis_akun)
        {
            this.Jenis_jasa = jenis_jasa;
            this.Rank = rank;
            this.Harga = harga;
            this.Penjoki = penjoki;
            this.Metode_pembayaran = metode_pembayaran;
            this.No_whatsapp = no_whatsapp;
            this.Email = email;
            this.Password = password;
            this.Jenis_akun = jenis_akun;
            
        }
        public string Jenis_jasa { get => jenis_jasa; set => jenis_jasa = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Harga { get => harga; set => harga = value; }
        public string Penjoki { get => penjoki; set => penjoki = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public string No_whatsapp { get => no_whatsapp; set => no_whatsapp = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Jenis_akun { get => jenis_akun; set => jenis_akun = value; }
    }
}
    

