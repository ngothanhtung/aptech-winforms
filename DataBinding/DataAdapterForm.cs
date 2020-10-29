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

namespace AptechWinforms.DataBinding
{
    public partial class DataAdapterForm : Form
    {
        private readonly SqlDataAdapter _dataAdapter;
        private readonly DataSet _ds = new DataSet();

        public DataAdapterForm()
        {
            InitializeComponent();
            this._dataAdapter = this.CreateDataAdapter();
        }


        private SqlDataAdapter CreateDataAdapter()
        {
            // 1. Connection
            const string connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            var connection = new SqlConnection(connectionString);

            // SqlDataAdapter
            var da = new SqlDataAdapter();

            // Select Command
            da.SelectCommand = new SqlCommand("SELECT Name, Description FROM Categories", connection);

            // Insert Command
            da.InsertCommand = new SqlCommand("INSERT INTO [Categories] (Name, Description) VALUES (@Name, @Description)", connection);
            da.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, "Name"));
            da.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 0, "Description"));

            // Update Command
            da.UpdateCommand = new SqlCommand("UPDATE [Categories] SET [Name] = @Name, [Description] = @Description WHERE ([Id] = @Id)", connection);
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.NVarChar, 0, "Id")).SourceVersion = DataRowVersion.Original;
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 0, "Name"));
            da.UpdateCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar, 0, "Description"));

            // Delete Command
            da.DeleteCommand = new SqlCommand("DELETE FROM [Categories] WHERE ([Id] = @Id)", connection);
            da.DeleteCommand.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id")).SourceVersion = DataRowVersion.Original;

            return da;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // --------------------------------------------------------------------------------------------------------
            // --------------------------------------------------------------------------------------------------------
            // Add a row /  record
            //var row = ds.Tables[0].NewRow();
            //row["Name"] = "New Cate" + DateTime.Now;
            //row["Description"] = "New Desc";
            //ds.Tables[0].Rows.Add(row);

            // Update
            var editRow = this._ds.Tables[0].Rows.Find(14);
            editRow["Description"] = "Edit Description " + DateTime.Now;

            // Delete
            //var deleteRow = ds.Tables[0].Rows.Find(8);
            //deleteRow.Delete();

            this._dataAdapter.Update(this._ds);
        }

        private void DataAdapterForm_Load(object sender, EventArgs e)
        {
            // Fill data to dataset
            this._dataAdapter.Fill(this._ds);
            this._ds.Tables[0].PrimaryKey = new DataColumn[]
            {
                this._ds.Tables[0].Columns["Id"]
            };

            dataGridView1.DataSource = this._ds.Tables[0];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._dataAdapter.Update(this._ds);
        }
    }
}
