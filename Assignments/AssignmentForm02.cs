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
    public partial class AssignmentForm02 : Form
    {
        public AssignmentForm02()
        {
            InitializeComponent();
        }

        private void buttonPizza1_Click(object sender, EventArgs e)
        {
            pictureBoxPizza.Image = Image.FromFile(@"Assignments\Pictures\1.jpg");
        }

        private void buttonPizza2_Click(object sender, EventArgs e)
        {
            pictureBoxPizza.Image = Image.FromFile(@"Assignments\Pictures\2.jpg");
        }
    }
}
