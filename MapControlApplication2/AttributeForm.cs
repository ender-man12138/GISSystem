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
    public partial class AttributeForm : Form
    {
        private DataTable dtSource;
        public DataTable DtSource   //数据源属性
        {
            get { return dtSource; }
            set { dtSource = value; }
        }

        public AttributeForm()
        {
            InitializeComponent();
        }

        private void AttributeForm_Load(object sender, EventArgs e)
        {
            if (dtSource != null)
            {
                AttrituteForm.DataSource = dtSource;
            }

        }
    }
}
