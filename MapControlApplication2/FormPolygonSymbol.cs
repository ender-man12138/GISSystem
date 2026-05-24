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
    public partial class FormPolygonSymbol : Form
    {
        public Color SymColor { get; set; }
        public Color OutlineColor { get; set; }
        public double OutlineSize { get; set; }
        public FormPolygonSymbol()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.SymColor = panelColor.BackColor;
            this.OutlineColor = panelOutlineColor.BackColor;
            this.OutlineSize = (double)numOutlineSize.Value;
            this.DialogResult = DialogResult.OK;
        }

        //private void panelColor_Paint(object sender, PaintEventArgs e)
        //{
        //    if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        panelColor.BackColor = colorDialog1.Color;
        //    }
        //}

        //private void panelOutlineColor_Paint(object sender, PaintEventArgs e)
        //{
        //    if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        panelOutlineColor.BackColor = colorDialog1.Color;
        //    }
        //}

        private void panelColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panelColor.BackColor = colorDialog1.Color;
            }
        }

        private void panelOutlineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                panelOutlineColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
