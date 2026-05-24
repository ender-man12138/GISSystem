namespace MapControlApplication2
{
    partial class AddPoint
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
            this.comboBox_feature = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_longtitude = new System.Windows.Forms.TextBox();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择图层：";
            // 
            // comboBox_feature
            // 
            this.comboBox_feature.FormattingEnabled = true;
            this.comboBox_feature.Location = new System.Drawing.Point(448, 26);
            this.comboBox_feature.Name = "comboBox_feature";
            this.comboBox_feature.Size = new System.Drawing.Size(121, 26);
            this.comboBox_feature.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "经度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "纬度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "名称：";
            // 
            // textBox_longtitude
            // 
            this.textBox_longtitude.Location = new System.Drawing.Point(448, 112);
            this.textBox_longtitude.Name = "textBox_longtitude";
            this.textBox_longtitude.Size = new System.Drawing.Size(100, 28);
            this.textBox_longtitude.TabIndex = 5;
            // 
            // textBox_latitude
            // 
            this.textBox_latitude.Location = new System.Drawing.Point(448, 218);
            this.textBox_latitude.Name = "textBox_latitude";
            this.textBox_latitude.Size = new System.Drawing.Size(100, 28);
            this.textBox_latitude.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(448, 338);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 28);
            this.textBox_name.TabIndex = 7;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(464, 449);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // AddPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_latitude);
            this.Controls.Add(this.textBox_longtitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_feature);
            this.Controls.Add(this.label1);
            this.Name = "AddPoint";
            this.Text = "AddPoint";
            this.Load += new System.EventHandler(this.AddPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_feature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_longtitude;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button btn_ok;
    }
}