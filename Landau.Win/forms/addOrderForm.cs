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
        HomePage mainWin;
        List<costumerTBL> costumers;
        public addOrderForm(HomePage mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;
        }

        private void pickCostumerCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            costumerTBL selectedCustomer = (costumerTBL)pickCostumerCmbx.SelectedItem;
            if (selectedCustomer == null)
                return;

            orderTBL o1 = new orderTBL();
            o1.costumerID = selectedCustomer.Id;
            o1.orderDate = DateTime.Now;
            o1.notes = orderNotesTxb.Text.Trim();
            o1.status = "Pending";
            o1 = DBHelper.AddOrder(o1);
            if (o1 == null)
            {
                MessageBox.Show("ERROR");
                return;
            }
            mainWin.openOrderDetailsWin(o1);
        }

        private void addOrderForm_Load(object sender, EventArgs e)
        {
            costumers = DBHelper.allCostumers;
            pickCostumerCmbx.DataSource = costumers;
            pickCostumerCmbx.DisplayMember = "fullName";
            pickCostumerCmbx.ValueMember = "Id";
        }

        private void pictureBoxAddOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
