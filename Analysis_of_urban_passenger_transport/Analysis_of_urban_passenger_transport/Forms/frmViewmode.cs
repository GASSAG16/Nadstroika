using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Analysis_of_urban_passenger_transport.Forms
{
    public partial class frmViewmode : MetroForm
    {
        AddonEntities db;

        int strTransport;
       
        public frmViewmode()
        {
            InitializeComponent();
        }

        private void frmViewmode_Load(object sender, EventArgs e)
        {
            db = new AddonEntities();          
        }

        #region Поиск маршрута,используя выбор транспорта
             
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
        void selectModeTransport()
        {
            string transport = cboSelectModeTransport.Text;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (frmEnterAndEdit frm = new frmEnterAndEdit(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    routeBindingSource.DataSource = db.Routes.ToList();
                }
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            using (frmInformation frm = new frmInformation())
            {
                frm.ShowDialog();
            }
        }
    }
}
