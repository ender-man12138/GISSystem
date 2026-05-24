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
    public partial class InsertTitle : Form
    {
        public Font font { get; set; }
        public Color titleColor { get; set; }
        public string title { get; set; }
        public InsertTitle()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.font = ParseFontFromString(textBox2.Text);
            this.titleColor = panelTitleColor.BackColor;
            this.title = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
        private void panelTitleColor_Click(object sender, EventArgs e)
        {
        }
        private Font ParseFontFromString(string fontString)
        {
            // 字体信息的格式类似于 "[Font: Name=宋体, Size=9, Units=3, GdiCharSet=134, GdiVerticalFont=False]"
            fontString = fontString.Replace("[Font: ", "").Replace("]", "");
            string[] parts = fontString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string fontFamily = "";
            float fontSize = 0;
            FontStyle fontStyle = FontStyle.Regular;
            byte gdiCharSet = 0;
            bool gdiVerticalFont = false;

            foreach (var part in parts)
            {
                var keyValue = part.Split('=');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0].Trim();
                    string value = keyValue[1].Trim();

                    switch (key)
                    {
                        case "Name":
                            fontFamily = value;
                            break;
                        case "Size":
                            fontSize = float.Parse(value);
                            break;
                        case "Units":
                            // Units 可能不需要处理，因为 Size 已经是正确的单位
                            break;
                        case "GdiCharSet":
                            gdiCharSet = byte.Parse(value);
                            break;
                        case "GdiVerticalFont":
                            gdiVerticalFont = bool.Parse(value);
                            break;
                    }
                }
            }
            Font = new Font(fontFamily, fontSize, fontStyle, GraphicsUnit.Point, gdiCharSet);
            return Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fontDialog1.Font.ToString();
                textBox2.Font = fontDialog1.Font;
            }
        }

        private void panelTitleColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleColor_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelTitleColor.BackColor = colorDialog1.Color;
            }
        }
    }
    }

