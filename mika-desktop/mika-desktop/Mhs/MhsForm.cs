using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mika_desktop.Mhs
{
    public partial class MhsForm : Form
    {
        private AddMhsForm addMhsForm;

        public MhsForm()
        {
            InitializeComponent();
        }

        private void MhsForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAddMhs_Click(object sender, EventArgs e)
        {
            // need to pass student's data as parameter to addMhsForm
            // so that we don't need to retrieve data from database
            addMhsForm = new AddMhsForm();
            addMhsForm.MdiParent = ParentForm;
            addMhsForm.Show();
        }
    }
}
