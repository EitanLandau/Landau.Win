
namespace Landau.Win.forms
{
    partial class addMeetingWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMeetingWin));
            this.meetingDescriptionTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openProjectBtn = new System.Windows.Forms.Button();
            this.meetingTypeCmbx = new System.Windows.Forms.ComboBox();
            this.meetingTypeTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.meetingDurationDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.meetingDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.meetingTitleTxb = new System.Windows.Forms.TextBox();
            this.addMeetingBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // meetingDescriptionTxb
            // 
            this.meetingDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingDescriptionTxb.Location = new System.Drawing.Point(105, 58);
            this.meetingDescriptionTxb.Multiline = true;
            this.meetingDescriptionTxb.Name = "meetingDescriptionTxb";
            this.meetingDescriptionTxb.Size = new System.Drawing.Size(218, 365);
            this.meetingDescriptionTxb.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(819, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "משך פגישה";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(356, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 61;
            this.label4.Text = "תיאור פגישה";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(872, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "כתובת";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(874, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "תאריך";
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openProjectBtn.BackColor = System.Drawing.Color.DimGray;
            this.openProjectBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.openProjectBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.openProjectBtn.Location = new System.Drawing.Point(40, 513);
            this.openProjectBtn.Name = "openProjectBtn";
            this.openProjectBtn.Size = new System.Drawing.Size(163, 52);
            this.openProjectBtn.TabIndex = 57;
            this.openProjectBtn.Text = "צור פרוייקט";
            this.openProjectBtn.UseVisualStyleBackColor = false;
            // 
            // meetingTypeCmbx
            // 
            this.meetingTypeCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingTypeCmbx.DataSource = this.meetingTypeTBLBindingSource;
            this.meetingTypeCmbx.DisplayMember = "name";
            this.meetingTypeCmbx.FormattingEnabled = true;
            this.meetingTypeCmbx.Location = new System.Drawing.Point(566, 163);
            this.meetingTypeCmbx.Name = "meetingTypeCmbx";
            this.meetingTypeCmbx.Size = new System.Drawing.Size(215, 24);
            this.meetingTypeCmbx.TabIndex = 56;
            this.meetingTypeCmbx.ValueMember = "Id";
            // 
            // meetingTypeTBLBindingSource
            // 
            this.meetingTypeTBLBindingSource.DataSource = typeof(Landau.Win.meetingTypeTBL);
            // 
            // addressTxb
            // 
            this.addressTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTxb.Location = new System.Drawing.Point(566, 263);
            this.addressTxb.Name = "addressTxb";
            this.addressTxb.Size = new System.Drawing.Size(215, 22);
            this.addressTxb.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(834, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "סוג פגישה";
            // 
            // meetingDurationDtp
            // 
            this.meetingDurationDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingDurationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.meetingDurationDtp.Location = new System.Drawing.Point(566, 485);
            this.meetingDurationDtp.Name = "meetingDurationDtp";
            this.meetingDurationDtp.ShowUpDown = true;
            this.meetingDurationDtp.Size = new System.Drawing.Size(215, 26);
            this.meetingDurationDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingDurationDtp.TabIndex = 66;
            // 
            // meetingDateDtp
            // 
            this.meetingDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meetingDateDtp.Location = new System.Drawing.Point(566, 373);
            this.meetingDateDtp.Name = "meetingDateDtp";
            this.meetingDateDtp.Size = new System.Drawing.Size(215, 26);
            this.meetingDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.meetingDateDtp.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(874, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 68;
            this.label6.Text = "כותרת";
            // 
            // meetingTitleTxb
            // 
            this.meetingTitleTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingTitleTxb.Location = new System.Drawing.Point(568, 65);
            this.meetingTitleTxb.Name = "meetingTitleTxb";
            this.meetingTitleTxb.Size = new System.Drawing.Size(215, 22);
            this.meetingTitleTxb.TabIndex = 67;
            // 
            // addMeetingBtn
            // 
            this.addMeetingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addMeetingBtn.BackColor = System.Drawing.Color.DimGray;
            this.addMeetingBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addMeetingBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addMeetingBtn.Location = new System.Drawing.Point(40, 455);
            this.addMeetingBtn.Name = "addMeetingBtn";
            this.addMeetingBtn.Size = new System.Drawing.Size(163, 52);
            this.addMeetingBtn.TabIndex = 69;
            this.addMeetingBtn.Text = "הוסף פגישה";
            this.addMeetingBtn.UseVisualStyleBackColor = false;
            this.addMeetingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addMeetingWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 577);
            this.Controls.Add(this.addMeetingBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.meetingTitleTxb);
            this.Controls.Add(this.meetingDurationDtp);
            this.Controls.Add(this.meetingDateDtp);
            this.Controls.Add(this.meetingDescriptionTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openProjectBtn);
            this.Controls.Add(this.meetingTypeCmbx);
            this.Controls.Add(this.addressTxb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMeetingWin";
            this.Text = "addMeetingWin";
            this.Load += new System.EventHandler(this.addMeetingWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox meetingDescriptionTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openProjectBtn;
        private System.Windows.Forms.ComboBox meetingTypeCmbx;
        private System.Windows.Forms.TextBox addressTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource meetingTypeTBLBindingSource;
        private Krypton.Toolkit.KryptonDateTimePicker meetingDurationDtp;
        private Krypton.Toolkit.KryptonDateTimePicker meetingDateDtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox meetingTitleTxb;
        private System.Windows.Forms.Button addMeetingBtn;
    }
}