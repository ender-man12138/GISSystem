namespace MapControlApplication2
{
    partial class FormBufferAnalysis
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
            this.comboBoxEdit1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBufferDistance = new System.Windows.Forms.TextBox();
            this.comboBoxEdit2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "图层选择：";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.FormattingEnabled = true;
            this.comboBoxEdit1.Location = new System.Drawing.Point(144, 72);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Size = new System.Drawing.Size(252, 26);
            this.comboBoxEdit1.TabIndex = 1;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "距离";
            // 
            // txtBufferDistance
            // 
            this.txtBufferDistance.Location = new System.Drawing.Point(144, 160);
            this.txtBufferDistance.Name = "txtBufferDistance";
            this.txtBufferDistance.Size = new System.Drawing.Size(128, 28);
            this.txtBufferDistance.TabIndex = 4;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.DisplayMember = "meters";
            this.comboBoxEdit2.FormattingEnabled = true;
            this.comboBoxEdit2.Items.AddRange(new object[] {
            "meters",
            "Kilometers",
            "Unknown"});
            this.comboBoxEdit2.Location = new System.Drawing.Point(292, 162);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Size = new System.Drawing.Size(154, 26);
            this.comboBoxEdit2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "输出路径";
            // 
            // OutputPath
            // 
            this.OutputPath.Location = new System.Drawing.Point(144, 244);
            this.OutputPath.Name = "OutputPath";
            this.OutputPath.Size = new System.Drawing.Size(252, 28);
            this.OutputPath.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(127, 323);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(72, 31);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormBufferAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 397);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OutputPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEdit2);
            this.Controls.Add(this.txtBufferDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label1);
            this.Name = "FormBufferAnalysis";
            this.Text = "FormBufferAnalysis";
            this.Load += new System.EventHandler(this.FormBufferAnalysis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEdit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBufferDistance;
        private System.Windows.Forms.ComboBox comboBoxEdit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button4;
    }
}