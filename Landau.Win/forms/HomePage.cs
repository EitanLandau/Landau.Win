using Landau.Win.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win
{
    public partial class HomePage : Form
    {
        Form current;
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDeateils_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void איתן(object sender, EventArgs e)
        {


        }

        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void newOrdedbtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addOrderForm)
                {
                    return;
                }
                current.Close();
            }
            current = new addOrderForm();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            addOrderPanel.Controls.Add(current);
            current.Show();
        }

        private void ordersHistoryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
