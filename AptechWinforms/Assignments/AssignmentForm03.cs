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
            //listViewCourse.Columns.Clear();
            listViewCourse.Items.Clear();
            //listViewCourse.Groups.Clear();

            // Course
            if (e.Node.Name.Contains("Course"))
            {
                // Add columns
                //listViewCourse.Columns.Add("Name", 160);
                //listViewCourse.Columns.Add("From Date", 100);
                //listViewCourse.Columns.Add("End Date", 100);
                //listViewCourse.Columns.Add("Duration (Weeks)", 100);

                

                if (e.Node.Name.Contains("Course-Java"))
                {
                    var item1 = new ListViewItem { ImageIndex = 0, Name = @"Sql", Text = @"Sql Server" };
                    item1.SubItems.Add("10/10/2020");
                    item1.SubItems.Add("10/11/2020");
                    item1.SubItems.Add("4");
                    item1.Group = listViewCourse.Groups[0];
                    listViewCourse.Items.Add(item1);


                    var item2 = new ListViewItem { ImageIndex = 0, Name = @"Java", Text = @"Java Full Stack" };
                    item2.SubItems.Add("10/10/2020");
                    item2.SubItems.Add("10/12/2020");
                    item2.SubItems.Add("8");
                    item2.Group = listViewCourse.Groups[1];

                    listViewCourse.Items.Add(item2);

                }
                else if (e.Node.Name.Contains("Course-NET"))
                {
                    var item = new ListViewItem { ImageIndex = 0, Name = @"Java", Text = @"Java Full Stack" };

                    item.SubItems.Add("15/10/2020");
                    item.SubItems.Add("15/12/2020");
                    item.SubItems.Add("8");
                    item.Group = listViewCourse.Groups[1];
                    listViewCourse.Items.Add(item);
                }
            }

          
            Debug.WriteLine(e.Node.Name);
        }
    }
}

