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

        private int[] Role = { 1, 2, 3 };


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
                BaseForm baseForm = new BaseForm(Role[0]);
                baseForm.Show();
            }
            else if (username == "dosen" && password == "dosen")
            {
                this.Hide();
                BaseForm baseForm = new BaseForm(Role[1]);
                baseForm.Show();
            }
            else if (username == "mhs" && password == "mhs")
            {
                this.Hide();
                BaseForm baseForm = new BaseForm(Role[2]);
                baseForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!", "Wrong Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsername.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if(username == "" || password == "")
                {
                    MessageBox.Show("Form can\'t be empty", "Form empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnLogin_Click(this, new EventArgs());
                }
            }
        }

        private void tbUsername_KeyUp(object sender, KeyEventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (username == "" || password == "")
                {
                    MessageBox.Show("Form can\'t be empty", "Form empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnLogin_Click(this, new EventArgs());
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
