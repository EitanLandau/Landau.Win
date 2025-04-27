namespace Landau.Win.forms
{
    partial class orderDeatailsWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderDeatailsWin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddOrder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addSubOrderBtn = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.TextBox();
            this.picProductCmbx = new System.Windows.Forms.ComboBox();
            this.finishOrderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.ammountInvitedUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderDeatsNotes = new System.Windows.Forms.TextBox();
            this.lecturesNseminarsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammountInvitedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxAddOrder
            // 
            this.pictureBoxAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddOrder.Image")));
            this.pictureBoxAddOrder.Location = new System.Drawing.Point(26, -3);
            this.pictureBoxAddOrder.Name = "pictureBoxAddOrder";
            this.pictureBoxAddOrder.Size = new System.Drawing.Size(841, 448);
            this.pictureBoxAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddOrder.TabIndex = 12;
            this.pictureBoxAddOrder.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(563, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "בחר סדנה/הרצאה";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addSubOrderBtn
            // 
            this.addSubOrderBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addSubOrderBtn.Location = new System.Drawing.Point(41, 321);
            this.addSubOrderBtn.Name = "addSubOrderBtn";
            this.addSubOrderBtn.Size = new System.Drawing.Size(147, 38);
            this.addSubOrderBtn.TabIndex = 14;
            this.addSubOrderBtn.Text = "הוסף הזמנה";
            this.addSubOrderBtn.UseVisualStyleBackColor = true;
            this.addSubOrderBtn.Click += new System.EventHandler(this.addSubOrderBtn_Click);
            // 
            // adress
            // 
            this.adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adress.Location = new System.Drawing.Point(402, 239);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(154, 22);
            this.adress.TabIndex = 15;
            // 
            // picProductCmbx
            // 
            this.picProductCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picProductCmbx.DataSource = this.lecturesNseminarsTBLBindingSource;
            this.picProductCmbx.DisplayMember = "title";
            this.picProductCmbx.FormattingEnabled = true;
            this.picProductCmbx.Location = new System.Drawing.Point(402, 68);
            this.picProductCmbx.Name = "picProductCmbx";
            this.picProductCmbx.Size = new System.Drawing.Size(154, 24);
            this.picProductCmbx.TabIndex = 16;
            // 
            // finishOrderBtn
            // 
            this.finishOrderBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.finishOrderBtn.Location = new System.Drawing.Point(41, 365);
            this.finishOrderBtn.Name = "finishOrderBtn";
            this.finishOrderBtn.Size = new System.Drawing.Size(147, 38);
            this.finishOrderBtn.TabIndex = 17;
            this.finishOrderBtn.Text = "סיים הזמנה";
            this.finishOrderBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(689, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "תאריך";
            // 
            // dtpOrder
            // 
            this.dtpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOrder.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(402, 114);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(154, 22);
            this.dtpOrder.TabIndex = 19;
            this.dtpOrder.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ammountInvitedUD
            // 
            this.ammountInvitedUD.Location = new System.Drawing.Point(402, 174);
            this.ammountInvitedUD.Name = "ammountInvitedUD";
            this.ammountInvitedUD.Size = new System.Drawing.Size(154, 22);
            this.ammountInvitedUD.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(618, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "כמות מוזמנים";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(690, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "הערות";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(689, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "כתובת";
            // 
            // OrderDeatsNotes
            // 
            this.OrderDeatsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDeatsNotes.Location = new System.Drawing.Point(402, 298);
            this.OrderDeatsNotes.Multiline = true;
            this.OrderDeatsNotes.Name = "OrderDeatsNotes";
            this.OrderDeatsNotes.Size = new System.Drawing.Size(154, 140);
            this.OrderDeatsNotes.TabIndex = 25;
            // 
            // lecturesNseminarsTBLBindingSource
            // 
            this.lecturesNseminarsTBLBindingSource.DataSource = typeof(Landau.Win.lecturesNseminarsTBL);
            // 
            // orderDeatailsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderDeatsNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ammountInvitedUD);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finishOrderBtn);
            this.Controls.Add(this.picProductCmbx);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.addSubOrderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAddOrder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderDeatailsWin";
            this.Text = "פרטי הזמנה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammountInvitedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addSubOrderBtn;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.ComboBox picProductCmbx;
        private System.Windows.Forms.Button finishOrderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.NumericUpDown ammountInvitedUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrderDeatsNotes;
        private System.Windows.Forms.BindingSource lecturesNseminarsTBLBindingSource;
    }
}