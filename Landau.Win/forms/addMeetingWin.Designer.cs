
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
            this.projectDescriptionTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updOrderBtn = new System.Windows.Forms.Button();
            this.projectCustomerCmbx = new System.Windows.Forms.ComboBox();
            this.projTitleTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updOrderHourDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.meetingTypeTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDescriptionTxb
            // 
            this.projectDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTxb.Location = new System.Drawing.Point(107, 55);
            this.projectDescriptionTxb.Multiline = true;
            this.projectDescriptionTxb.Name = "projectDescriptionTxb";
            this.projectDescriptionTxb.Size = new System.Drawing.Size(218, 365);
            this.projectDescriptionTxb.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(824, 381);
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
            this.label4.Location = new System.Drawing.Point(356, 55);
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
            this.label3.Location = new System.Drawing.Point(877, 162);
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
            this.label2.Location = new System.Drawing.Point(879, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = "תאריך";
            // 
            // updOrderBtn
            // 
            this.updOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updOrderBtn.BackColor = System.Drawing.Color.DimGray;
            this.updOrderBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updOrderBtn.Location = new System.Drawing.Point(41, 482);
            this.updOrderBtn.Name = "updOrderBtn";
            this.updOrderBtn.Size = new System.Drawing.Size(179, 66);
            this.updOrderBtn.TabIndex = 57;
            this.updOrderBtn.Text = "צור פרוייקט";
            this.updOrderBtn.UseVisualStyleBackColor = false;
            // 
            // projectCustomerCmbx
            // 
            this.projectCustomerCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectCustomerCmbx.DataSource = this.meetingTypeTBLBindingSource;
            this.projectCustomerCmbx.DisplayMember = "name";
            this.projectCustomerCmbx.FormattingEnabled = true;
            this.projectCustomerCmbx.Location = new System.Drawing.Point(571, 62);
            this.projectCustomerCmbx.Name = "projectCustomerCmbx";
            this.projectCustomerCmbx.Size = new System.Drawing.Size(215, 24);
            this.projectCustomerCmbx.TabIndex = 56;
            this.projectCustomerCmbx.ValueMember = "Id";
            // 
            // projTitleTxb
            // 
            this.projTitleTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projTitleTxb.Location = new System.Drawing.Point(571, 162);
            this.projTitleTxb.Name = "projTitleTxb";
            this.projTitleTxb.Size = new System.Drawing.Size(215, 22);
            this.projTitleTxb.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(839, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "סוג פגישה";
            // 
            // updOrderHourDtp
            // 
            this.updOrderHourDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderHourDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updOrderHourDtp.Location = new System.Drawing.Point(571, 384);
            this.updOrderHourDtp.Name = "updOrderHourDtp";
            this.updOrderHourDtp.ShowUpDown = true;
            this.updOrderHourDtp.Size = new System.Drawing.Size(215, 26);
            this.updOrderHourDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderHourDtp.TabIndex = 66;
            // 
            // updOrderDateDtp
            // 
            this.updOrderDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updOrderDateDtp.Location = new System.Drawing.Point(571, 272);
            this.updOrderDateDtp.Name = "updOrderDateDtp";
            this.updOrderDateDtp.Size = new System.Drawing.Size(215, 26);
            this.updOrderDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderDateDtp.TabIndex = 65;
            // 
            // meetingTypeTBLBindingSource
            // 
            this.meetingTypeTBLBindingSource.DataSource = typeof(Landau.Win.meetingTypeTBL);
            // 
            // addMeetingWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 577);
            this.Controls.Add(this.updOrderHourDtp);
            this.Controls.Add(this.updOrderDateDtp);
            this.Controls.Add(this.projectDescriptionTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updOrderBtn);
            this.Controls.Add(this.projectCustomerCmbx);
            this.Controls.Add(this.projTitleTxb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMeetingWin";
            this.Text = "addMeetingWin";
            this.Load += new System.EventHandler(this.addMeetingWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meetingTypeTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox projectDescriptionTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updOrderBtn;
        private System.Windows.Forms.ComboBox projectCustomerCmbx;
        private System.Windows.Forms.TextBox projTitleTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource meetingTypeTBLBindingSource;
        private Krypton.Toolkit.KryptonDateTimePicker updOrderHourDtp;
        private Krypton.Toolkit.KryptonDateTimePicker updOrderDateDtp;
    }
}