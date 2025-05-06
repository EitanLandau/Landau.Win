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
            orderTBL O1 = allOrders.Where(x => x.Id.Equals(orderID)).FirstOrDefault();
            












            }
            else
            {
                MessageBox.Show("מספר לא תקיו");
            }
   

        }

        private void updateOrderDeatsWin_Load(object sender, EventArgs e)
        {
            allOrders = DBHelper.allOrders;
        }
    }
}
