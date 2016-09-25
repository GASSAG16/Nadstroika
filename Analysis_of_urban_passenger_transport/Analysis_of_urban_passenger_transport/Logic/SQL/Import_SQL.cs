using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Analysis_of_urban_passenger_transport.AddonDataSetTableAdapters;

namespace Analysis_of_urban_passenger_transport
{
    class Import_SQL
    {     
        //Импорт данных на сервер

                //datepechat                    Дата печати
                //tiptransporta                 Тип транспорта

                //NomerMarsh                    номер маршрута
                //tipReisa                      тип рейса

                //Konechnaya_A                  Конечная 1
                //Konechnaya_B                  Конечная 2
                //Konechnaya_C                  Конечная 3

                //Pereklychenie_na_marsh        Переключение на маршрут
                //Osobennosti_marsh             Особенности маршрута

                //namepc.Text                   Имя ПК

        AddonDataSet addon = new AddonDataSet();
        InsertRouteTableAdapter insertRoute = new InsertRouteTableAdapter();


        public void importSQL(Label lbTransport, TextBox tbRouteNumber, TextBox tbTypeOfFlight, RichTextBox tbFeaturesOfRoute, Label lbMachineName,
                                        TextBox tbEndA, TextBox tbEndB, TextBox tbEndC, TextBox tbSwitchingToRoutes, Label lbToday, Label lbNow)
            {
                if ((tbRouteNumber.Text == "") || (tbTypeOfFlight.Text == "") || (tbEndA.Text == ""))
                    {
                        MessageBox.Show("Ошибка! Внимание, пустые данные !!!");
                    }
                else
                    {
                        DateTime Today = DateTime.Parse(lbToday.Text);
                        insertRoute.Fill(addon.InsertRoute,lbTransport.Text, tbRouteNumber.Text, tbTypeOfFlight.Text, tbEndA.Text,tbEndB.Text,
                                         tbEndC.Text, tbSwitchingToRoutes.Text,tbFeaturesOfRoute.Text,lbMachineName.Text, Today, lbNow.Text);
                    MessageBox.Show("Данные внесены !!!");
                }
            }
    }
}