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
            // Course
            if (e.Node.Name.Contains("Course"))
            {
                listViewCourse.Items.Clear();
                if (e.Node.Name.Contains("Course-Java"))
                {
                    var item = new ListViewItem { ImageIndex = 0, Name = e.Node.Name, Text = e.Node.Text };
                    item.SubItems.Add(new DateTime(2020, 10, 10).ToShortDateString());
                    item.SubItems.Add(new DateTime(2020, 12, 10).ToShortDateString());
                    item.SubItems.Add("8");
                    item.Group = listViewCourse.Groups[1];
                    listViewCourse.Items.Add(item);
                }
                else if (e.Node.Name.Contains("Course-NET"))
                {
                    var item = new ListViewItem { ImageIndex = 0, Name = e.Node.Name, Text = e.Node.Text };

                    item.SubItems.Add(new DateTime(2020, 10, 15).ToShortDateString());
                    item.SubItems.Add(new DateTime(2020, 11, 15).ToShortDateString());
                    item.SubItems.Add("4");
                    item.Group = listViewCourse.Groups[1];
                    listViewCourse.Items.Add(item);
                }
            }

          
            Debug.WriteLine(e.Node.Name);
        }
    }
}

