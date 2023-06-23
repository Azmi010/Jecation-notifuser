using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notifuser
{
    internal class Notifsukses
    {
        private KodePembayaran kodePembayaran;

        public Notifsukses()
        {
        }

        public Notifsukses(KodePembayaran kodePembayaran)
        {
            this.kodePembayaran = kodePembayaran;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public int kodepembayaran { get; set; }
    }
}
