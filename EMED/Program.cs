using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMED
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
            //Application.Run(new Form1());
            //Application.Run(new Prescrib(9,8,"unknown"));
            //Application.Run(new User_Info_Update(9));
            //Application.Run(new Patient_list(11));
            //Application.Run(new Appointment(8));
            //Application.Run(new Report_Upload(20));
            Application.Run(new Authorization());
            //Application.Run(new Doctor_Panel(13));
            //Application.Run(new Patient_Panel(8));
            //Application.Run(new Staff_Panel(17));
        }
    }
}
