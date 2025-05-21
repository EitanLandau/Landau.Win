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
    public partial class manageServiceWin : Form
    {
        List<serviceTBL> serviceList;
        public manageServiceWin()
        {
            InitializeComponent();
        }

        private void manageServiceWin_Load(object sender, EventArgs e)
        {
            updateDGV();
            pickServiceCmbx.DataSource = DBHelper.allServices;
            pickServiceCmbx.DisplayMember = "serviceName";
            pickServiceCmbx.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updateDGV()
        {
            serviceList = DBHelper.allServices;
            serviceList = serviceList.OrderBy(x => x.serviceName).ToList();
            servicesDGV.DataSource = serviceList;
        }
    }
}
