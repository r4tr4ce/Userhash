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
using System.Security.Cryptography;
using System.IO;
using System.Xml;

namespace Userhash
{
    public partial class Form1 : Form
    {
        public static List<User> users = new List<User>();
        private FormContent formContent = new FormContent();
        public static User signed;
        public static int openFormsCount = 0;
        private static string xmlFilePath;
        public Form1()
        {
            InitializeComponent();
            LoadUsersFromXml();
            FormContent formContent = new FormContent();
            this.FormClosed += MainForm_FormClosed;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (username == "admin" && users.Any(u => u.Username == username && u.Password == ComputeHash(password)))
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                openFormsCount++;
                successfullLogin(username,ComputeHash(password));
            }
            else if (users.Any(u => u.Username == username && u.Password == ComputeHash(password)))
            {
                successfullLogin(username,ComputeHash(password));
            }
            else
            {
                MessageBox.Show("Neplatné uživatelské jméno nebo heslo.");
                passwordBox.Text = null;
            }
        }
        private void successfullLogin(string username, string password)
        {
            signed = new User(username, password);
            formContent.labelUser.Text = "Vítejte, " + signed.Username.ToString();
            formContent.Show();
            openFormsCount++;
            this.Visible = false;
        }
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void LoadUsersFromXml()
        {
            try
            {
                string startupPath = Application.StartupPath;
                string projectFolderPath = Directory.GetParent(startupPath)?.Parent?.FullName;
                xmlFilePath = Path.Combine(projectFolderPath, "UserData.xml");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);
                XmlNodeList userNodes = xmlDoc.SelectNodes("//User");
                foreach (XmlNode userNode in userNodes)
                {
                    string username = userNode.SelectSingleNode("Username").InnerText;
                    string password = userNode.SelectSingleNode("Password").InnerText;
                    users.Add(new User(username, password));
                }

                //MessageBox.Show("Users loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void SerializeUsersToXml()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                using (StreamWriter writer = new StreamWriter(xmlFilePath))
                {
                    serializer.Serialize(writer, users);
                }

                //MessageBox.Show("Users serialized to XML successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool anyOpenWindow = Application.OpenForms.Cast<Form>().Any(form => form.Visible);
            if (!anyOpenWindow)
            {
                Application.Exit();
            }
        }
        public static void DecrementOpenFormsCount()
        {
            openFormsCount--;
            CheckIfLastFormClosed();
        }
        private static void CheckIfLastFormClosed()
        {
            if (openFormsCount == 0)
            {
                Application.Exit();
            }
        }
    }
}
