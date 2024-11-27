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
            this.costumerMangmentTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnAdd = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnChange = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btnDeateils = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.costumerMangmentTab,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.costumerMangmentTab;
            this.kryptonRibbon1.Size = new System.Drawing.Size(859, 171);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // costumerMangmentTab
            // 
            this.costumerMangmentTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.costumerMangmentTab.Text = "ניהול לקוחות";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "לקוחות";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnAdd,
            this.btnChange,
            this.btnDeateils});
            // 
            // btnAdd
            // 
            this.btnAdd.ImageLarge = global::Landau.Win.Properties.Resources.צילום_מסך_2024_11_26_152303;
            this.btnAdd.TextLine1 = "הוסף לקוח";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.ImageLarge = global::Landau.Win.Properties.Resources.צילום_מסך_2024_03_03_191346;
            this.btnChange.TextLine1 = "שנה פרטי לקוח";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDeateils
            // 
            this.btnDeateils.ImageLarge = global::Landau.Win.Properties.Resources.צילום_מסך_2023_11_12_190958;
            this.btnDeateils.ImageSmall = null;
            this.btnDeateils.TextLine1 = "פרטי לקוח";
            this.btnDeateils.Click += new System.EventHandler(this.btnDeateils_Click);
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
        private Krypton.Ribbon.KryptonRibbonTab costumerMangmentTab;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnAdd;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnChange;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnDeateils;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
    }
}

