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
    public partial class updateProjectWin : Form
    {
        List<projectTrackView> allProjectTrackViews;
        List<projectTrackView> currentProject;
        public updateProjectWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateProjectWin_Load(object sender, EventArgs e)
        {
            projToUpdCmbx.DataSource = DBHelper.allProjects;
            projToUpdCmbx.DisplayMember = "title";
            projToUpdCmbx.ValueMember = "id";

            changeProjCustomerCmbx.DataSource = DBHelper.allCostumers;
            changeProjCustomerCmbx.DisplayMember = "fullName";
            changeProjCustomerCmbx.ValueMember = "id";

            changeServiceCmbx.DataSource = DBHelper.allServices;
            changeServiceCmbx.DisplayMember = "serviceName";
            changeServiceCmbx.ValueMember = "id";

            updMeetingTypeCmbx.DataSource = DBHelper.allMeetingTypes;
            updMeetingTypeCmbx.DisplayMember = "name";
            updMeetingTypeCmbx.ValueMember = "id";
        }

        private void updateDGV()
        {
            projectTBL selectedProject = (projectTBL)projToUpdCmbx.SelectedItem;
            currentProject = allProjectTrackViews.Where(x => x.projectID.Equals(selectedProject.Id)).ToList();
            updProjDGV.DataSource = currentProject;
            currentProject = currentProject.OrderBy(x => x.date).ToList();
        
    }

        private void projToUpdCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDGV();
        }
    }
}
