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
    public partial class FormPointSymbol : Form
    {
        public Color SymColor { get; set; }
        public double SymSize { get; set; }
        public bool HasOutline { get; set; }
        public Color OutlineColor { get; set; }
        public double OutlineSize { get; set; }
        public Color Color { get; internal set; }

        public FormPointSymbol()
        {
            InitializeComponent();
        }

        private void cblsOutline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.SymColor=panelColor.BackColor;
            this.SymSize=(double) numSize.Value;
            this.HasOutline = cblsOutline.Checked;
            this.OutlineColor = panelOutlineColor.BackColor;
            this.OutlineSize = (double)numOutlineSize.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            //弹出颜色选择对话框colordialog
            //调用ColorDialog类的ShowDialog方法
            if(colorDialog1.ShowDialog()==DialogResult.OK )
            {
                //获取这个类的Color属性，并把它赋值给PanelColor的对应的属性上来
               panelColor.BackColor =colorDialog1.Color;
            }
        }

        private void panelOutlineColor_Click(object sender, EventArgs e)
        {
            //弹出颜色选择对话框colordialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //获取这个类的Color属性，并把它赋值给PanelColor的对应的属性上来
                panelOutlineColor.BackColor = colorDialog1.Color;
            }
        }

        private void panelColor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
