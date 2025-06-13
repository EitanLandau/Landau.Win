
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
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountInvitedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subOrderNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderHistoryDGV
            // 
            this.orderHistoryDGV.AllowUserToAddRows = false;
            this.orderHistoryDGV.AllowUserToDeleteRows = false;
            this.orderHistoryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderHistoryDGV.AutoGenerateColumns = false;
            this.orderHistoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryDGV.ColumnHeadersHeight = 29;
            this.orderHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderHistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.Column1,
            this.orderIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountInvitedDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.orderNotesDataGridViewTextBoxColumn,
            this.subOrderNotesDataGridViewTextBoxColumn});
            this.orderHistoryDGV.DataSource = this.orderHistoryViewBindingSource;
            this.orderHistoryDGV.Location = new System.Drawing.Point(26, 36);
            this.orderHistoryDGV.Name = "orderHistoryDGV";
            this.orderHistoryDGV.ReadOnly = true;
            this.orderHistoryDGV.RowHeadersVisible = false;
            this.orderHistoryDGV.RowHeadersWidth = 51;
            this.orderHistoryDGV.RowTemplate.Height = 24;
            this.orderHistoryDGV.Size = new System.Drawing.Size(920, 468);
            this.orderHistoryDGV.TabIndex = 0;
            this.orderHistoryDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderHistoryDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "היסטוריית הזמנות";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "מספר הזמנה ראשית";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "שם לקוח";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "מספר הזמנה";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "מוצר";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "תאריך הזמנה";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.amountInvitedDataGridViewTextBoxColumn.HeaderText = "כמות מוזמנים";
            this.amountInvitedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountInvitedDataGridViewTextBoxColumn.Name = "amountInvitedDataGridViewTextBoxColumn";
            this.amountInvitedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.adressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderNotesDataGridViewTextBoxColumn
            // 
            this.orderNotesDataGridViewTextBoxColumn.DataPropertyName = "orderNotes";
            this.orderNotesDataGridViewTextBoxColumn.HeaderText = "הערות";
            this.orderNotesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNotesDataGridViewTextBoxColumn.Name = "orderNotesDataGridViewTextBoxColumn";
            this.orderNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subOrderNotesDataGridViewTextBoxColumn
            // 
            this.subOrderNotesDataGridViewTextBoxColumn.DataPropertyName = "subOrderNotes";
            this.subOrderNotesDataGridViewTextBoxColumn.HeaderText = "הערות פרטי הזמנה";
            this.subOrderNotesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subOrderNotesDataGridViewTextBoxColumn.Name = "subOrderNotesDataGridViewTextBoxColumn";
            this.subOrderNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderHistoryViewBindingSource
            // 
            this.orderHistoryViewBindingSource.DataSource = typeof(Landau.Win.orderHistoryView);
            // 
            // orderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1017, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderHistoryDGV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderHistory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.orderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderHistoryDGV;
        private System.Windows.Forms.BindingSource orderHistoryViewBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountInvitedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subOrderNotesDataGridViewTextBoxColumn;
    }
}