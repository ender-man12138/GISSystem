namespace MapControlApplication2
{
    partial class FormLineSymbol
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.panelColor = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "渲染染色：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 151);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 19);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "大小：";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(155, 96);
            this.numSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(60, 21);
            this.numSize.TabIndex = 12;
            this.numSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor.Location = new System.Drawing.Point(155, 30);
            this.panelColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(37, 37);
            this.panelColor.TabIndex = 11;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // FormLineSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.panelColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLineSymbol";
            this.Text = "FormLineSymbol";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}