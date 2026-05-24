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
using ESRI.ArcGIS.Geometry;

namespace MapControlApplication2
{
    public partial class Blur_query : Form
    {
        public Blur_query()
        {
            InitializeComponent();
        }
        public string condition { get; private set; }

        private void btn_OK_Click(object sender, EventArgs e)
        {
          
           condition= "Like '%" + tbx_condition.Text + "%' ";
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnstastics_Click(object sender, EventArgs e)
        {
           
        }

        private void SUMschool(IFeatureLayer featureLayer, bool getAllFeatures)
        {
            List<int> fidList = new List<int>();
            IFeatureClass featureClass = featureLayer.FeatureClass;

            if (featureClass == null)
            {
                MessageBox.Show("无效的图层！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IFeatureCursor featureCursor;

            if (getAllFeatures)
            {
                // 获取所有要素
                featureCursor = featureClass.Search(null, false);
            }
            else
            {
                // 获取选中要素
                IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
                ISelectionSet selectionSet = featureSelection.SelectionSet;

                if (selectionSet.Count == 0)
                {
                    MessageBox.Show("请先选择要素！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ICursor cursor;
                selectionSet.Search(null, false, out cursor);
                featureCursor = cursor as IFeatureCursor;
            }

            // 使用游标读取要素的FID
            IFeature feature = featureCursor.NextFeature();
            while (feature != null)
            {
                fidList.Add(feature.OID);
                feature = featureCursor.NextFeature();
            }

            // 计算FID总和
            if (fidList.Count > 0)
            {
                int fidSum = fidList.Sum();
                MessageBox.Show($"选中要素的FID总和为：{fidSum}\n要素数量：{fidList.Count}",
                              "统计结果",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("没有找到要素！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
