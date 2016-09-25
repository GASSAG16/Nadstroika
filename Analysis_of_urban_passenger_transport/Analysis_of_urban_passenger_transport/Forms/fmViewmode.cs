using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Analysis_of_urban_passenger_transport.Logic.Display;

namespace Analysis_of_urban_passenger_transport
{
    public partial class fmViewmode : Form
    {
        Interfeis Inter = new Interfeis();
        
        public fmViewmode()
        {
            InitializeComponent();
        }

        private void cbTransport_TextChanged(object sender, EventArgs e)
        {
            Inter.Setting(cbTransport, lbTransport);
        }

        private void Startovya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "addonDataSet.Route". При необходимости она может быть перемещена или удалена.
            this.routeTableAdapter.Fill(this.addonDataSet.Route);
            Inter.Setting( lbUserName);
            gbView.Hide();
        }

        private void trTimer_Tick_1(object sender, EventArgs e)
        {
            Inter.TodayAndNow(lbToday, lbNow);
        }

        private void lbPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В следующей редакции!");
        }

        private void lbEnter_EditRouteDirectory_Click(object sender, EventArgs e)
        {
            var editRoute = new fmMakingAndEditingRoute();
            editRoute.Show();
            this.Hide(); 
        }

        private void lbAbout_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Данная надстройка была задумана и написана в 2012 году, в качестве дополнения к основной системы анализа пассажиропотоков.");      
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbFindTheRoute_Click(object sender, EventArgs e)
        {
            requestRouteTableAdapter.Fill(addonDataSet.requestRoute,lbTransport.Text, tbSearchStart.Text);
            gbView.Show();
        }

        private void fmViewmode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}