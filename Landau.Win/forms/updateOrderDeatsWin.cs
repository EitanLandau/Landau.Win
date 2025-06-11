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
    public partial class updateOrderDeatsWin : Form
    {
        List<lecturesNseminarsTBL> allLecturesNseminars;
        List<subOrderTBL> allSubOrders;
        List<orderTBL> allorders;
        List<costumerTBL> allcustomers;
        List<orderHistoryView> currentOrder;
        List<orderHistoryView> allOrderHistoryViews;
        public updateOrderDeatsWin()
        {
            InitializeComponent();
        }


        private void updateOrderDeatsWin_Load(object sender, EventArgs e)
        {
            allLecturesNseminars = DBHelper.allLecturesNseminars;
            changeProductCmbx.DataSource = allLecturesNseminars;
            changeProductCmbx.DisplayMember = "title";
            changeProductCmbx.ValueMember = "Id";
            allorders = DBHelper.allOrders;
            pickOrderCmbx.DataSource = allorders;
            pickOrderCmbx.DisplayMember = "Id";
            pickOrderCmbx.ValueMember = "Id";
            allcustomers = DBHelper.allCostumers;
            changeCustomerCmbx.DataSource = allcustomers;
            changeCustomerCmbx.DisplayMember = "fullName";
            changeCustomerCmbx.ValueMember = "Id";
        }
        #region 
        private void changeProductCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        } 
        private void updOrderDateDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updAmmountInvitedUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updOrderHourDtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updAdressTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void updateDGV()
        {
            allOrderHistoryViews = DBHelper.allorderHistoryViews;
            orderTBL selectedOrder = (orderTBL)pickOrderCmbx.SelectedItem;
               currentOrder = allOrderHistoryViews.Where(x => x.Id.Equals(selectedOrder.Id)).ToList();
            orderHistoryDGV.DataSource = currentOrder;
                  }
            private void updOrderBtn_Click(object sender, EventArgs e)
        {

            if (!validateForm())
            {
                return;
            }
           /* if (pickOrderCmbx != null)
            {
                int orderID;
                subOrderTBL s1 = allSubOrders.Where(x => x.Id.Equals(orderID)).FirstOrDefault();
                lecturesNseminarsTBL selectedLecture = (lecturesNseminarsTBL)changeProductCmbx.SelectedItem;
                DateTime DatePart = updOrderDateDtp.Value.Date;
                TimeSpan orderHour = updOrderHourDtp.Value.TimeOfDay;
                s1.lectureID = selectedLecture.Id;
                s1.date = DatePart + orderHour;
                s1.amountInvited = (int)updAmmountInvitedUD.Value;
                s1.notes = updOrderDeatsNotes.Text;
                s1.adress = updAdressTxb.Text;
                DBHelper.UpdateSubOrder(s1);
                changeProductCmbx.Text = "";
                updAmmountInvitedUD.Value = 1;
                updAdressTxb.Text = "";
                updOrderDeatsNotes.Text = "";
            }
            else
            {
                MessageBox.Show("יש למלא מספר הזמנה");
                return;
            }*/

        }
        private bool validateForm()
        {

            bool a1 = Utils.isValidInstitution(updAdressTxb.Text, errorProviderUpdOrderDeats, updAdressTxb, "יש להזין כתובת");
            bool a2 = changeProductCmbx.SelectedItem != "" && changeProductCmbx.SelectedItem != null;
            bool a3 = updAdressTxb.Text != "" && updAdressTxb.Text != null;
            if (!a2)
            {
                errorProviderUpdOrderDeats.SetError(changeProductCmbx, "יש לבחור מוצר");
                return false;
            }
            if (!a3)
            {
                errorProviderUpdOrderDeats.SetError(updAdressTxb, "יש להזין כתובת");
                return false;
            }
            return a1 && a2 && a3;
        }
        private void lecturesNseminarsTBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pickOrderCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            allcustomers = DBHelper.allCostumers;
            allLecturesNseminars = DBHelper.allLecturesNseminars;
            orderTBL selectedOrder = (orderTBL)pickOrderCmbx.SelectedItem;
            updateDGV();
            costumerTBL cust = allcustomers.Where(x => x.Id.Equals(selectedOrder.costumerID)).FirstOrDefault();
            changeCustomerCmbx.Text = cust.fullName;
        }

        private void orderHistoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
