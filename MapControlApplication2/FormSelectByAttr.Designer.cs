namespace MapControlApplication2
{
    partial class FormSelectByAttr
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnGreater = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_blur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLayerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWhereClause = new System.Windows.Forms.TextBox();
            this.btn_statics = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "图层";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.ItemHeight = 18;
            this.lstFields.Location = new System.Drawing.Point(37, 84);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(243, 328);
            this.lstFields.TabIndex = 2;
            this.lstFields.DoubleClick += new System.EventHandler(this.lstFields_DoubleClick);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(20, 39);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 34);
            this.btnE.TabIndex = 3;
            this.btnE.Text = "=";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.Location = new System.Drawing.Point(119, 39);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(75, 34);
            this.btnAnd.TabIndex = 4;
            this.btnAnd.Text = "And";
            this.btnAnd.UseVisualStyleBackColor = true;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnGreater
            // 
            this.btnGreater.Location = new System.Drawing.Point(20, 98);
            this.btnGreater.Name = "btnGreater";
            this.btnGreater.Size = new System.Drawing.Size(75, 32);
            this.btnGreater.TabIndex = 5;
            this.btnGreater.Text = ">";
            this.btnGreater.UseVisualStyleBackColor = true;
            this.btnGreater.Click += new System.EventHandler(this.btnGreater_Click);
            // 
            // btnOr
            // 
            this.btnOr.Location = new System.Drawing.Point(119, 98);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(75, 32);
            this.btnOr.TabIndex = 6;
            this.btnOr.Text = "Or";
            this.btnOr.UseVisualStyleBackColor = true;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnLess
            // 
            this.btnLess.Location = new System.Drawing.Point(20, 159);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(75, 32);
            this.btnLess.TabIndex = 7;
            this.btnLess.Text = "<";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(20, 218);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(75, 35);
            this.btnNotEqual.TabIndex = 8;
            this.btnNotEqual.Text = "<>";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Location = new System.Drawing.Point(423, 302);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(75, 35);
            this.btnPercent.TabIndex = 9;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(20, 277);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 33);
            this.btnLike.TabIndex = 10;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(119, 277);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 33);
            this.btnQuote.TabIndex = 11;
            this.btnQuote.Text = "\'\'";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(60, 588);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 34);
            this.button10.TabIndex = 12;
            this.button10.Text = "清除";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(182, 588);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 34);
            this.button11.TabIndex = 13;
            this.button11.Text = "确定";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(423, 588);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 34);
            this.button12.TabIndex = 14;
            this.button12.Text = "取消";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_blur);
            this.groupBox1.Controls.Add(this.btnE);
            this.groupBox1.Controls.Add(this.btnAnd);
            this.groupBox1.Controls.Add(this.btnGreater);
            this.groupBox1.Controls.Add(this.btnQuote);
            this.groupBox1.Controls.Add(this.btnOr);
            this.groupBox1.Controls.Add(this.btnLike);
            this.groupBox1.Controls.Add(this.btnLess);
            this.groupBox1.Controls.Add(this.btnNotEqual);
            this.groupBox1.Location = new System.Drawing.Point(304, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 326);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运算符";
            // 
            // btn_blur
            // 
            this.btn_blur.Location = new System.Drawing.Point(119, 159);
            this.btn_blur.Name = "btn_blur";
            this.btn_blur.Size = new System.Drawing.Size(75, 32);
            this.btn_blur.TabIndex = 12;
            this.btn_blur.Text = "模糊查询";
            this.btn_blur.UseVisualStyleBackColor = true;
            this.btn_blur.Click += new System.EventHandler(this.btn_blur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "SELECT*FROM ";
            // 
            // lblLayerName
            // 
            this.lblLayerName.AutoSize = true;
            this.lblLayerName.Location = new System.Drawing.Point(179, 431);
            this.lblLayerName.Name = "lblLayerName";
            this.lblLayerName.Size = new System.Drawing.Size(80, 18);
            this.lblLayerName.TabIndex = 17;
            this.lblLayerName.Text = "图层名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "WHERE";
            // 
            // txtWhereClause
            // 
            this.txtWhereClause.Location = new System.Drawing.Point(37, 465);
            this.txtWhereClause.Multiline = true;
            this.txtWhereClause.Name = "txtWhereClause";
            this.txtWhereClause.Size = new System.Drawing.Size(461, 108);
            this.txtWhereClause.TabIndex = 19;
            this.txtWhereClause.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_statics
            // 
            this.btn_statics.Location = new System.Drawing.Point(304, 594);
            this.btn_statics.Name = "btn_statics";
            this.btn_statics.Size = new System.Drawing.Size(75, 23);
            this.btn_statics.TabIndex = 20;
            this.btn_statics.Text = "统计";
            this.btn_statics.UseVisualStyleBackColor = true;
            this.btn_statics.Click += new System.EventHandler(this.btn_statics_Click);
            // 
            // FormSelectByAttr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 643);
            this.Controls.Add(this.btn_statics);
            this.Controls.Add(this.txtWhereClause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSelectByAttr";
            this.Text = "根据属性查图形";
            this.Load += new System.EventHandler(this.FormSelectByAttr_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnGreater;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLayerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWhereClause;
        private System.Windows.Forms.Button btn_blur;
        private System.Windows.Forms.Button btn_statics;
    }
}