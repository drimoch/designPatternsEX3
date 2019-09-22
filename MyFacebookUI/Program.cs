using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// $G$ RUL-999 (-10) Wrong solution name




// $G$ THE-001 (-29) your grade on diagrams document - 71. please see comments inside the document. (50% of your grade).

namespace MyFacebookUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacebookForm());
        }
    }
}
