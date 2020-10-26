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

namespace AptechWinforms
{
    public partial class DataAdapterForm : Form
    {
        public DataAdapterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";

            var ds = new DataSet();
            var sqlCommandText = "SELECT * FROM Categories";
            var da = new SqlDataAdapter(sqlCommandText, connectionString);
            da.InsertCommand = new SqlCommand("INSERT INTO Categories (Name, Description) VALUES (@Name, @Description)", new SqlConnection(connectionString));

            da.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, sourceColumn: "Name"));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 0, sourceColumn: "Description"));

            da.Fill(ds);

            var row = ds.Tables[0].NewRow();
            row["Name"] = "New Cate" + DateTime.Now;
            row["Description"] = "New Desc";
            ds.Tables[0].Rows.Add(row);

            da.Update(ds);
        }
    }
}
