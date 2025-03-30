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
    public partial class updateCustomerForm : Form
    {
        List<costumerTBL> cstmrList;
        public updateCustomerForm()
        {
            InitializeComponent();
        }

        private void updateCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.costumerTBL' table. You can move, or remove it, as needed.
            this.costumerTBLTableAdapter.Fill(this.dbDataSet.costumerTBL);
            updateComboBox();

        }
        private void updateComboBox()
        {
            cstmrList = DBHelper.allCostumers;
            pickCustomerCmbx.DataSource = cstmrList;
        }
        private void updCustomerDeatils_Click(object sender, EventArgs e)
        {

        }

        private void updFirstNameTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateFormPic_Click(object sender, EventArgs e)
        {

        }

        private void pickCustomerCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
