using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notifuser
{
    internal class KodeTransaksi
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string NamaKamar { get; set; }
        public int JumlahMalam { get; set; }
        public int JumlahKamar { get; set; }
        public int TotalHarga { get; set; }
    }
}
