﻿using System;
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
        List<meetingTypeTBL> allMeetingTypes;
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
            if (projectMeetingsDGV.CurrentRow != null)
              {
                  DataGridViewRow row = projectMeetingsDGV.CurrentRow;
                  meetingDescriptionTxb.Text = row.Cells["notes"].Value.ToString();
                  meetingTopicTxb.Text = row.Cells["topic"].Value.ToString();
              }
        }

        private void pickProjectCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProject = (projectTBL)pickProjectCmbx.SelectedItem;
            projectNameLbl.Text = selectedProject.title;
            projectDescriptionTxb.Text = selectedProject.description;
            projectCreationDateTxb.Text = selectedProject.creationDate.Date.ToString("D", new CultureInfo("he-IL"));
            DateTime today = DateTime.Now;
            List<projectTrackView> lst = allProjectTrackViews.Where(x => x.projectID.Equals(selectedProject.Id) && x.date >= today).ToList();

            if (lst.Count == 0)
            {
                nextMeetingDateLbl.Text = "הפרוייקט לא פעיל";
                meetingsLeftLbl.Text = "פגישות שנשארו: 0";
            }
            else
            {
                nextMeetingDateLbl.Text = "פגישה הבאה:" + lst.FirstOrDefault().date.ToString("D", new CultureInfo("he-IL"));
                meetingsLeftLbl.Text = "פגישות שנשארו:" + lst.Count;
            }
            updateDGV();
        }

        private void projectMeetingsDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                allMeetingTypes = DBHelper.allMeetingTypes;
                DataGridViewCell cell = projectMeetingsDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                meetingTypeTBL selectedType = allMeetingTypes.FirstOrDefault(x => x.name.Equals(cell.Value.ToString()));
                string str = "";
                str += "סוג פגישה:" + selectedType.name + "\n";
                if (selectedType.isRequiresPreparation)
                    str += " דורש הכנה מוקדמת?: כן" + "\n";
                else
                    str += " דורש הכנה מוקדמת?: לא" + "\n";

                if (selectedType.multiParticipant)
                    str += " רב משתתפים?: כן" + "\n";
                else
                    str += " רב משתתפים?: לא" + "\n";

                str += "תיאור:" + selectedType.description;

                cell.ToolTipText = str;
            }
            else
            {
                return;
            }
        }
    }
}
