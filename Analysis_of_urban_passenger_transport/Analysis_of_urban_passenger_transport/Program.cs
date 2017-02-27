using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Analysis_of_urban_passenger_transport
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frmViewmode());
        }
    }
}
