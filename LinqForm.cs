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
    public partial class LinqForm : Form
    {
        private OnlineShopEntities db = new OnlineShopEntities();

        public LinqForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add
            var category = new Category();
            category.Name = "New Name 345";
            category.Description = "New Desc 345";

            this.db.Categories.Add(category);

            this.db.SaveChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete
            var category = db.Categories.Find(40);
            db.Categories.Remove(category);


            // Update
            var categogies = db.Categories.ToList().Where(x => x.Name.Contains("New"));


            foreach (var c in categogies)
            {
                c.Name = "New Name" + DateTime.Now.ToString();
            }

            this.db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var categories1 = from c in db.Categories
                              orderby c.Name
                              select c;
            var result = categories1.ToList();


            var categories2 = db.Categories.OrderBy(c => c.Name).ToList();
        }
    }
}
