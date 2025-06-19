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
            selectedProject = (projectTBL)pickProjectCmbx.SelectedItem;
            allProjectTrackViews = DBHelper.allProjectTrackViews;
            allProjects = DBHelper.allProjects;
            pickProjectCmbx.DataSource = allProjects;
            pickProjectCmbx.DisplayMember = "title";
            pickProjectCmbx.ValueMember = "id";
            updateDGV();
        }
        private void updateDGV()
        {
            currentProject = allProjectTrackViews.Where(x => x.projectID.Equals(selectedProject.Id)).ToList();
            projectMeetingsDGV.DataSource = currentProject;
            currentProject = currentProject.OrderBy(x => x.date).ToList();
            projectNameLbl.Text = selectedProject.title;
        }


    }
}
