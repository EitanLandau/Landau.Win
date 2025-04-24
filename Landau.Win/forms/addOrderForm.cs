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
    public partial class addOrderForm : Form
    {
        orderTBL selectedcostumer;
        public addOrderForm()
        {
            InitializeComponent();
        }

        private void pickCostumerCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void continueBtn_Click(object sender, EventArgs e)
        {

        }

        private void addOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.costumerTBL' table. You can move, or remove it, as needed.
            this.costumerTBLTableAdapter.Fill(this.dbDataSet.costumerTBL);

        }
    }
}
