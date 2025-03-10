namespace Landau.Win.forms
{
    partial class updateCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateCustomerForm));
            this.pickCustomerCmbx = new System.Windows.Forms.ComboBox();
            this.pickCustLbl = new System.Windows.Forms.Label();
            this.updateFormPic = new System.Windows.Forms.PictureBox();
            this.updFirstNameTxb = new System.Windows.Forms.TextBox();
            this.updEmailTxb = new System.Windows.Forms.TextBox();
            this.updLastNameTxb = new System.Windows.Forms.TextBox();
            this.updPhoneMtxb = new System.Windows.Forms.MaskedTextBox();
            this.updBdateDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updNotesTxb = new System.Windows.Forms.TextBox();
            this.updCustomerDeatils = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateFormPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pickCustomerCmbx
            // 
            this.pickCustomerCmbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickCustomerCmbx.FormattingEnabled = true;
            this.pickCustomerCmbx.Location = new System.Drawing.Point(335, 65);
            this.pickCustomerCmbx.Name = "pickCustomerCmbx";
            this.pickCustomerCmbx.Size = new System.Drawing.Size(142, 24);
            this.pickCustomerCmbx.TabIndex = 0;
            // 
            // pickCustLbl
            // 
            this.pickCustLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickCustLbl.AutoSize = true;
            this.pickCustLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickCustLbl.ForeColor = System.Drawing.Color.Black;
            this.pickCustLbl.Location = new System.Drawing.Point(351, 18);
            this.pickCustLbl.Name = "pickCustLbl";
            this.pickCustLbl.Size = new System.Drawing.Size(115, 28);
            this.pickCustLbl.TabIndex = 1;
            this.pickCustLbl.Text = "בחר לקוח";
            // 
            // updateFormPic
            // 
            this.updateFormPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateFormPic.Image = ((System.Drawing.Image)(resources.GetObject("updateFormPic.Image")));
            this.updateFormPic.Location = new System.Drawing.Point(1, 12);
            this.updateFormPic.Name = "updateFormPic";
            this.updateFormPic.Size = new System.Drawing.Size(799, 445);
            this.updateFormPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updateFormPic.TabIndex = 2;
            this.updateFormPic.TabStop = false;
            // 
            // updFirstNameTxb
            // 
            this.updFirstNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updFirstNameTxb.Location = new System.Drawing.Point(510, 155);
            this.updFirstNameTxb.Name = "updFirstNameTxb";
            this.updFirstNameTxb.Size = new System.Drawing.Size(142, 22);
            this.updFirstNameTxb.TabIndex = 3;
            // 
            // updEmailTxb
            // 
            this.updEmailTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updEmailTxb.Location = new System.Drawing.Point(510, 258);
            this.updEmailTxb.Name = "updEmailTxb";
            this.updEmailTxb.Size = new System.Drawing.Size(142, 22);
            this.updEmailTxb.TabIndex = 4;
            // 
            // updLastNameTxb
            // 
            this.updLastNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updLastNameTxb.Location = new System.Drawing.Point(510, 207);
            this.updLastNameTxb.Name = "updLastNameTxb";
            this.updLastNameTxb.Size = new System.Drawing.Size(142, 22);
            this.updLastNameTxb.TabIndex = 5;
            // 
            // updPhoneMtxb
            // 
            this.updPhoneMtxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updPhoneMtxb.Location = new System.Drawing.Point(510, 307);
            this.updPhoneMtxb.Mask = "(999) 000-0000";
            this.updPhoneMtxb.Name = "updPhoneMtxb";
            this.updPhoneMtxb.Size = new System.Drawing.Size(142, 22);
            this.updPhoneMtxb.TabIndex = 6;
            // 
            // updBdateDtp
            // 
            this.updBdateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updBdateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updBdateDtp.Location = new System.Drawing.Point(510, 359);
            this.updBdateDtp.Name = "updBdateDtp";
            this.updBdateDtp.Size = new System.Drawing.Size(113, 22);
            this.updBdateDtp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "תאריך לידה";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "טלפון";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "אימייל";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "שם משפחה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "הערות";
            // 
            // updNotesTxb
            // 
            this.updNotesTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updNotesTxb.Location = new System.Drawing.Point(228, 159);
            this.updNotesTxb.Multiline = true;
            this.updNotesTxb.Name = "updNotesTxb";
            this.updNotesTxb.Size = new System.Drawing.Size(176, 222);
            this.updNotesTxb.TabIndex = 15;
            // 
            // updCustomerDeatils
            // 
            this.updCustomerDeatils.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updCustomerDeatils.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCustomerDeatils.Location = new System.Drawing.Point(35, 343);
            this.updCustomerDeatils.Name = "updCustomerDeatils";
            this.updCustomerDeatils.Size = new System.Drawing.Size(114, 52);
            this.updCustomerDeatils.TabIndex = 16;
            this.updCustomerDeatils.Text = "עדכן";
            this.updCustomerDeatils.UseVisualStyleBackColor = true;
            // 
            // updateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updCustomerDeatils);
            this.Controls.Add(this.updNotesTxb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updBdateDtp);
            this.Controls.Add(this.updPhoneMtxb);
            this.Controls.Add(this.updLastNameTxb);
            this.Controls.Add(this.updEmailTxb);
            this.Controls.Add(this.updFirstNameTxb);
            this.Controls.Add(this.pickCustLbl);
            this.Controls.Add(this.pickCustomerCmbx);
            this.Controls.Add(this.updateFormPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "updateCustomerForm";
            this.Text = "עדכן פרטי לקוח";
            ((System.ComponentModel.ISupportInitialize)(this.updateFormPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pickCustomerCmbx;
        private System.Windows.Forms.Label pickCustLbl;
        private System.Windows.Forms.PictureBox updateFormPic;
        private System.Windows.Forms.TextBox updFirstNameTxb;
        private System.Windows.Forms.TextBox updEmailTxb;
        private System.Windows.Forms.TextBox updLastNameTxb;
        private System.Windows.Forms.MaskedTextBox updPhoneMtxb;
        private System.Windows.Forms.DateTimePicker updBdateDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updNotesTxb;
        private System.Windows.Forms.Button updCustomerDeatils;
    }
}