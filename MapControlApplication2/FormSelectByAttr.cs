using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
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
    public partial class FormSelectByAttr : Form
    {
        private IMap map = null;
        public FormSelectByAttr(IMap pmap)
        {
            this.map = pmap;
            InitializeComponent();
        }

        private void FormSelectByAttr_Load(object sender, EventArgs e)
        {
            this.GetAllFeatureLayers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "< ";
        }
        public  void GetAllFeatureLayers()
        {
            //清空前一个图层所有字段名称
            comboBox1.Items.Clear();
            for (int i = 0; i < this.map.LayerCount; i++)
            {
                ILayer layer = this.map.Layer[i];//cmbEditLayers.Items.Add(m_mapControl.Layer[i].Name;
                if (layer is IFeatureLayer)
                {
                    comboBox1.Items.Add(layer.Name);
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strLayerName = comboBox1.SelectedItem.ToString();
            //修改lblLayerName（图层名称）的TEXT属性为选中项
            lblLayerName.Text = strLayerName;
            lstFields.Items.Clear();
            //获取选中项对应的图层的数据的字段集，并循环添加到lstFields中
            //1.得到图层，转为矢量图层
            ILayer layer = DataOperator.GetLayerByName(this.map, comboBox1.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            //2.循环遍历矢量图层的数据的Fields
            for (int i = 0; i < featureLayer.FeatureClass.Fields.FieldCount;i++)
            {
                IField field = featureLayer.FeatureClass.Fields.Field[i];
                lstFields.Items.Add(field.Name);
                //lstFields.Items.Add(featureLayer.FeatureClass.Fields.Field[i].Name);
            }
            //3.给lstFields的item添加一项，内容为第i个字段的名称
        }

        private void lstFields_DoubleClick(object sender, EventArgs e)
        {
            //把选中的字段添加到查询条件文本框txtWhereClause
            txtWhereClause.Text += lstFields.SelectedItem.ToString() + "";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "= ";
        }

        private void btnGreater_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "> ";
        }

        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "<> ";
        }

        private void btnLike_Click(object sender, EventArgs e)
        {

            txtWhereClause.Text += "Like ";
            //txtWhereClause.Text += "";
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "And ";
        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "Or ";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "% ";
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            txtWhereClause.Text += "'' ";
        }

        private void btn_blur_Click(object sender, EventArgs e)
        {
            Blur_query bq = new Blur_query();
            if (bq.ShowDialog() == DialogResult.OK) 
            {
                txtWhereClause.Text += bq.condition;
            }
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IActiveView activeView = map as IActiveView;
            string strLayerName = comboBox1.SelectedItem.ToString();
            ILayer layer = DataOperator.GetLayerByName(this.map, comboBox1.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
            MapAnalysis.QueryByAttr(featureLayer, txtWhereClause.Text);
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtWhereClause.Clear();
        }

        private void btn_statics_Click(object sender, EventArgs e)
        {
            // 检查图层输入
            if (string.IsNullOrEmpty(txtWhereClause.Text))
            {
                MessageBox.Show("请输入查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请先选择一个图层！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取选中图层
            ILayer layer = DataOperator.GetLayerByName(this.map, comboBox1.SelectedItem.ToString());
            IFeatureLayer featureLayer = layer as IFeatureLayer;
            // 获取选中要素的FID总和
            int sum = DataOperator.SUMschool(featureLayer);
            MessageBox.Show("选中要素的FID总和为: " + sum.ToString());
        }
    }
}
;