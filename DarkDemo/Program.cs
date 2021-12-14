using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new StaffMenu(new Staff {staff_id=10001, Name="Jojo", staff_mail= "manager@edeexpress.com.hk", position= "Manager", emplyedDate= "2021-06-06" }));
            //Application.Run(new Pickup(new Customer { account_id= 10000001, country="Hong Kong", email= "123@123.com" }));}
            //Application.Run(new CheckReport(new Staff{staff_id=10001, position= "Manager"}));
            //Application.Run(new PlaceRegularOoder(new Customer { account_id = 10000001, country = "Hong Kong", email = "123@123.com" }));
        }
    }
}
