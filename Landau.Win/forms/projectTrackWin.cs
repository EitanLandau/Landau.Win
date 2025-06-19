using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Landau.Win.forms
{
    public partial class projectTrackWin : Form
    {
        List<projectTBL> allProjects;
        List<projectTrackView> allProjectTrackViews;
        List<projectTrackView> currentProject;
        projectTBL selectedProject;
        public projectTrackWin()
        {
            InitializeComponent();
        }

        private void projectTrackWin_Load(object sender, EventArgs e)
        {
            allProjectTrackViews = DBHelper.allProjectTrackViews;
            allProjects = DBHelper.allProjects;
            pickProjectCmbx.DataSource = allProjects;
            pickProjectCmbx.DisplayMember = "title";
            pickProjectCmbx.ValueMember = "id";
            
            updateDGV();
        }
        private void updateDGV()
        {
            selectedProject = (projectTBL)pickProjectCmbx.SelectedItem;
            currentProject = allProjectTrackViews.Where(x => x.projectID.Equals(selectedProject.Id)).ToList();
            projectMeetingsDGV.DataSource = currentProject;
            currentProject = currentProject.OrderBy(x => x.date).ToList();
        }

        private void projectMeetingsDGV_SelectionChanged(object sender, EventArgs e)
        {
            /*  if (projectMeetingsDGV.CurrentRow != null)
              {
                  DataGridViewRow row = projectMeetingsDGV.CurrentRow;
                  meetingDescriptionTxb.Text = row.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
                  updOrderDateDtp.Value = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
                  updOrderHourDtp.Value = Convert.ToDateTime(row.Cells["dateDataGridViewTextBoxColumn"].Value);
                  updAdressTxb.Text = row.Cells["adressDataGridViewTextBoxColumn"].Value.ToString();
                  updAmmountInvitedUD.Value = Convert.ToInt32(row.Cells["amountInvitedDataGridViewTextBoxColumn"].Value);
                  updOrderDeatsNotesTxb.Text = row.Cells["subOrderNotes"].Value.ToString();
              }*/
        }

        private void pickProjectCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (projectTBL)pickProjectCmbx.SelectedItem;
            updateDGV();
            if (!selectedProject.inProcess)
            {
                nextMeetingDateLbl.Text = "הפרוייקט לא פעיל";
                meetingsLeftLbl.Text = "פגישות שנשארו: 0";
            }
            else
            {
                DateTime today = DateTime.Now;

                // nextMeetingDateLbl.Text = 
            }
        }
    }
}
