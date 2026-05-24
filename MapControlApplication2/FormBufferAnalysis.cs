using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapControlApplication2
{

    public partial class FormBufferAnalysis : Form
    {
        public IMap map = null;
       

        public FormBufferAnalysis(IMap pmap)
        {

            this.map = pmap;
            InitializeComponent();

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            double bufferDistance;
            double.TryParse(txtBufferDistance.Text, out bufferDistance);
            if (0.0 == bufferDistance)
            {
                MessageBox.Show("缓冲距离不可为0！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(OutputPath.Text=="")
            {
                MessageBox.Show("请选择输出路径");
                    return;
            }
            if(comboBoxEdit2.SelectedIndex==-1)
            {
                MessageBox.Show("请选择缓冲区半径");
                return;
            }

            string strOutput = OutputPath.Text;
            string strUnit = comboBoxEdit2.SelectedIndex.ToString();
            string Message;
            bool result;
            if (comboBoxEdit1.SelectedIndex != -1)
            {
                ILayer layer = DataOperator.GetLayerByName(map, comboBoxEdit1.SelectedItem.ToString());
                IFeatureLayer featureLayer = layer as IFeatureLayer;
                result = MapAnalysis.BufferAnalysis(featureLayer, strOutput, bufferDistance, strUnit, out Message);
            }
            else
            {
                string shapefilepath = comboBoxEdit1.Text;
                result = MapAnalysis.BufferAnalysis(shapefilepath, strOutput, bufferDistance, strUnit, out Message);
            }
           
            if (result)
            {
                MessageBox.Show("缓冲区分析成功");
            }
            else
            {
                MessageBox.Show("缓冲区分析失败，出错消息为："+Message);
            }
            
            //Geoprocessor gp = new Geoprocessor();
            //gp.OverwriteOutput = true;
            ////create a new instance of a buffer tool
            //ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer(layer, this.OutputPath, Convert.ToString(bufferDistance) + " " + (string)comboBoxEdit2.SelectedItem);
            ////ESRI.ArcGIS.AnalysisTools.Buffer buffer = new ESRI.ArcGIS.AnalysisTools.Buffer (layer, this.OutputPath, "100"+" "+"Meters" );
            //buffer.dissolve_option = "ALL";//这个要设成ALL,否则相交部分不会融合
            //buffer.line_side = "FULL";//默认是"FULL",最好不要改否则出错
            //buffer.line_end_type = "ROUND";//默认是"ROUND",最好不要改否则出错
            //                               //execute the buffer tool (very easy :-))
            //IGeoProcessorResult results = null;
            //try
            //{
            //    results = (IGeoProcessorResult)gp.Execute(buffer, null);
            //    MessageBox.Show("缓冲区建立成功！");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("缓冲区建立失败！");
            //    // txtMessages.Text += "Failed to buffer layer: " + layer.Name + "\r\n";
            //}
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLayerName = comboBoxEdit1.SelectedItem.ToString();
            //1.得到图层，转为矢量图层
            ILayer layer = DataOperator.GetLayerByName(map, comboBoxEdit1.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            //2.循环遍历矢量图层的数据的Fields
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount; i++)
            {
                IField field = featureLayer.FeatureClass.Fields.Field[i];

                //lstFields.Items.Add(featureLayer.FeatureClass.Fields.Field[i].Name);
            }
            //3.给lstFields的item添加一项，内容为第i个字段的名称
        }
        public void GetAllFeatureLayers()
        {
            //清空前一个图层所有字段名称
            comboBoxEdit1.Items.Clear();
            for (int i = 0; i < this.map.LayerCount; i++)
            {
                ILayer layer = this.map.Layer[i];//cmbEditLayers.Items.Add(m_mapControl.Layer[i].Name;
                if (layer is IFeatureLayer)
                {
                    comboBoxEdit1.Items.Add(layer.Name);
                }
            }
            if (comboBoxEdit1.Items.Count > 0)
            {
                comboBoxEdit1.SelectedIndex = 0;
            }
        }
        private void FormBufferAnalysis_Load(object sender, EventArgs e)
        {
            this.GetAllFeatureLayers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开图层文件";
            openFileDialog.Filter = "shp文件(*.shp)|*.shp";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName;
                System.Diagnostics.Debug.WriteLine(strFileName);

                //shapefile文件名称，不包含路径
                string strShortFileName = openFileDialog.SafeFileName;
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                IFeatureClass fc = DataOperator.OpenFeatureClass(fileInfo.DirectoryName, strShortFileName);
                //将读取的shapefile数据添加到下拉框中
                DataOperator.AddFeatureLayer(map, fc);

            }
            GetAllFeatureLayers();
        }
            
       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            sfg.Title = "请选择保存缓冲区的路径";
            sfg.Filter = "Shape文件 (*.shp)| *.shp";
            //sfg.ShowDialog();
            if (sfg.ShowDialog()==DialogResult.OK)
            {
               OutputPath.Text= sfg.FileName;
            }
        }
    }
    }
