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
    public partial class updateProductForm : Form
    {
        public updateProductForm()
        {
            InitializeComponent();
        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                return;
            }

            lecturesNseminarsTBL L1 = new lecturesNseminarsTBL();
            L1.type = updProductTypeCmbx.SelectedItem.ToString() == "סדנא";
            L1.price = (int)updPriceNumUD.Value;
            L1.length = updSessionLengthDtp.Value.TimeOfDay;
            L1.title = updTitleTxb.Text;
            L1.description = updProductDescribtionTxb.Text;

            L1 = DBHelper.AddProduct(L1);
            if (L1 != null)
            {
                MessageBox.Show("🐧(: סבבה תות בננה");
                updProductTypeCmbx.Text = "";
                updPriceNumUD.Value = 0;
                updTitleTxb.Text = "";
                updProductDescribtionTxb.Text = "";
            }
            else
            {
                MessageBox.Show("וואלה לא סבבה");
            }
        }
        private bool validateForm()
        {
            bool a1 = Utils.isNotNull(updProductTypeCmbx.SelectedItem, errorProviderUpdProduct, updProductTypeCmbx, "יש לבחור סוג מוצר");
            bool a2 = Utils.isNotEmpty(updTitleTxb.Text, errorProviderUpdProduct, updTitleTxb, "יש להזין כותרת להרצאה");
            return a1 && a2;
        }
    }
}
