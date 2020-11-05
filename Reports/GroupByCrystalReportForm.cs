using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms.Reports
{
    public partial class GroupByCrystalReportForm : Form
    {
        public GroupByCrystalReportForm()
        {
            InitializeComponent();
        }

        private void GroupByCrystalReportForm_Load(object sender, EventArgs e)
        {
            GroupByReport1.SetParameterValue("CategoryId", 2);
        }
    }
}
