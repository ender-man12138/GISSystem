using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapControlApplication2
{
    public partial class AddPoint : Form
    {
        private IMap map = null;
        public AddPoint(IMap pmap)
        {
            InitializeComponent();
            this.map = pmap;
        }
        public void GetAllFeatureLayers()
        {
            //清空前一个图层所有字段名称
            comboBox_feature.Items.Clear();
            for (int i = 0; i < this.map.LayerCount; i++)
            {
                ILayer layer = this.map.Layer[i];//cmbEditLayers.Items.Add(m_mapControl.Layer[i].Name;
                if (layer is IFeatureLayer)
                {
                    comboBox_feature.Items.Add(layer.Name);
                }
            }
            if (comboBox_feature.Items.Count > 0)
            {
                comboBox_feature.SelectedIndex = 0;
            }
        }
        private void AddPoint_Load(object sender, EventArgs e)
        {
            this.GetAllFeatureLayers();
            
            }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //第二次判断，判断选择的图层是否为点图层
            ILayer layer = DataOperator.GetLayerByName(this.map, comboBox_feature.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            if (featureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPoint)
            {
                MessageBox.Show("请选择点图层进行点要素添加！");
                return;
            }

            // 调用新方法添加点要素
            AddNewPointFeature(featureLayer);
        }

        public void AddNewPointFeature(IFeatureLayer featureLayer)
        {
            // 读取用户输入的经纬度和属性信息
            if (!double.TryParse(textBox_longtitude.Text, out double longitude) ||
                !double.TryParse(textBox_latitude.Text, out double latitude))
            {
                MessageBox.Show("请输入有效的经纬度坐标！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 创建点几何对象
            IPoint point = new PointClass();
            point.PutCoords(longitude, latitude);

            // 获取要素类并创建新要素
            IFeatureClass featureClass = featureLayer.FeatureClass;
            IFeature feature = featureClass.CreateFeature();

            // 设置点的几何形状
            feature.Shape = point;

            // 设置经度值
            int lonIndex = featureClass.FindField("Lon");
            if (lonIndex != -1)
            {
                feature.set_Value(lonIndex, longitude);
            }

            // 设置纬度值
            int latIndex = featureClass.FindField("Lat");
            if (latIndex != -1)
            {
                feature.set_Value(latIndex, latitude);
            }

            // 设置点名称
            int pointNameIndex = featureClass.FindField("PointName"); // 使用PointName字段而不是FID
            if (pointNameIndex != -1)
            {
                feature.set_Value(pointNameIndex, textBox_name.Text);
            }

            // 保存要素
            feature.Store();

            // 刷新地图
            IActiveView activeView = map as IActiveView;
            if (activeView != null)
            {
                activeView.Refresh();
            }

            MessageBox.Show("点要素添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 清空输入框
            textBox_longtitude.Clear();
            textBox_latitude.Clear();
            textBox_name.Clear();
        }
    }
    }

