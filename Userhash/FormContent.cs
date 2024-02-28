using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userhash
{
    public partial class FormContent : Form
    {
        public FormContent()
        {
            InitializeComponent();
        }

        private void buttonPswdChange_Click(object sender, EventArgs e)
        {
            ChangePswd changePswd = new ChangePswd();
            changePswd.Show();
            Form1.openFormsCount++;
        }

        private void FormContent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.DecrementOpenFormsCount();
        }
    }
}
