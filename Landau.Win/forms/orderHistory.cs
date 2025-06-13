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
    public partial class orderHistory : Form
    {
        List<orderHistoryView> allorderHistoryViews;
        public orderHistory()
        {
            InitializeComponent();
        }

        private void orderHistory_Load(object sender, EventArgs e)
        {
            updateDGV();
        }
        public void updateDGV()
        {
            allorderHistoryViews = DBHelper.allorderHistoryViews;
            allorderHistoryViews = allorderHistoryViews.OrderBy(x => x.orderID).ToList();
            orderHistoryDGV.DataSource = allorderHistoryViews;
        }
        private void orderHistoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
