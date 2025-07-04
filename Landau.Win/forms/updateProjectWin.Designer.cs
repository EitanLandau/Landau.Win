﻿
namespace Landau.Win.forms
{
    partial class updateProjectWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateProjectWin));
            this.changeProjCustomerCmbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.projToUpdCmbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updOrderDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderNotesTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeServiceCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updProjDGV = new System.Windows.Forms.DataGridView();
            this.projectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTrackViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.meetingTitleTxb = new System.Windows.Forms.TextBox();
            this.meetingDurationDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.meetingDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updMeetingTypeCmbx = new System.Windows.Forms.ComboBox();
            this.addressTxb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.continueProjBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.meetingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingTypeTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.updProjDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // changeProjCustomerCmbx
            // 
            this.changeProjCustomerCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeProjCustomerCmbx.DataSource = this.costumerTBLBindingSource;
            this.changeProjCustomerCmbx.DisplayMember = "fullName";
            this.changeProjCustomerCmbx.FormattingEnabled = true;
            this.changeProjCustomerCmbx.Location = new System.Drawing.Point(853, 270);
            this.changeProjCustomerCmbx.Name = "changeProjCustomerCmbx";
            this.changeProjCustomerCmbx.Size = new System.Drawing.Size(211, 24);
            this.changeProjCustomerCmbx.TabIndex = 63;
            this.changeProjCustomerCmbx.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(1198, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 62;
            this.label9.Text = "שנה לקוח";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(548, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "פרטי הזמנה";
            // 
            // projToUpdCmbx
            // 
            this.projToUpdCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projToUpdCmbx.DataSource = this.projectTBLBindingSource;
            this.projToUpdCmbx.DisplayMember = "Id";
            this.projToUpdCmbx.FormattingEnabled = true;
            this.projToUpdCmbx.Location = new System.Drawing.Point(853, 114);
            this.projToUpdCmbx.Name = "projToUpdCmbx";
            this.projToUpdCmbx.Size = new System.Drawing.Size(214, 24);
            this.projToUpdCmbx.TabIndex = 59;
            this.projToUpdCmbx.ValueMember = "Id";
            this.projToUpdCmbx.SelectedIndexChanged += new System.EventHandler(this.projToUpdCmbx_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(1169, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = "בחר פרוייקט";
            // 
            // updOrderDateDtp
            // 
            this.updOrderDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDateDtp.CalendarTodayDate = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.updOrderDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updOrderDateDtp.Location = new System.Drawing.Point(853, 431);
            this.updOrderDateDtp.Name = "updOrderDateDtp";
            this.updOrderDateDtp.Size = new System.Drawing.Size(211, 26);
            this.updOrderDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderDateDtp.TabIndex = 57;
            // 
            // updOrderNotesTxb
            // 
            this.updOrderNotesTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderNotesTxb.Location = new System.Drawing.Point(853, 578);
            this.updOrderNotesTxb.Multiline = true;
            this.updOrderNotesTxb.Name = "updOrderNotesTxb";
            this.updOrderNotesTxb.Size = new System.Drawing.Size(214, 174);
            this.updOrderNotesTxb.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(1153, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "תיאור פרוייקט";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1159, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "תאריך פגישה";
            // 
            // changeServiceCmbx
            // 
            this.changeServiceCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeServiceCmbx.DataSource = this.serviceTBLBindingSource;
            this.changeServiceCmbx.DisplayMember = "serviceName";
            this.changeServiceCmbx.FormattingEnabled = true;
            this.changeServiceCmbx.Location = new System.Drawing.Point(853, 359);
            this.changeServiceCmbx.Name = "changeServiceCmbx";
            this.changeServiceCmbx.Size = new System.Drawing.Size(211, 24);
            this.changeServiceCmbx.TabIndex = 53;
            this.changeServiceCmbx.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(1183, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "בחר תהליך";
            // 
            // updProjDGV
            // 
            this.updProjDGV.AllowUserToAddRows = false;
            this.updProjDGV.AllowUserToDeleteRows = false;
            this.updProjDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updProjDGV.AutoGenerateColumns = false;
            this.updProjDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updProjDGV.ColumnHeadersHeight = 29;
            this.updProjDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.updProjDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectID,
            this.meetingID,
            this.name,
            this.topic,
            this.description,
            this.meetingIDDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn,
            this.typeIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.topicDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.serviceIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.institutionDataGridViewTextBoxColumn});
            this.updProjDGV.DataSource = this.projectTrackViewBindingSource;
            this.updProjDGV.Location = new System.Drawing.Point(302, 91);
            this.updProjDGV.Name = "updProjDGV";
            this.updProjDGV.ReadOnly = true;
            this.updProjDGV.RowHeadersVisible = false;
            this.updProjDGV.RowHeadersWidth = 51;
            this.updProjDGV.RowTemplate.Height = 24;
            this.updProjDGV.Size = new System.Drawing.Size(625, 478);
            this.updProjDGV.TabIndex = 60;
            // 
            // projectID
            // 
            this.projectID.DataPropertyName = "projectID";
            this.projectID.HeaderText = "מספר פרוייקט";
            this.projectID.MinimumWidth = 6;
            this.projectID.Name = "projectID";
            this.projectID.ReadOnly = true;
            // 
            // meetingID
            // 
            this.meetingID.DataPropertyName = "meetingID";
            this.meetingID.HeaderText = "מספר פגישה";
            this.meetingID.MinimumWidth = 6;
            this.meetingID.Name = "meetingID";
            this.meetingID.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "סוג פגישה";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // topic
            // 
            this.topic.DataPropertyName = "topic";
            this.topic.HeaderText = "תיאור פגישה";
            this.topic.MinimumWidth = 6;
            this.topic.Name = "topic";
            this.topic.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "תיאור פרוייקט";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // projectTrackViewBindingSource
            // 
            this.projectTrackViewBindingSource.DataSource = typeof(Landau.Win.projectTrackView);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(853, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(1124, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "שנה שם פרוייקט";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DisplayMember = "title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל"});
            this.comboBox1.Location = new System.Drawing.Point(853, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 24);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(1113, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "שנה סטטוס פעיל";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(326, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 81;
            this.label6.Text = "שנה כותרת";
            // 
            // meetingTitleTxb
            // 
            this.meetingTitleTxb.Location = new System.Drawing.Point(24, 114);
            this.meetingTitleTxb.Name = "meetingTitleTxb";
            this.meetingTitleTxb.Size = new System.Drawing.Size(215, 22);
            this.meetingTitleTxb.TabIndex = 80;
            // 
            // meetingDurationDtp
            // 
            this.meetingDurationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.meetingDurationDtp.Location = new System.Drawing.Point(16, 469);
            this.meetingDurationDtp.Name = "meetingDurationDtp";
            this.meetingDurationDtp.ShowUpDown = true;
            this.meetingDurationDtp.Size = new System.Drawing.Size(215, 26);
            this.meetingDurationDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingDurationDtp.TabIndex = 79;
            // 
            // meetingDateDtp
            // 
            this.meetingDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meetingDateDtp.Location = new System.Drawing.Point(12, 369);
            this.meetingDateDtp.MinDate = new System.DateTime(2025, 6, 20, 14, 5, 20, 0);
            this.meetingDateDtp.Name = "meetingDateDtp";
            this.meetingDateDtp.Size = new System.Drawing.Size(215, 26);
            this.meetingDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingDateDtp.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(259, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 29);
            this.label10.TabIndex = 76;
            this.label10.Text = " שנה משך פגישה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(317, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 29);
            this.label12.TabIndex = 74;
            this.label12.Text = " שנה כתובת";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(327, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 29);
            this.label13.TabIndex = 73;
            this.label13.Text = "שנה תאריך";
            // 
            // updMeetingTypeCmbx
            // 
            this.updMeetingTypeCmbx.DataSource = this.meetingTypeTBLBindingSource;
            this.updMeetingTypeCmbx.DisplayMember = "name";
            this.updMeetingTypeCmbx.FormattingEnabled = true;
            this.updMeetingTypeCmbx.Location = new System.Drawing.Point(16, 199);
            this.updMeetingTypeCmbx.Name = "updMeetingTypeCmbx";
            this.updMeetingTypeCmbx.Size = new System.Drawing.Size(215, 24);
            this.updMeetingTypeCmbx.TabIndex = 72;
            this.updMeetingTypeCmbx.ValueMember = "Id";
            // 
            // addressTxb
            // 
            this.addressTxb.Location = new System.Drawing.Point(15, 285);
            this.addressTxb.Name = "addressTxb";
            this.addressTxb.Size = new System.Drawing.Size(215, 22);
            this.addressTxb.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(257, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 29);
            this.label14.TabIndex = 70;
            this.label14.Text = " החלף סוג פגישה";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 540);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 204);
            this.textBox2.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(297, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 29);
            this.label11.TabIndex = 82;
            this.label11.Text = "תיאור פרוייקט";
            // 
            // continueProjBtn
            // 
            this.continueProjBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.continueProjBtn.BackColor = System.Drawing.Color.DimGray;
            this.continueProjBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.continueProjBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.continueProjBtn.Location = new System.Drawing.Point(626, 641);
            this.continueProjBtn.Name = "continueProjBtn";
            this.continueProjBtn.Size = new System.Drawing.Size(195, 62);
            this.continueProjBtn.TabIndex = 84;
            this.continueProjBtn.Text = "עדכן פרוייקט";
            this.continueProjBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(388, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 62);
            this.button1.TabIndex = 85;
            this.button1.Text = "עדכן פגישה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meetingIDDataGridViewTextBoxColumn
            // 
            this.meetingIDDataGridViewTextBoxColumn.DataPropertyName = "meetingID";
            this.meetingIDDataGridViewTextBoxColumn.HeaderText = "meetingID";
            this.meetingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.meetingIDDataGridViewTextBoxColumn.Name = "meetingIDDataGridViewTextBoxColumn";
            this.meetingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "projectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "projectID";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeIDDataGridViewTextBoxColumn
            // 
            this.typeIDDataGridViewTextBoxColumn.DataPropertyName = "typeID";
            this.typeIDDataGridViewTextBoxColumn.HeaderText = "typeID";
            this.typeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeIDDataGridViewTextBoxColumn.Name = "typeIDDataGridViewTextBoxColumn";
            this.typeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topicDataGridViewTextBoxColumn
            // 
            this.topicDataGridViewTextBoxColumn.DataPropertyName = "topic";
            this.topicDataGridViewTextBoxColumn.HeaderText = "topic";
            this.topicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topicDataGridViewTextBoxColumn.Name = "topicDataGridViewTextBoxColumn";
            this.topicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "serviceID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // institutionDataGridViewTextBoxColumn
            // 
            this.institutionDataGridViewTextBoxColumn.DataPropertyName = "institution";
            this.institutionDataGridViewTextBoxColumn.HeaderText = "institution";
            this.institutionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.institutionDataGridViewTextBoxColumn.Name = "institutionDataGridViewTextBoxColumn";
            this.institutionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectTBLBindingSource
            // 
            this.projectTBLBindingSource.DataSource = typeof(Landau.Win.projectTBL);
            // 
            // costumerTBLBindingSource
            // 
            this.costumerTBLBindingSource.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // serviceTBLBindingSource
            // 
            this.serviceTBLBindingSource.DataSource = typeof(Landau.Win.serviceTBL);
            // 
            // meetingTypeTBLBindingSource
            // 
            this.meetingTypeTBLBindingSource.DataSource = typeof(Landau.Win.meetingTypeTBL);
            // 
            // updateProjectWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 779);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.continueProjBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.meetingTitleTxb);
            this.Controls.Add(this.meetingDurationDtp);
            this.Controls.Add(this.meetingDateDtp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.updMeetingTypeCmbx);
            this.Controls.Add(this.addressTxb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changeProjCustomerCmbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.projToUpdCmbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updOrderDateDtp);
            this.Controls.Add(this.updOrderNotesTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeServiceCmbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updProjDGV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateProjectWin";
            this.Text = "updateProjectWin";
            this.Load += new System.EventHandler(this.updateProjectWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updProjDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox changeProjCustomerCmbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox projToUpdCmbx;
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonDateTimePicker updOrderDateDtp;
        private System.Windows.Forms.TextBox updOrderNotesTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox changeServiceCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView updProjDGV;
        private System.Windows.Forms.BindingSource projectTrackViewBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox meetingTitleTxb;
        private Krypton.Toolkit.KryptonDateTimePicker meetingDurationDtp;
        private Krypton.Toolkit.KryptonDateTimePicker meetingDateDtp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox updMeetingTypeCmbx;
        private System.Windows.Forms.TextBox addressTxb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button continueProjBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource;
        private System.Windows.Forms.BindingSource projectTBLBindingSource;
        private System.Windows.Forms.BindingSource serviceTBLBindingSource;
        private System.Windows.Forms.BindingSource meetingTypeTBLBindingSource;
    }
}