using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AptechWinforms
{
    public partial class ADOForm : Form
    {
        public ADOForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            var connection = new SqlConnection(connectionString);
            // 2. Command
            var sqlCommandText = "SELECT * FROM Products";
            var command = new SqlCommand(sqlCommandText, connection);
            // 3. Query / Execute
            connection.Open();
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var price = reader.GetDecimal(2);
            }
            // Close connection
            if (connection.State == System.Data.ConnectionState.Open) 
            {
                connection.Close();
            }
                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            var connection = new SqlConnection(connectionString);
            // 2. Command
            var sqlCommandText = "usp_GetProducts";
            var command = new SqlCommand(sqlCommandText, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            // 3. Query / Execute
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var price = reader.GetDecimal(2);
            }
            // Close connection
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            var connection = new SqlConnection(connectionString);
            // 2. Command
            var sqlCommandText = "usp_GetProducts_ByCategoryId";
            var command = new SqlCommand(sqlCommandText, connection);
            // 2.a Parameters
            command.Parameters.AddWithValue("@CategoryId", 2);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            // 3. Query / Execute
            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var price = reader.GetDecimal(2);
            }
            // Close connection
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Connection
            var connectionString = "server=localhost;database=OnlineShop;uid=dev;password=123456789";
            var connection = new SqlConnection(connectionString);
            // 2. Command
            var sqlCommandText = "INSERT INTO Categories (Name, Description) VALUES (@Name, @Description)";
            var command = new SqlCommand(sqlCommandText, connection);
            // 2.a Parameters
            command.Parameters.AddWithValue("@Name", "New Name XYZ");
            command.Parameters.AddWithValue("@Description", "New Description XYZ");
            command.CommandType = System.Data.CommandType.Text;
            // 3. Query / Execute
            connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
           
            // Close connection
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
