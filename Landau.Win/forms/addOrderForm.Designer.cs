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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pickCostumerCmbx
            // 
            this.pickCostumerCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pickCostumerCmbx.FormattingEnabled = true;
            this.pickCostumerCmbx.Location = new System.Drawing.Point(546, 34);
            this.pickCostumerCmbx.Name = "pickCostumerCmbx";
            this.pickCostumerCmbx.Size = new System.Drawing.Size(160, 30);
            this.pickCostumerCmbx.TabIndex = 0;
            this.pickCostumerCmbx.SelectedIndexChanged += new System.EventHandler(this.pickCostumerCmbx_SelectedIndexChanged);
            // 
            // costumerLbl
            // 
            this.costumerLbl.AutoSize = true;
            this.costumerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerLbl.Location = new System.Drawing.Point(724, 34);
            this.costumerLbl.Name = "costumerLbl";
            this.costumerLbl.Size = new System.Drawing.Size(51, 25);
            this.costumerLbl.TabIndex = 1;
            this.costumerLbl.Text = "לקוח";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressLbl.Location = new System.Drawing.Point(724, 94);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(60, 25);
            this.addressLbl.TabIndex = 2;
            this.addressLbl.Text = "כתובת";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(543, 98);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(163, 22);
            this.addressTxtBox.TabIndex = 3;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.notesLbl.Location = new System.Drawing.Point(724, 248);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(60, 25);
            this.notesLbl.TabIndex = 5;
            this.notesLbl.Text = "הערות";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateLbl.Location = new System.Drawing.Point(724, 140);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(117, 50);
            this.dateLbl.TabIndex = 6;
            this.dateLbl.Text = "תאריך התחלה\r\n      (ושעה)";
            // 
            // dateMskdBx
            // 
            this.dateMskdBx.Location = new System.Drawing.Point(518, 155);
            this.dateMskdBx.Mask = "00/00/0000 90:00";
            this.dateMskdBx.Name = "dateMskdBx";
            this.dateMskdBx.Size = new System.Drawing.Size(188, 22);
            this.dateMskdBx.TabIndex = 7;
            this.dateMskdBx.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 238);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 141);
            this.textBox1.TabIndex = 8;
            // 
            // continueBtn
            // 
            this.continueBtn.Location = new System.Drawing.Point(39, 327);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(120, 52);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "המשך";
            this.continueBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // addOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateMskdBx);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.costumerLbl);
            this.Controls.Add(this.pickCostumerCmbx);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOrderForm";
            this.Text = "הוסף לקוח וכאלה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}