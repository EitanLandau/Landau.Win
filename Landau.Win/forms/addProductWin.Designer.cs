namespace Landau.Win.forms
{
    partial class addProductWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductWin));
            this.productTypeCmbx = new System.Windows.Forms.ComboBox();
            this.priceNumUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTxb = new System.Windows.Forms.TextBox();
            this.sessionLengthDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productDescribtionTxb = new System.Windows.Forms.TextBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.errorProviderProduct = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // productTypeCmbx
            // 
            this.productTypeCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productTypeCmbx.FormattingEnabled = true;
            this.productTypeCmbx.Items.AddRange(new object[] {
            "סדנא",
            "הרצאה"});
            this.productTypeCmbx.Location = new System.Drawing.Point(402, 41);
            this.productTypeCmbx.Name = "productTypeCmbx";
            this.productTypeCmbx.Size = new System.Drawing.Size(121, 24);
            this.productTypeCmbx.TabIndex = 0;
            // 
            // priceNumUD
            // 
            this.priceNumUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.priceNumUD.Location = new System.Drawing.Point(403, 127);
            this.priceNumUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumUD.Name = "priceNumUD";
            this.priceNumUD.Size = new System.Drawing.Size(120, 32);
            this.priceNumUD.TabIndex = 1;
            this.priceNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(659, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "סוג מוצר";
            // 
            // titleTxb
            // 
            this.titleTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTxb.Location = new System.Drawing.Point(402, 346);
            this.titleTxb.Name = "titleTxb";
            this.titleTxb.Size = new System.Drawing.Size(249, 22);
            this.titleTxb.TabIndex = 3;
            // 
            // sessionLengthDtp
            // 
            this.sessionLengthDtp.AllowButtonSpecToolTipPriority = true;
            this.sessionLengthDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionLengthDtp.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.sessionLengthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sessionLengthDtp.Location = new System.Drawing.Point(402, 243);
            this.sessionLengthDtp.Name = "sessionLengthDtp";
            this.sessionLengthDtp.Size = new System.Drawing.Size(120, 26);
            this.sessionLengthDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sessionLengthDtp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(689, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "מחיר";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(546, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "אורך הרצאה/סדנה";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(204, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "תיאור מוצר";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(675, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "כותרת";
            // 
            // productDescribtionTxb
            // 
            this.productDescribtionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productDescribtionTxb.Location = new System.Drawing.Point(166, 82);
            this.productDescribtionTxb.Multiline = true;
            this.productDescribtionTxb.Name = "productDescribtionTxb";
            this.productDescribtionTxb.Size = new System.Drawing.Size(194, 287);
            this.productDescribtionTxb.TabIndex = 9;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProductBtn.BackColor = System.Drawing.Color.Maroon;
            this.addProductBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProductBtn.ForeColor = System.Drawing.Color.Linen;
            this.addProductBtn.Location = new System.Drawing.Point(12, 370);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(147, 59);
            this.addProductBtn.TabIndex = 10;
            this.addProductBtn.Text = "הוסף מוצר";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // errorProviderProduct
            // 
            this.errorProviderProduct.ContainerControl = this;
            // 
            // addProductWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productDescribtionTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sessionLengthDtp);
            this.Controls.Add(this.titleTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceNumUD);
            this.Controls.Add(this.productTypeCmbx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProductWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addProductWin_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productTypeCmbx;
        private System.Windows.Forms.NumericUpDown priceNumUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTxb;
        private Krypton.Toolkit.KryptonDateTimePicker sessionLengthDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productDescribtionTxb;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.ErrorProvider errorProviderProduct;
    }
}