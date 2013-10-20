#region Code Info
/*
 * Date                 Comments
 * 2013-10-20           Initially Created  
 */
#endregion Code Info

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace YouTubeAnalyticsExtracter
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
            Application.Run(new Analytics());
        }
    }
}
