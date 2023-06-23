using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notifuser
{
    public partial class KodePembayaran : Form
    {
        public string textboxvalue
        {
            get { return textBox1.Text; }
        }
        private NotifuserController controller;
        public KodePembayaran()
        {
            InitializeComponent();
            controller = new NotifuserController(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.kirimkode();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
