namespace MapControlApplication2
{
    partial class FormPointSymbol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColor = new System.Windows.Forms.Panel();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cblsOutline = new System.Windows.Forms.CheckBox();
            this.panelOutlineColor = new System.Windows.Forms.Panel();
            this.numOutlineSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(125, 43);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(37, 37);
            this.panelColor.TabIndex = 0;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            this.panelColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelColor_Paint);
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(125, 109);
            this.numSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(60, 21);
            this.numSize.TabIndex = 1;
            this.numSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cblsOutline
            // 
            this.cblsOutline.AutoSize = true;
            this.cblsOutline.Location = new System.Drawing.Point(39, 161);
            this.cblsOutline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cblsOutline.Name = "cblsOutline";
            this.cblsOutline.Size = new System.Drawing.Size(79, 21);
            this.cblsOutline.TabIndex = 2;
            this.cblsOutline.Text = "使用边框";
            this.cblsOutline.UseVisualStyleBackColor = true;
            this.cblsOutline.CheckedChanged += new System.EventHandler(this.cblsOutline_CheckedChanged);
            // 
            // panelOutlineColor
            // 
            this.panelOutlineColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOutlineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutlineColor.Location = new System.Drawing.Point(125, 203);
            this.panelOutlineColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOutlineColor.Name = "panelOutlineColor";
            this.panelOutlineColor.Size = new System.Drawing.Size(41, 37);
            this.panelOutlineColor.TabIndex = 3;
            this.panelOutlineColor.Click += new System.EventHandler(this.panelOutlineColor_Click);
            // 
            // numOutlineSize
            // 
            this.numOutlineSize.Location = new System.Drawing.Point(125, 284);
            this.numOutlineSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numOutlineSize.Name = "numOutlineSize";
            this.numOutlineSize.Size = new System.Drawing.Size(60, 21);
            this.numOutlineSize.TabIndex = 4;
            this.numOutlineSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "大小：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "边框颜色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "边框宽度：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(125, 338);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 19);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "渲染染色：";
            // 
            // FormPointSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numOutlineSize);
            this.Controls.Add(this.panelOutlineColor);
            this.Controls.Add(this.cblsOutline);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.panelColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPointSymbol";
            this.Text = "FormPointSymbol";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.CheckBox cblsOutline;
        private System.Windows.Forms.Panel panelOutlineColor;
        private System.Windows.Forms.NumericUpDown numOutlineSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}