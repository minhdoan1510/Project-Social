using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    static class main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new fLogin());
            Form f = new Form();
            UCLoading uCLoading = new UCLoading();
            //uCLoading.Dock = DockStyle.Fill;
            f.Controls.Add(uCLoading);
            f.ShowDialog();
        
            //Application.Run(f);
        }
    }
}
