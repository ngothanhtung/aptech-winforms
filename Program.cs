using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AptechWinforms.Assignments;
using AptechWinforms.CR;
using AptechWinforms.DataBinding;

namespace AptechWinforms
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
            //Application.Run(new LinqForm());
            //Application.Run(new DataBindingForm1());
            Application.Run(new BasicForm());
        }
    }
}
