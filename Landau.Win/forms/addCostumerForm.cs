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
    public partial class addCostumerForm : Form
    {
        List<costumerTBL> allCustomers;
        public addCostumerForm()
        {
            InitializeComponent();
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCostumerForm_Load(object sender, EventArgs e)
        {
            allCustomers = DBHelper.allCostumers;
            dtpBDate.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void addCostumerDeateilsBtn_Click(object sender, EventArgs e)
        {
            // to add validations

            string firstName = firstNameTxt.Text.Trim();
            string lastName = lastNameTxt.Text.Trim();
            string phone  = phoneMtxb.Text.Trim();
            string email = txbEmail.Text.Trim();
            if (!validateForm())
            {
                return;
            }

                costumerTBL tmp = allCustomers.Where(x => x.firstName.Equals(firstName) && x.lastName.Equals(firstName)).FirstOrDefault();

            if (tmp == null)
            {
                costumerTBL c1 = new costumerTBL();
                c1.firstName = firstName;
                c1.lastName = lastName;
                c1.email = email;
                c1.phoneNumber = phone;
                c1.bDate = dtpBDate.Value;
                c1.regDate = DateTime.Now;
                c1 = DBHelper.AddCostumer(c1);
                if (c1 != null)
                {
                    MessageBox.Show("🦄(: סבבה אגוזים");
                    txbEmail.Text = "";
                    firstNameTxt.Text = "";
                    lastNameTxt.Text = "";
                    phoneMtxb.Text = "";
                    dtpBDate.Text = "";
                }
                else
                {
                    MessageBox.Show("וואלה לא סבבה");
                }
            }
            else
            {
                MessageBox.Show("שם זה כבר נמצא במערכת , או שכבר נרשמת או שתשנה שם");
            }

        }

        private bool validateForm()
        {
            string firstName = firstNameTxt.Text.Trim();
            string lastName = lastNameTxt.Text.Trim();
            string phone = phoneMtxb.Text.Trim();
            string email = txbEmail.Text.Trim();

            bool a1 = Utils.isValidName(firstName, errorProvider1, firstNameTxt, "יש להזין שם תקין");
            bool a2 = Utils.isValidName(lastName, errorProvider1, lastNameTxt, "יש להזין שם תקין");
            bool a3 = Utils.isValidPhoneNumber(phone, errorProvider1, phoneMtxb, "יש להזין מספר טלפון תקין");
            bool a4 = Utils.isValidEmail(email, errorProvider1, txbEmail, "יש להזין כתובת אימייל תקינה");
            return a1 && a2 && a3 && a4;


        }

        private void firstNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void phoneMtxb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addPictureBx_Click(object sender, EventArgs e)
        {

        }
    }
}
