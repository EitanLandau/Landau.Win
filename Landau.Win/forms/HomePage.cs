﻿using Landau.Win.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Landau.Win
{
    public partial class HomePage : Form
    {
        Form current;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DBHelper.Init();

        }


        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {

        }
        public void openOrderDetailsWin(orderTBL o1)
        {

            if (current != null)
            {
                if (current is orderDeatailsWin)
                {
                    return;
                }
                current.Close();
            }
            current = new orderDeatailsWin(o1, this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();

        }
        public void OpenAddOrderForm()
        {
            if (current != null)
            {
                if (current is addOrderForm)
                {
                    return;
                }
                current.Close();
            }
            current = new addOrderForm(this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
        private void newOrdedbtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addOrderForm)
                {
                    return;
                }
                current.Close();
            }
            current = new addOrderForm(this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void ordersHistoryBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is orderHistory)
                {
                    return;
                }
                current.Close();
            }
            current = new orderHistory();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCostumerBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addCostumerForm)
                {
                    return;
                }
                current.Close();
            }
            current = new addCostumerForm();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateCustomerForm)
                {
                    return;
                }
                current.Close();
            }
            current = new updateCustomerForm();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void costumerLstBtn_Click(object sender, EventArgs e)
        {

            if (current != null)
            {
                if (current is customerListForm)
                {
                    return;
                }
                current.Close();
            }
            current = new customerListForm();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void costumerFeatures_DialogBoxLauncherClick(object sender, EventArgs e)
        {

        }

        private void addLectureBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addProductWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addProductWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void updateOrderBtn_DropDown(object sender, Krypton.Toolkit.ContextMenuArgs e)
        {

        }

        private void updateOrderBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateOrderDeatsWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateOrderDeatsWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void updLectureBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateProductForm)
                {
                    return;
                }
                current.Close();
            }
            current = new updateProductForm();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void lectureListBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is productList)
                {
                    return;
                }
                current.Close();
            }
            current = new productList();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void mangeServicesBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is manageServiceWin)
                {
                    return;
                }
                current.Close();
            }
            current = new manageServiceWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void openProjectBtn_Click(object sender, EventArgs e)
        {

            if (current != null)
            {
                if (current is openNewProjectWin)
                {
                    return;
                }
                current.Close();
            }
            current = new openNewProjectWin(this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
        public void openNewProject()
        {

            if (current != null)
            {
                if (current is openNewProjectWin)
                {
                    return;
                }
                current.Close();
            }
            current = new openNewProjectWin(this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
        public void openAddMeetingWin(projectTBL p1)
        {

            if (current != null)
            {
                if (current is addMeetingWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addMeetingWin(p1, this);
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();

        }

        private void trackYourProjectBtn_Click(object sender, EventArgs e)
        {

            if (current != null)
            {
                if (current is projectTrackWin)
                {
                    return;
                }
                current.Close();
            }
            current = new projectTrackWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void updProjBtn_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateProjectWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateProjectWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
            {

            }
        }
    }
}
