using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userhash
{
    internal class Db
    {
        static string connectionString = string.Format("Data Source={0};Version=3;", Path.Combine(Form1.projectFolderPath, "mydatabase.db"));
        private static SQLiteConnection connection = new SQLiteConnection(connectionString);
        public static void Connect()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connected to SQLite!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }
        public static void Update()
        {
            string createTableSql = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT, admin BOOL)";
            string insertSql = "INSERT INTO users (username, password, admin) VALUES (@username, @password, @admin)";

            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection);
            SQLiteCommand insertCommand = new SQLiteCommand(insertSql, connection);

            string pswd = Form1.ComputeHash("heslo123");
            insertCommand.Parameters.AddWithValue("@username", "pepa");
            insertCommand.Parameters.AddWithValue("@password", pswd);
            insertCommand.Parameters.AddWithValue("@admin", false);

            try
            {
                connection.Open();
                createTableCommand.ExecuteNonQuery();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Table created and data inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }
        public static void LoadData()
        {
            connection.Open();
            string query = "SELECT * FROM users";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string password = reader.GetString(2);
                        MessageBox.Show($"ID: {id}, Name: {name}, Pwd: {password}");
                    }
                }
            }
            connection.Close();
        }
    }
}
