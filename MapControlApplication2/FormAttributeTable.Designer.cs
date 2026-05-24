namespace MapControlApplication2
{
    partial class FormAttributeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttributeTable));
            this.btnSelectedFeature = new System.Windows.Forms.ToolStrip();
            this.lblCount = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAllFeature = new System.Windows.Forms.ToolStripButton();
            this.btnSelected = new System.Windows.Forms.ToolStripButton();
            this.btnSelectedFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectedFeature
            // 
            this.btnSelectedFeature.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSelectedFeature.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.btnSelectedFeature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAllFeature,
            this.btnSelected,
            this.lblCount});
            this.btnSelectedFeature.Location = new System.Drawing.Point(0, 417);
            this.btnSelectedFeature.Name = "btnSelectedFeature";
            this.btnSelectedFeature.Size = new System.Drawing.Size(800, 33);
            this.btnSelectedFeature.TabIndex = 1;
            this.btnSelectedFeature.Text = "toolStrip1";
            this.btnSelectedFeature.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btnSelectedFeature_ItemClicked);
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(152, 28);
            this.lblCount.Text = "共*记录，选中*条";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(800, 417);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAllFeature
            // 
            this.btnAllFeature.Checked = true;
            this.btnAllFeature.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAllFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnAllFeature.Image")));
            this.btnAllFeature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllFeature.Name = "btnAllFeature";
            this.btnAllFeature.Size = new System.Drawing.Size(110, 28);
            this.btnAllFeature.Text = "全部要素";
            this.btnAllFeature.Click += new System.EventHandler(this.btnAllFeature_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnSelected.Image")));
            this.btnSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(110, 28);
            this.btnSelected.Text = "选中要素";
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // FormAttributeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelectedFeature);
            this.Name = "FormAttributeTable";
            this.Text = "FormAttributeTable";
            this.Load += new System.EventHandler(this.FormAttributeTable_Load);
            this.btnSelectedFeature.ResumeLayout(false);
            this.btnSelectedFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip btnSelectedFeature;
        private System.Windows.Forms.ToolStripButton btnAllFeature;
        private System.Windows.Forms.ToolStripButton btnSelected;
        private System.Windows.Forms.ToolStripLabel lblCount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}