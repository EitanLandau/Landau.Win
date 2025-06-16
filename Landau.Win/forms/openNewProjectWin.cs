using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win.forms
{
    public partial class openNewProjectWin : Form
    {
        HomePage mainWin;
        public openNewProjectWin(HomePage mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;
        }

        private void openNewProjectWin_Load(object sender, EventArgs e)
        {
            projectCustomerCmbx.DataSource = DBHelper.allCostumers;
            projectCustomerCmbx.DisplayMember = "fullName";
            projectCustomerCmbx.ValueMember = "Id";
            chooseServiceCmbx.DataSource = DBHelper.allServices;
            chooseServiceCmbx.DisplayMember = "serviceName";
            chooseServiceCmbx.ValueMember = "Id";
        }

        private void continueProjBtn_Click(object sender, EventArgs e)
        {
            costumerTBL selectedCustomer = (costumerTBL)projectCustomerCmbx.SelectedItem;
            if (selectedCustomer == null)
                return;

            projectTBL p1 = new projectTBL();
            p1.customerID = selectedCustomer.Id;
            p1.creationDate = DateTime.Now;
            p1.description = projectDescriptionTxb.Text.Trim();
            p1.inProcess = true;
            p1.meetingsNum = 1;
            p1 = DBHelper.AddProject(p1);
            if (p1 == null)
            {
                MessageBox.Show("ERROR");
                return;
            }
            mainWin.openAddMeetingWin(p1);
        }
    }
}
