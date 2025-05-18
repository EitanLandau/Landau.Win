
namespace Landau.Win.forms
{
    partial class updateOrderDeatsWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateOrderDeatsWin));
            this.updOrderHourDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderDateDtp = new Krypton.Toolkit.KryptonDateTimePicker();
            this.updOrderDeatsNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updAmmountInvitedUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updOrderBtn = new System.Windows.Forms.Button();
            this.changeProductCmbx = new System.Windows.Forms.ComboBox();
            this.lecturesNseminarsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updAdressTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderIDTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderUpdOrderDeats = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.updAmmountInvitedUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdOrderDeats)).BeginInit();
            this.SuspendLayout();
            // 
            // updOrderHourDtp
            // 
            this.updOrderHourDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderHourDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updOrderHourDtp.Location = new System.Drawing.Point(537, 258);
            this.updOrderHourDtp.Name = "updOrderHourDtp";
            this.updOrderHourDtp.ShowUpDown = true;
            this.updOrderHourDtp.Size = new System.Drawing.Size(141, 26);
            this.updOrderHourDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderHourDtp.TabIndex = 40;
            this.updOrderHourDtp.ValueChanged += new System.EventHandler(this.updOrderHourDtp_ValueChanged);
            // 
            // updOrderDateDtp
            // 
            this.updOrderDateDtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updOrderDateDtp.Location = new System.Drawing.Point(501, 210);
            this.updOrderDateDtp.Name = "updOrderDateDtp";
            this.updOrderDateDtp.Size = new System.Drawing.Size(215, 26);
            this.updOrderDateDtp.StateCommon.Content.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderDateDtp.TabIndex = 39;
            this.updOrderDateDtp.ValueChanged += new System.EventHandler(this.updOrderDateDtp_ValueChanged);
            // 
            // updOrderDeatsNotes
            // 
            this.updOrderDeatsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updOrderDeatsNotes.Location = new System.Drawing.Point(71, 147);
            this.updOrderDeatsNotes.Multiline = true;
            this.updOrderDeatsNotes.Name = "updOrderDeatsNotes";
            this.updOrderDeatsNotes.Size = new System.Drawing.Size(218, 273);
            this.updOrderDeatsNotes.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(859, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 37;
            this.label5.Text = "כתובת";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(341, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "הערות";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(788, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "כמות מוזמנים";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updAmmountInvitedUD
            // 
            this.updAmmountInvitedUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updAmmountInvitedUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updAmmountInvitedUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.updAmmountInvitedUD.Location = new System.Drawing.Point(524, 318);
            this.updAmmountInvitedUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updAmmountInvitedUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAmmountInvitedUD.Name = "updAmmountInvitedUD";
            this.updAmmountInvitedUD.Size = new System.Drawing.Size(175, 32);
            this.updAmmountInvitedUD.TabIndex = 34;
            this.updAmmountInvitedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updAmmountInvitedUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updAmmountInvitedUD.ValueChanged += new System.EventHandler(this.updAmmountInvitedUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(857, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "תאריך";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // updOrderBtn
            // 
            this.updOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updOrderBtn.BackColor = System.Drawing.Color.Firebrick;
            this.updOrderBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updOrderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(210)))), ((int)(((byte)(221)))));
            this.updOrderBtn.Location = new System.Drawing.Point(38, 441);
            this.updOrderBtn.Name = "updOrderBtn";
            this.updOrderBtn.Size = new System.Drawing.Size(156, 56);
            this.updOrderBtn.TabIndex = 32;
            this.updOrderBtn.Text = "עדכן הזמנה";
            this.updOrderBtn.UseVisualStyleBackColor = false;
            this.updOrderBtn.Click += new System.EventHandler(this.updOrderBtn_Click);
            // 
            // changeProductCmbx
            // 
            this.changeProductCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeProductCmbx.DataSource = this.lecturesNseminarsTBLBindingSource;
            this.changeProductCmbx.DisplayMember = "title";
            this.changeProductCmbx.FormattingEnabled = true;
            this.changeProductCmbx.Location = new System.Drawing.Point(501, 151);
            this.changeProductCmbx.Name = "changeProductCmbx";
            this.changeProductCmbx.Size = new System.Drawing.Size(215, 24);
            this.changeProductCmbx.TabIndex = 31;
            this.changeProductCmbx.ValueMember = "Id";
            this.changeProductCmbx.SelectedIndexChanged += new System.EventHandler(this.changeProductCmbx_SelectedIndexChanged);
            // 
            // lecturesNseminarsTBLBindingSource
            // 
            this.lecturesNseminarsTBLBindingSource.DataSource = typeof(Landau.Win.lecturesNseminarsTBL);
            this.lecturesNseminarsTBLBindingSource.CurrentChanged += new System.EventHandler(this.lecturesNseminarsTBLBindingSource_CurrentChanged);
            // 
            // updAdressTxb
            // 
            this.updAdressTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updAdressTxb.Location = new System.Drawing.Point(537, 398);
            this.updAdressTxb.Name = "updAdressTxb";
            this.updAdressTxb.Size = new System.Drawing.Size(154, 22);
            this.updAdressTxb.TabIndex = 30;
            this.updAdressTxb.TextChanged += new System.EventHandler(this.updAdressTxb_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(736, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "בחר סדנה/הרצאה";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(352, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 42;
            // 
            // orderIDTxb
            // 
            this.orderIDTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderIDTxb.Location = new System.Drawing.Point(357, 56);
            this.orderIDTxb.Name = "orderIDTxb";
            this.orderIDTxb.Size = new System.Drawing.Size(230, 22);
            this.orderIDTxb.TabIndex = 43;
            this.orderIDTxb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(377, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "הזן מספר הזמנה";
            // 
            // errorProviderUpdOrderDeats
            // 
            this.errorProviderUpdOrderDeats.ContainerControl = this;
            // 
            // updateOrderDeatsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderIDTxb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updOrderHourDtp);
            this.Controls.Add(this.updOrderDateDtp);
            this.Controls.Add(this.updOrderDeatsNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updAmmountInvitedUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updOrderBtn);
            this.Controls.Add(this.changeProductCmbx);
            this.Controls.Add(this.updAdressTxb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateOrderDeatsWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.updateOrderDeatsWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updAmmountInvitedUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesNseminarsTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdOrderDeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDateTimePicker updOrderHourDtp;
        private Krypton.Toolkit.KryptonDateTimePicker updOrderDateDtp;
        private System.Windows.Forms.TextBox updOrderDeatsNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updAmmountInvitedUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updOrderBtn;
        private System.Windows.Forms.ComboBox changeProductCmbx;
        private System.Windows.Forms.TextBox updAdressTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderIDTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource lecturesNseminarsTBLBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderUpdOrderDeats;
    }
}