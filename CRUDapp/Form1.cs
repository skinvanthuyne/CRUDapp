using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CRUDapp
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=C:\\Users\\skinv\\source\\repos\\CRUDapp\\CRUDapp\\Files\\CRUDdatabase.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }

        // Shared method to create and open a database connection
        private SQLiteConnection GetDatabaseConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        // Reusable method to execute non-query commands (INSERT, UPDATE, DELETE)
        private bool ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (var connection = GetDatabaseConnection())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        // Add parameters to the command
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if rows were affected
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            string query = "SELECT person_id, person_firstname, person_lastname, person_role FROM Person;";
            try
            {
                using (var connection = GetDatabaseConnection())
                {
                    connection.Open();
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            var people = new List<Person>();
                            while (reader.Read())
                            {
                                people.Add(new Person
                                {
                                    PersonId = reader.GetInt32(0),
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    Role = reader.GetString(3)
                                });
                            }
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = people;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add person
        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string role = txtRole.Text.Trim();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            string query = "INSERT INTO Person (person_firstname, person_lastname, person_role) VALUES (@FirstName, @LastName, @Role)";
            var parameters = new Dictionary<string, object>
            {
                { "@FirstName", firstname },
                { "@LastName", lastname },
                { "@Role", role }
            };

            if (ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Person added successfully.");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtRole.Clear();
                LoadData(); // Refresh the grid
            }
        }

        // Remove person
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a person to remove.");
                return;
            }

            // Get the person_id from the selected row
            var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Person;
            if (selectedRow == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            int personId = selectedRow.PersonId;

            string query = "DELETE FROM Person WHERE person_id = @PersonId";
            var parameters = new Dictionary<string, object>
            {
                { "@PersonId", personId }
            };

            if (ExecuteNonQuery(query, parameters))
            {
                MessageBox.Show("Person removed successfully.");
                LoadData(); // Refresh the grid
            }
        }

        // Refresh data
        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public class Person
        {
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Role { get; set; }
        }
    }
}

