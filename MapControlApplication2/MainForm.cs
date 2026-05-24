using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Output;

namespace MapControlApplication2
{
    public sealed partial class MainForm : Form
    {
        #region class private members
        public  IMapControl3 m_mapControl = null;
        private string m_mapDocumentName = string.Empty;
        private ILayer m_tocLayer = null;
        private int flagSelect = 0;//图形查询控制标识符
        private int flagEdit = 0;//要素编辑控制标识符
       
        #endregion

        #region class constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get the MapControl
            m_mapControl = (IMapControl3)axMapControl2.Object;

            //disable the Save menu (since there is no document yet)
            //menuSaveDoc.Enabled = false;
        }

        #region Main Menu event handlers
        private void menuNewDoc_Click(object sender, EventArgs e)
        {
            //execute New Document command
            ICommand command = new CreateNewDocument();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuOpenDoc_Click(object sender, EventArgs e)
        {
            //execute Open Document command
            ICommand command = new ControlsOpenDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            //execute SaveAs Document command
            ICommand command = new ControlsSaveAsDocCommandClass();
            command.OnCreate(m_mapControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }
        #endregion
        public partial class Form1 : Form
        {
            private IMapControl4 m_mapControl = null;
            private ILayer m_tocLayer = null;
        }


        //listen to MapReplaced evant in order to update the statusbar and the Save menu
        private void axMapControl1_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            //get the current document name from the MapControl
            m_mapDocumentName = m_mapControl.DocumentFilename;

            //if there is no MapDocument, diable the Save menu and clear the statusbar
            if (m_mapDocumentName == string.Empty)
            {
                menuSaveDoc.Enabled = false;
                statusBarXY.Text = string.Empty;
            }
            else
            {
                //enable the Save manu and write the doc name to the statusbar
                menuSaveDoc.Enabled = true;
                statusBarXY.Text = System.IO.Path.GetFileName(m_mapDocumentName);
            }
        }

        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            statusBarXY.Text = string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl2.MapUnits.ToString().Substring(4));
        }

        private void 加载文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //定义并实例化一个ICommand接口对象,用ControlsAddDataCommandClass构造函数实例化
            ICommand command = new ControlsAddDataCommandClass();
            //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
            command.OnCreate(m_mapControl.Object);
            //调用ICommand的OnClick方法
            command.OnClick();
            this.GetAllFeatureLayers();
        }


        private void 打开文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //定义并实例化一个ICommand接口对象        
                ICommand command = new ControlsOpenDocCommandClass();
                //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
                command.OnCreate(m_mapControl.Object);
                //调用ICommand的OnClick方法
                command.OnClick();
            }
            this.GetAllFeatureLayers();

        }

        private void 固定比例尺放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //定义并实例化一个ICommand接口对象,用ControlsMapZoomInFixedCommandClass构造函数实例化
            ICommand command = new ControlsMapZoomInFixedCommandClass();
            //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
            command.OnCreate(m_mapControl.Object);
            //调用ICommand的OnClick方法
            command.OnClick();
        }

        private void 固定比例尺缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //定义并实例化一个ICommand接口对象,用ControlsMapZoomOutFixedCommandClass构造函数实例化
            ICommand command = new ControlsMapZoomOutFixedCommandClass();
            //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
            command.OnCreate(m_mapControl.Object);
            //调用ICommand的OnClick方法
            command.OnClick();
        }

        private void 全图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //定义并实例化一个ICommand接口对象,用ControlsMapFullExtentCommand构造函数实例化
            ICommand command = new ControlsMapFullExtentCommand();
            //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
            command.OnCreate(m_mapControl.Object);
            //调用ICommand的OnClick方法
            command.OnClick();
        }

        private void 放大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //定义一个ICommand接口对象并通过ControlsMapZoomInToolClass的构造函数实例化
                ICommand command = new ControlsMapZoomInToolClass();
                //调用ICommand接口的方法OnCreate
                command.OnCreate(m_mapControl.Object);
                this.ResetToolControlStatus();
                //设置IMapControl3的CurrentTool属性（ITool）为ITool类型的对象，需要将Icommand接口对象用as运算符转化为ITool类型
                m_mapControl.CurrentTool = command as ITool;
                放大ToolStripMenuItem.Checked = true;
            }
        }

        private void 缩小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand command = new ControlsMapZoomOutToolClass();
            command.OnCreate(m_mapControl.Object);
            this.ResetToolControlStatus();
            m_mapControl.CurrentTool = command as ITool;
            缩小ToolStripMenuItem.Checked = true;
        }

        private void 平移ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICommand command = new ControlsMapPanToolClass();
            command.OnCreate(m_mapControl.Object);
            this.ResetToolControlStatus();
            m_mapControl.CurrentTool = command as ITool;
            平移ToolStripMenuItem.Checked = false;
        }

        private void mudLoadShapefile_Click(object sender, EventArgs e)
        {
            //定义并初始化一个OpenFileDialog对象
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //设置OpenFileDialog对象的Filter属性为Shape文件|*.shp
            openFileDialog.Filter = "Shape文件|*.shp";
            //设置OpenFileDialog对象的Title属性为选择Shape文件
            openFileDialog.Title = "Shape文件";
            //调用OpenFileDialog对象的ShowDialog方法并判断返回值是否为DialogResult.OK类型
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //读取OpenFileDialog对象的FileName属性，得到Shape文件名（含路径）
                string shapeFileName = openFileDialog.FileName;
                //定义并初始化一个FileInfo对象，初始化时把文件名作为参数传入
                FileInfo fileInfo = new FileInfo(shapeFileName);
                //读取FileInfo对象的DirectoryName属性和Name属性，作为OpenFeatureClass方法的2个参数传入
                string directory = fileInfo.DirectoryName;
                string fileName = fileInfo.Name;
                //调用OpenFeatureClass方法，并赋值给一个IFeatureClass对象
                IFeatureClass fc = DataOperator.OpenFeatureClass(fileInfo.DirectoryName, fileName);
                DataOperator.AddFeatureLayer(m_mapControl.Map, fc);
                m_mapControl.ActiveView.Refresh();
                this.GetAllFeatureLayers();

            }

            //IFeatureClass featureClass = DataOperator.OpenFeatureClass(@"C:\Program Files (x86)\ArcGIS\DeveloperKit10.8\Samples\ArcObjectsSampleData\data\World", "world30");
            ////调用AddFeatureLayer方法
            //DataOperator.AddFeatureLayer(m_mapControl.Map, featureClass);
            //刷新地图
            m_mapControl.ActiveView.Refresh();
        }


        private void mudLoadGDB_Click(object sender, EventArgs e)
        {
            string path = System.Environment.CurrentDirectory;
            IFeatureClass featureClass = DataOperator.OpenGDBFeatureClass(path + @"\city.gdb", "worldcities");
            DataOperator.AddFeatureLayer(m_mapControl.Map, featureClass);
            this.GetAllFeatureLayers();
        }

        #region 定义公共方法
        //public IFeatureClass OpenFeatureClass(string shpPath, string shpName)
        //{
        ////定义一个IWorkspaceFactory对象，用ShapefileWorkspaceFactoryClass构造函数初始化
        //IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
        ////调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
        //IWorkspace workspace = workspaceFactory.OpenFromFile(shpPath, 0);
        ////将IWorkspace对象接口转换为IFeatureWorkspace对象
        //IFeatureWorkspace featureWorkSpace = workspace as IFeatureWorkspace;
        ////调用IFeatureWorkspace的OpenFeatureClass方法，并赋值给一个IFeatureClass的对象
        //IFeatureClass featureClass = featureWorkSpace.OpenFeatureClass(shpName);
        ////返回该IFeatureClass对象
        // return featureClass;
        //    }
        //public IFeatureClass OpenGDBFeatureClass(string DBPath,string clsName)
        //{
        //    // 定义一个IWorkspaceFactory对象，用FileGDBWorkspaceFactoryClass构造函数初始化
        //    IWorkspaceFactory workspaceFactory = new FileGDBWorkspaceFactoryClass();
        //    //调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
        //    IWorkspace workspace = workspaceFactory.OpenFromFile(DBPath,0);
        //    //将IWorkspace对象接口转换为IFeatureWorkspace对象
        //    IFeatureWorkspace gdbWorkSpace = workspace as IFeatureWorkspace;
        //    //调用IFeatureWorkspace的OpenFeatureClass方法，并赋值给一个IFeatureClass的对象
        //    IFeatureClass tfeatureClass = gdbWorkSpace.OpenFeatureClass(clsName);
        //    //返回该IFeatureClass对象
        //    return tfeatureClass;
        //}
        //public IFeatureClass CreateShapefile(string shpPath, string shpName, ISpatialReference spatialRef)
        //{
        //    IFeatureClass featCls = null;
        //    //定义一个IWorkspaceFactory对象，用ShapefileWorkspaceFactoryClass构造函数初始化
        //    IWorkspaceFactory workspaceFactory = new ShapefileWorkspaceFactoryClass();
        //    //调用IWorkspaceFactory的OpenFromFile方法，并赋值给一个IWorkspace的对象
        //    IWorkspace workspace = workspaceFactory.OpenFromFile(shpPath, 0);
        //    //将IWorkspace对象接口转换为IFeatureWorkspace对象 
        //    IFeatureWorkspace featureWS = workspace as IFeatureWorkspace;
        //    //创建并编辑要素类所需的字段集
        //    IFields fields = new FieldsClass();
        //    IFieldsEdit fieldsEdit = fields as IFieldsEdit;
        //    //创建并编辑序号字段，此字段为要素类必需字段
        //    IFieldEdit fieldEdit = new FieldClass();
        //    fieldEdit.Name_2 = "OID";
        //    fieldEdit.AliasName_2 = "序号";
        //    fieldEdit.Type_2 = esriFieldType.esriFieldTypeOID;
        //    fieldsEdit.AddField(fieldEdit as IField);
        //    //创建并编辑"名称"字段，字段类型为文本型，该部分代码大家仿照写出
        //    fieldEdit = new FieldClass();
        //    fieldEdit.Name_2 = "Name";
        //    fieldEdit.AliasName_2 = "名称";
        //    fieldEdit.Type_2 = esriFieldType.esriFieldTypeString;
        //    fieldsEdit.AddField(fieldEdit as IField);
        //    //创建几何图形定义，设置空间参考和几何类型，为添加图形字段作准备 
        //    IGeometryDefEdit geoDefEdit = new GeometryDefClass();
        //    geoDefEdit.GeometryType_2 = esriGeometryType.esriGeometryPoint;
        //    geoDefEdit.SpatialReference_2 = spatialRef;
        //    //创建并编辑"形状"字段
        //    fieldEdit = new FieldClass();
        //    fieldEdit.Name_2 = "Shape";
        //    fieldEdit.AliasName_2 = "形状";
        //    fieldEdit.Type_2 = esriFieldType.esriFieldTypeGeometry;
        //    fieldEdit.GeometryDef_2 = geoDefEdit as IGeometryDef;
        //    fieldsEdit.AddField(fieldEdit as IField);
        //    //创建要素类
        //    featCls = featureWS.CreateFeatureClass(shpName, fields, null, null, esriFeatureType.esriFTSimple, "Shape", "");
        //    return featCls;
        //}
        #endregion
        ////定义一个IFeatureLayer对象，用FeatureLayerClass构造函数初始化
        //public bool AddFeatureLayer(IMap map, IFeatureClass featureClass)
        //{
        //    //设置IFeatureLayer的FeatureClass属性为参数featureClass的值
        //    IFeatureLayer featureLayer = new FeatureLayerClass();
        //    featureLayer.FeatureClass = featureClass;
        //    //设置IFeatureLayer的Name属性为参数featureClass的AliasName属性
        //    featureLayer.Name = featureLayer.FeatureClass.AliasName;
        //    //将IFeatureLayer对象接口转换为ILayer对象
        //    ILayer layer = featureLayer as ILayer;
        //    //调用IMap的AddLayer方法，将上一步得到的ILayer对象作为参数传入
        //    map.AddLayer(layer);
        //    //返回true；
        //    return true;
        //}

        private void axMapControl2_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {


        }




        private void axTOCControl2_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)

        {
            if (e.button != 2) return;//只有按了右键才弹出右键菜单

            //获取鼠标指定位置的项esriTOCControlItem
            IBasicMap map = null;
            object other = null;
            object index = null;
            esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
            axTOCControl2.HitTest(e.x, e.y, ref item, ref map, ref m_tocLayer, ref other, ref index);

            //判断esriTOCControlItem是选中了图层、地图、图例等               
            if (item == esriTOCControlItem.esriTOCControlItemLayer)
            {
                tocMnuAddData.Visible = false;//加载数据菜单不显示
                                              //若为矢量图层，则显示打开属性表菜单
                if (m_tocLayer is IFeatureLayer)
                {
                    tocMnuOpenAttr.Visible = true;
                    tocMnuSymbology.Visible = true;
                }
                else
                {
                    tocMnuOpenAttr.Visible = false;
                    tocMnuSymbology.Visible = false;
                }
                tocMnuZoomtoLyr.Visible = true;
                tocMnuDelLayer.Visible = true;
                //显示右键菜单
                contextMenuStrip1.Show(axTOCControl2, e.x, e.y);
            }
            else if (item == esriTOCControlItem.esriTOCControlItemMap)
            {
                tocMnuAddData.Visible = true;   //加载数据菜单显示
                tocMnuOpenAttr.Visible = false; //打开属性表菜单不显示
                tocMnuSymbology.Visible = false;//符号化菜单不显示
                tocMnuZoomtoLyr.Visible = false;
                tocMnuDelLayer.Visible = false;                                //显示右键菜单
                contextMenuStrip1.Show(axTOCControl2, e.x, e.y);
            }

        }
        //public DataTable GetAttributeTable(IFeatureLayer featLyr)
        //{
        //    DataTable dt = new DataTable();
        //    //1.获取图层的要素类FeatureClass
        //    IFeatureClass featCls = featLyr.FeatureClass;
        //    if (featCls != null)
        //    {
        //        //读取要素类的字段信息，并依次将字段名称加入到属性表列中
        //        for (int i = 0; i < featCls.Fields.FieldCount; i++)
        //        {
        //            DataColumn dc = new DataColumn(featCls.Fields.get_Field(i).Name);
        //            dt.Columns.Add(dc);
        //        }
        //        //2.通过游标FeatureCursor来获取每个要素Feature
        //        IFeatureCursor featCursor = featCls.Search(null, false);
        //        IFeature feat = featCursor.NextFeature();

        //        //循环遍历所有的Feature
        //        while (feat != null)
        //        {
        //            DataRow dr = dt.NewRow();
        //            for (int j = 0; j < feat.Fields.FieldCount; j++)
        //            {
        //                //3.读取Feature的字段值
        //                dr[j] = feat.get_Value(j).ToString();
        //                if(feat.Fields.Field[j].Type==esriFieldType.esriFieldTypeGeometry)
        //                {
        //                    if(featCls.ShapeType==esriGeometryType.esriGeometryPoint)
        //                    {
        //                        dr[j] = "点";
        //                    }
        //                    else if(featCls.ShapeType == esriGeometryType.esriGeometryPolyline)
        //                    {
        //                        dr[j] = "线";
        //                    }
        //                    else if(featCls.ShapeType == esriGeometryType.esriGeometryPolygon)
        //                    {
        //                        dr[j] = "面";
        //                    }

        //                }
        //            }
        //            dt.Rows.Add(dr);
        //            feat = featCursor.NextFeature();
        //        }
        //    }
        //    return dt;
        //}

        private void tocMnuAddData_Click(object sender, EventArgs e)
        {
            //定义并实例化一个ICommand接口对象,用ControlsAddDataCommandClass构造函数实例化            
            ICommand command = new ControlsAddDataCommandClass();
            //调用ICommand的OnCreate方法,把IMapControl3对象的Object属性作为参数传进来
            command.OnCreate(m_mapControl.Object);
            //调用ICommand的OnClick方法
            command.OnClick();
            this.GetAllFeatureLayers();
        }

        private void tocMnuOpenAttr_Click(object sender, EventArgs e)
        {
            #region 实验三打开属性表
            //获取选中图层
            //if (m_tocLayer != null)
            //{
            //    //调用读取属性表方法得到属性表
            //    DataTable dt = DataOperator.GetAttributeTable(m_tocLayer as IFeatureLayer);
            //    //调用另一窗体，为其设置数据源属性值
            //    AttributeForm frm = new AttributeForm();
            //    frm.DtSource = dt;
            //    //显示窗体
            //    frm.Show();
            #endregion
            //弹出FormAttributeTable窗体
            FormAttributeTable formAttributeTable = new FormAttributeTable(m_tocLayer as IFeatureLayer);
            formAttributeTable.Show();
            //}


        }

        private void tocMnuZoomtoLyr_Click(object sender, EventArgs e)
        {
            m_mapControl.Extent = m_tocLayer.AreaOfInterest;
        }

        private void tocMnuDelLayer_Click(object sender, EventArgs e)
        {
            m_mapControl.Map.DeleteLayer(m_tocLayer);
            this.GetAllFeatureLayers();
        }

        private void mnuCreateShp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "新建点Shape文件";
            sfd.Filter = "shape文件|*.shp";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //shapefile文件名称，包含路径
                string strFullFileName = sfd.FileName;
                //shapefile文件名称，不包含路径
                FileInfo fileInfo = new FileInfo(sfd.FileName);
                IFeatureClass fc = DataOperator.CreateShapefile(fileInfo.DirectoryName, fileInfo.Name, m_mapControl.Map.SpatialReference);
                //调用AddFeatureLayer方法
                DataOperator.AddFeatureLayer(m_mapControl.Map, fc);
            }
            this.GetAllFeatureLayers();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void axToolbarControl1_OnMouseDown(object sender, IToolbarControlEvents_OnMouseDownEvent e)
        {

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            if (btnAddPoint.Checked)
            {
                btnAddPoint.Checked = false;
            }
            else
            {
                if (cmbEditLayers.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择编辑图层！");
                    return;
                }
                //第二次判断，判断选择的图层是否为点图层
                ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                if (featureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPoint)
                {
                    MessageBox.Show("请选择点图层进行点要素添加！");
                    return;
                }
                //确认是否真的要编辑
                if (MessageBox.Show("确定要添加点？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.ResetToolControlStatus();
                    btnAddPoint.Checked = true;
                    mnuAddPoint.Checked = true;
                    flagEdit = 1;
                }

            }
        }
        private void GetAllFeatureLayers()
        {
            //先清空下拉框选项
            //循环图层个数，依次给下拉框添加选项，选项名称为图层名称
            //如果下拉框有1个及以上选项，则默认选中第一项
            cmbEditLayers.Items.Clear();
            ILayer layer;
            for (int i = 0; i < m_mapControl.LayerCount; i++)
            {
                layer = m_mapControl.get_Layer(i);
                cmbEditLayers.Items.Add(layer.Name);//cmbEditLayers.Items.Add(m_mapControl.Layer[i].Name;
            }
            if (cmbEditLayers.Items.Count > 0)
            {
                cmbEditLayers.SelectedIndex = 0;
            }
        }

        private void btnAddPolyline_Click(object sender, EventArgs e)
        {
            //第一次判断，判断下拉框是否选图层
            if (cmbEditLayers.SelectedIndex == -1)
            {
                MessageBox.Show("请选择编辑图层！");
                return;
            }
            //得到下拉框cmbEditLayers中选中图层对应的图层
            ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;//图层转矢量
                                                                //第二次判断，判断选择的图层是否为线图层
            if (featureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPolyline)
            {
                MessageBox.Show("请选择线图层进行线要素添加！");
                return;
            }
            //调用DataOperator类的GetPolylineGeometry方法，得到曲线的图形
            IPolyline polyline = DataOperator.GetPolylineGeometry();
            //调用DataOperator类的AddFeature方法，将上述图形加到下拉框对应的图层数据中
            DataOperator.AddFeature(featureLayer, polyline);
            //缩放到图层
            m_mapControl.Extent = featureLayer.AreaOfInterest;
        }

        private void btnAddPolygon_Click(object sender, EventArgs e)
        {
            //第一次判断，判断下拉框是否选图层
            if (cmbEditLayers.SelectedIndex == -1)
            {
                MessageBox.Show("请选择编辑图层！");
                return;
            }
            //调用DataOperator类的GetLayerByName方法，得到下拉框cmbEditLayers中选中图层对应的图层
            ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;//图层转矢量
            //第二次判断，判断选择的图层是否为面图层
            if (featureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPolygon)
            {
                MessageBox.Show("请选择面图层进行面要素添加！");
                return;
            }
            //得到面图形，调用DataOperator类的GetPolygonGeometry方法，得到面图形
            IPolygon polygon = DataOperator.GetPolygonGeometry();
            //调用DataPoerator类的方法的AddFeature方法实现面图形加入到面图层的数据中
            DataOperator.AddFeature(featureLayer, polygon);
            //缩放到图层
            m_mapControl.Extent = featureLayer.AreaOfInterest;
        }

        private void axMapControl2_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            // 获取 MapControl 的 IScreenDisplay 接口
            var screenDisplay = axMapControl2.ActiveView.ScreenDisplay;
            // 获取地图控件的地图空间中的点
            IPoint point = new PointClass();
            point.PutCoords(e.mapX, e.mapY);

            // 将点的 X 和 Y 坐标格式化为字符串
            string latitude = point.Y.ToString("0.000000");
            string longitude = point.X.ToString("0.000000");

            // 更新状态栏标签文本
            toolStripStatusLabel1.Text = $"纬度: {latitude}, 经度: {longitude}";
        }

        private void axMapControl2_OnMouseDown_1(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            //判断当前地图操作工具为【添加点要素】
            if (btnAddPoint.Checked && cmbEditLayers.SelectedIndex != -1)
            {
                //得到点的图形，主要根据事件参数e获取MapX和MaoY
                IPoint point = new PointClass();
                point.PutCoords(e.mapX, e.mapY);
                //得到图层
                ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                //调用DataOperator类的AddFeature方法，将上述图形加到下拉框对应的图层数据中
                DataOperator.AddFeature(featureLayer, point);
                //刷新地图
                m_mapControl.ActiveView.Refresh();

            }
            if (flagSelect != 0)
            { 
                IGeometry selectGeo = null;
             if (flagSelect == 1)
                {
                    //IDisplayTransformation displayTransformation = axMapControl2.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x + 5, e.y); 
                    //IPoint pointOffest=displayTransformation.ToMapPoint
                        IPoint point = new PointClass();
                    point.PutCoords(e.mapX, e.mapY);
                    //计算屏幕坐标横坐标向右偏移5个像素单位对应在地图上的坐标
                    IPoint pointOffset = axMapControl2.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x + 5, e.y);
                    //计算对应偏移点的地图偏移量
                    double dis = pointOffset.X - point.X;
                    //得到鼠标点击位置周围的范围
                    IEnvelope pEnv = new EnvelopeClass();
                    pEnv.PutCoords(e.mapX - dis, e.mapY - dis, e.mapX + dis, e.mapY + dis);
                    selectGeo = pEnv;
                   
                }
                else if (flagSelect == 2)
                {
                    IEnvelope envelope = m_mapControl.TrackRectangle();
                    selectGeo = envelope;

                } else if (flagSelect == 3)
                {
                    IGeometry geometry = m_mapControl.TrackPolygon();
                    selectGeo = geometry;

                }

                ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                MapAnalysis.QueryByGeometry(featureLayer, selectGeo);
                m_mapControl.ActiveView.Refresh();
            }
            //判断当前地图操作工具为【矩形查询】
            //else if (btnSelByRect.Checked && cmbEditLayers.SelectedIndex != -1)
            //{
            //    IEnvelope envelope = m_mapControl.TrackRectangle();
            //    //调用MapAnalysis的QueryByGeometry,传一个IFeatureLayere类型和IGeometry类型的参数进去
            //    ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
            //    IFeatureLayer featureLayer = layer as IFeatureLayer;
            //    MapAnalysis.QueryByGeometry(featureLayer, selectGeo);
            //    m_mapControl.ActiveView.Refresh();
            //}
            //else if (bynSelByPolygon.Checked && cmbEditLayers.SelectedIndex != -1)
            //{
            //    IGeometry geometry = m_mapControl.TrackPolygon();
            //    //调用MapAnalysis的QueryByGeometry,传一个IFeatureLayere类型和IGeometry类型的参数进去
            //    ILayer layer = DataOperator.GetLayerByName(m_mapControl.Map, cmbEditLayers.SelectedItem.ToString());
            //    IFeatureLayer featureLayer = layer as IFeatureLayer;
            //    MapAnalysis.QueryByGeometry(featureLayer, geometry);
            //    m_mapControl.ActiveView.Refresh();
            //}
        }

        private void mnuAddPoint_Click(object sender, EventArgs e)
        {
            this.btnAddPoint_Click(sender, e);
        }

        private void mnuAddPolyline_Click(object sender, EventArgs e)
        {
            this.btnAddPolyline_Click(sender, e);
        }

        private void mnuAddPolygon_Click(object sender, EventArgs e)
        {
            this.btnAddPolygon_Click(sender, e);
        }

        private void tocMnuSymbology_Click(object sender, EventArgs e)
        {
            IFeatureLayer featureLayer = m_tocLayer as IFeatureLayer;
            esriGeometryType geoType = featureLayer.FeatureClass.ShapeType;

            //弹出设置点符号的窗体
            if (geoType == esriGeometryType.esriGeometryPoint)
            {
                FormPointSymbol form = new FormPointSymbol();//声明并且初始化
                if (form.ShowDialog() == DialogResult.OK)
                {

                    Color color = form.SymColor;
                    double size = form.SymSize;
                    bool outline = form.HasOutline;
                    Color outlineColor = form.OutlineColor;
                    double outlineSize = form.OutlineSize;
                    //System.Color转IColor
                    //创建一个IRgbColor接口对象，用RgbColor类的构造函数new
                    IRgbColor rgbColor = new RgbColorClass();
                    //设置该接口对象的R、G、B属性为Form对应的SymColor的RGB属性
                    rgbColor.Red = color.R;
                    rgbColor.Green = color.G;
                    rgbColor.Blue = color.B;
                    //IColor iColor = rgbColor as IColor;
                    //创建一个IRgbColor接口对象，用RgbColor类的构造函数new
                    IRgbColor rgbOutlineColor = new RgbColorClass();
                    //设置该接口对象的R、G、B属性为Form对应的OutlineColor的RGB属性
                    rgbOutlineColor.Red = outlineColor.R;
                    rgbOutlineColor.Green = outlineColor.G;
                    rgbOutlineColor.Blue = outlineColor.B;
                    //IColor iOutlineColor = rgbOutlineColor as IColor;
                    //调用方法实现点符号渲染图层
                    MapComposer.PointRenderSimply(m_tocLayer as IFeatureLayer, rgbColor, size, outline, rgbOutlineColor, outlineSize);
                    m_mapControl.ActiveView.Refresh();
                }
            }
            else if (geoType == esriGeometryType.esriGeometryPolyline)
            {
               
                FormLineSymbol form = new FormLineSymbol();

                Color color = form.SymColor;
                double size = form.SymSize;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IRgbColor rgbColor = new RgbColor();
                    rgbColor.Red = form.SymColor.R;
                    rgbColor.Green = form.SymColor.G;
                    rgbColor.Blue = form.SymColor.B;

                    MapComposer.PolylineRenderSimply(m_tocLayer as IFeatureLayer, rgbColor, size);
                    m_mapControl.ActiveView.Refresh();

                }

            }
            else if (geoType == esriGeometryType.esriGeometryPolygon)
            {
                FormPolygonSymbol form = new FormPolygonSymbol();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    IRgbColor rgbColor = new RgbColor();
                    rgbColor.Red = form.SymColor.R;
                    rgbColor.Green = form.SymColor.G;
                    rgbColor.Blue = form.SymColor.B;

                    IRgbColor outlinergb = new RgbColor();
                    outlinergb.Red = form.OutlineColor.R;
                    outlinergb.Green = form.OutlineColor.G;
                    outlinergb.Blue = form.OutlineColor.B;

                    MapComposer.PolygonRenderSimply(m_tocLayer as IFeatureLayer, rgbColor, outlinergb, form.OutlineSize);
                    m_mapControl.ActiveView.Refresh();
                }
            }
        }
        private void ChangeControl()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                //切换到地图，设置地图关联控件的Buddy属性
                axToolbarControl1.SetBuddyControl(m_mapControl.Object);
                axTOCControl2.SetBuddyControl(m_mapControl.Object);
                //切换到地图tab页
                tabControl1.SelectedIndex = 0;
                //设置菜单的Checked属性              
                mnuDisplayMap.Checked = true;
                mnuDisplayLayout.Checked = false;
            }
            else
            {
                //切换到布局，设置地图关联控件的Buddy属性
                axToolbarControl1.SetBuddyControl(axPageLayoutControl1.Object);
                axTOCControl2.SetBuddyControl(axPageLayoutControl1.Object);
                //切换到布局tab页
                tabControl1.SelectedIndex = 1;
                //设置菜单的Checked属性
                mnuDisplayMap.Checked = false;
                mnuDisplayLayout.Checked = true;




            }
        }


        private void mnuDisplayMap_Click(object sender, EventArgs e)
        {

        }

        private void mnuDisplayLayout_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeControl();
        }

        private void axMapControl2_OnAfterScreenDraw(object sender, IMapControlEvents2_OnAfterScreenDrawEvent e)
        {
            //将MapControl中的当前地图copy到PageLayout的当前地图
            //调用MapComposer类的CopyMap方法
            MapComposer.CopyMap(axMapControl2.Map, axPageLayoutControl1.ActiveView.FocusMap);
            axPageLayoutControl1.ActiveView.Refresh();
        }

        private void axPageLayoutControl1_OnAfterScreenDraw(object sender, IPageLayoutControlEvents_OnAfterScreenDrawEvent e)
        {
            MapComposer.CopyMap(axPageLayoutControl1.ActiveView.FocusMap, axMapControl2.Map);
            axMapControl2.ActiveView.Refresh();
        }

        private void mnuOutput_Click(object sender, EventArgs e)
{

            IExport docExport;
            docExport = new ExportJPEGClass();
            IActiveView docActiveView;
            int iOutputResolution = 300;
            if (!mnuDisplayLayout.Checked)

                docActiveView = axMapControl2.ActiveView;
            else
                docActiveView = axPageLayoutControl1.ActiveView;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "选择保存路径";
            saveFileDialog.Filter = "JPEG 文件 (*.jpg)|*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                docExport.ExportFileName = saveFileDialog.FileName;
                IPrintAndExport printAndExport = new PrintAndExportClass();
                printAndExport.Export(docActiveView, docExport, iOutputResolution, true, null);
                MessageBox.Show("地图输出成功!");
            }
            else
            {
                MessageBox.Show("地图输出失败!");
            }
            //IActiveView docActiveView;
            //if (!mnuDisplayLayout.Checked)
            //    docActiveView = axMapControl2.ActiveView;
            //else
            //    docActiveView = axPageLayoutControl1.ActiveView;
            //IExport export = new ExportJPEGClass();
            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.Title = "输出地图";
            //saveFile.Filter = "JPEG 文件 (*.jpg)|*.jpg";
            //if (saveFile.ShowDialog() == DialogResult.OK)
            //{
            //    SetResolution setResolution = new SetResolution();
            //    if (setResolution.ShowDialog() == DialogResult.OK)
            //    {
            //        export.Resolution = setResolution.resolution;
            //    }
            //    export.ExportFileName = saveFile.FileName;
            //    //使用IPrintAndExport的Export方法
            //    IPrintAndExport printAndExport = new PrintAndExport();
            //    printAndExport.Export(docActiveView, export, export.Resolution, true, null);
            //    MessageBox.Show("地图输出成功!");
            //}


        }

        private void mnuInsertNorthArrow_Click(object sender, EventArgs e)
        {
            IPageLayout pageLayout = axPageLayoutControl1.ActiveView as IPageLayout;
            MapComposer.AddNorthArrow(pageLayout, axPageLayoutControl1.ActiveView.FocusMap);

        }
        //属性查图形菜单
        private void mnuSearchByAttr_Click(object sender, EventArgs e)
        {
            //弹出属性查图形的窗体
            FormSelectByAttr form = new FormSelectByAttr(m_mapControl.Map);
            form.Show();
        }

        private void mnuInsertScalebar_Click(object sender, EventArgs e)
        {
            MapComposer.AddScaleBar(axPageLayoutControl1.PageLayout, axPageLayoutControl1.ActiveView.FocusMap);
        }

        private void mnuInsertLegend_Click(object sender, EventArgs e)
        {
            MapComposer.AddLegend(axPageLayoutControl1.PageLayout, axPageLayoutControl1.ActiveView.FocusMap);
        }

        private void mnuInsertTitle_Click(object sender, EventArgs e)
        {
            MapComposer.AddMapTitle(axPageLayoutControl1.PageLayout, axPageLayoutControl1.ActiveView.FocusMap);
        }

        private void btnSelByPoint_Click(object sender, EventArgs e)
        {
            if (cmbEditLayers.SelectedIndex != -1)
            {
                this.ResetToolControlStatus();
                btnSelByPoint.Checked = true;
                mnuSelByPoint.Checked = true;
                flagSelect = 1;
            }
            else
                MessageBox.Show("请先选择图层！");
        }
        //矩形查询
        private void btnSelByRect_Click(object sender, EventArgs e)
        {
            if (cmbEditLayers.SelectedIndex != -1)
            {
                this.ResetToolControlStatus();
                btnSelByRect.Checked = true;
                mnuSelByRect.Checked = true;
                flagSelect = 2;
            }
            else
                MessageBox.Show("请先选择图层！");
                
        }

        private void bynSelByPolygon_Click(object sender, EventArgs e)
        {
            if(cmbEditLayers.SelectedIndex!=-1)
            {
                this.ResetToolControlStatus();
                bynSelByPolygon.Checked = true;
                mnuSelByPolygon.Checked = true;
                flagSelect = 3;
            }else
                MessageBox.Show("请先选择图层！");
        }

        private void mnuSelByPoint_Click(object sender, EventArgs e)
        {

        }
        private void ResetToolControlStatus()
        {
            //重置设计地图控件交互功能的菜单项、工具按钮的Checked状态
            btnAddPoint.Checked = false;
            mnuAddPoint.Checked = false;
            btnSelByPoint.Checked = false;
            btnSelByRect.Checked = false;
            bynSelByPolygon.Checked = false;
            mnuSelByPoint.Checked = false;
            mnuSelByRect.Checked = false;
            mnuSelByPolygon.Checked = false;
            放大ToolStripMenuItem.Checked = false;
            缩小ToolStripMenuItem.Checked = false;
            平移ToolStripMenuItem.Checked = false;
            //重置AxToolbarControl的item的状态，m_mapControl的CurrentTool设为null
            m_mapControl.CurrentTool = null;
            //2个标志变量复制0
           flagSelect = 0;
           flagEdit = 0;
    }

        private void btnClearSel_Click(object sender, EventArgs e)
        {
            IMap map = m_mapControl.Map;
            map.ClearSelection();
            m_mapControl.ActiveView.Refresh();
        }

        private void mnuBuffer_Click(object sender, EventArgs e)
        {
            FormBufferAnalysis bufferAnalysis = new FormBufferAnalysis(m_mapControl.Map);
            bufferAnalysis.ShowDialog();
        }

        private void mnuSelByRect_Click(object sender, EventArgs e)
        {

        }

        private void 时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapComposer.AddDateTimeStamp(axPageLayoutControl1.PageLayout);
        }

        private void mnu_add_Click(object sender, EventArgs e)
        {
            AddPoint ap = new AddPoint(m_mapControl.Map);
            ap.Show();
        }
    }
        }
    

