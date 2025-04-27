namespace Landau.Win.forms
{
    partial class addCostumerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCostumerForm));
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.addCostumerDeateilsBtn = new System.Windows.Forms.Button();
            this.addPictureBx = new System.Windows.Forms.PictureBox();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.BdateLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneMtxb = new System.Windows.Forms.MaskedTextBox();
            this.notesTxb = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.institutionTxb = new System.Windows.Forms.TextBox();
            this.institutionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(713, 48);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(104, 28);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "שם פרטי";
            this.firstNameLbl.Click += new System.EventHandler(this.firstNameLbl_Click);
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTxt.Location = new System.Drawing.Point(545, 54);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(158, 22);
            this.firstNameTxt.TabIndex = 2;
            this.firstNameTxt.TextChanged += new System.EventHandler(this.firstNameTxt_TextChanged);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(713, 98);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(136, 28);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "שם משפחה";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTxt.Location = new System.Drawing.Point(546, 98);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(158, 22);
            this.lastNameTxt.TabIndex = 4;
            this.lastNameTxt.TextChanged += new System.EventHandler(this.lastNameTxt_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Location = new System.Drawing.Point(545, 149);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(158, 22);
            this.txbEmail.TabIndex = 5;
            // 
            // emailLbl
            // 
            this.emailLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(710, 143);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(75, 28);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "אימייל";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(710, 198);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(139, 28);
            this.phoneNumberLbl.TabIndex = 7;
            this.phoneNumberLbl.Text = "מספר טלפון";
            // 
            // addCostumerDeateilsBtn
            // 
            this.addCostumerDeateilsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCostumerDeateilsBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCostumerDeateilsBtn.Location = new System.Drawing.Point(64, 306);
            this.addCostumerDeateilsBtn.Name = "addCostumerDeateilsBtn";
            this.addCostumerDeateilsBtn.Size = new System.Drawing.Size(143, 63);
            this.addCostumerDeateilsBtn.TabIndex = 9;
            this.addCostumerDeateilsBtn.Text = "הוסף לקוח";
            this.addCostumerDeateilsBtn.UseVisualStyleBackColor = true;
            this.addCostumerDeateilsBtn.Click += new System.EventHandler(this.addCostumerDeateilsBtn_Click);
            // 
            // addPictureBx
            // 
            this.addPictureBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPictureBx.Image = ((System.Drawing.Image)(resources.GetObject("addPictureBx.Image")));
            this.addPictureBx.Location = new System.Drawing.Point(-32, -56);
            this.addPictureBx.Name = "addPictureBx";
            this.addPictureBx.Size = new System.Drawing.Size(915, 478);
            this.addPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBx.TabIndex = 10;
            this.addPictureBx.TabStop = false;
            this.addPictureBx.Click += new System.EventHandler(this.addPictureBx_Click);
            // 
            // dtpBDate
            // 
            this.dtpBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBDate.Location = new System.Drawing.Point(545, 257);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(110, 22);
            this.dtpBDate.TabIndex = 12;
            // 
            // BdateLbl
            // 
            this.BdateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BdateLbl.AutoSize = true;
            this.BdateLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BdateLbl.Location = new System.Drawing.Point(709, 251);
            this.BdateLbl.Name = "BdateLbl";
            this.BdateLbl.Size = new System.Drawing.Size(133, 28);
            this.BdateLbl.TabIndex = 7;
            this.BdateLbl.Text = "תאריך לידה";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // phoneMtxb
            // 
            this.phoneMtxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneMtxb.Location = new System.Drawing.Point(545, 204);
            this.phoneMtxb.Mask = "(999) 000-0000";
            this.phoneMtxb.Name = "phoneMtxb";
            this.phoneMtxb.Size = new System.Drawing.Size(158, 22);
            this.phoneMtxb.TabIndex = 13;
            this.phoneMtxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneMtxb.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoneMtxb_MaskInputRejected);
            // 
            // notesTxb
            // 
            this.notesTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTxb.Location = new System.Drawing.Point(254, 36);
            this.notesTxb.Multiline = true;
            this.notesTxb.Name = "notesTxb";
            this.notesTxb.Size = new System.Drawing.Size(181, 298);
            this.notesTxb.TabIndex = 14;
            // 
            // notesLbl
            // 
            this.notesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notesLbl.AutoSize = true;
            this.notesLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLbl.Location = new System.Drawing.Point(453, 39);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(67, 24);
            this.notesLbl.TabIndex = 15;
            this.notesLbl.Text = "הערות";
            // 
            // institutionTxb
            // 
            this.institutionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.institutionTxb.Location = new System.Drawing.Point(546, 312);
            this.institutionTxb.Name = "institutionTxb";
            this.institutionTxb.Size = new System.Drawing.Size(157, 22);
            this.institutionTxb.TabIndex = 16;
            // 
            // institutionLbl
            // 
            this.institutionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.institutionLbl.AutoSize = true;
            this.institutionLbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.institutionLbl.Location = new System.Drawing.Point(709, 306);
            this.institutionLbl.Name = "institutionLbl";
            this.institutionLbl.Size = new System.Drawing.Size(65, 28);
            this.institutionLbl.TabIndex = 17;
            this.institutionLbl.Text = "מוסד";
            // 
            // addCostumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 452);
            this.Controls.Add(this.institutionLbl);
            this.Controls.Add(this.institutionTxb);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.notesTxb);
            this.Controls.Add(this.phoneMtxb);
            this.Controls.Add(this.dtpBDate);
            this.Controls.Add(this.addCostumerDeateilsBtn);
            this.Controls.Add(this.BdateLbl);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.addPictureBx);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addCostumerForm";
            this.Text = "הוסף לקוח";
            this.Load += new System.EventHandler(this.addCostumerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Button addCostumerDeateilsBtn;
        private System.Windows.Forms.PictureBox addPictureBx;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Label BdateLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox phoneMtxb;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.TextBox notesTxb;
        private System.Windows.Forms.TextBox institutionTxb;
        private System.Windows.Forms.Label institutionLbl;
    }
}