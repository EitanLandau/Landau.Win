
namespace Landau.Win.forms
{
    partial class orderHistory
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
            this.orderHistoryDGV = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInvitedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subOrderNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderHistoryDGV
            // 
            this.orderHistoryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderHistoryDGV.AutoGenerateColumns = false;
            this.orderHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderNotesDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.amountInvitedDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.subOrderNotesDataGridViewTextBoxColumn,
            this.lectureIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.orderHistoryDGV.DataSource = this.orderHistoryViewBindingSource;
            this.orderHistoryDGV.Location = new System.Drawing.Point(12, 12);
            this.orderHistoryDGV.Name = "orderHistoryDGV";
            this.orderHistoryDGV.RowHeadersWidth = 51;
            this.orderHistoryDGV.RowTemplate.Height = 24;
            this.orderHistoryDGV.Size = new System.Drawing.Size(1025, 493);
            this.orderHistoryDGV.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderNotesDataGridViewTextBoxColumn
            // 
            this.orderNotesDataGridViewTextBoxColumn.DataPropertyName = "orderNotes";
            this.orderNotesDataGridViewTextBoxColumn.HeaderText = "orderNotes";
            this.orderNotesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNotesDataGridViewTextBoxColumn.Name = "orderNotesDataGridViewTextBoxColumn";
            this.orderNotesDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountInvitedDataGridViewTextBoxColumn
            // 
            this.amountInvitedDataGridViewTextBoxColumn.DataPropertyName = "amountInvited";
            this.amountInvitedDataGridViewTextBoxColumn.HeaderText = "amountInvited";
            this.amountInvitedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountInvitedDataGridViewTextBoxColumn.Name = "amountInvitedDataGridViewTextBoxColumn";
            this.amountInvitedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // subOrderNotesDataGridViewTextBoxColumn
            // 
            this.subOrderNotesDataGridViewTextBoxColumn.DataPropertyName = "subOrderNotes";
            this.subOrderNotesDataGridViewTextBoxColumn.HeaderText = "subOrderNotes";
            this.subOrderNotesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subOrderNotesDataGridViewTextBoxColumn.Name = "subOrderNotesDataGridViewTextBoxColumn";
            this.subOrderNotesDataGridViewTextBoxColumn.Width = 125;
            // 
            // lectureIDDataGridViewTextBoxColumn
            // 
            this.lectureIDDataGridViewTextBoxColumn.DataPropertyName = "lectureID";
            this.lectureIDDataGridViewTextBoxColumn.HeaderText = "lectureID";
            this.lectureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lectureIDDataGridViewTextBoxColumn.Name = "lectureIDDataGridViewTextBoxColumn";
            this.lectureIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderHistoryViewBindingSource
            // 
            this.orderHistoryViewBindingSource.DataSource = typeof(Landau.Win.orderHistoryView);
            // 
            // orderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 450);
            this.Controls.Add(this.orderHistoryDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderHistory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.orderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderHistoryDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountInvitedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subOrderNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderHistoryViewBindingSource;
    }
}