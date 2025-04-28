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
    public partial class addProductWin : Form
    {
        List<lecturesNseminarsTBL> allLecturesNseminars;
        public addProductWin()
        {
            InitializeComponent();
        }
        private void addProductWin_Load(object sender, EventArgs e)
        {
            allLecturesNseminars = DBHelper.allLecturesNseminars;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string title = titleTxb.Text;

            /*if (!validateForm())
              {
                return;
            }*/
            lecturesNseminarsTBL tmp = allLecturesNseminars.Where(x => x.title.Equals(title)).FirstOrDefault();

            if (tmp == null)
            {
                lecturesNseminarsTBL L1 = new lecturesNseminarsTBL();
                L1.type = productTypeCmbx.SelectedItem == "סדנא";
                L1.price = (int)priceNumUD.Value;
                L1.length = sessionLengthDtp.Value.TimeOfDay;
                L1.title = titleTxb.Text;
                L1.description = productDescribtionTxb.Text;
                L1 = DBHelper.AddProduct(L1);
                if (L1 != null)
                {
                    MessageBox.Show("🐧(: סבבה תות בננה");
                    productTypeCmbx.Text = "";
                    priceNumUD.Value = 0;
                    titleTxb.Text = "";
                    productDescribtionTxb.Text = "";
                }
                else
                {
                    MessageBox.Show("וואלה לא סבבה");
                }
            }
            else
            {
                MessageBox.Show("יש כבר מוצר בשם הזה");
            }
        }
    }
}
