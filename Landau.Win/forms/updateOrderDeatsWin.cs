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
        List<orderTBL> allOrders;
        List<subOrderTBL> allSubOrders;
        public updateOrderDeatsWin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int orderID;
            if (int.TryParse(orderIDTxb.Text, out int num))
            {
            orderID = int.Parse(orderIDTxb.Text);
            subOrderTBL SO1 = allSubOrders.Where(x => x.Id.Equals(orderID)).FirstOrDefault();
          












            }
            else
            {
                MessageBox.Show("מספר לא תקיו");
            }
   

        }

        private void updateOrderDeatsWin_Load(object sender, EventArgs e)
        {
            allOrders = DBHelper.allOrders;
            allSubOrders = DBHelper.allSubOrders;
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

        }
    }
}
