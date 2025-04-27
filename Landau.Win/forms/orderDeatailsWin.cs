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
    public partial class orderDeatailsWin : Form
    {
        orderTBL o1;
        public orderDeatailsWin()
        {
            this.o1 = null;
            InitializeComponent();
        }
        public orderDeatailsWin(orderTBL o1)
        {
            this.o1 = o1;
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
            int selectedLecture = picProductCmbx.SelectedIndex;
            int order = o1.Id;
           
        }
    }
}
