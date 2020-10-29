using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptechWinforms.DataBinding
{
    public partial class DataBindingForm1 : Form
    {
        public DataBindingForm1()
        {
            InitializeComponent();
        }

        private void DataBindingForm1_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.onlineShopDataSet.Categories);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Update(this.onlineShopDataSet.Categories);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add new row
            this.onlineShopDataSet.Categories.AddCategoriesRow("New Name", "New Description");
            this.categoriesTableAdapter.Update(this.onlineShopDataSet.Categories);
        }
    }
}
