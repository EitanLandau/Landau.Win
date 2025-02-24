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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addCostumerForm));
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addCostumerDeateilsBtn = new System.Windows.Forms.Button();
            this.addPictureBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBx)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameLbl.Location = new System.Drawing.Point(694, 65);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(94, 29);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "שם פרטי";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(497, 72);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(158, 22);
            this.firstNameTxt.TabIndex = 2;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLbl.Location = new System.Drawing.Point(671, 141);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(117, 29);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "שם משפחה";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(497, 148);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(158, 22);
            this.lastNameTxt.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 5;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLbl.Location = new System.Drawing.Point(713, 204);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(75, 29);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "אימייל";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phoneNumberLbl.Location = new System.Drawing.Point(663, 268);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(125, 29);
            this.phoneNumberLbl.TabIndex = 7;
            this.phoneNumberLbl.Text = "מספר טלפון";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(497, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 8;
            // 
            // addCostumerDeateilsBtn
            // 
            this.addCostumerDeateilsBtn.Location = new System.Drawing.Point(33, 268);
            this.addCostumerDeateilsBtn.Name = "addCostumerDeateilsBtn";
            this.addCostumerDeateilsBtn.Size = new System.Drawing.Size(143, 63);
            this.addCostumerDeateilsBtn.TabIndex = 9;
            this.addCostumerDeateilsBtn.Text = "הוסף לקוח";
            this.addCostumerDeateilsBtn.UseVisualStyleBackColor = true;
            // 
            // addPictureBx
            // 
            this.addPictureBx.Image = ((System.Drawing.Image)(resources.GetObject("addPictureBx.Image")));
            this.addPictureBx.Location = new System.Drawing.Point(1, -2);
            this.addPictureBx.Name = "addPictureBx";
            this.addPictureBx.Size = new System.Drawing.Size(804, 451);
            this.addPictureBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addPictureBx.TabIndex = 10;
            this.addPictureBx.TabStop = false;
            // 
            // addCostumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCostumerDeateilsBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.addPictureBx);
            this.Name = "addCostumerForm";
            this.Text = "הוסף לקוח";
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addCostumerDeateilsBtn;
        private System.Windows.Forms.PictureBox addPictureBx;
    }
}