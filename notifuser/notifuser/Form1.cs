namespace notifuser
{
    public partial class Form1 : Form
    {
        private NotifuserController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new NotifuserController(this);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            KodePembayaran kp = new KodePembayaran();
            kp.StartPosition = FormStartPosition.Manual;
            kp.Location = new Point(620, 120);
            kp.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.kode();
            controller.konfirmasi();
        }
        public void newlabel15(string text)
        {
            label15.Text = text;
        }
        public void newlabel12(string text)
        {
            label12.Text = text;
        }
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}