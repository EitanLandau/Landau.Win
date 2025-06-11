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
            this.newOrdedbtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updateOrderBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.ordersHistoryBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.serviceTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup2 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple4 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.addLectureBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updLectureBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.lectureListBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple3 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.openProjectBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.updProjectBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.mangeProjectBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupTriple6 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroup4 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple7 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.mangeServicesBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroup3 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple5 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.addTaskBtn = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.kryptonRibbonGroupThemeComboBox1 = new Krypton.Ribbon.KryptonRibbonGroupThemeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonShortcuts.ToggleKeyboardAccess1 = System.Windows.Forms.Keys.None;
            this.kryptonRibbon1.RibbonShortcuts.ToggleKeyboardAccess2 = System.Windows.Forms.Keys.None;
            this.kryptonRibbon1.RibbonShortcuts.ToggleMinimizeMode = System.Windows.Forms.Keys.None;
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.costumersMangment,
            this.orders,
            this.serviceTab,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.orders;
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
            this.costumerFeatures.DialogBoxLauncherClick += new System.EventHandler(this.costumerFeatures_DialogBoxLauncherClick);
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
            this.addCostumerBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("addCostumerBtn.ImageLarge")));
            this.addCostumerBtn.TextLine1 = "הוסף לקוח";
            this.addCostumerBtn.Click += new System.EventHandler(this.addCostumerBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("updateBtn.ImageLarge")));
            this.updateBtn.TextLine1 = "עדכן לקוח";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // costumerLstBtn
            // 
            this.costumerLstBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("costumerLstBtn.ImageLarge")));
            this.costumerLstBtn.TextLine1 = "רשימת לקוחות";
            this.costumerLstBtn.Click += new System.EventHandler(this.costumerLstBtn_Click);
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
            this.newOrdedbtn,
            this.updateOrderBtn,
            this.ordersHistoryBtn});
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
            this.updateOrderBtn.Click += new System.EventHandler(this.updateOrderBtn_Click);
            this.updateOrderBtn.DropDown += new System.EventHandler<Krypton.Toolkit.ContextMenuArgs>(this.updateOrderBtn_DropDown);
            // 
            // ordersHistoryBtn
            // 
            this.ordersHistoryBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("ordersHistoryBtn.ImageLarge")));
            this.ordersHistoryBtn.TextLine1 = "היסטורית הזמנות";
            this.ordersHistoryBtn.Click += new System.EventHandler(this.ordersHistoryBtn_Click);
            // 
            // serviceTab
            // 
            this.serviceTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup2});
            this.serviceTab.Text = "סדנאות והרצאות ";
            // 
            // kryptonRibbonGroup2
            // 
            this.kryptonRibbonGroup2.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple4});
            // 
            // kryptonRibbonGroupTriple4
            // 
            this.kryptonRibbonGroupTriple4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.addLectureBtn,
            this.updLectureBtn,
            this.lectureListBtn});
            // 
            // addLectureBtn
            // 
            this.addLectureBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("addLectureBtn.ImageLarge")));
            this.addLectureBtn.TextLine1 = "הוסף מוצר";
            this.addLectureBtn.Click += new System.EventHandler(this.addLectureBtn_Click);
            // 
            // updLectureBtn
            // 
            this.updLectureBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("updLectureBtn.ImageLarge")));
            this.updLectureBtn.TextLine1 = "עדכן מוצר";
            this.updLectureBtn.Click += new System.EventHandler(this.updLectureBtn_Click);
            // 
            // lectureListBtn
            // 
            this.lectureListBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("lectureListBtn.ImageLarge")));
            this.lectureListBtn.TextLine1 = "הרצאות וסדנאות";
            this.lectureListBtn.Click += new System.EventHandler(this.lectureListBtn_Click);
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1,
            this.kryptonRibbonGroup4,
            this.kryptonRibbonGroup3});
            this.kryptonRibbonTab1.Text = "ניהול פרוייקטים";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple3,
            this.kryptonRibbonGroupTriple6});
            this.kryptonRibbonGroup1.TextLine1 = "פרויקטים";
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.openProjectBtn,
            this.updProjectBtn,
            this.mangeProjectBtn});
            // 
            // openProjectBtn
            // 
            this.openProjectBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("openProjectBtn.ImageLarge")));
            this.openProjectBtn.TextLine1 = "פתיחת פרויקט";
            // 
            // updProjectBtn
            // 
            this.updProjectBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("updProjectBtn.ImageLarge")));
            this.updProjectBtn.TextLine1 = "עדכון פרוייקט";
            // 
            // mangeProjectBtn
            // 
            this.mangeProjectBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("mangeProjectBtn.ImageLarge")));
            this.mangeProjectBtn.TextLine1 = "עקוב אחרי הפרויקט";
            // 
            // kryptonRibbonGroup4
            // 
            this.kryptonRibbonGroup4.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple7});
            this.kryptonRibbonGroup4.TextLine1 = "תהליכים";
            // 
            // kryptonRibbonGroupTriple7
            // 
            this.kryptonRibbonGroupTriple7.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.mangeServicesBtn});
            // 
            // mangeServicesBtn
            // 
            this.mangeServicesBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("mangeServicesBtn.ImageLarge")));
            this.mangeServicesBtn.TextLine1 = "נהל תהליכים";
            this.mangeServicesBtn.Click += new System.EventHandler(this.mangeServicesBtn_Click);
            // 
            // kryptonRibbonGroup3
            // 
            this.kryptonRibbonGroup3.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple5});
            this.kryptonRibbonGroup3.TextLine1 = "משימות";
            // 
            // kryptonRibbonGroupTriple5
            // 
            this.kryptonRibbonGroupTriple5.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.addTaskBtn});
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.ImageLarge = ((System.Drawing.Image)(resources.GetObject("addTaskBtn.ImageLarge")));
            this.addTaskBtn.TextLine1 = "הוסף משימה";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 171);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(946, 284);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // kryptonRibbonGroupThemeComboBox1
            // 
            this.kryptonRibbonGroupThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            this.kryptonRibbonGroupThemeComboBox1.DropDownWidth = 121;
            this.kryptonRibbonGroupThemeComboBox1.FormattingEnabled = false;
            this.kryptonRibbonGroupThemeComboBox1.ItemHeight = 20;
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
        private Krypton.Ribbon.KryptonRibbonTab serviceTab;
        private System.Windows.Forms.Panel mainPanel;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private Krypton.Ribbon.KryptonRibbonGroupButton openProjectBtn;
        private Krypton.Ribbon.KryptonRibbonGroupThemeComboBox kryptonRibbonGroupThemeComboBox1;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup2;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple4;
        private Krypton.Ribbon.KryptonRibbonGroupButton lectureListBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton addLectureBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton updLectureBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton updProjectBtn;
        private Krypton.Ribbon.KryptonRibbonGroupButton mangeProjectBtn;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup3;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple5;
        private Krypton.Ribbon.KryptonRibbonGroupButton addTaskBtn;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple6;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup4;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple7;
        private Krypton.Ribbon.KryptonRibbonGroupButton mangeServicesBtn;
    }
}

