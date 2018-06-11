using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mika_desktop.Admin.AdminMhs;
using mika_desktop.Dataset;

namespace mika_desktop.Mhs
{
    public partial class MhsForm : Form
    {
  
        private Admin.AdminMhs.UpdateMhsForm admMhs;
        private Dataset.DataSetMIKA.Mhs_profilDataTable dsprof;
        public int nomor = 0;

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
            //addMhsForm = new AddMhsForm();
            //addMhsForm.MdiParent = ParentForm;
            //addMhsForm.Show();

            
            admMhs = new UpdateMhsForm();
            admMhs.MdiParent = this.MdiParent;
            admMhs.Show();
        }
        public void isidgv()
        {
            //belum ketemu cara input data secara spesifik dari multiple data set ke datagridview dengan projek yang berbeda
        }


        private void btnRefreshMhs_Click(object sender, EventArgs e)
        {
            isidgv();
        }
    }
}
