
namespace Landau.Win.forms
{
    partial class manageServiceWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageServiceWin));
            this.OrderDeatsNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howManySessionsUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.serviceNameTxb = new System.Windows.Forms.TextBox();
            this.servicePriceUD = new System.Windows.Forms.NumericUpDown();
            this.addProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.howManySessionsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDeatsNotes
            // 
            this.OrderDeatsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDeatsNotes.Location = new System.Drawing.Point(751, 272);
            this.OrderDeatsNotes.Multiline = true;
            this.OrderDeatsNotes.Name = "OrderDeatsNotes";
            this.OrderDeatsNotes.Size = new System.Drawing.Size(156, 183);
            this.OrderDeatsNotes.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(1024, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(1024, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "תיאור";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(938, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "מספר מפגשים";
            // 
            // howManySessionsUD
            // 
            this.howManySessionsUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.howManySessionsUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.howManySessionsUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.howManySessionsUD.Location = new System.Drawing.Point(751, 134);
            this.howManySessionsUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.howManySessionsUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howManySessionsUD.Name = "howManySessionsUD";
            this.howManySessionsUD.Size = new System.Drawing.Size(156, 28);
            this.howManySessionsUD.TabIndex = 30;
            this.howManySessionsUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.howManySessionsUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(975, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם תהליך";
            // 
            // serviceNameTxb
            // 
            this.serviceNameTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceNameTxb.Location = new System.Drawing.Point(751, 70);
            this.serviceNameTxb.Name = "serviceNameTxb";
            this.serviceNameTxb.Size = new System.Drawing.Size(147, 22);
            this.serviceNameTxb.TabIndex = 28;
            // 
            // servicePriceUD
            // 
            this.servicePriceUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servicePriceUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.servicePriceUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.servicePriceUD.Location = new System.Drawing.Point(751, 196);
            this.servicePriceUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.servicePriceUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.servicePriceUD.Name = "servicePriceUD";
            this.servicePriceUD.Size = new System.Drawing.Size(156, 28);
            this.servicePriceUD.TabIndex = 35;
            this.servicePriceUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servicePriceUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBtn.BackColor = System.Drawing.Color.Teal;
            this.addProductBtn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addProductBtn.ForeColor = System.Drawing.Color.Azure;
            this.addProductBtn.Location = new System.Drawing.Point(751, 490);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(147, 59);
            this.addProductBtn.TabIndex = 36;
            this.addProductBtn.Text = "הוסף";
            this.addProductBtn.UseVisualStyleBackColor = false;
            // 
            // manageServiceWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 718);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.servicePriceUD);
            this.Controls.Add(this.OrderDeatsNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.howManySessionsUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serviceNameTxb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageServiceWin";
            this.Text = "addService";
            this.Load += new System.EventHandler(this.manageServiceWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.howManySessionsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePriceUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OrderDeatsNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown howManySessionsUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serviceNameTxb;
        private System.Windows.Forms.NumericUpDown servicePriceUD;
        private System.Windows.Forms.Button addProductBtn;
    }
}