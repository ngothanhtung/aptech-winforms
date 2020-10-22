using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms.Assignments
{
    public partial class AssignmentForm01 : Form
    {
        public AssignmentForm01()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submit", "TalkTime Call Center");
        }

        private void AssignmentForm01_Load(object sender, EventArgs e)
        {
            // Add combobox items by coding
            comboBoxCountry.Items.Add("VN");
            comboBoxCountry.Items.Add("US");
            comboBoxCountry.Items.Add("FR");
            comboBoxCountry.Items.Add("EN");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://aptech-danang.edu.vn");
        }
    }
}
