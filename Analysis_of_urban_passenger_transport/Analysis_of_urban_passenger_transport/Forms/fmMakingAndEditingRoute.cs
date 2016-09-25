using System;
using System.Windows.Forms;
using Analysis_of_urban_passenger_transport.Logic.Display;


namespace Analysis_of_urban_passenger_transport
{
    public partial class fmMakingAndEditingRoute : Form
    {
        Interfeis Inter = new Interfeis();

        public fmMakingAndEditingRoute()
        {
            InitializeComponent();
        }

        private void cbTransportMaking_TextChanged(object sender, EventArgs e)
        {
            Inter.Setting(cbTransportMaking, lbTransport);
        }

        private void cbSelectTask_TextChanged(object sender, EventArgs e)
        {
            Inter.Setting(cbTransportMaking, cbSelectTask, gbViewMaking, lbTransport, tbRouteNumberMaking, tbTypeOfFlightMaking, tbFeaturesOfRouteMaking,
                lbMachineNameMaking, tbEndAMaking, tbEndBMaking, tbEndCMaking, tbSwitchingToRoutesMaking, lbToday, lbNow);
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            Inter.Setting(gbViewMaking, cbTransportMaking, tbRouteNumberMaking, tbTypeOfFlightMaking, tbFeaturesOfRouteMaking, lbMachineNameMaking, tbEndAMaking, tbEndBMaking, tbEndCMaking, tbSwitchingToRoutesMaking, cbSelectTask);
        }

        private void trTimer_Tick(object sender, EventArgs e)
        {
            Inter.TodayAndNow(lbToday, lbNow);
        }

        private void fmMakingAndEditingRoute_Load(object sender, EventArgs e)
        {
            Inter.Setting(lbUserName);
            gbViewMaking.Hide();
            gbViewEditingRoute.Hide();
        }

        private void cbTransportEditing_TextChanged(object sender, EventArgs e)
        {
            Inter.Setting(cbTransportEditing, lbTransport);
        }

        private void tbFindTheRoute_Click(object sender, EventArgs e)
        {
            requestRouteTableAdapter.Fill(addonDataSet.requestRoute, lbTransport.Text, tbSearchStart.Text);
            gbViewEditingRoute.Show();
        }

        private void cbSelectTask__TextChanged(object sender, EventArgs e)
        {
            Inter.Setting(cbTransportEditing, cbSelectTask_, gbViewEditingRoute, lbTransport, tbRouteNumberEditing, tbTypeOfFlightEditing,
                tbFeaturesOfRouteEditing, lbMachineName, tbEndAEditing, tbEndBEditing, tbEndCEditing, tbSwitchingToRoutesEditing, lbPrintDate, lbNow);
            tbSearchStart.Text = "";
        }

        private void fmMakingAndEditingRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            var view = new fmViewmode();
            view.Show();
            this.Hide();
        }

        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbViewEditingRoute.Hide();
                gbViewMaking.Hide();
        }
    }
}
