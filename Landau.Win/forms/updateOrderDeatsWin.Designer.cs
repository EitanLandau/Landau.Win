
namespace Landau.Win.forms
{
    partial class updateOrderDeatsWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateOrderDeatsWin));
            this.updOrderHourDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderDeatsNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updAmmountInvitedUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updOrderBtn = new System.Windows.Forms.Button();
            this.changeProductCmbx = new System.Windows.Forms.ComboBox();
            this.lecturesNseminarsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updAdressTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderUpdOrderDeats = new System.Windows.Forms.ErrorProvider(this.components);
            this.pickOrderCmbx = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.orderHistoryDGV = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInvitedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changeCustomerCmbx = new System.Windows.Forms.ComboBox();
            this.costumerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updAmmountInvitedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdOrderDeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updOrderHourDtp
            // 
            this.updOrderHourDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderHourDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updOrderHourDtp.Location = new System.Drawing.Point(1061, 445);
            this.updOrderHourDtp.Name = "updOrderHourDtp";
            this.updOrderHourDtp.ShowUpDown = true;
            this.updOrderHourDtp.Size = new System.Drawing.Size(137, 26);
            this.updOrderHourDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderHourDtp.TabIndex = 40;
            this.updOrderHourDtp.ValueChanged += new System.EventHandler(this.updOrderHourDtp_ValueChanged);
            // 
            // updOrderDateDtp
            // 
            this.updOrderDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updOrderDateDtp.Location = new System.Drawing.Point(1022, 380);
            this.updOrderDateDtp.Name = "updOrderDateDtp";
            this.updOrderDateDtp.Size = new System.Drawing.Size(211, 26);
            this.updOrderDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderDateDtp.TabIndex = 39;
            this.updOrderDateDtp.ValueChanged += new System.EventHandler(this.updOrderDateDtp_ValueChanged);
            // 
            // updOrderDeatsNotes
            // 
            this.updOrderDeatsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDeatsNotes.Location = new System.Drawing.Point(600, 231);
            this.updOrderDeatsNotes.Multiline = true;
            this.updOrderDeatsNotes.Name = "updOrderDeatsNotes";
            this.updOrderDeatsNotes.Size = new System.Drawing.Size(214, 378);
            this.updOrderDeatsNotes.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(1382, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "כתובת";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(863, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "הערות";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(1311, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "כמות מוזמנים";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updAmmountInvitedUD
            // 
            this.updAmmountInvitedUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updAmmountInvitedUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updAmmountInvitedUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.updAmmountInvitedUD.Location = new System.Drawing.Point(1045, 535);
            this.updAmmountInvitedUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updAmmountInvitedUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAmmountInvitedUD.Name = "updAmmountInvitedUD";
            this.updAmmountInvitedUD.Size = new System.Drawing.Size(171, 32);
            this.updAmmountInvitedUD.TabIndex = 34;
            this.updAmmountInvitedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updAmmountInvitedUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAmmountInvitedUD.ValueChanged += new System.EventHandler(this.updAmmountInvitedUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(1384, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "תאריך";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // updOrderBtn
            // 
            this.updOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updOrderBtn.BackColor = System.Drawing.Color.Firebrick;
            this.updOrderBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.updOrderBtn.Location = new System.Drawing.Point(12, 818);
            this.updOrderBtn.Name = "updOrderBtn";
            this.updOrderBtn.Size = new System.Drawing.Size(182, 63);
            this.updOrderBtn.TabIndex = 32;
            this.updOrderBtn.Text = "עדכן הזמנה";
            this.updOrderBtn.UseVisualStyleBackColor = false;
            this.updOrderBtn.Click += new System.EventHandler(this.updOrderBtn_Click);
            // 
            // changeProductCmbx
            // 
            this.changeProductCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeProductCmbx.DataSource = this.lecturesNseminarsTBLBindingSource;
            this.changeProductCmbx.DisplayMember = "title";
            this.changeProductCmbx.FormattingEnabled = true;
            this.changeProductCmbx.Location = new System.Drawing.Point(1022, 294);
            this.changeProductCmbx.Name = "changeProductCmbx";
            this.changeProductCmbx.Size = new System.Drawing.Size(211, 24);
            this.changeProductCmbx.TabIndex = 31;
            this.changeProductCmbx.ValueMember = "Id";
            this.changeProductCmbx.SelectedIndexChanged += new System.EventHandler(this.changeProductCmbx_SelectedIndexChanged);
            // 
            // lecturesNseminarsTBLBindingSource
            // 
            this.lecturesNseminarsTBLBindingSource.DataSource = typeof(Landau.Win.lecturesNseminarsTBL);
            this.lecturesNseminarsTBLBindingSource.CurrentChanged += new System.EventHandler(this.lecturesNseminarsTBLBindingSource_CurrentChanged);
            // 
            // updAdressTxb
            // 
            this.updAdressTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updAdressTxb.Location = new System.Drawing.Point(1049, 631);
            this.updAdressTxb.Name = "updAdressTxb";
            this.updAdressTxb.Size = new System.Drawing.Size(171, 22);
            this.updAdressTxb.TabIndex = 30;
            this.updAdressTxb.TextChanged += new System.EventHandler(this.updAdressTxb_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(1257, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "בחר סדנה/הרצאה";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(938, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(1276, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "הזן מספר הזמנה";
            // 
            // errorProviderUpdOrderDeats
            // 
            this.errorProviderUpdOrderDeats.ContainerControl = this;
            // 
            // pickOrderCmbx
            // 
            this.pickOrderCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickOrderCmbx.DataSource = this.orderTBLBindingSource;
            this.pickOrderCmbx.DisplayMember = "Id";
            this.pickOrderCmbx.FormattingEnabled = true;
            this.pickOrderCmbx.Location = new System.Drawing.Point(1022, 124);
            this.pickOrderCmbx.Name = "pickOrderCmbx";
            this.pickOrderCmbx.Size = new System.Drawing.Size(211, 24);
            this.pickOrderCmbx.TabIndex = 45;
            this.pickOrderCmbx.ValueMember = "Id";
            this.pickOrderCmbx.SelectedIndexChanged += new System.EventHandler(this.pickOrderCmbx_SelectedIndexChanged);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(Landau.Win.orderTBL);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(456, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "פרטי הזמנה";
            // 
            // orderHistoryDGV
            // 
            this.orderHistoryDGV.AllowUserToAddRows = false;
            this.orderHistoryDGV.AllowUserToDeleteRows = false;
            this.orderHistoryDGV.AutoGenerateColumns = false;
            this.orderHistoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryDGV.ColumnHeadersHeight = 29;
            this.orderHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderHistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.orderID,
            this.titleDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountInvitedDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn});
            this.orderHistoryDGV.DataSource = this.orderHistoryViewBindingSource;
            this.orderHistoryDGV.Location = new System.Drawing.Point(56, 119);
            this.orderHistoryDGV.Name = "orderHistoryDGV";
            this.orderHistoryDGV.ReadOnly = true;
            this.orderHistoryDGV.RowHeadersVisible = false;
            this.orderHistoryDGV.RowHeadersWidth = 51;
            this.orderHistoryDGV.RowTemplate.Height = 24;
            this.orderHistoryDGV.Size = new System.Drawing.Size(913, 553);
            this.orderHistoryDGV.TabIndex = 46;
            this.orderHistoryDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderHistoryDGV_CellContentClick);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם לקוח";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "מספר תת הזמנה";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "orderID";
            this.orderID.HeaderText = "מספר הזמנה";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "מוצר";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountInvitedDataGridViewTextBoxColumn
            // 
            this.amountInvitedDataGridViewTextBoxColumn.DataPropertyName = "amountInvited";
            this.amountInvitedDataGridViewTextBoxColumn.HeaderText = "מספר מוזמנים";
            this.amountInvitedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountInvitedDataGridViewTextBoxColumn.Name = "amountInvitedDataGridViewTextBoxColumn";
            this.amountInvitedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "תאריך הזמנה";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderHistoryViewBindingSource
            // 
            this.orderHistoryViewBindingSource.DataSource = typeof(Landau.Win.orderHistoryView);
            // 
            // changeCustomerCmbx
            // 
            this.changeCustomerCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeCustomerCmbx.DataSource = this.costumerTBLBindingSource;
            this.changeCustomerCmbx.DisplayMember = "fullName";
            this.changeCustomerCmbx.FormattingEnabled = true;
            this.changeCustomerCmbx.Location = new System.Drawing.Point(1022, 205);
            this.changeCustomerCmbx.Name = "changeCustomerCmbx";
            this.changeCustomerCmbx.Size = new System.Drawing.Size(211, 24);
            this.changeCustomerCmbx.TabIndex = 49;
            this.changeCustomerCmbx.ValueMember = "Id";
            // 
            // costumerTBLBindingSource
            // 
            this.costumerTBLBindingSource.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(1345, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 29);
            this.label9.TabIndex = 48;
            this.label9.Text = "שנה לקוח";
            // 
            // updateOrderDeatsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 911);
            this.Controls.Add(this.changeCustomerCmbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderHistoryDGV);
            this.Controls.Add(this.pickOrderCmbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updOrderHourDtp);
            this.Controls.Add(this.updOrderDateDtp);
            this.Controls.Add(this.updOrderDeatsNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updAmmountInvitedUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updOrderBtn);
            this.Controls.Add(this.changeProductCmbx);
            this.Controls.Add(this.updAdressTxb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateOrderDeatsWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.updateOrderDeatsWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updAmmountInvitedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdOrderDeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDateTimePicker updOrderHourDtp;
        private Krypton.Toolkit.KryptonDateTimePicker updOrderDateDtp;
        private System.Windows.Forms.TextBox updOrderDeatsNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updAmmountInvitedUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updOrderBtn;
        private System.Windows.Forms.ComboBox changeProductCmbx;
        private System.Windows.Forms.TextBox updAdressTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource lecturesNseminarsTBLBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderUpdOrderDeats;
        private System.Windows.Forms.ComboBox pickOrderCmbx;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView orderHistoryDGV;
        private System.Windows.Forms.BindingSource orderHistoryViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subOrderNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountInvitedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox changeCustomerCmbx;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource;
        private System.Windows.Forms.Label label9;
    }
}