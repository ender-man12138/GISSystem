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
    public partial class FormLineSymbol : Form
    {
        public Color SymColor { get; set; }
        public double SymSize { get; set; }
      
        public Color Color { get; internal set; }
        public FormLineSymbol()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            this.SymColor = panelColor.BackColor;
            this.SymSize = (double)numSize.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            //调用ColorDialog类的ShowDialog方法
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取这个类的Color属性，并把它赋值给PanelColor的对应的属性上来
                panelColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
