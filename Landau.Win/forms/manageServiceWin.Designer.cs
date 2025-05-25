
namespace Landau.Win.forms
{
    partial class manageServiceWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageServiceWin));
            this.serviceDescriptionTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howManySessionsUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameTxb = new System.Windows.Forms.TextBox();
            this.servicePriceUD = new System.Windows.Forms.NumericUpDown();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.updServiceBtn = new System.Windows.Forms.Button();
            this.updPriceUD = new System.Windows.Forms.NumericUpDown();
            this.updDescriptionUd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updMeetingNumUd = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.updServiceName = new System.Windows.Forms.TextBox();
            this.pickServiceCmbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.servicesDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderMangeServices = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.howManySessionsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMeetingNumUd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMangeServices)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceDescriptionTxb
            // 
            this.serviceDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceDescriptionTxb.Location = new System.Drawing.Point(738, 312);
            this.serviceDescriptionTxb.Multiline = true;
            this.serviceDescriptionTxb.Name = "serviceDescriptionTxb";
            this.serviceDescriptionTxb.Size = new System.Drawing.Size(151, 200);
            this.serviceDescriptionTxb.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(1015, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(1011, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "תיאור";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(929, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "מספר מפגשים";
            // 
            // howManySessionsUD
            // 
            this.howManySessionsUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.howManySessionsUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.howManySessionsUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.howManySessionsUD.Location = new System.Drawing.Point(738, 145);
            this.howManySessionsUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.howManySessionsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howManySessionsUD.Name = "howManySessionsUD";
            this.howManySessionsUD.Size = new System.Drawing.Size(151, 28);
            this.howManySessionsUD.TabIndex = 30;
            this.howManySessionsUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.howManySessionsUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(952, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם התהליך";
            // 
            // serviceNameTxb
            // 
            this.serviceNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceNameTxb.Location = new System.Drawing.Point(738, 55);
            this.serviceNameTxb.Name = "serviceNameTxb";
            this.serviceNameTxb.Size = new System.Drawing.Size(151, 22);
            this.serviceNameTxb.TabIndex = 28;
            // 
            // servicePriceUD
            // 
            this.servicePriceUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servicePriceUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.servicePriceUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.servicePriceUD.Location = new System.Drawing.Point(738, 231);
            this.servicePriceUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.servicePriceUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.servicePriceUD.Name = "servicePriceUD";
            this.servicePriceUD.Size = new System.Drawing.Size(151, 28);
            this.servicePriceUD.TabIndex = 35;
            this.servicePriceUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servicePriceUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBtn.BackColor = System.Drawing.Color.Teal;
            this.addProductBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProductBtn.ForeColor = System.Drawing.Color.Azure;
            this.addProductBtn.Location = new System.Drawing.Point(756, 521);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(118, 59);
            this.addProductBtn.TabIndex = 36;
            this.addProductBtn.Text = "הוסף";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // updServiceBtn
            // 
            this.updServiceBtn.BackColor = System.Drawing.Color.Teal;
            this.updServiceBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updServiceBtn.ForeColor = System.Drawing.Color.Azure;
            this.updServiceBtn.Location = new System.Drawing.Point(66, 521);
            this.updServiceBtn.Name = "updServiceBtn";
            this.updServiceBtn.Size = new System.Drawing.Size(138, 59);
            this.updServiceBtn.TabIndex = 45;
            this.updServiceBtn.Text = "עדכן";
            this.updServiceBtn.UseVisualStyleBackColor = false;
            this.updServiceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updPriceUD
            // 
            this.updPriceUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updPriceUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.updPriceUD.Location = new System.Drawing.Point(66, 236);
            this.updPriceUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updPriceUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPriceUD.Name = "updPriceUD";
            this.updPriceUD.Size = new System.Drawing.Size(156, 28);
            this.updPriceUD.TabIndex = 44;
            this.updPriceUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updPriceUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updDescriptionUd
            // 
            this.updDescriptionUd.Location = new System.Drawing.Point(66, 312);
            this.updDescriptionUd.Multiline = true;
            this.updDescriptionUd.Name = "updDescriptionUd";
            this.updDescriptionUd.Size = new System.Drawing.Size(156, 183);
            this.updDescriptionUd.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(400, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "מחיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(396, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "תיאור";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(314, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "מספר מפגשים";
            // 
            // updMeetingNumUd
            // 
            this.updMeetingNumUd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updMeetingNumUd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.updMeetingNumUd.Location = new System.Drawing.Point(66, 174);
            this.updMeetingNumUd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updMeetingNumUd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updMeetingNumUd.Name = "updMeetingNumUd";
            this.updMeetingNumUd.Size = new System.Drawing.Size(156, 28);
            this.updMeetingNumUd.TabIndex = 39;
            this.updMeetingNumUd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updMeetingNumUd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(337, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "שם התהליך";
            // 
            // updServiceName
            // 
            this.updServiceName.Location = new System.Drawing.Point(66, 115);
            this.updServiceName.Name = "updServiceName";
            this.updServiceName.Size = new System.Drawing.Size(156, 22);
            this.updServiceName.TabIndex = 37;
            // 
            // pickServiceCmbx
            // 
            this.pickServiceCmbx.DataSource = this.serviceTBLBindingSource1;
            this.pickServiceCmbx.DisplayMember = "serviceName";
            this.pickServiceCmbx.FormattingEnabled = true;
            this.pickServiceCmbx.Location = new System.Drawing.Point(66, 58);
            this.pickServiceCmbx.Name = "pickServiceCmbx";
            this.pickServiceCmbx.Size = new System.Drawing.Size(156, 24);
            this.pickServiceCmbx.TabIndex = 46;
            this.pickServiceCmbx.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(276, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "בחר תהליך לעדכון";
            // 
            // servicesDGV
            // 
            this.servicesDGV.AllowUserToAddRows = false;
            this.servicesDGV.AllowUserToDeleteRows = false;
            this.servicesDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.servicesDGV.AutoGenerateColumns = false;
            this.servicesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.sessionsNumDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.servicesDGV.DataSource = this.serviceTBLBindingSource;
            this.servicesDGV.Location = new System.Drawing.Point(158, 88);
            this.servicesDGV.Name = "servicesDGV";
            this.servicesDGV.ReadOnly = true;
            this.servicesDGV.RowHeadersVisible = false;
            this.servicesDGV.RowHeadersWidth = 51;
            this.servicesDGV.RowTemplate.Height = 24;
            this.servicesDGV.Size = new System.Drawing.Size(707, 618);
            this.servicesDGV.TabIndex = 48;
            this.servicesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id ";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "serviceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "שם תהליך";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionsNumDataGridViewTextBoxColumn
            // 
            this.sessionsNumDataGridViewTextBoxColumn.DataPropertyName = "sessionsNum";
            this.sessionsNumDataGridViewTextBoxColumn.HeaderText = "מספר מפגשים";
            this.sessionsNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessionsNumDataGridViewTextBoxColumn.Name = "sessionsNumDataGridViewTextBoxColumn";
            this.sessionsNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "תיאור";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceTBLBindingSource
            // 
            this.serviceTBLBindingSource.DataSource = typeof(Landau.Win.serviceTBL);
            // 
            // serviceTBLBindingSource1
            // 
            this.serviceTBLBindingSource1.DataSource = typeof(Landau.Win.serviceTBL);
            // 
            // errorProviderMangeServices
            // 
            this.errorProviderMangeServices.ContainerControl = this;
            // 
            // manageServiceWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 718);
            this.Controls.Add(this.servicesDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pickServiceCmbx);
            this.Controls.Add(this.updServiceBtn);
            this.Controls.Add(this.updPriceUD);
            this.Controls.Add(this.updDescriptionUd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updMeetingNumUd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updServiceName);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.servicePriceUD);
            this.Controls.Add(this.serviceDescriptionTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.howManySessionsUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceNameTxb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageServiceWin";
            this.Text = "addService";
            this.Load += new System.EventHandler(this.manageServiceWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.howManySessionsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMeetingNumUd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMangeServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox serviceDescriptionTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown howManySessionsUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceNameTxb;
        private System.Windows.Forms.NumericUpDown servicePriceUD;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button updServiceBtn;
        private System.Windows.Forms.NumericUpDown updPriceUD;
        private System.Windows.Forms.TextBox updDescriptionUd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown updMeetingNumUd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updServiceName;
        private System.Windows.Forms.ComboBox pickServiceCmbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource serviceTBLBindingSource1;
        private System.Windows.Forms.DataGridView servicesDGV;
        private System.Windows.Forms.BindingSource serviceTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionsNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProviderMangeServices;
    }
}