
namespace Landau.Win.forms
{
    partial class updateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateProductForm));
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.updProductDescribtionTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updSessionLengthDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updTitleTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updPriceNumUD = new System.Windows.Forms.NumericUpDown();
            this.updProductTypeCmbx = new System.Windows.Forms.ComboBox();
            this.errorProviderUpdProduct = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.updPriceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateProductBtn.BackColor = System.Drawing.Color.Purple;
            this.updateProductBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateProductBtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.updateProductBtn.Location = new System.Drawing.Point(24, 472);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(145, 58);
            this.updateProductBtn.TabIndex = 21;
            this.updateProductBtn.Text = "עדכן מוצר";
            this.updateProductBtn.UseVisualStyleBackColor = false;
            this.updateProductBtn.Click += new System.EventHandler(this.updateProductBtn_Click);
            // 
            // updProductDescribtionTxb
            // 
            this.updProductDescribtionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updProductDescribtionTxb.Location = new System.Drawing.Point(344, 161);
            this.updProductDescribtionTxb.Multiline = true;
            this.updProductDescribtionTxb.Name = "updProductDescribtionTxb";
            this.updProductDescribtionTxb.Size = new System.Drawing.Size(194, 287);
            this.updProductDescribtionTxb.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(854, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "כותרת";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(382, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "תיאור מוצר";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(721, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "אורך הרצאה/סדנה";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(871, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "מחיר";
            // 
            // updSessionLengthDtp
            // 
            this.updSessionLengthDtp.AllowButtonSpecToolTipPriority = true;
            this.updSessionLengthDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updSessionLengthDtp.CalendarFirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.updSessionLengthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updSessionLengthDtp.Location = new System.Drawing.Point(584, 322);
            this.updSessionLengthDtp.Name = "updSessionLengthDtp";
            this.updSessionLengthDtp.Size = new System.Drawing.Size(120, 26);
            this.updSessionLengthDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updSessionLengthDtp.TabIndex = 15;
            // 
            // updTitleTxb
            // 
            this.updTitleTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updTitleTxb.Location = new System.Drawing.Point(584, 425);
            this.updTitleTxb.Name = "updTitleTxb";
            this.updTitleTxb.Size = new System.Drawing.Size(249, 22);
            this.updTitleTxb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(829, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "סוג מוצר";
            // 
            // updPriceNumUD
            // 
            this.updPriceNumUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updPriceNumUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updPriceNumUD.Location = new System.Drawing.Point(585, 206);
            this.updPriceNumUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updPriceNumUD.Name = "updPriceNumUD";
            this.updPriceNumUD.Size = new System.Drawing.Size(177, 32);
            this.updPriceNumUD.TabIndex = 12;
            this.updPriceNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updProductTypeCmbx
            // 
            this.updProductTypeCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updProductTypeCmbx.FormattingEnabled = true;
            this.updProductTypeCmbx.Items.AddRange(new object[] {
            "סדנא",
            "הרצאה"});
            this.updProductTypeCmbx.Location = new System.Drawing.Point(584, 120);
            this.updProductTypeCmbx.Name = "updProductTypeCmbx";
            this.updProductTypeCmbx.Size = new System.Drawing.Size(178, 24);
            this.updProductTypeCmbx.TabIndex = 11;
            // 
            // errorProviderUpdProduct
            // 
            this.errorProviderUpdProduct.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(706, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "בחר מוצר";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "סדנא",
            "הרצאה"});
            this.comboBox1.Location = new System.Drawing.Point(491, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 22;
            // 
            // updateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.updateProductBtn);
            this.Controls.Add(this.updProductDescribtionTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updSessionLengthDtp);
            this.Controls.Add(this.updTitleTxb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updPriceNumUD);
            this.Controls.Add(this.updProductTypeCmbx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateProductForm";
            this.Text = "updateCustomerWin";
            this.Load += new System.EventHandler(this.updateProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updPriceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.TextBox updProductDescribtionTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonDateTimePicker updSessionLengthDtp;
        private System.Windows.Forms.TextBox updTitleTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updPriceNumUD;
        private System.Windows.Forms.ComboBox updProductTypeCmbx;
        private System.Windows.Forms.ErrorProvider errorProviderUpdProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}