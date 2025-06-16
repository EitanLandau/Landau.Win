
namespace Landau.Win.forms
{
    partial class openNewProjectWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openNewProjectWin));
            this.projectDescriptionTxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.continueProjBtn = new System.Windows.Forms.Button();
            this.projectCustomerCmbx = new System.Windows.Forms.ComboBox();
            this.costumerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projTitleTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseServiceCmbx = new System.Windows.Forms.ComboBox();
            this.serviceTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDescriptionTxb
            // 
            this.projectDescriptionTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTxb.Location = new System.Drawing.Point(150, 77);
            this.projectDescriptionTxb.Multiline = true;
            this.projectDescriptionTxb.Name = "projectDescriptionTxb";
            this.projectDescriptionTxb.Size = new System.Drawing.Size(218, 321);
            this.projectDescriptionTxb.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(401, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "תיאור פרוייקט";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(940, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 47;
            this.label3.Text = "כותרת";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(887, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "בחר תהליך";
            // 
            // continueProjBtn
            // 
            this.continueProjBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.continueProjBtn.BackColor = System.Drawing.Color.DimGray;
            this.continueProjBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.continueProjBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.continueProjBtn.Location = new System.Drawing.Point(23, 482);
            this.continueProjBtn.Name = "continueProjBtn";
            this.continueProjBtn.Size = new System.Drawing.Size(150, 59);
            this.continueProjBtn.TabIndex = 44;
            this.continueProjBtn.Text = "המשך";
            this.continueProjBtn.UseVisualStyleBackColor = false;
            this.continueProjBtn.Click += new System.EventHandler(this.continueProjBtn_Click);
            // 
            // projectCustomerCmbx
            // 
            this.projectCustomerCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectCustomerCmbx.DataSource = this.costumerTBLBindingSource;
            this.projectCustomerCmbx.DisplayMember = "fullName";
            this.projectCustomerCmbx.FormattingEnabled = true;
            this.projectCustomerCmbx.Location = new System.Drawing.Point(610, 185);
            this.projectCustomerCmbx.Name = "projectCustomerCmbx";
            this.projectCustomerCmbx.Size = new System.Drawing.Size(215, 24);
            this.projectCustomerCmbx.TabIndex = 43;
            this.projectCustomerCmbx.ValueMember = "Id";
            // 
            // costumerTBLBindingSource
            // 
            this.costumerTBLBindingSource.DataSource = typeof(Landau.Win.costumerTBL);
            // 
            // projTitleTxb
            // 
            this.projTitleTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projTitleTxb.Location = new System.Drawing.Point(610, 84);
            this.projTitleTxb.Name = "projTitleTxb";
            this.projTitleTxb.Size = new System.Drawing.Size(215, 22);
            this.projTitleTxb.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(899, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "שייך לקוח";
            // 
            // chooseServiceCmbx
            // 
            this.chooseServiceCmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseServiceCmbx.DataSource = this.serviceTBLBindingSource;
            this.chooseServiceCmbx.DisplayMember = "serviceName";
            this.chooseServiceCmbx.FormattingEnabled = true;
            this.chooseServiceCmbx.Location = new System.Drawing.Point(610, 308);
            this.chooseServiceCmbx.Name = "chooseServiceCmbx";
            this.chooseServiceCmbx.Size = new System.Drawing.Size(215, 24);
            this.chooseServiceCmbx.TabIndex = 53;
            this.chooseServiceCmbx.ValueMember = "Id";
            // 
            // serviceTBLBindingSource
            // 
            this.serviceTBLBindingSource.DataSource = typeof(Landau.Win.serviceTBL);
            // 
            // openNewProjectWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 572);
            this.Controls.Add(this.chooseServiceCmbx);
            this.Controls.Add(this.projectDescriptionTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.continueProjBtn);
            this.Controls.Add(this.projectCustomerCmbx);
            this.Controls.Add(this.projTitleTxb);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "openNewProjectWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.openNewProjectWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costumerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox projectDescriptionTxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button continueProjBtn;
        private System.Windows.Forms.ComboBox projectCustomerCmbx;
        private System.Windows.Forms.TextBox projTitleTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseServiceCmbx;
        private System.Windows.Forms.BindingSource costumerTBLBindingSource;
        private System.Windows.Forms.BindingSource serviceTBLBindingSource;
    }
}