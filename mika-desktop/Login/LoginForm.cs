using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mika_desktop.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username == "admin" && password == "admin")
            {
                this.Hide();
                BaseForm baseForm = new BaseForm(1);
                baseForm.Show();
            }
            else if (username == "dosen" && password == "dosen")
            {
                this.Hide();
                BaseForm baseForm = new BaseForm(2);
                baseForm.Show();
            }
            else if (username == "mhs" && password == "mhs")
            {
                this.Hide();
                BaseForm baseForm = new BaseForm(3);
                baseForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
