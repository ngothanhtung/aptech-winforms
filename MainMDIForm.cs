using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms
{
    public partial class MainMDIForm : Form
    {
        public MainMDIForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Completed 100%";
        }
    }
}
