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
    public partial class addMeetingWin : Form
    {
        HomePage mainWin;
        projectTBL p1;
        List<meetingTypeTBL> allMeetingTypes;
        public addMeetingWin()
        {
            InitializeComponent();
        }
        public addMeetingWin(projectTBL p1, HomePage mainWin)
        {
            this.p1 = p1;
            this.mainWin = mainWin;
            InitializeComponent();
        }

        private void addMeetingWin_Load(object sender, EventArgs e)
        {
            allMeetingTypes = DBHelper.allMeetingTypes;
            meetingTypeCmbx.DataSource = allMeetingTypes;
            meetingTypeCmbx.DisplayMember = "name";
            meetingTypeCmbx.ValueMember = "id";
            meetingDateDtp.MinDate = DateTime.Now;
        }

        private void addMeetingBtn_Click(object sender, EventArgs e)
        {
            meetingTypeTBL type = (meetingTypeTBL)meetingTypeCmbx.SelectedItem;
            if (!validateForm())
            {
                return;
            }
            meetingTBL m1 = new meetingTBL();
            TimeSpan t = meetingDurationDtp.Value.TimeOfDay;
            m1.projectID = p1.Id;
            m1.typeID = type.Id;
            m1.date = meetingDateDtp.Value.Date;
            m1.duration = t;
            m1.notes = meetingDescriptionTxb.Text;
            m1.address = addressTxb.Text;
            m1.topic = meetingTitleTxb.Text;
            m1 = DBHelper.AddMeeting(m1);
            if (m1 != null)
            {
                MessageBox.Show("פגישה נוספה בהצלחה");
                meetingTypeCmbx.Text = "";
                meetingDateDtp.Value = DateTime.Now;
                addressTxb.Text = "";
                meetingDescriptionTxb.Text = "";
                meetingTitleTxb.Text = "";
            }
            else
            {
                MessageBox.Show("וואלה לא סבבה");
            }
        }
        private bool validateForm()
        {
            bool a1 = true/*Utils.isNotNull(productTypeCmbx.SelectedItem, errorProviderProduct, productTypeCmbx, "יש לבחור סוג מוצר")*/;
            bool a2 = true/*Utils.isNotEmpty(titleTxb.Text, errorProviderProduct, titleTxb, "יש להזין כותרת להרצאה")*/;
            return a1 && a2;
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {
                mainWin.openNewProject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBHelper.DeleteProject(p1))
            {
                mainWin.openNewProject();
            }
            else
            {
                MessageBox.Show("לא סבבי בכלל");
            }
        }
    }
}
