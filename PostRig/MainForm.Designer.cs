namespace PostRig
{
    partial class PostRigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostRigForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            this.MainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.RoadCarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.TouringCarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SingleSeaterBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.InitialConditionBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.HarmonicIPBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.CombinedIPBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.RunBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.NewMenuBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.OpenMenuBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SaveMenuBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.SaveAsMenuBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.ExitMenuBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SysCharateristicsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DesignRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.CarTemplateDesignPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SimulationSetupRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.InputSimSetupGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RunSimSetupGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ResultsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SysCharacteristicsResultsGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PropertiesPanel = new DevExpress.XtraEditors.PanelControl();
            this.PropertiesTreeList = new DevExpress.XtraTreeList.TreeList();
            this.VehicleParametersTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ValuesTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.UnitsTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SimSetupPanel = new DevExpress.XtraEditors.PanelControl();
            this.SimSetupTreeList = new DevExpress.XtraTreeList.TreeList();
            this.SimulationParametersTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SimValuesTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SimulationUnitTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.HarmonicInputChartControl = new DevExpress.XtraCharts.ChartControl();
            this.GraphPanel = new DevExpress.XtraEditors.PanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesPanel)).BeginInit();
            this.PropertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSetupPanel)).BeginInit();
            this.SimSetupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimSetupTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicInputChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPanel)).BeginInit();
            this.GraphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRibbonControl
            // 
            this.MainRibbonControl.AllowGlyphSkinning = true;
            this.MainRibbonControl.ExpandCollapseItem.Id = 0;
            this.MainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MainRibbonControl.ExpandCollapseItem,
            this.RoadCarBarButtonItem,
            this.TouringCarBarButtonItem,
            this.SingleSeaterBarButtonItem,
            this.InitialConditionBarCheckItem,
            this.HarmonicIPBarCheckItem,
            this.CombinedIPBarCheckItem,
            this.RunBarButton,
            this.NewMenuBarButtonItem,
            this.OpenMenuBarButtonItem,
            this.SaveMenuBarButton,
            this.SaveAsMenuBarButton,
            this.ExitMenuBarButtonItem,
            this.SysCharateristicsBarButtonItem});
            this.MainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.MainRibbonControl.MaxItemId = 20;
            this.MainRibbonControl.Name = "MainRibbonControl";
            this.MainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.DesignRibbonPage,
            this.SimulationSetupRibbonPage,
            this.ResultsRibbonPage});
            this.MainRibbonControl.QuickToolbarItemLinks.Add(this.NewMenuBarButtonItem);
            this.MainRibbonControl.QuickToolbarItemLinks.Add(this.OpenMenuBarButtonItem);
            this.MainRibbonControl.QuickToolbarItemLinks.Add(this.SaveMenuBarButton);
            this.MainRibbonControl.QuickToolbarItemLinks.Add(this.SaveAsMenuBarButton);
            this.MainRibbonControl.QuickToolbarItemLinks.Add(this.ExitMenuBarButtonItem);
            this.MainRibbonControl.Size = new System.Drawing.Size(1184, 143);
            // 
            // RoadCarBarButtonItem
            // 
            this.RoadCarBarButtonItem.Caption = "Road Car";
            this.RoadCarBarButtonItem.Id = 1;
            this.RoadCarBarButtonItem.Name = "RoadCarBarButtonItem";
            this.RoadCarBarButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.RoadCarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RoadCarBarButtonItem_ItemClick);
            // 
            // TouringCarBarButtonItem
            // 
            this.TouringCarBarButtonItem.Caption = "Touring Car";
            this.TouringCarBarButtonItem.Id = 2;
            this.TouringCarBarButtonItem.Name = "TouringCarBarButtonItem";
            this.TouringCarBarButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.TouringCarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TouringCarBarButtonItem_ItemClick);
            // 
            // SingleSeaterBarButtonItem
            // 
            this.SingleSeaterBarButtonItem.Caption = "Single Seater";
            this.SingleSeaterBarButtonItem.Id = 3;
            this.SingleSeaterBarButtonItem.Name = "SingleSeaterBarButtonItem";
            this.SingleSeaterBarButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.SingleSeaterBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SingleSeaterBarButtonItem_ItemClick);
            // 
            // InitialConditionBarCheckItem
            // 
            this.InitialConditionBarCheckItem.Caption = "Initial Conditions";
            this.InitialConditionBarCheckItem.Id = 4;
            this.InitialConditionBarCheckItem.Name = "InitialConditionBarCheckItem";
            this.InitialConditionBarCheckItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.InitialConditionBarCheckItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InitialConditionBarCheckItem_ItemClick);
            // 
            // HarmonicIPBarCheckItem
            // 
            this.HarmonicIPBarCheckItem.Caption = "Harmonic Input";
            this.HarmonicIPBarCheckItem.Id = 5;
            this.HarmonicIPBarCheckItem.Name = "HarmonicIPBarCheckItem";
            this.HarmonicIPBarCheckItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.HarmonicIPBarCheckItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HarmonicIPBarCheckItem_ItemClick);
            // 
            // CombinedIPBarCheckItem
            // 
            this.CombinedIPBarCheckItem.Caption = "Combined Input";
            this.CombinedIPBarCheckItem.Id = 6;
            this.CombinedIPBarCheckItem.Name = "CombinedIPBarCheckItem";
            this.CombinedIPBarCheckItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.CombinedIPBarCheckItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CombinedIPBarCheckItem_ItemClick);
            // 
            // RunBarButton
            // 
            this.RunBarButton.Caption = "Run";
            this.RunBarButton.Id = 7;
            this.RunBarButton.Name = "RunBarButton";
            this.RunBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.RunBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RunBarButton_ItemClick);
            // 
            // NewMenuBarButtonItem
            // 
            this.NewMenuBarButtonItem.Caption = "New";
            this.NewMenuBarButtonItem.Id = 14;
            this.NewMenuBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NewMenuBarButtonItem.ImageOptions.Image")));
            this.NewMenuBarButtonItem.Name = "NewMenuBarButtonItem";
            this.NewMenuBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.NewMenuBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewMenuBarButtonItem_ItemClick);
            // 
            // OpenMenuBarButtonItem
            // 
            this.OpenMenuBarButtonItem.Caption = "Open";
            this.OpenMenuBarButtonItem.Id = 15;
            this.OpenMenuBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenuBarButtonItem.ImageOptions.Image")));
            this.OpenMenuBarButtonItem.Name = "OpenMenuBarButtonItem";
            this.OpenMenuBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenMenuBarButtonItem_ItemClick);
            // 
            // SaveMenuBarButton
            // 
            this.SaveMenuBarButton.Caption = "Save";
            this.SaveMenuBarButton.Id = 16;
            this.SaveMenuBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenuBarButton.ImageOptions.Image")));
            this.SaveMenuBarButton.Name = "SaveMenuBarButton";
            this.SaveMenuBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveMenuBarButton_ItemClick);
            // 
            // SaveAsMenuBarButton
            // 
            this.SaveAsMenuBarButton.Caption = "SaveAs";
            this.SaveAsMenuBarButton.Id = 17;
            this.SaveAsMenuBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsMenuBarButton.ImageOptions.Image")));
            this.SaveAsMenuBarButton.Name = "SaveAsMenuBarButton";
            this.SaveAsMenuBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveAsMenuBarButton_ItemClick);
            // 
            // ExitMenuBarButtonItem
            // 
            this.ExitMenuBarButtonItem.Caption = "Exit";
            this.ExitMenuBarButtonItem.Id = 18;
            this.ExitMenuBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ExitMenuBarButtonItem.ImageOptions.Image")));
            this.ExitMenuBarButtonItem.Name = "ExitMenuBarButtonItem";
            this.ExitMenuBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitMenuBarButtonItem_ItemClick);
            // 
            // SysCharateristicsBarButtonItem
            // 
            this.SysCharateristicsBarButtonItem.Caption = "System Characteristics";
            this.SysCharateristicsBarButtonItem.Id = 19;
            this.SysCharateristicsBarButtonItem.Name = "SysCharateristicsBarButtonItem";
            this.SysCharateristicsBarButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // DesignRibbonPage
            // 
            this.DesignRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.CarTemplateDesignPageGroup});
            this.DesignRibbonPage.Name = "DesignRibbonPage";
            this.DesignRibbonPage.Text = "Design";
            this.DesignRibbonPage.Visible = false;
            // 
            // CarTemplateDesignPageGroup
            // 
            this.CarTemplateDesignPageGroup.ItemLinks.Add(this.RoadCarBarButtonItem);
            this.CarTemplateDesignPageGroup.ItemLinks.Add(this.TouringCarBarButtonItem);
            this.CarTemplateDesignPageGroup.ItemLinks.Add(this.SingleSeaterBarButtonItem);
            this.CarTemplateDesignPageGroup.Name = "CarTemplateDesignPageGroup";
            this.CarTemplateDesignPageGroup.Text = "Template";
            // 
            // SimulationSetupRibbonPage
            // 
            this.SimulationSetupRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.InputSimSetupGroup,
            this.RunSimSetupGroup});
            this.SimulationSetupRibbonPage.Name = "SimulationSetupRibbonPage";
            this.SimulationSetupRibbonPage.Text = "Simulation Setup";
            this.SimulationSetupRibbonPage.Visible = false;
            // 
            // InputSimSetupGroup
            // 
            this.InputSimSetupGroup.ItemLinks.Add(this.InitialConditionBarCheckItem);
            this.InputSimSetupGroup.ItemLinks.Add(this.HarmonicIPBarCheckItem);
            this.InputSimSetupGroup.ItemLinks.Add(this.CombinedIPBarCheckItem);
            this.InputSimSetupGroup.Name = "InputSimSetupGroup";
            this.InputSimSetupGroup.Text = "Input Setup";
            // 
            // RunSimSetupGroup
            // 
            this.RunSimSetupGroup.ItemLinks.Add(this.RunBarButton);
            this.RunSimSetupGroup.Name = "RunSimSetupGroup";
            this.RunSimSetupGroup.Text = "Run";
            // 
            // ResultsRibbonPage
            // 
            this.ResultsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SysCharacteristicsResultsGroup});
            this.ResultsRibbonPage.Name = "ResultsRibbonPage";
            this.ResultsRibbonPage.Text = "Results";
            this.ResultsRibbonPage.Visible = false;
            // 
            // SysCharacteristicsResultsGroup
            // 
            this.SysCharacteristicsResultsGroup.ItemLinks.Add(this.SysCharateristicsBarButtonItem);
            this.SysCharacteristicsResultsGroup.Name = "SysCharacteristicsResultsGroup";
            this.SysCharacteristicsResultsGroup.Text = "System";
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.Controls.Add(this.PropertiesTreeList);
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PropertiesPanel.Location = new System.Drawing.Point(0, 143);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(344, 665);
            this.PropertiesPanel.TabIndex = 1;
            this.PropertiesPanel.Visible = false;
            // 
            // PropertiesTreeList
            // 
            this.PropertiesTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.VehicleParametersTreeListColumn,
            this.ValuesTreeListColumn,
            this.UnitsTreeListColumn});
            this.PropertiesTreeList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PropertiesTreeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PropertiesTreeList.Location = new System.Drawing.Point(2, 2);
            this.PropertiesTreeList.Name = "PropertiesTreeList";
            this.PropertiesTreeList.BeginUnboundLoad();
            this.PropertiesTreeList.AppendNode(new object[] {
            "Vehicle Mass",
            null,
            "Kg"}, -1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Spring Stiffness",
            null,
            "N/m"}, -1);
            this.PropertiesTreeList.AppendNode(new object[] {
            "Damping Coefficient",
            null,
            "N/(m/s)"}, -1);
            this.PropertiesTreeList.EndUnboundLoad();
            this.PropertiesTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.PropertiesTreeList.OptionsView.AutoWidth = false;
            this.PropertiesTreeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.PropertiesTreeList.Size = new System.Drawing.Size(340, 293);
            this.PropertiesTreeList.TabIndex = 0;
            // 
            // VehicleParametersTreeListColumn
            // 
            this.VehicleParametersTreeListColumn.Caption = "Vehicle Parameters";
            this.VehicleParametersTreeListColumn.FieldName = "Vehicle Parameters";
            this.VehicleParametersTreeListColumn.Name = "VehicleParametersTreeListColumn";
            this.VehicleParametersTreeListColumn.OptionsColumn.AllowEdit = false;
            this.VehicleParametersTreeListColumn.OptionsColumn.AllowFocus = false;
            this.VehicleParametersTreeListColumn.OptionsColumn.AllowMove = false;
            this.VehicleParametersTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.VehicleParametersTreeListColumn.OptionsColumn.AllowSort = false;
            this.VehicleParametersTreeListColumn.OptionsColumn.ReadOnly = true;
            this.VehicleParametersTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.VehicleParametersTreeListColumn.OptionsFilter.AllowFilter = false;
            this.VehicleParametersTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.VehicleParametersTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.VehicleParametersTreeListColumn.Visible = true;
            this.VehicleParametersTreeListColumn.VisibleIndex = 0;
            this.VehicleParametersTreeListColumn.Width = 162;
            // 
            // ValuesTreeListColumn
            // 
            this.ValuesTreeListColumn.Caption = "Values";
            this.ValuesTreeListColumn.FieldName = "Values";
            this.ValuesTreeListColumn.Name = "ValuesTreeListColumn";
            this.ValuesTreeListColumn.OptionsColumn.AllowMove = false;
            this.ValuesTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.ValuesTreeListColumn.OptionsColumn.AllowSort = false;
            this.ValuesTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.ValuesTreeListColumn.OptionsFilter.AllowFilter = false;
            this.ValuesTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.ValuesTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.ValuesTreeListColumn.Visible = true;
            this.ValuesTreeListColumn.VisibleIndex = 1;
            // 
            // UnitsTreeListColumn
            // 
            this.UnitsTreeListColumn.Caption = "Units";
            this.UnitsTreeListColumn.FieldName = "Units";
            this.UnitsTreeListColumn.Name = "UnitsTreeListColumn";
            this.UnitsTreeListColumn.OptionsColumn.AllowEdit = false;
            this.UnitsTreeListColumn.OptionsColumn.AllowFocus = false;
            this.UnitsTreeListColumn.OptionsColumn.AllowMove = false;
            this.UnitsTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.UnitsTreeListColumn.OptionsColumn.AllowSort = false;
            this.UnitsTreeListColumn.OptionsColumn.FixedWidth = true;
            this.UnitsTreeListColumn.OptionsColumn.ReadOnly = true;
            this.UnitsTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.UnitsTreeListColumn.OptionsFilter.AllowFilter = false;
            this.UnitsTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.UnitsTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.UnitsTreeListColumn.Visible = true;
            this.UnitsTreeListColumn.VisibleIndex = 2;
            // 
            // SimSetupPanel
            // 
            this.SimSetupPanel.Controls.Add(this.SimSetupTreeList);
            this.SimSetupPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SimSetupPanel.Location = new System.Drawing.Point(344, 143);
            this.SimSetupPanel.Name = "SimSetupPanel";
            this.SimSetupPanel.Size = new System.Drawing.Size(343, 665);
            this.SimSetupPanel.TabIndex = 3;
            this.SimSetupPanel.Visible = false;
            // 
            // SimSetupTreeList
            // 
            this.SimSetupTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.SimulationParametersTreeListColumn,
            this.SimValuesTreeListColumn,
            this.SimulationUnitTreeListColumn});
            this.SimSetupTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.SimSetupTreeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SimSetupTreeList.Location = new System.Drawing.Point(2, 2);
            this.SimSetupTreeList.Name = "SimSetupTreeList";
            this.SimSetupTreeList.BeginUnboundLoad();
            this.SimSetupTreeList.AppendNode(new object[] {
            "Time Data",
            null,
            null}, -1);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Start Time",
            null,
            "s"}, 0);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Time Step",
            null,
            "s"}, 0);
            this.SimSetupTreeList.AppendNode(new object[] {
            "End Time",
            null,
            "s"}, 0);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Initial Conition Data",
            null,
            null}, -1);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Initial Displacement",
            null,
            "m"}, 4);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Initial Velocity",
            null,
            "m"}, 4);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Harmonic Input Data",
            null,
            null}, -1);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Oscillation Frequency",
            null,
            "Hz"}, 7);
            this.SimSetupTreeList.AppendNode(new object[] {
            "Force Magnitude",
            null,
            "N"}, 7);
            this.SimSetupTreeList.EndUnboundLoad();
            this.SimSetupTreeList.OptionsView.AutoWidth = false;
            this.SimSetupTreeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.SimSetupTreeList.Size = new System.Drawing.Size(339, 293);
            this.SimSetupTreeList.TabIndex = 0;
            this.SimSetupTreeList.ExpandAll();
            // 
            // SimulationParametersTreeListColumn
            // 
            this.SimulationParametersTreeListColumn.Caption = "Simulation Parameters";
            this.SimulationParametersTreeListColumn.FieldName = "Simulation Parameters";
            this.SimulationParametersTreeListColumn.Name = "SimulationParametersTreeListColumn";
            this.SimulationParametersTreeListColumn.OptionsColumn.AllowMove = false;
            this.SimulationParametersTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.SimulationParametersTreeListColumn.OptionsColumn.AllowSort = false;
            this.SimulationParametersTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.SimulationParametersTreeListColumn.OptionsFilter.AllowFilter = false;
            this.SimulationParametersTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.SimulationParametersTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.SimulationParametersTreeListColumn.Visible = true;
            this.SimulationParametersTreeListColumn.VisibleIndex = 0;
            this.SimulationParametersTreeListColumn.Width = 170;
            // 
            // SimValuesTreeListColumn
            // 
            this.SimValuesTreeListColumn.Caption = "Values";
            this.SimValuesTreeListColumn.FieldName = "Values";
            this.SimValuesTreeListColumn.Name = "SimValuesTreeListColumn";
            this.SimValuesTreeListColumn.OptionsColumn.AllowMove = false;
            this.SimValuesTreeListColumn.OptionsColumn.AllowSort = false;
            this.SimValuesTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.SimValuesTreeListColumn.OptionsFilter.AllowFilter = false;
            this.SimValuesTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.SimValuesTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.SimValuesTreeListColumn.Visible = true;
            this.SimValuesTreeListColumn.VisibleIndex = 1;
            // 
            // SimulationUnitTreeListColumn
            // 
            this.SimulationUnitTreeListColumn.Caption = "Units";
            this.SimulationUnitTreeListColumn.FieldName = "Units";
            this.SimulationUnitTreeListColumn.Name = "SimulationUnitTreeListColumn";
            this.SimulationUnitTreeListColumn.OptionsColumn.AllowMove = false;
            this.SimulationUnitTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.SimulationUnitTreeListColumn.OptionsColumn.AllowSort = false;
            this.SimulationUnitTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.SimulationUnitTreeListColumn.OptionsFilter.AllowFilter = false;
            this.SimulationUnitTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.SimulationUnitTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.SimulationUnitTreeListColumn.Visible = true;
            this.SimulationUnitTreeListColumn.VisibleIndex = 2;
            // 
            // HarmonicInputChartControl
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.HarmonicInputChartControl.Diagram = xyDiagram2;
            this.HarmonicInputChartControl.Legend.Name = "Default Legend";
            this.HarmonicInputChartControl.Location = new System.Drawing.Point(75, 132);
            this.HarmonicInputChartControl.Name = "HarmonicInputChartControl";
            series2.Name = "Harmonic Input";
            series2.View = splineSeriesView2;
            this.HarmonicInputChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.HarmonicInputChartControl.Size = new System.Drawing.Size(389, 232);
            this.HarmonicInputChartControl.TabIndex = 5;
            // 
            // GraphPanel
            // 
            this.GraphPanel.Controls.Add(this.HarmonicInputChartControl);
            this.GraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphPanel.Location = new System.Drawing.Point(687, 143);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(497, 665);
            this.GraphPanel.TabIndex = 5;
            this.GraphPanel.Visible = false;
            // 
            // PostRigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 808);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.SimSetupPanel);
            this.Controls.Add(this.PropertiesPanel);
            this.Controls.Add(this.MainRibbonControl);
            this.Name = "PostRigForm";
            this.Ribbon = this.MainRibbonControl;
            this.Text = "Post Rig";
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesPanel)).EndInit();
            this.PropertiesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimSetupPanel)).EndInit();
            this.SimSetupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimSetupTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicInputChartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphPanel)).EndInit();
            this.GraphPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage DesignRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup CarTemplateDesignPageGroup;
        private DevExpress.XtraBars.BarButtonItem RoadCarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem TouringCarBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem SingleSeaterBarButtonItem;
        private DevExpress.XtraBars.BarCheckItem InitialConditionBarCheckItem;
        private DevExpress.XtraBars.BarCheckItem HarmonicIPBarCheckItem;
        private DevExpress.XtraBars.BarCheckItem CombinedIPBarCheckItem;
        private DevExpress.XtraBars.BarButtonItem RunBarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage SimulationSetupRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup InputSimSetupGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RunSimSetupGroup;
        private DevExpress.XtraEditors.PanelControl PropertiesPanel;
        private DevExpress.XtraTreeList.TreeList PropertiesTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn VehicleParametersTreeListColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ValuesTreeListColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn UnitsTreeListColumn;
        private DevExpress.XtraBars.BarButtonItem NewMenuBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem OpenMenuBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem SaveMenuBarButton;
        private DevExpress.XtraBars.BarButtonItem SaveAsMenuBarButton;
        private DevExpress.XtraBars.BarButtonItem ExitMenuBarButtonItem;
        private DevExpress.XtraEditors.PanelControl SimSetupPanel;
        private DevExpress.XtraTreeList.TreeList SimSetupTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn SimulationParametersTreeListColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn SimValuesTreeListColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn SimulationUnitTreeListColumn;
        private DevExpress.XtraCharts.ChartControl HarmonicInputChartControl;
        private DevExpress.XtraEditors.PanelControl GraphPanel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ResultsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SysCharacteristicsResultsGroup;
        private DevExpress.XtraBars.BarButtonItem SysCharateristicsBarButtonItem;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

