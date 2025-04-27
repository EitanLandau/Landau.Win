using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win.forms
{
    public partial class updateCustomerForm : Form
    {
        List<costumerTBL> cstmrList;
        public updateCustomerForm()
        {
            InitializeComponent();
        }

        private void updateCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.costumerTBL' table. You can move, or remove it, as needed.
            this.costumerTBLTableAdapter.Fill(this.dbDataSet.costumerTBL);
            updateComboBox();

        }
        private void updateComboBox()
        {
            cstmrList = DBHelper.allCostumers;
            pickCustomerCmbx.DataSource = cstmrList;
        }
        private void updCustomerDeatils_Click(object sender, EventArgs e)
        {
            costumerTBL selectedCustomer = (costumerTBL)pickCustomerCmbx.SelectedItem;
            if (selectedCustomer == null)
            {
                return;
            }
            if (!ValidateUpdate()) { 
                return ;
               }
            selectedCustomer.firstName = updFirstNameTxb.Text.Trim();
            selectedCustomer.lastName = updLastNameTxb.Text.Trim();
            selectedCustomer.email = updEmailTxb.Text.Trim();
            selectedCustomer.phoneNumber = updPhoneMtxb.Text.Trim();
            selectedCustomer.bDate = updBdateDtp.Value;
            selectedCustomer.notes = updNotesTxb.Text.Trim();
            selectedCustomer.institution = updInstitutionTxb.Text.Trim();
            DBHelper.UpdateCostumer(selectedCustomer);
            updFirstNameTxb.Text = "";
            updLastNameTxb.Text = "";
            updEmailTxb .Text = "";
            updPhoneMtxb.Text = "";
            updBdateDtp.Text = "";
            updNotesTxb.Text = "";
            updInstitutionTxb.Text = "";

        }
        private bool ValidateUpdate()
        {
            bool a1 = Utils.isValidName( updFirstNameTxb.Text, errorProvider1, updFirstNameTxb, "יש למלא שם ללקוח");
            bool a2 = Utils.isValidName(updLastNameTxb.Text, errorProvider1, updLastNameTxb, "יש למלא שם ללקוח");
            bool a3 = Utils.isValidPhoneNumber(updPhoneMtxb.Text, errorProvider1, updPhoneMtxb , "יש למלא מספר טלפון");
            bool a4 = Utils.isValidEmail(updEmailTxb.Text, errorProvider1, updEmailTxb, "יש למלא אימייל");
            bool a5 = Utils.isValidInstitution(updInstitutionTxb.Text, errorProvider1, updInstitutionTxb, "יש להזין מוסד");
            return a1 && a2 && a3 && a4;
        }
        private void updFirstNameTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateFormPic_Click(object sender, EventArgs e)
        {

        }

        private void pickCustomerCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
          costumerTBL selectedCustomer = (costumerTBL)pickCustomerCmbx.SelectedItem;
            if (selectedCustomer == null)
            {
                return;
            }
            updFirstNameTxb.Text = selectedCustomer.firstName;
            updLastNameTxb.Text = selectedCustomer.lastName;
            updEmailTxb.Text = selectedCustomer.email;
            updPhoneMtxb.Text = selectedCustomer.phoneNumber;
            updNotesTxb.Text = selectedCustomer.notes;
            updBdateDtp.Value = selectedCustomer.bDate;
            updInstitutionTxb.Text = selectedCustomer.institution;
            
        }

        private void pickCustLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
