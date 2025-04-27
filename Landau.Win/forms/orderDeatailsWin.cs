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

namespace Landau.Win.forms
{
    public partial class orderDeatailsWin : Form
    {
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
            lecturesNseminarsTBL selectedLecture = (lecturesNseminarsTBL)picProductCmbx.SelectedItem;
            if (!Utils.isValidInstitution(adressTxb.Text , errorProviderOrder , adressTxb , "יש להזין כתובת") )
            {
                return;
            }
            subOrderTBL s1 = new subOrderTBL();
            s1.orderID = o1.Id;
            s1.lectureID = selectedLecture.Id;
            s1.date = dtpOrder.Value;
            s1.amountInvited = (int)ammountInvitedUD.Value; ;
            s1.notes = OrderDeatsNotes.Text;
            s1.adress = adressTxb.Text;
            s1 = DBHelper.AddSubOrder(s1);
            if (s1 != null)
            {
                MessageBox.Show("🐋(:סבבי ");
                picProductCmbx.Text = "";
                ammountInvitedUD.Value = 1;
                adressTxb.Text = "";
                OrderDeatsNotes.Text = "";
            }
            else
            {
                MessageBox.Show("וואלה לא סבבה");
            }



        }

        private void finishOrderBtn_Click(object sender, EventArgs e)
        {
            mainWin.OpenAddOrderForm();
        }
    }
}
