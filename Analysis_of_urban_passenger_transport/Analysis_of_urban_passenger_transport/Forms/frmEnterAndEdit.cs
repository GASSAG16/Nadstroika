
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis_of_urban_passenger_transport.Forms
{
    public partial class frmEnterAndEdit : MetroFramework.Forms.MetroForm
    {
        int strTransport;
        
        public frmEnterAndEdit(Route obj)
        {
            InitializeComponent();
            MarshBindingNavigator.Enabled = false;
        }

        #region Общее

        #region Внесение и обновление после закрытия
        
        private void frmEnterAndEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (switchMode.CheckState == CheckState.Checked)
            {
                if (DialogResult == DialogResult.OK)
                {
                    importTransportInfo();
                    e.Cancel = false;
                }
            }
            else if ((switchMode.CheckState == CheckState.Unchecked))
            {
                if (DialogResult == DialogResult.OK)
                {
                    updateTransportInfo();
                    e.Cancel = false;
                }
            }
            e.Cancel = false;
        }        
        void importTransportInfo()
        {
            Route routeInfo = new Route();
            {
                routeInfo.id_tip = strTransport.ToString();
                routeInfo.RouteNumber = txtRouteNumber.Text;
                routeInfo.TypeOfFlight = txtTypeOfFlight.Text;
                routeInfo.EndA = txtEndA.Text;
                routeInfo.EndB = txtEndB.Text;
                routeInfo.EndC = txtEndC.Text;
                routeInfo.FeaturesOfRoute = txtFeaturesOfRoute.Text;
                routeInfo.SwitchingToRoutes = txtSwitchingToRoutes.Text;
            }

            using (var context = new AddonEntities())
            {
                context.Routes.Add(routeInfo);
                context.SaveChanges();
                MessageBox.Show("Данные внесены!", "Сообщение");
            }

        }
        void updateTransportInfo()
        {
            using (AddonEntities db = new AddonEntities())
            {
                Route obj = routeBindingSource.Current as Route;
                if (obj != null)
                {
                    db.Entry<Route>(obj).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                MessageBox.Show("Данные обновлены!", "Сообщение");
            }
        }
        
        #endregion

        #region Переключение режимов внесение / редактирование
        
        private void switchMode_CheckedChanged(object sender, EventArgs e)
        {
            switchMode_EnterAndEdit();
        }
        void switchMode_EnterAndEdit()
        {
            if (switchMode.Checked == true)
            {
                cboSelectTransport.Enabled = true;
                MarshBindingNavigator.Enabled = false;
            }
            else
            {
                cboSelectTransport.Enabled = false;
                MarshBindingNavigator.Enabled = true;
            }
        }
        
        #endregion

        #region Поиск маршрута используя выбор транспорта
        
        private void tbFindTheRoute_Click(object sender, EventArgs e)
        {
            selectModeTransport();
            using (AddonEntities db = new AddonEntities())
            {
                var otbor = from p in db.Routes
                            where p.id_tip == strTransport.ToString()
                            where p.RouteNumber == tbSearchStart.Text
                            select p;
                List<Route> lista = otbor.ToList();
                MarshBindingNavigator.BindingSource.DataSource = lista;
                routeBindingSource.DataSource = lista.ToList();
            }
        }
        private void cboSelectTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string transport = cboSelectTransport.Text;
            modeTransport(transport);
        }

     
        void selectModeTransport()
        {
           string transport = cboSelectEditTransport.Text;
           modeTransport(transport);
        }
        void modeTransport(string transport)
        {
            if ((transport == "Трамвай") || (transport == "Троллейбус") || (transport == "Автобус"))
            {
                if (transport == "Трамвай")
                {
                    strTransport = 3;
                }
                if (transport == "Троллейбус")           // переделать в switch
                {
                    strTransport = 2;
                }
                if (transport == "Автобус")
                {
                    strTransport = 1;
                }
            }
        }
        
        #endregion
        
        #endregion
    }
}
