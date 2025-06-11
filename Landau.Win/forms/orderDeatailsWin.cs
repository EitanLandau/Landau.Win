using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Landau.Win.forms
{
    public partial class orderDeatailsWin : Form
    {
        int subOrderCounter = 0;
        HomePage mainWin;
        orderTBL o1;
        public orderDeatailsWin()
        {
            this.o1 = null;
            InitializeComponent();
        }
        public orderDeatailsWin(orderTBL o1 , HomePage mainWin)
        {
            this.o1 = o1;
            this.mainWin = mainWin;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addSubOrderBtn_Click(object sender, EventArgs e)
        {
            lecturesNseminarsTBL selectedLecture = (lecturesNseminarsTBL)pickProductCmbx.SelectedItem;
            if (!validateForm())
            {
                return;
            }
            subOrderTBL s1 = new subOrderTBL();
            DateTime DatePart = orderDateDtp.Value.Date;
            TimeSpan orderHour = orderHourDtp.Value.TimeOfDay;
            s1.orderID = o1.Id;
            s1.lectureID = selectedLecture.Id;
            s1.date = DatePart + orderHour;
            s1.amountInvited = (int)ammountInvitedUD.Value; ;
            s1.notes = OrderDeatsNotes.Text;
            s1.adress = adressTxb.Text;
            s1 = DBHelper.AddSubOrder(s1);
            if (s1 != null)
            {
                MessageBox.Show("הזמנה נוספה בהצלחה");
                pickProductCmbx.Text = "";
                ammountInvitedUD.Value = 1;
                adressTxb.Text = "";
                OrderDeatsNotes.Text = "";
                subOrderCounter++;
            }
            else
            {
                MessageBox.Show("וואלה לא סבבה");
            }



        }

        private void finishOrderBtn_Click(object sender, EventArgs e)
        {
            if (subOrderCounter == 0)
            {
                DialogResult result = MessageBox.Show(
"לא נוספה שום הזמנה לסל בטוח שאתה רוצה להמשיך? ",
"המשך הזמנה",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mainWin.OpenAddOrderForm();
                }
            }
            if (!validateForm() && subOrderCounter == 0)
            {
                DialogResult result = MessageBox.Show(
    "יש למלא פרטי הזמנה",
    "שגיאה בהזמנה",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    DBHelper.DeleteOrder(o1);
                    mainWin.OpenAddOrderForm();
                }
            }
            if (!validateForm()) {
                MessageBox.Show("מספר הזמנה: "+o1.Id);
                mainWin.OpenAddOrderForm();
                 }
        }

        private bool validateForm()
        {
         
            bool a1 = Utils.isValidInstitution(adressTxb.Text, errorProviderOrder, adressTxb, "יש להזין כתובת");
            bool a2 = pickProductCmbx.SelectedItem != "" && pickProductCmbx.SelectedItem != null;
            bool a3 = adressTxb.Text != "" && adressTxb.Text != null;
            if (!a2)
            {
                errorProviderOrder.SetError(pickProductCmbx, "יש לבחור מוצר");
                return false;
            }
            if (!a3)
            {
                errorProviderOrder.SetError(adressTxb, "יש להזין כתובת");
                return false;
            }
            return a1 && a2 && a3;
        }


        private void orderDeatailsWin_Load(object sender, EventArgs e)
        {
            pickProductCmbx.DataSource = DBHelper.GetAllLecturesNseminars();
            pickProductCmbx.DisplayMember = "title";
        }

        private void orderDateDtp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
