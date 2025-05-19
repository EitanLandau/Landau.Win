
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
            this.ammountInvitedUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.adressTxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ammountInvitedUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDeatsNotes
            // 
            this.OrderDeatsNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDeatsNotes.Location = new System.Drawing.Point(475, 259);
            this.OrderDeatsNotes.Multiline = true;
            this.OrderDeatsNotes.Name = "OrderDeatsNotes";
            this.OrderDeatsNotes.Size = new System.Drawing.Size(218, 140);
            this.OrderDeatsNotes.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(833, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "כתובת";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(831, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "הערות";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(762, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "כמות מוזמנים";
            // 
            // ammountInvitedUD
            // 
            this.ammountInvitedUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ammountInvitedUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ammountInvitedUD.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ammountInvitedUD.Location = new System.Drawing.Point(498, 137);
            this.ammountInvitedUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ammountInvitedUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ammountInvitedUD.Name = "ammountInvitedUD";
            this.ammountInvitedUD.Size = new System.Drawing.Size(175, 32);
            this.ammountInvitedUD.TabIndex = 30;
            this.ammountInvitedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ammountInvitedUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(750, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם תהליך";
            // 
            // adressTxb
            // 
            this.adressTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adressTxb.Location = new System.Drawing.Point(511, 202);
            this.adressTxb.Name = "adressTxb";
            this.adressTxb.Size = new System.Drawing.Size(154, 22);
            this.adressTxb.TabIndex = 28;
            // 
            // manageServiceWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.OrderDeatsNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ammountInvitedUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressTxb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageServiceWin";
            this.Text = "addService";
            this.Load += new System.EventHandler(this.manageServiceWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ammountInvitedUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OrderDeatsNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ammountInvitedUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adressTxb;
    }
}