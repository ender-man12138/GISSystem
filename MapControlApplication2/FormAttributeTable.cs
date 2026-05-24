using ESRI.ArcGIS.Carto;
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
    public partial class FormAttributeTable : Form
    {
        //定义一个私有的成员变量m_featLayer
        private IFeatureLayer m_featLayer;
        //构造函数是增加一个IFeatureLayer类型的参数，以便赋值
        public FormAttributeTable(IFeatureLayer featureLayer)
        {
            InitializeComponent();
            this.m_featLayer = featureLayer;
           
        }

        private void btnSelectedFeature_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAllFeature_Click(object sender, EventArgs e)
        {

            DataTable dataTable = DataOperator.GetAttributeTable(m_featLayer, true);
            dataGridView1.DataSource = dataTable;
            btnAllFeature.Checked = true;
            btnSelected.Checked = false;
            this.changed();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormAttributeTable_Load(object sender, EventArgs e)
        {
            //调用新的Get方法
            //根据btnallfeature的CHECKED属性决定是全部要素还是选中要素的属性DATATABLE
            DataTable dataTable = DataOperator.GetAttributeTable(m_featLayer, true);
            //将上述dataTable赋值给dataGridView1的DataSource属性
            dataGridView1.DataSource = dataTable;
           
            if (m_featLayer != null)
            {
                
                DataOperator dataOper = new DataOperator();
                DataTable dt = DataOperator.GetAttributeTable(m_featLayer, false);
                dataGridView1.DataSource = dt;
                this.changed();
                this.Text = "图层属性表（" + m_featLayer.Name + "）";
            }
        }



        private void btnSelected_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataOperator.GetAttributeTable(m_featLayer, false);
            dataGridView1.DataSource = dataTable;
            btnSelected.Checked = true;
            btnAllFeature.Checked = false;
            this.changed();
        }
        public void changed()
        {
            int totalCount = m_featLayer.FeatureClass.FeatureCount(null);
            IFeatureSelection featSelection = m_featLayer as IFeatureSelection;
            int selectedCount = featSelection.SelectionSet.Count;
            lblCount.Text = string.Format("(共{0}条记录，选中{1}条)", totalCount, selectedCount);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    

