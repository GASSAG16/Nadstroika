using System;
using System.Windows.Forms;

namespace Analysis_of_urban_passenger_transport.Logic.Display
{
    class Interfeis:Import_SQL
    {
        string strTransportMaking, strTransport, strSelectTask;
        
        
        public void Setting( Label lbUserName)
        {
            lbUserName.Text = Environment.UserName;
            //lbMachineName.Text = Environment.MachineName;
            //lbPrintDate.Text = DateTime.Today.ToLongDateString();
            //lbPrinting.Text = DateTime.Now.ToLongTimeString();

        }
        public void TodayAndNow(Label lbToday, Label lbNow)
        {
            lbToday.Text = DateTime.Today.ToLongDateString();
            lbNow.Text = DateTime.Now.ToLongTimeString();
        }


        public void Setting(ComboBox cbTransport, Label lbTransport)
        {
            strTransportMaking = cbTransport.Text;
            
            
            if ((strTransportMaking == "Трамвай") || (strTransportMaking == "Троллейбус") || (strTransportMaking == "Автобус"))
            {
                if (strTransportMaking == "Трамвай")
                {
                    strTransport = 3.ToString();
                    lbTransport.Text = strTransport;
                }
                if (strTransportMaking == "Троллейбус")           // переделать в switch
                {
                    strTransport = 2.ToString();
                    lbTransport.Text = strTransport;
                }
                if (strTransportMaking == "Автобус")
                {
                    strTransport = 1.ToString();
                    lbTransport.Text = strTransport;
                }
            }

        }

        public void Setting(ComboBox cbTransport,ComboBox cbSelectTask, GroupBox gbView, Label lbTransport, TextBox tbRouteNumber, TextBox tbTypeOfFlight, RichTextBox tbFeaturesOfRoute, Label lbMachineName,
                                        TextBox tbEndA, TextBox tbEndB, TextBox tbEndC, TextBox tbSwitchingToRoutes, Label lbToday, Label lbNow)
        {
            strSelectTask = cbSelectTask.Text;

            if (strSelectTask == "Сохранить и закрыть")
            {
                gbView.Hide();
                importSQL(lbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, lbToday, lbNow);
            }
            if (strSelectTask == "Сохранить и добавить новый тип рейса")
            {
                importSQL(lbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, lbToday, lbNow);

            }
            if (strSelectTask == "Сохранить и добавить новый маршрут")
            {
                importSQL(lbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, lbToday, lbNow);;
                resetFields(cbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, cbSelectTask);

            }
            if (strSelectTask == "Обновить и закрыть")
            {
                gbView.Hide();
                resetFields(cbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, cbSelectTask);
            }
        }

        public void Setting(GroupBox gbView, ComboBox cbTransport, TextBox tbRouteNumber, TextBox tbTypeOfFlight,RichTextBox tbFeaturesOfRoute,Label lbMachineName,
            TextBox tbEndA, TextBox tbEndB, TextBox tbEndC, TextBox tbSwitchingToRoutes, ComboBox cbSelectTask)
        {
            gbView.Show();
            resetFields(cbTransport, tbRouteNumber, tbTypeOfFlight, tbFeaturesOfRoute, lbMachineName, tbEndA, tbEndB, tbEndC, tbSwitchingToRoutes, cbSelectTask);
        }

        private static void resetFields(ComboBox cbTransport, TextBox tbRouteNumber, TextBox tbTypeOfFlight, RichTextBox tbFeaturesOfRoute, Label lbMachineName,
                                        TextBox tbEndA, TextBox tbEndB, TextBox tbEndC, TextBox tbSwitchingToRoutes, ComboBox cbSelectTask)
        {
            cbTransport.Text = "";
            tbRouteNumber.Text = "";
            tbTypeOfFlight.Text = "";
            tbFeaturesOfRoute.Text = "";
            lbMachineName.Text = Environment.MachineName;
            tbEndA.Text = "";
            tbEndB.Text = "";
            tbEndC.Text = "";
            tbSwitchingToRoutes.Text = "";
            cbSelectTask.Text = "";
        }   
   
    }
}
