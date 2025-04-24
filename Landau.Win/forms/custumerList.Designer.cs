namespace Landau.Win.forms
{
    partial class customerListForm
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
            this.customerListDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.costumerTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costumerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerListDGV
            // 
            this.customerListDGV.AllowUserToAddRows = false;
            this.customerListDGV.AllowUserToDeleteRows = false;
            this.customerListDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListDGV.AutoGenerateColumns = false;
            this.customerListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerListDGV.ColumnHeadersHeight = 29;
            this.customerListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.bDateDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.customerListDGV.DataSource = this.costumerTBLBindingSource1;
            this.customerListDGV.Location = new System.Drawing.Point(12, 41);
            this.customerListDGV.Name = "customerListDGV";
            this.customerListDGV.ReadOnly = true;
            this.customerListDGV.RowHeadersVisible = false;
            this.customerListDGV.RowHeadersWidth = 51;
            this.customerListDGV.RowTemplate.Height = 24;
            this.customerListDGV.Size = new System.Drawing.Size(911, 370);
            this.customerListDGV.TabIndex = 0;
            this.customerListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(420, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "רשימת לקוחות";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(214, 13);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(44, 16);
            this.lblTotalCustomers.TabIndex = 2;
            this.lblTotalCustomers.Text = "label2";
            // 
            // costumerTBLBindingSource1
            // 
            this.costumerTBLBindingSource1.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // costumerTBLBindingSource
            // 
            this.costumerTBLBindingSource.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם מלא";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "אימיל";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDateDataGridViewTextBoxColumn
            // 
            this.bDateDataGridViewTextBoxColumn.DataPropertyName = "bDate";
            this.bDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.bDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bDateDataGridViewTextBoxColumn.Name = "bDateDataGridViewTextBoxColumn";
            this.bDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "regDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "תאריך רישום";
            this.regDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "הערות";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerListDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerListForm";
            this.Text = "רשימת לקוחות";
            this.Load += new System.EventHandler(this.customerDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerListDGV;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}