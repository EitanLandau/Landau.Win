namespace Landau.Win
{
    partial class HomePage
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.costumersMangment = new Krypton.Ribbon.KryptonRibbonTab();
            this.costumerFeatures = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.addBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updateBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.costumerLst = new Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.costumersMangment});
            this.kryptonRibbon1.SelectedTab = this.costumersMangment;
            this.kryptonRibbon1.Size = new System.Drawing.Size(859, 171);
            this.kryptonRibbon1.TabIndex = 0;
            this.kryptonRibbon1.SelectedTabChanged += new System.EventHandler(this.kryptonRibbon1_SelectedTabChanged);
            // 
            // costumersMangment
            // 
            this.costumersMangment.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.costumerFeatures});
            this.costumersMangment.Text = "ניהול לקוחות";
            // 
            // costumerFeatures
            // 
            this.costumerFeatures.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.costumerFeatures.TextLine1 = "( :";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.addBtn,
            this.updateBtn,
            this.costumerLst});
            // 
            // addBtn
            // 
            this.addBtn.TextLine1 = "הוסף לקוח";
            // 
            // updateBtn
            // 
            this.updateBtn.TextLine1 = "עדכן לקוח";
            // 
            // costumerLst
            // 
            this.costumerLst.TextLine1 = "רשימת לקוחות";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "HomePage";
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab costumersMangment;
        private Krypton.Ribbon.KryptonRibbonGroup costumerFeatures;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton addBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton updateBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton costumerLst;
    }
}

