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
        public updateOrderDeatsWin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateOrderDeatsWin_Load(object sender, EventArgs e)
        {
            allLecturesNseminars = DBHelper.allLecturesNseminars;
            allSubOrders = DBHelper.allSubOrders;
            changeProductCmbx.DataSource = allLecturesNseminars;
            changeProductCmbx.DisplayMember = "title";
            changeProductCmbx.ValueMember = "Id";
        }

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

        private void updOrderBtn_Click(object sender, EventArgs e)
        {

            if (!validateForm())
            {
                return;
            }
            if (orderIDTxb.Text != null)
            {
                int orderID;
                orderID = int.Parse(orderIDTxb.Text);
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

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            int orderID;
            if (int.TryParse(orderIDTxb.Text, out int num))
            {
                orderID = int.Parse(orderIDTxb.Text);
                subOrderTBL selectedOrder = allSubOrders.Where(x => x.Id.Equals(orderID)).FirstOrDefault();
                if (selectedOrder == null)
                {
                    MessageBox.Show("יש לבחור לקוח");
                    return;
                }
                DialogResult result = MessageBox.Show(
                    "האם אתה בטוח שאתה רוצה למחוק את הזמנה?",
                    "אישור מחיקה",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DBHelper.DeleteSubOrder(selectedOrder);
                    MessageBox.Show("לקוח נמחק בהצלחה");
                    changeProductCmbx.Text = "";
                    updAmmountInvitedUD.Value = 1;
                    updAdressTxb.Text = "";
                    updOrderDeatsNotes.Text = "";
                }
            }
            else
            {
                MessageBox.Show("מספר לא תקיו");
                return;
            }
        }

        private void conffirmBtn_Click(object sender, EventArgs e)
        {
            int orderID;
            if (int.TryParse(orderIDTxb.Text, out int num))
            {
                orderID = int.Parse(orderIDTxb.Text);
                subOrderTBL SO1 = allSubOrders.Where(x => x.Id.Equals(orderID)).FirstOrDefault();
                if (SO1 != null)
                {
                    lecturesNseminarsTBL current = allLecturesNseminars.Where(x => x.Id.Equals(SO1.lectureID)).FirstOrDefault();
                    changeProductCmbx.Text = current.title;
                    updOrderDateDtp.Value = SO1.date.Date;
                    updOrderHourDtp.Value = SO1.date;
                    updAmmountInvitedUD.Value = SO1.amountInvited;
                    updAdressTxb.Text = SO1.adress;
                    updOrderDeatsNotes.Text = SO1.notes;
                }
                else
                {
                    MessageBox.Show("מספר הזמנה לא קיים במערכת");
                    return;

                }

            }
            else
            {
                MessageBox.Show("מספר לא תקיו");
                return;
            }
        }
    }
}
