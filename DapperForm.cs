using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace AptechWinforms
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public partial class DapperForm : Form
    {
        public DapperForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            using (var db = new SqlConnection(connectionString))
            {
                var parameter = new
                {
                    CategoryId = 1
                };
                var list = db.Query<Product>(sql: "usp_GetProducts_ByCategoryID", param: parameter, commandType: CommandType.StoredProcedure);
            }

        }
    }
}
