namespace fLogin
{
    partial class UCCatalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain_Catalog = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain_Catalog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain_Catalog
            // 
            this.pnlMain_Catalog.Controls.Add(this.panel1);
            this.pnlMain_Catalog.Controls.Add(this.pnlSearch);
            this.pnlMain_Catalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain_Catalog.Location = new System.Drawing.Point(0, 0);
            this.pnlMain_Catalog.Name = "pnlMain_Catalog";
            this.pnlMain_Catalog.Size = new System.Drawing.Size(208, 591);
            this.pnlMain_Catalog.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.AutoSize = true;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(208, 30);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(208, 30);
            this.pnlSearch.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 400);
            this.panel1.TabIndex = 1;
            // 
            // UCCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain_Catalog);
            this.Name = "UCCatalog";
            this.Size = new System.Drawing.Size(208, 591);
            this.pnlMain_Catalog.ResumeLayout(false);
            this.pnlMain_Catalog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain_Catalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearch;
    }
}
