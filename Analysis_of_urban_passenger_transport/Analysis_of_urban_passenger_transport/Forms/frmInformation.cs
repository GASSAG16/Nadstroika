﻿using MetroFramework.Forms;
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
    public partial class frmInformation : MetroForm
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        private void frmInformation_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
        }
    }
}