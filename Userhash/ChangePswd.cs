using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Userhash
{
    public partial class ChangePswd : Form
    {
        public ChangePswd()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (Form1.ComputeHash(textBoxOldPswd.Text) == Form1.signed.Password)
            {
                if (!string.IsNullOrEmpty(textBoxNewPswd.Text) && textBoxNewPswd.Text == textBoxNewPswd2.Text)
                {
                    User userToUpdate = Form1.users.FirstOrDefault(u => u.Username == Form1.signed.Username);
                    userToUpdate.Password = Form1.ComputeHash(textBoxNewPswd.Text);
                    MessageBox.Show("Heslo bylo úspěšně změněno. ");
                    Form1.SerializeUsersToXml();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nová hesla se neshodují nebo jsou prázdná. ");
                }
            }
            else
            {
                MessageBox.Show("Špatné aktuální heslo. ");
            }
        }

        private void ChangePswd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DecrementOpenFormsCount();
        }
    }
}
