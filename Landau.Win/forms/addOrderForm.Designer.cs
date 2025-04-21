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
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateMskdBx = new System.Windows.Forms.MaskedTextBox();
            this.notesTxt = new System.Windows.Forms.TextBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.pictureBoxAddOrder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pickCostumerCmbx
            // 
            this.pickCostumerCmbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pickCostumerCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pickCostumerCmbx.FormattingEnabled = true;
            this.pickCostumerCmbx.Location = new System.Drawing.Point(497, 32);
            this.pickCostumerCmbx.Name = "pickCostumerCmbx";
            this.pickCostumerCmbx.Size = new System.Drawing.Size(160, 30);
            this.pickCostumerCmbx.TabIndex = 0;
            this.pickCostumerCmbx.SelectedIndexChanged += new System.EventHandler(this.pickCostumerCmbx_SelectedIndexChanged);
            // 
            // costumerLbl
            // 
            this.costumerLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.costumerLbl.AutoSize = true;
            this.costumerLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerLbl.Location = new System.Drawing.Point(695, 34);
            this.costumerLbl.Name = "costumerLbl";
            this.costumerLbl.Size = new System.Drawing.Size(64, 28);
            this.costumerLbl.TabIndex = 1;
            this.costumerLbl.Text = "לקוח";
            // 
            // addressLbl
            // 
            this.addressLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressLbl.Location = new System.Drawing.Point(695, 88);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(79, 28);
            this.addressLbl.TabIndex = 2;
            this.addressLbl.Text = "כתובת";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressTxtBox.Location = new System.Drawing.Point(497, 94);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(163, 22);
            this.addressTxtBox.TabIndex = 3;
            // 
            // notesLbl
            // 
            this.notesLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notesLbl.AutoSize = true;
            this.notesLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.notesLbl.Location = new System.Drawing.Point(724, 248);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(78, 28);
            this.notesLbl.TabIndex = 5;
            this.notesLbl.Text = "הערות";
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateLbl.Location = new System.Drawing.Point(695, 138);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(139, 48);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "תאריך התחלה\r\n      (ושעה)";
            // 
            // dateMskdBx
            // 
            this.dateMskdBx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateMskdBx.Location = new System.Drawing.Point(497, 160);
            this.dateMskdBx.Mask = "00/00/0000 90:00";
            this.dateMskdBx.Name = "dateMskdBx";
            this.dateMskdBx.Size = new System.Drawing.Size(188, 22);
            this.dateMskdBx.TabIndex = 7;
            this.dateMskdBx.ValidatingType = typeof(System.DateTime);
            // 
            // notesTxt
            // 
            this.notesTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.notesTxt.Location = new System.Drawing.Point(497, 238);
            this.notesTxt.Multiline = true;
            this.notesTxt.Name = "notesTxt";
            this.notesTxt.Size = new System.Drawing.Size(209, 141);
            this.notesTxt.TabIndex = 8;
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.continueBtn.Location = new System.Drawing.Point(39, 327);
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
            this.pictureBoxAddOrder.Location = new System.Drawing.Point(12, -9);
            this.pictureBoxAddOrder.Name = "pictureBoxAddOrder";
            this.pictureBoxAddOrder.Size = new System.Drawing.Size(868, 483);
            this.pictureBoxAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddOrder.TabIndex = 11;
            this.pictureBoxAddOrder.TabStop = false;
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.notesTxt);
            this.Controls.Add(this.dateMskdBx);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.addressLbl);
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
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.MaskedTextBox dateMskdBx;
        private System.Windows.Forms.TextBox notesTxt;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.PictureBox pictureBoxAddOrder;
    }
}