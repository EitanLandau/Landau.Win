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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.costumersMangment = new Krypton.Ribbon.KryptonRibbonTab();
            this.costumerFeatures = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.addCostumerBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updateBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.costumerLstBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.orders = new Krypton.Ribbon.KryptonRibbonTab();
            this.ordersGroup = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.ordersHistoryBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.newOrdedbtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updateOrderBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.costumersMangment,
            this.orders,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.costumersMangment;
            this.kryptonRibbon1.Size = new System.Drawing.Size(946, 171);
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
            this.addCostumerBtn,
            this.updateBtn,
            this.costumerLstBtn});
            // 
            // addCostumerBtn
            // 
            this.addCostumerBtn.ImageLarge = global::Landau.Win.Properties.Resources.צילום_מסך_2024_11_26_152303;
            this.addCostumerBtn.TextLine1 = "הוסף לקוח";
            this.addCostumerBtn.Click += new System.EventHandler(this.addCostumerBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageLarge")));
            this.updateBtn.TextLine1 = "עדכן לקוח";
            // 
            // costumerLstBtn
            // 
            this.costumerLstBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("costumerLstBtn.ImageLarge")));
            this.costumerLstBtn.TextLine1 = "רשימת לקוחות";
            // 
            // orders
            // 
            this.orders.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.ordersGroup});
            this.orders.Text = "הזמנות";
            // 
            // ordersGroup
            // 
            this.ordersGroup.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2});
            this.ordersGroup.TextLine1 = "נתק אותי";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.ordersHistoryBtn,
            this.newOrdedbtn,
            this.updateOrderBtn});
            // 
            // ordersHistoryBtn
            // 
            this.ordersHistoryBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("ordersHistoryBtn.ImageLarge")));
            this.ordersHistoryBtn.TextLine1 = "היסטורית הזמנות";
            this.ordersHistoryBtn.Click += new System.EventHandler(this.ordersHistoryBtn_Click);
            // 
            // newOrdedbtn
            // 
            this.newOrdedbtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("newOrdedbtn.ImageLarge")));
            this.newOrdedbtn.TextLine1 = "הוסף הזמנה";
            this.newOrdedbtn.Click += new System.EventHandler(this.newOrdedbtn_Click);
            // 
            // updateOrderBtn
            // 
            this.updateOrderBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("updateOrderBtn.ImageLarge")));
            this.updateOrderBtn.TextLine1 = "עדכן הזמנה";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 171);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(946, 284);
            this.mainPanel.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 455);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "HomePage";
            this.Text = "homePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Krypton.Ribbon.KryptonRibbonGroupButton addCostumerBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton updateBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton costumerLstBtn;
        private Krypton.Ribbon.KryptonRibbonTab orders;
        private Krypton.Ribbon.KryptonRibbonGroup ordersGroup;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private Krypton.Ribbon.KryptonRibbonGroupButton ordersHistoryBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton newOrdedbtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton updateOrderBtn;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

