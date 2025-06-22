
namespace Landau.Win.forms
{
    partial class projectTrackWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projectTrackWin));
            this.projectNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pickProjectCmbx = new System.Windows.Forms.ComboBox();
            this.projectTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectMeetingsDGV = new System.Windows.Forms.DataGridView();
            this.topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTrackViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingDescriptionTxb = new System.Windows.Forms.TextBox();
            this.meetingTopicTxb = new System.Windows.Forms.TextBox();
            this.nextMeetingDateLbl = new System.Windows.Forms.Label();
            this.meetingsLeftLbl = new System.Windows.Forms.Label();
            this.projectDescriptionTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.projectCreationDateTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMeetingsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLbl
            // 
            this.projectNameLbl.AutoSize = true;
            this.projectNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.projectNameLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.projectNameLbl.Location = new System.Drawing.Point(479, 49);
            this.projectNameLbl.Name = "projectNameLbl";
            this.projectNameLbl.Size = new System.Drawing.Size(83, 29);
            this.projectNameLbl.TabIndex = 69;
            this.projectNameLbl.Text = "כותרת";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(1286, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "שם פגישה";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(1266, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "תיאור פגישה";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(1077, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 72;
            this.label3.Text = "בחר פרוייקט";
            // 
            // pickProjectCmbx
            // 
            this.pickProjectCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickProjectCmbx.DataSource = this.projectTBLBindingSource;
            this.pickProjectCmbx.DisplayMember = "title";
            this.pickProjectCmbx.FormattingEnabled = true;
            this.pickProjectCmbx.Location = new System.Drawing.Point(905, 34);
            this.pickProjectCmbx.Name = "pickProjectCmbx";
            this.pickProjectCmbx.Size = new System.Drawing.Size(149, 24);
            this.pickProjectCmbx.TabIndex = 75;
            this.pickProjectCmbx.ValueMember = "Id";
            this.pickProjectCmbx.SelectedIndexChanged += new System.EventHandler(this.pickProjectCmbx_SelectedIndexChanged);
            // 
            // projectTBLBindingSource
            // 
            this.projectTBLBindingSource.DataSource = typeof(Landau.Win.projectTBL);
            // 
            // projectMeetingsDGV
            // 
            this.projectMeetingsDGV.AllowUserToAddRows = false;
            this.projectMeetingsDGV.AllowUserToDeleteRows = false;
            this.projectMeetingsDGV.AutoGenerateColumns = false;
            this.projectMeetingsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectMeetingsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectMeetingsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topic,
            this.projectIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.institution,
            this.nameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.notes,
            this.description});
            this.projectMeetingsDGV.DataSource = this.projectTrackViewBindingSource;
            this.projectMeetingsDGV.Location = new System.Drawing.Point(42, 92);
            this.projectMeetingsDGV.Name = "projectMeetingsDGV";
            this.projectMeetingsDGV.ReadOnly = true;
            this.projectMeetingsDGV.RowHeadersVisible = false;
            this.projectMeetingsDGV.RowHeadersWidth = 52;
            this.projectMeetingsDGV.RowTemplate.Height = 24;
            this.projectMeetingsDGV.Size = new System.Drawing.Size(1042, 510);
            this.projectMeetingsDGV.TabIndex = 76;
            this.projectMeetingsDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.projectMeetingsDGV_CellMouseClick);
            this.projectMeetingsDGV.SelectionChanged += new System.EventHandler(this.projectMeetingsDGV_SelectionChanged);
            // 
            // topic
            // 
            this.topic.DataPropertyName = "topic";
            this.topic.HeaderText = "שם הפגישה";
            this.topic.MinimumWidth = 6;
            this.topic.Name = "topic";
            this.topic.ReadOnly = true;
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "projectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "מספר פרוייקט";
            this.projectIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            this.projectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם לקוח";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // institution
            // 
            this.institution.DataPropertyName = "institution";
            this.institution.HeaderText = "מוסד";
            this.institution.MinimumWidth = 6;
            this.institution.Name = "institution";
            this.institution.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "סוג פגישה";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "משך זמן הפגישה";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.HeaderText = "notes";
            this.notes.MinimumWidth = 6;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Visible = false;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // projectTrackViewBindingSource
            // 
            this.projectTrackViewBindingSource.DataSource = typeof(Landau.Win.projectTrackView);
            // 
            // meetingDescriptionTxb
            // 
            this.meetingDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingDescriptionTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meetingDescriptionTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingDescriptionTxb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.meetingDescriptionTxb.Location = new System.Drawing.Point(1050, 363);
            this.meetingDescriptionTxb.Multiline = true;
            this.meetingDescriptionTxb.Name = "meetingDescriptionTxb";
            this.meetingDescriptionTxb.ReadOnly = true;
            this.meetingDescriptionTxb.Size = new System.Drawing.Size(198, 239);
            this.meetingDescriptionTxb.TabIndex = 77;
            // 
            // meetingTopicTxb
            // 
            this.meetingTopicTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingTopicTxb.BackColor = System.Drawing.SystemColors.Window;
            this.meetingTopicTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.meetingTopicTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingTopicTxb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.meetingTopicTxb.Location = new System.Drawing.Point(1050, 291);
            this.meetingTopicTxb.Name = "meetingTopicTxb";
            this.meetingTopicTxb.ReadOnly = true;
            this.meetingTopicTxb.Size = new System.Drawing.Size(198, 20);
            this.meetingTopicTxb.TabIndex = 78;
            // 
            // nextMeetingDateLbl
            // 
            this.nextMeetingDateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextMeetingDateLbl.AutoSize = true;
            this.nextMeetingDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.nextMeetingDateLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nextMeetingDateLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nextMeetingDateLbl.Location = new System.Drawing.Point(978, 124);
            this.nextMeetingDateLbl.Name = "nextMeetingDateLbl";
            this.nextMeetingDateLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nextMeetingDateLbl.Size = new System.Drawing.Size(186, 29);
            this.nextMeetingDateLbl.TabIndex = 80;
            this.nextMeetingDateLbl.Text = "פגישה הבאה:   ";
            // 
            // meetingsLeftLbl
            // 
            this.meetingsLeftLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingsLeftLbl.AutoSize = true;
            this.meetingsLeftLbl.BackColor = System.Drawing.Color.Transparent;
            this.meetingsLeftLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingsLeftLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.meetingsLeftLbl.Location = new System.Drawing.Point(1210, 209);
            this.meetingsLeftLbl.Name = "meetingsLeftLbl";
            this.meetingsLeftLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meetingsLeftLbl.Size = new System.Drawing.Size(194, 29);
            this.meetingsLeftLbl.TabIndex = 81;
            this.meetingsLeftLbl.Text = "פגישות שנשארו:";
            // 
            // projectDescriptionTxb
            // 
            this.projectDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectDescriptionTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.projectDescriptionTxb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.projectDescriptionTxb.Location = new System.Drawing.Point(585, 363);
            this.projectDescriptionTxb.Multiline = true;
            this.projectDescriptionTxb.Name = "projectDescriptionTxb";
            this.projectDescriptionTxb.ReadOnly = true;
            this.projectDescriptionTxb.Size = new System.Drawing.Size(199, 239);
            this.projectDescriptionTxb.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(799, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 82;
            this.label4.Text = "תיאור פרטי פרויקט";
            // 
            // projectCreationDateTxb
            // 
            this.projectCreationDateTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectCreationDateTxb.BackColor = System.Drawing.SystemColors.Window;
            this.projectCreationDateTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectCreationDateTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.projectCreationDateTxb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.projectCreationDateTxb.Location = new System.Drawing.Point(585, 282);
            this.projectCreationDateTxb.Name = "projectCreationDateTxb";
            this.projectCreationDateTxb.ReadOnly = true;
            this.projectCreationDateTxb.Size = new System.Drawing.Size(199, 20);
            this.projectCreationDateTxb.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(872, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 84;
            this.label5.Text = "תאריך יצירה";
            // 
            // projectTrackWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 889);
            this.Controls.Add(this.projectCreationDateTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.projectDescriptionTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meetingsLeftLbl);
            this.Controls.Add(this.nextMeetingDateLbl);
            this.Controls.Add(this.meetingTopicTxb);
            this.Controls.Add(this.meetingDescriptionTxb);
            this.Controls.Add(this.projectMeetingsDGV);
            this.Controls.Add(this.pickProjectCmbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "projectTrackWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.projectTrackWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectMeetingsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTrackViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label projectNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pickProjectCmbx;
        private System.Windows.Forms.DataGridView projectMeetingsDGV;
        private System.Windows.Forms.BindingSource projectTBLBindingSource;
        private System.Windows.Forms.BindingSource projectTrackViewBindingSource;
        private System.Windows.Forms.TextBox meetingDescriptionTxb;
        private System.Windows.Forms.TextBox meetingTopicTxb;
        private System.Windows.Forms.Label nextMeetingDateLbl;
        private System.Windows.Forms.Label meetingsLeftLbl;
        private System.Windows.Forms.TextBox projectDescriptionTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox projectCreationDateTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institution;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}