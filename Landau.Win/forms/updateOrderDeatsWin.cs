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
        costumerTBL tmp;
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
            updateDGV();
            
        }
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
            if (pickOrderCmbx != null)
            {
                allSubOrders = DBHelper.allSubOrders;
                DataGridViewRow current = orderHistoryDGV.CurrentRow;
                orderTBL selectedOrder = (orderTBL)pickOrderCmbx.SelectedItem;
                int subOrderId = Convert.ToInt32(current.Cells["orderId"].Value);
                subOrderTBL s1 = allSubOrders.Where(x => x.Id.Equals(subOrderId)).FirstOrDefault();
                lecturesNseminarsTBL selectedLecture = (lecturesNseminarsTBL)changeProductCmbx.SelectedItem;
                DateTime DatePart = updOrderDateDtp.Value.Date;
                TimeSpan orderHour = updOrderHourDtp.Value.TimeOfDay;
                s1.lectureID = selectedLecture.Id;
                s1.date = DatePart + orderHour;
                s1.amountInvited = (int)updAmmountInvitedUD.Value;
                s1.notes = updOrderNotesTxb.Text;
                s1.adress = updAdressTxb.Text;
                selectedOrder.notes = updOrderDeatsNotesTxb.Text;
                costumerTBL changeCust = (costumerTBL)changeCustomerCmbx.SelectedItem;
                selectedOrder.costumerID = changeCust.Id;
                if (DBHelper.UpdateOrder(selectedOrder) && DBHelper.UpdateSubOrder(s1)) { 

                    MessageBox.Show("הזמנה עודכנה בהצלחה");
                    changeProductCmbx.Text = "";
                    updAmmountInvitedUD.Value = 1;
                    updAdressTxb.Text = "";
                    updOrderDeatsNotesTxb.Text = "";
                    updOrderDeatsNotesTxb.Text = "";
                    updateDGV();
                }
            else
            {
                    MessageBox.Show("וואלה משהו לא סבבה");
                }
            }
            else
            {
                MessageBox.Show("יש למלא מספר הזמנה");
                return;
            }

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
            updOrderNotesTxb.Text = selectedOrder.notes;
            tmp = cust;
        }
        private void orderHistoryDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(orderHistoryDGV.CurrentRow != null)
            {
               DataGridViewRow row = orderHistoryDGV.CurrentRow;
                changeProductCmbx.Text = row.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
                updOrderDateDtp.Value = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
                updOrderHourDtp.Value = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
                updAdressTxb.Text = row.Cells["adressDataGridViewTextBoxColumn"].Value.ToString();
                updAmmountInvitedUD.Value = Convert.ToInt32(row.Cells["amountInvitedDataGridViewTextBoxColumn"].Value);
                updOrderDeatsNotesTxb.Text = row.Cells["subOrderNotes"].Value.ToString();
            }
        }

        private void changeProductCmbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
