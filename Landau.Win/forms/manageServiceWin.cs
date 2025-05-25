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
    public partial class manageServiceWin : Form
    {
        List<serviceTBL> serviceList;
        public manageServiceWin()
        {
            InitializeComponent();
        }

        private void manageServiceWin_Load(object sender, EventArgs e)
        {
            updateDGV();
            pickServiceCmbx.DataSource = DBHelper.allServices;
            pickServiceCmbx.DisplayMember = "serviceName";
            pickServiceCmbx.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updateDGV()
        {
            serviceList = DBHelper.allServices;
            serviceList = serviceList.OrderBy(x => x.serviceName).ToList();
            servicesDGV.DataSource = serviceList;
        }

    private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                return;
            }
            serviceTBL s1 = new serviceTBL();
            s1.serviceName = serviceNameTxb.Text;
            s1.sessionsNum = (int)(howManySessionsUD.Value);
            s1.price = (int)servicePriceUD.Value; ;
            s1.description = serviceDescriptionTxb.Text;
            s1 = DBHelper.AddService(s1);
            if (s1 != null)
            {
                MessageBox.Show("שירות נוסף בהצלחה");
                serviceDescriptionTxb .Text = "";
                servicePriceUD.Value = 1;
                serviceNameTxb.Text = "";
                howManySessionsUD.Value = 1;
                updateDGV();
            }
            else
            {
                MessageBox.Show("וואלה לא סבבה");
            }
        }

        private bool validateForm()
        {
            bool a1 = Utils.isNotEmpty(serviceNameTxb.Text, errorProviderMangeServices, serviceNameTxb, "יש למלא שם תהליך");
            bool a2 = Utils.isNotEmpty(serviceDescriptionTxb.Text, errorProviderMangeServices, serviceDescriptionTxb, "יש למלא תיאור");
            return a1 && a2;
        }
    }
}
