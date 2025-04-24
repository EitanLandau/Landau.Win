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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrderForm));
            this.pickCostumerCmbx = new System.Windows.Forms.ComboBox();
            this.costumerLbl = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.pictureBoxAddOrder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pickCostumerCmbx
            // 
            this.pickCostumerCmbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pickCostumerCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pickCostumerCmbx.FormattingEnabled = true;
            this.pickCostumerCmbx.Location = new System.Drawing.Point(575, 79);
            this.pickCostumerCmbx.Name = "pickCostumerCmbx";
            this.pickCostumerCmbx.Size = new System.Drawing.Size(225, 30);
            this.pickCostumerCmbx.TabIndex = 0;
            this.pickCostumerCmbx.SelectedIndexChanged += new System.EventHandler(this.pickCostumerCmbx_SelectedIndexChanged);
            // 
            // costumerLbl
            // 
            this.costumerLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.costumerLbl.AutoSize = true;
            this.costumerLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerLbl.Location = new System.Drawing.Point(685, 31);
            this.costumerLbl.Name = "costumerLbl";
            this.costumerLbl.Size = new System.Drawing.Size(115, 28);
            this.costumerLbl.TabIndex = 1;
            this.costumerLbl.Text = "בחר לקוח";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.continueBtn.Location = new System.Drawing.Point(103, 344);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(120, 52);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "המשך";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // pictureBoxAddOrder
            // 
            this.pictureBoxAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddOrder.Image")));
            this.pictureBoxAddOrder.Location = new System.Drawing.Point(45, -9);
            this.pictureBoxAddOrder.Name = "pictureBoxAddOrder";
            this.pictureBoxAddOrder.Size = new System.Drawing.Size(868, 483);
            this.pictureBoxAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddOrder.TabIndex = 11;
            this.pictureBoxAddOrder.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(722, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "הערות";
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.costumerLbl);
            this.Controls.Add(this.pickCostumerCmbx);
            this.Controls.Add(this.pictureBoxAddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrderForm";
            this.Text = "הוסף לקוח וכאלה";
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
    }
}