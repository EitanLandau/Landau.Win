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
    public partial class customerListForm : Form
    {
        List<costumerTBL> custList;
        public customerListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDGV_Load(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void updateDGV()
        {
            custList = DBHelper.allCostumers;
            custList = custList.OrderBy(x => x.fullName).ToList();
            customerListDGV.DataSource = custList;
            lblTotalCustomers.Text = "סך לקוחות : "+custList.Count;
        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
