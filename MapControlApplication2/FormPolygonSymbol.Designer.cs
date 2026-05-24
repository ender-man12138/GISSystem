namespace MapControlApplication2
{
    partial class FormPolygonSymbol
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
            this.button_OK = new System.Windows.Forms.Button();
            this.numOutlineSize = new System.Windows.Forms.NumericUpDown();
            this.panelOutlineColor = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(196, 428);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(188, 46);
            this.button_OK.TabIndex = 25;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // numOutlineSize
            // 
            this.numOutlineSize.Location = new System.Drawing.Point(303, 314);
            this.numOutlineSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numOutlineSize.Name = "numOutlineSize";
            this.numOutlineSize.Size = new System.Drawing.Size(180, 28);
            this.numOutlineSize.TabIndex = 24;
            // 
            // panelOutlineColor
            // 
            this.panelOutlineColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOutlineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutlineColor.Location = new System.Drawing.Point(303, 182);
            this.panelOutlineColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOutlineColor.Name = "panelOutlineColor";
            this.panelOutlineColor.Size = new System.Drawing.Size(139, 61);
            this.panelOutlineColor.TabIndex = 23;
            this.panelOutlineColor.Click += new System.EventHandler(this.panelOutlineColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(303, 60);
            this.panelColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(139, 60);
            this.panelColor.TabIndex = 22;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "边框宽度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "边框颜色：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "渲染颜色：";
            // 
            // FormPolygonSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 512);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.numOutlineSize);
            this.Controls.Add(this.panelOutlineColor);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPolygonSymbol";
            this.Text = "FormPolygonSymbol";
            ((System.ComponentModel.ISupportInitialize)(this.numOutlineSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.NumericUpDown numOutlineSize;
        private System.Windows.Forms.Panel panelOutlineColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}