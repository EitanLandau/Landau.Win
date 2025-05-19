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
        public openNewProjectWin()
        {
            InitializeComponent();
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
    }
}
