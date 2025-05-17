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
  
            if (!validateForm())
            {
                return;
            }

            lecturesNseminarsTBL L1 = new lecturesNseminarsTBL();
            L1.type = productTypeCmbx.SelectedItem.ToString() == "סדנא";
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



        private bool validateForm()
        {
            bool a1 = Utils.isNotNull(productTypeCmbx.SelectedItem, errorProviderProduct, productTypeCmbx, "יש לבחור סוג מוצר");
            bool a2 = Utils.isNotEmpty(titleTxb.Text, errorProviderProduct, titleTxb, "יש להזין כותרת להרצאה");
            return a1 && a2;
                }

        private void addProductWin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
