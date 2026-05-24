namespace MapControlApplication2
{
    partial class AttributeForm
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
            this.AttrituteForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AttrituteForm)).BeginInit();
            this.SuspendLayout();
            // 
            // AttrituteForm
            // 
            this.AttrituteForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttrituteForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttrituteForm.Location = new System.Drawing.Point(0, 0);
            this.AttrituteForm.Name = "AttrituteForm";
            this.AttrituteForm.RowHeadersWidth = 62;
            this.AttrituteForm.RowTemplate.Height = 30;
            this.AttrituteForm.Size = new System.Drawing.Size(800, 450);
            this.AttrituteForm.TabIndex = 0;
            // 
            // AttributeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AttrituteForm);
            this.Name = "AttributeForm";
            this.Text = "打开属性表";
            this.Load += new System.EventHandler(this.AttributeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttrituteForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AttrituteForm;
    }
}