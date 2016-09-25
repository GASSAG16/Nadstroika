using System;
using System.Windows.Forms;

namespace Analysis_of_urban_passenger_transport
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void trPerexod_Tick(object sender, EventArgs e)
        {
            fmViewmode star = new fmViewmode();
            star.Show();
            trPerexod.Stop();
            this.Hide();
        }
    }
}
