using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms.Assignments
{
    public partial class AssignmentForm03 : Form
    {
        public AssignmentForm03()
        {
            InitializeComponent();
        }

        private void treeViewCourse_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewCourse.Items.Clear();

            // Course
            if (e.Node.Name == "Java")
            {
                var item = new ListViewItem();
                item.ImageIndex = 0;
                item.Name = "Java";
                item.Text = "Java Full Stack";

                item.SubItems.Add("10/10/2020");
                item.SubItems.Add("10/12/2020");

                listViewCourse.Items.Add(item);
            }

            Debug.WriteLine(e.Node.Name);
        }
    }
}

