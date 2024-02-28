using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Userhash
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            dataGridView1.DataSource = Form1.users;
            editButton.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

            User selectedUser = Form1.users[selectedIndex];

            selectedUser.Username = usernameTextBox.Text;
            selectedUser.Password = Form1.ComputeHash(passwordTextBox.Text);

            RefreshGrid();

            editButton.Enabled = false;
        }
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                User selectedUser = (User)dataGridView1.Rows[rowIndex].DataBoundItem;

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user confirms deletion
                if (result == DialogResult.Yes)
                {
                    Form1.users.Remove(selectedUser);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string hashedPassword = Form1.ComputeHash(password);

            User userData = new User(username, hashedPassword);
            Form1.users.Add(userData);

            RefreshGrid();
        }
        private void RefreshGrid()
        {
            Form1.SerializeUsersToXml();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Form1.users;
            usernameTextBox.Text = null;
            passwordTextBox.Text = null;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridView1.Rows.Count)
            {
                User clickedUser = (User)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                usernameTextBox.Text = clickedUser.Username;
                passwordTextBox.Text = clickedUser.Password;
                editButton.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = null;
            passwordTextBox.Text = null;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DecrementOpenFormsCount();
        }
    }
}
