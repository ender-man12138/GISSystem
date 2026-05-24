namespace MapControlApplication2
{
    partial class MainForm
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
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayMap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.数据编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateShp = new System.Windows.Forms.ToolStripMenuItem();
            this.插入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertNorthArrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertScalebar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertLegend = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsertTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchByAttr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelByPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelByRect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelByPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClearSel = new System.Windows.Forms.ToolStripMenuItem();
            this.空间分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuffer = new System.Windows.Forms.ToolStripMenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tocMnuAddData = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMnuOpenAttr = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMnuZoomtoLyr = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMnuDelLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.tocMnuSymbology = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbEditLayers = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl2 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPoint = new System.Windows.Forms.ToolStripButton();
            this.btnAddPolyline = new System.Windows.Forms.ToolStripButton();
            this.btnAddPolygon = new System.Windows.Forms.ToolStripButton();
            this.btnSelByPoint = new System.Windows.Forms.ToolStripButton();
            this.btnSelByRect = new System.Windows.Forms.ToolStripButton();
            this.bynSelByPolygon = new System.Windows.Forms.ToolStripButton();
            this.btnClearSel = new System.Windows.Forms.ToolStripButton();
            this.打开文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudLoadShapefile = new System.Windows.Forms.ToolStripMenuItem();
            this.mudLoadGDB = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平移ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.固定比例尺放大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.固定比例尺缩小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddPolyline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddPolygon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.地图ToolStripMenuItem,
            this.数据编辑ToolStripMenuItem,
            this.插入ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.空间分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文档ToolStripMenuItem,
            this.加载文档ToolStripMenuItem,
            this.mudLoadShapefile,
            this.mudLoadGDB,
            this.toolStripSeparator1,
            this.mnuOutput,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // mnuOutput
            // 
            this.mnuOutput.Name = "mnuOutput";
            this.mnuOutput.Size = new System.Drawing.Size(225, 34);
            this.mnuOutput.Text = "输出地图";
            this.mnuOutput.Click += new System.EventHandler(this.mnuOutput_Click);
            // 
            // 地图ToolStripMenuItem
            // 
            this.地图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayMap,
            this.mnuDisplayLayout,
            this.toolStripSeparator2,
            this.放大ToolStripMenuItem,
            this.缩小ToolStripMenuItem,
            this.平移ToolStripMenuItem,
            this.固定比例尺放大ToolStripMenuItem,
            this.固定比例尺缩小ToolStripMenuItem,
            this.全图ToolStripMenuItem});
            this.地图ToolStripMenuItem.Name = "地图ToolStripMenuItem";
            this.地图ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.地图ToolStripMenuItem.Text = "地图";
            // 
            // mnuDisplayMap
            // 
            this.mnuDisplayMap.Checked = true;
            this.mnuDisplayMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDisplayMap.Name = "mnuDisplayMap";
            this.mnuDisplayMap.Size = new System.Drawing.Size(236, 34);
            this.mnuDisplayMap.Text = "显示地图";
            this.mnuDisplayMap.Click += new System.EventHandler(this.mnuDisplayMap_Click);
            // 
            // mnuDisplayLayout
            // 
            this.mnuDisplayLayout.Name = "mnuDisplayLayout";
            this.mnuDisplayLayout.Size = new System.Drawing.Size(236, 34);
            this.mnuDisplayLayout.Text = "显示布局";
            this.mnuDisplayLayout.Click += new System.EventHandler(this.mnuDisplayLayout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // 数据编辑ToolStripMenuItem
            // 
            this.数据编辑ToolStripMenuItem.Checked = true;
            this.数据编辑ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.数据编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateShp,
            this.mnuAddPoint,
            this.mnuAddPolyline,
            this.mnuAddPolygon,
            this.mnu_add});
            this.数据编辑ToolStripMenuItem.Name = "数据编辑ToolStripMenuItem";
            this.数据编辑ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.数据编辑ToolStripMenuItem.Text = "数据编辑";
            // 
            // mnuCreateShp
            // 
            this.mnuCreateShp.Name = "mnuCreateShp";
            this.mnuCreateShp.Size = new System.Drawing.Size(270, 34);
            this.mnuCreateShp.Text = "创建点Shape";
            this.mnuCreateShp.Click += new System.EventHandler(this.mnuCreateShp_Click);
            // 
            // 插入ToolStripMenuItem
            // 
            this.插入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInsertNorthArrow,
            this.mnuInsertScalebar,
            this.mnuInsertLegend,
            this.mnuInsertTitle,
            this.时间ToolStripMenuItem});
            this.插入ToolStripMenuItem.Name = "插入ToolStripMenuItem";
            this.插入ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.插入ToolStripMenuItem.Text = "插入";
            // 
            // mnuInsertNorthArrow
            // 
            this.mnuInsertNorthArrow.Name = "mnuInsertNorthArrow";
            this.mnuInsertNorthArrow.Size = new System.Drawing.Size(164, 34);
            this.mnuInsertNorthArrow.Text = "指北针";
            this.mnuInsertNorthArrow.Click += new System.EventHandler(this.mnuInsertNorthArrow_Click);
            // 
            // mnuInsertScalebar
            // 
            this.mnuInsertScalebar.Name = "mnuInsertScalebar";
            this.mnuInsertScalebar.Size = new System.Drawing.Size(164, 34);
            this.mnuInsertScalebar.Text = "比例尺";
            this.mnuInsertScalebar.Click += new System.EventHandler(this.mnuInsertScalebar_Click);
            // 
            // mnuInsertLegend
            // 
            this.mnuInsertLegend.Name = "mnuInsertLegend";
            this.mnuInsertLegend.Size = new System.Drawing.Size(164, 34);
            this.mnuInsertLegend.Text = "图例";
            this.mnuInsertLegend.Click += new System.EventHandler(this.mnuInsertLegend_Click);
            // 
            // mnuInsertTitle
            // 
            this.mnuInsertTitle.Name = "mnuInsertTitle";
            this.mnuInsertTitle.Size = new System.Drawing.Size(164, 34);
            this.mnuInsertTitle.Text = "标题";
            this.mnuInsertTitle.Click += new System.EventHandler(this.mnuInsertTitle_Click);
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchByAttr,
            this.toolStripSeparator3,
            this.mnuSelByPoint,
            this.mnuSelByRect,
            this.mnuSelByPolygon,
            this.toolStripSeparator4,
            this.mnuClearSel});
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.数据查询ToolStripMenuItem.Text = "数据查询";
            // 
            // mnuSearchByAttr
            // 
            this.mnuSearchByAttr.Name = "mnuSearchByAttr";
            this.mnuSearchByAttr.Size = new System.Drawing.Size(200, 34);
            this.mnuSearchByAttr.Text = "属性查图形";
            this.mnuSearchByAttr.Click += new System.EventHandler(this.mnuSearchByAttr_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
            // 
            // mnuSelByPoint
            // 
            this.mnuSelByPoint.Name = "mnuSelByPoint";
            this.mnuSelByPoint.Size = new System.Drawing.Size(200, 34);
            this.mnuSelByPoint.Text = "点选查询";
            this.mnuSelByPoint.Click += new System.EventHandler(this.mnuSelByPoint_Click);
            // 
            // mnuSelByRect
            // 
            this.mnuSelByRect.Name = "mnuSelByRect";
            this.mnuSelByRect.Size = new System.Drawing.Size(200, 34);
            this.mnuSelByRect.Text = "矩形查询";
            this.mnuSelByRect.Click += new System.EventHandler(this.mnuSelByRect_Click);
            // 
            // mnuSelByPolygon
            // 
            this.mnuSelByPolygon.Name = "mnuSelByPolygon";
            this.mnuSelByPolygon.Size = new System.Drawing.Size(200, 34);
            this.mnuSelByPolygon.Text = "多边形查询";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // mnuClearSel
            // 
            this.mnuClearSel.Name = "mnuClearSel";
            this.mnuClearSel.Size = new System.Drawing.Size(200, 34);
            this.mnuClearSel.Text = "清除选择集";
            // 
            // 空间分析ToolStripMenuItem
            // 
            this.空间分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBuffer});
            this.空间分析ToolStripMenuItem.Name = "空间分析ToolStripMenuItem";
            this.空间分析ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.空间分析ToolStripMenuItem.Text = "空间分析";
            // 
            // mnuBuffer
            // 
            this.mnuBuffer.Name = "mnuBuffer";
            this.mnuBuffer.Size = new System.Drawing.Size(200, 34);
            this.mnuBuffer.Text = "缓冲区分析";
            this.mnuBuffer.Click += new System.EventHandler(this.mnuBuffer_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 32);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1422, 28);
            this.axToolbarControl1.TabIndex = 3;
            this.axToolbarControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IToolbarControlEvents_Ax_OnMouseDownEventHandler(this.axToolbarControl1_OnMouseDown);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(462, 291);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 60);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(15, 745);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(15, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1407, 31);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(83, 24);
            this.statusBarXY.Text = "Test 123";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(195, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(195, 24);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tocMnuAddData,
            this.tocMnuOpenAttr,
            this.tocMnuZoomtoLyr,
            this.tocMnuDelLayer,
            this.tocMnuSymbology});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 154);
            // 
            // tocMnuAddData
            // 
            this.tocMnuAddData.Name = "tocMnuAddData";
            this.tocMnuAddData.Size = new System.Drawing.Size(170, 30);
            this.tocMnuAddData.Text = "加载数据";
            this.tocMnuAddData.Click += new System.EventHandler(this.tocMnuAddData_Click);
            // 
            // tocMnuOpenAttr
            // 
            this.tocMnuOpenAttr.Name = "tocMnuOpenAttr";
            this.tocMnuOpenAttr.Size = new System.Drawing.Size(170, 30);
            this.tocMnuOpenAttr.Text = "打开属性表";
            this.tocMnuOpenAttr.Click += new System.EventHandler(this.tocMnuOpenAttr_Click);
            // 
            // tocMnuZoomtoLyr
            // 
            this.tocMnuZoomtoLyr.Name = "tocMnuZoomtoLyr";
            this.tocMnuZoomtoLyr.Size = new System.Drawing.Size(170, 30);
            this.tocMnuZoomtoLyr.Text = "缩放至图层";
            this.tocMnuZoomtoLyr.Click += new System.EventHandler(this.tocMnuZoomtoLyr_Click);
            // 
            // tocMnuDelLayer
            // 
            this.tocMnuDelLayer.Name = "tocMnuDelLayer";
            this.tocMnuDelLayer.Size = new System.Drawing.Size(170, 30);
            this.tocMnuDelLayer.Text = "删除图层";
            this.tocMnuDelLayer.Click += new System.EventHandler(this.tocMnuDelLayer_Click);
            // 
            // tocMnuSymbology
            // 
            this.tocMnuSymbology.Name = "tocMnuSymbology";
            this.tocMnuSymbology.Size = new System.Drawing.Size(170, 30);
            this.tocMnuSymbology.Text = "符号化";
            this.tocMnuSymbology.Click += new System.EventHandler(this.tocMnuSymbology_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbEditLayers,
            this.btnAddPoint,
            this.btnAddPolyline,
            this.btnAddPolygon,
            this.btnSelByPoint,
            this.btnSelByRect,
            this.bynSelByPolygon,
            this.btnClearSel});
            this.toolStrip1.Location = new System.Drawing.Point(15, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1407, 33);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 28);
            this.toolStripLabel1.Text = "选择图层";
            // 
            // cmbEditLayers
            // 
            this.cmbEditLayers.Name = "cmbEditLayers";
            this.cmbEditLayers.Size = new System.Drawing.Size(121, 33);
            this.cmbEditLayers.ToolTipText = "选择编辑图层";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(15, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1407, 681);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 14;
            // 
            // axTOCControl2
            // 
            this.axTOCControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl2.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl2.Margin = new System.Windows.Forms.Padding(4);
            this.axTOCControl2.Name = "axTOCControl2";
            this.axTOCControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl2.OcxState")));
            this.axTOCControl2.Size = new System.Drawing.Size(465, 681);
            this.axTOCControl2.TabIndex = 5;
            this.axTOCControl2.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl2_OnMouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 681);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axMapControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axMapControl2
            // 
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(3, 3);
            this.axMapControl2.Margin = new System.Windows.Forms.Padding(4);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(924, 643);
            this.axMapControl2.TabIndex = 4;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown_1);
            this.axMapControl2.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl2_OnMouseMove);
            this.axMapControl2.OnAfterScreenDraw += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnAfterScreenDrawEventHandler(this.axMapControl2_OnAfterScreenDraw);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axPageLayoutControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "布局";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(924, 643);
            this.axPageLayoutControl1.TabIndex = 0;
            this.axPageLayoutControl1.OnAfterScreenDraw += new ESRI.ArcGIS.Controls.IPageLayoutControlEvents_Ax_OnAfterScreenDrawEventHandler(this.axPageLayoutControl1_OnAfterScreenDraw);
            // 
            // 时间ToolStripMenuItem
            // 
            this.时间ToolStripMenuItem.Name = "时间ToolStripMenuItem";
            this.时间ToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.时间ToolStripMenuItem.Text = "时间";
            this.时间ToolStripMenuItem.Click += new System.EventHandler(this.时间ToolStripMenuItem_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPoint.Image")));
            this.btnAddPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(128, 28);
            this.btnAddPoint.Text = "添加点要素";
            this.btnAddPoint.ToolTipText = "添加点要素";
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnAddPolyline
            // 
            this.btnAddPolyline.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPolyline.Image")));
            this.btnAddPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPolyline.Name = "btnAddPolyline";
            this.btnAddPolyline.Size = new System.Drawing.Size(128, 28);
            this.btnAddPolyline.Text = "添加线要素";
            this.btnAddPolyline.ToolTipText = "添加线要素";
            this.btnAddPolyline.Click += new System.EventHandler(this.btnAddPolyline_Click);
            // 
            // btnAddPolygon
            // 
            this.btnAddPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPolygon.Image")));
            this.btnAddPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPolygon.Name = "btnAddPolygon";
            this.btnAddPolygon.Size = new System.Drawing.Size(128, 28);
            this.btnAddPolygon.Text = "添加面要素";
            this.btnAddPolygon.ToolTipText = "添加面要素";
            this.btnAddPolygon.Click += new System.EventHandler(this.btnAddPolygon_Click);
            // 
            // btnSelByPoint
            // 
            this.btnSelByPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnSelByPoint.Image")));
            this.btnSelByPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelByPoint.Name = "btnSelByPoint";
            this.btnSelByPoint.Size = new System.Drawing.Size(110, 28);
            this.btnSelByPoint.Text = "点选查询";
            this.btnSelByPoint.Click += new System.EventHandler(this.btnSelByPoint_Click);
            // 
            // btnSelByRect
            // 
            this.btnSelByRect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelByRect.Image")));
            this.btnSelByRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelByRect.Name = "btnSelByRect";
            this.btnSelByRect.Size = new System.Drawing.Size(110, 28);
            this.btnSelByRect.Text = "矩形查询";
            this.btnSelByRect.Click += new System.EventHandler(this.btnSelByRect_Click);
            // 
            // bynSelByPolygon
            // 
            this.bynSelByPolygon.Image = ((System.Drawing.Image)(resources.GetObject("bynSelByPolygon.Image")));
            this.bynSelByPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bynSelByPolygon.Name = "bynSelByPolygon";
            this.bynSelByPolygon.Size = new System.Drawing.Size(128, 28);
            this.bynSelByPolygon.Text = "多边形查询";
            this.bynSelByPolygon.Click += new System.EventHandler(this.bynSelByPolygon_Click);
            // 
            // btnClearSel
            // 
            this.btnClearSel.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSel.Image")));
            this.btnClearSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearSel.Name = "btnClearSel";
            this.btnClearSel.Size = new System.Drawing.Size(128, 28);
            this.btnClearSel.Text = "清楚选择集";
            this.btnClearSel.Click += new System.EventHandler(this.btnClearSel_Click);
            // 
            // 打开文档ToolStripMenuItem
            // 
            this.打开文档ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.folder;
            this.打开文档ToolStripMenuItem.Name = "打开文档ToolStripMenuItem";
            this.打开文档ToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.打开文档ToolStripMenuItem.Text = "打开文档";
            this.打开文档ToolStripMenuItem.Click += new System.EventHandler(this.打开文档ToolStripMenuItem_Click);
            // 
            // 加载文档ToolStripMenuItem
            // 
            this.加载文档ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.AddData;
            this.加载文档ToolStripMenuItem.Name = "加载文档ToolStripMenuItem";
            this.加载文档ToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.加载文档ToolStripMenuItem.Text = "加载文档";
            this.加载文档ToolStripMenuItem.Click += new System.EventHandler(this.加载文档ToolStripMenuItem_Click);
            // 
            // mudLoadShapefile
            // 
            this.mudLoadShapefile.Image = ((System.Drawing.Image)(resources.GetObject("mudLoadShapefile.Image")));
            this.mudLoadShapefile.Name = "mudLoadShapefile";
            this.mudLoadShapefile.Size = new System.Drawing.Size(225, 34);
            this.mudLoadShapefile.Text = "加载Shapefile";
            this.mudLoadShapefile.Click += new System.EventHandler(this.mudLoadShapefile_Click);
            // 
            // mudLoadGDB
            // 
            this.mudLoadGDB.Image = ((System.Drawing.Image)(resources.GetObject("mudLoadGDB.Image")));
            this.mudLoadGDB.Name = "mudLoadGDB";
            this.mudLoadGDB.Size = new System.Drawing.Size(225, 34);
            this.mudLoadGDB.Text = "加载文件GDB";
            this.mudLoadGDB.Click += new System.EventHandler(this.mudLoadGDB_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 放大ToolStripMenuItem
            // 
            this.放大ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.zoom_in;
            this.放大ToolStripMenuItem.Name = "放大ToolStripMenuItem";
            this.放大ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.放大ToolStripMenuItem.Text = "放大";
            this.放大ToolStripMenuItem.Click += new System.EventHandler(this.放大ToolStripMenuItem_Click);
            // 
            // 缩小ToolStripMenuItem
            // 
            this.缩小ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.zoom_out;
            this.缩小ToolStripMenuItem.Name = "缩小ToolStripMenuItem";
            this.缩小ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.缩小ToolStripMenuItem.Text = "缩小";
            this.缩小ToolStripMenuItem.Click += new System.EventHandler(this.缩小ToolStripMenuItem_Click);
            // 
            // 平移ToolStripMenuItem
            // 
            this.平移ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.Pan;
            this.平移ToolStripMenuItem.Name = "平移ToolStripMenuItem";
            this.平移ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.平移ToolStripMenuItem.Text = "平移";
            this.平移ToolStripMenuItem.Click += new System.EventHandler(this.平移ToolStripMenuItem_Click);
            // 
            // 固定比例尺放大ToolStripMenuItem
            // 
            this.固定比例尺放大ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.FixedZoomOut;
            this.固定比例尺放大ToolStripMenuItem.Name = "固定比例尺放大ToolStripMenuItem";
            this.固定比例尺放大ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.固定比例尺放大ToolStripMenuItem.Text = "固定比例尺放大";
            this.固定比例尺放大ToolStripMenuItem.Click += new System.EventHandler(this.固定比例尺放大ToolStripMenuItem_Click);
            // 
            // 固定比例尺缩小ToolStripMenuItem
            // 
            this.固定比例尺缩小ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.FixedZoomIn;
            this.固定比例尺缩小ToolStripMenuItem.Name = "固定比例尺缩小ToolStripMenuItem";
            this.固定比例尺缩小ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.固定比例尺缩小ToolStripMenuItem.Text = "固定比例尺缩小";
            this.固定比例尺缩小ToolStripMenuItem.Click += new System.EventHandler(this.固定比例尺缩小ToolStripMenuItem_Click);
            // 
            // 全图ToolStripMenuItem
            // 
            this.全图ToolStripMenuItem.Image = global::MapControlApplication2.Properties.Resources.ZoomEntire;
            this.全图ToolStripMenuItem.Name = "全图ToolStripMenuItem";
            this.全图ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.全图ToolStripMenuItem.Text = "全图";
            this.全图ToolStripMenuItem.Click += new System.EventHandler(this.全图ToolStripMenuItem_Click);
            // 
            // mnuAddPoint
            // 
            this.mnuAddPoint.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddPoint.Image")));
            this.mnuAddPoint.Name = "mnuAddPoint";
            this.mnuAddPoint.Size = new System.Drawing.Size(270, 34);
            this.mnuAddPoint.Text = "添加点";
            this.mnuAddPoint.Click += new System.EventHandler(this.mnuAddPoint_Click);
            // 
            // mnuAddPolyline
            // 
            this.mnuAddPolyline.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddPolyline.Image")));
            this.mnuAddPolyline.Name = "mnuAddPolyline";
            this.mnuAddPolyline.Size = new System.Drawing.Size(270, 34);
            this.mnuAddPolyline.Text = "添加线";
            this.mnuAddPolyline.Click += new System.EventHandler(this.mnuAddPolyline_Click);
            // 
            // mnuAddPolygon
            // 
            this.mnuAddPolygon.Image = ((System.Drawing.Image)(resources.GetObject("mnuAddPolygon.Image")));
            this.mnuAddPolygon.Name = "mnuAddPolygon";
            this.mnuAddPolygon.Size = new System.Drawing.Size(270, 34);
            this.mnuAddPolygon.Text = "添加面";
            this.mnuAddPolygon.Click += new System.EventHandler(this.mnuAddPolygon_Click);
            // 
            // mnu_add
            // 
            this.mnu_add.Name = "mnu_add";
            this.mnu_add.Size = new System.Drawing.Size(270, 34);
            this.mnu_add.Text = "添加具体点";
            this.mnu_add.Click += new System.EventHandler(this.mnu_add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 805);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ArcEngine Controls Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExistApp;
        private System.Windows.Forms.ToolStripMenuItem menuSeparator;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平移ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 固定比例尺放大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 固定比例尺缩小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudLoadShapefile;
        private System.Windows.Forms.ToolStripMenuItem mudLoadGDB;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tocMnuAddData;
        private System.Windows.Forms.ToolStripMenuItem tocMnuOpenAttr;
        private System.Windows.Forms.ToolStripMenuItem tocMnuZoomtoLyr;
        private System.Windows.Forms.ToolStripMenuItem tocMnuDelLayer;
        private System.Windows.Forms.ToolStripMenuItem 数据编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateShp;
        private System.Windows.Forms.ToolStripMenuItem mnuAddPoint;
        private System.Windows.Forms.ToolStripMenuItem mnuAddPolyline;
        private System.Windows.Forms.ToolStripMenuItem mnuAddPolygon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl2;
        private System.Windows.Forms.ToolStripComboBox cmbEditLayers;
        private System.Windows.Forms.ToolStripButton btnAddPoint;
        private System.Windows.Forms.ToolStripButton btnAddPolyline;
        private System.Windows.Forms.ToolStripButton btnAddPolygon;
        private System.Windows.Forms.ToolStripMenuItem tocMnuSymbology;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayMap;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayLayout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private System.Windows.Forms.ToolStripMenuItem mnuOutput;
        private System.Windows.Forms.ToolStripMenuItem 插入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertNorthArrow;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertScalebar;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertLegend;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertTitle;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchByAttr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSelByPoint;
        private System.Windows.Forms.ToolStripMenuItem mnuSelByRect;
        private System.Windows.Forms.ToolStripMenuItem mnuSelByPolygon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuClearSel;
        private System.Windows.Forms.ToolStripButton btnSelByPoint;
        private System.Windows.Forms.ToolStripButton btnSelByRect;
        private System.Windows.Forms.ToolStripButton bynSelByPolygon;
        private System.Windows.Forms.ToolStripButton btnClearSel;
        private System.Windows.Forms.ToolStripMenuItem 空间分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBuffer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_add;
    }
}

