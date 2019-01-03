using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using SoftAssurance2;

namespace SoftAssurance
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
            Application.Run(new Form1());

            var opportunityManager = new DashboardManager();
            var account = new Account();
            var contact = new Contact();
            Opportunity opportunity = opportunityManager.CreateOpportunity(account, contact, "test opportunity");
        }
    }
}
