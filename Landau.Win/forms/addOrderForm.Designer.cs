namespace Landau.Win.forms
{
    partial class addOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrderForm));
            this.pickCostumerCmbx = new System.Windows.Forms.ComboBox();
            this.costumerTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.costumerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumerLbl = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.pictureBoxAddOrder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderNotesTxb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.costumerTBLTableAdapter = new Landau.Win.dbDataSetTableAdapters.costumerTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pickCostumerCmbx
            // 
            this.pickCostumerCmbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickCostumerCmbx.DataSource = this.costumerTBLBindingSource1;
            this.pickCostumerCmbx.DisplayMember = "fullName";
            this.pickCostumerCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pickCostumerCmbx.FormattingEnabled = true;
            this.pickCostumerCmbx.Location = new System.Drawing.Point(363, 81);
            this.pickCostumerCmbx.Name = "pickCostumerCmbx";
            this.pickCostumerCmbx.Size = new System.Drawing.Size(225, 30);
            this.pickCostumerCmbx.TabIndex = 0;
            this.pickCostumerCmbx.SelectedIndexChanged += new System.EventHandler(this.pickCostumerCmbx_SelectedIndexChanged);
            // 
            // costumerTBLBindingSource
            // 
            this.costumerTBLBindingSource.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // costumerLbl
            // 
            this.costumerLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.costumerLbl.AutoSize = true;
            this.costumerLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.costumerLbl.Location = new System.Drawing.Point(421, 37);
            this.costumerLbl.Name = "costumerLbl";
            this.costumerLbl.Size = new System.Drawing.Size(115, 28);
            this.costumerLbl.TabIndex = 1;
            this.costumerLbl.Text = "בחר לקוח";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.continueBtn.BackColor = System.Drawing.Color.Navy;
            this.continueBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.continueBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.continueBtn.Location = new System.Drawing.Point(395, 391);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(141, 55);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "המשך";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // pictureBoxAddOrder
            // 
            this.pictureBoxAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddOrder.Image")));
            this.pictureBoxAddOrder.Location = new System.Drawing.Point(30, -9);
            this.pictureBoxAddOrder.Name = "pictureBoxAddOrder";
            this.pictureBoxAddOrder.Size = new System.Drawing.Size(838, 483);
            this.pictureBoxAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddOrder.TabIndex = 11;
            this.pictureBoxAddOrder.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(434, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "הערות";
            // 
            // orderNotesTxb
            // 
            this.orderNotesTxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderNotesTxb.Location = new System.Drawing.Point(363, 193);
            this.orderNotesTxb.Multiline = true;
            this.orderNotesTxb.Name = "orderNotesTxb";
            this.orderNotesTxb.Size = new System.Drawing.Size(225, 183);
            this.orderNotesTxb.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // costumerTBLTableAdapter
            // 
            this.costumerTBLTableAdapter.ClearBeforeFill = true;
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.orderNotesTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.costumerLbl);
            this.Controls.Add(this.pickCostumerCmbx);
            this.Controls.Add(this.pictureBoxAddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrderForm";
            this.Text = "הוסף לקוח וכאלה";
            this.Load += new System.EventHandler(this.addOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pickCostumerCmbx;
        private System.Windows.Forms.Label costumerLbl;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.PictureBox pictureBoxAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderNotesTxb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource1;
        private dbDataSetTableAdapters.costumerTBLTableAdapter costumerTBLTableAdapter;
    }
}