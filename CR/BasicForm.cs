using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace AptechWinforms.CR
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }

        private void BasicForm_Load(object sender, EventArgs e)
        {
            var rpt = new ReportDocument();
            rpt.Load("CR\\GroupCrystalReport.rpt");
            // Set DatabaseLogon
            rpt.SetDatabaseLogon("dev", "123456789", "localhost", "OnlineShop");

            // Set Parameters
            rpt.SetParameterValue("CompanyName", "Công ty cổ phần Softech");

            crystalReportViewer1.ReportSource = rpt;

            return;

            // Export by coding
            var destinationOptions = new DiskFileDestinationOptions { DiskFileName = "report.pdf" };
            var exportOptions = new ExportOptions
            {
                ExportDestinationType = ExportDestinationType.DiskFile,
                ExportFormatType = ExportFormatType.PortableDocFormat,
                DestinationOptions = destinationOptions
            };
            rpt.Export(exportOptions);
        }
    }
}
