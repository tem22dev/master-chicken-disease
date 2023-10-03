using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils;
using static Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.utils.Constants;

namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", Config.PrologHomeDir);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frMain());
        }
    }
}
