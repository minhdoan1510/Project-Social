namespace fLogin
{
    partial class UCSearchBar
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
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pnlLbSearch = new System.Windows.Forms.Panel();
            this.lsvSearchView = new System.Windows.Forms.ListBox();
            this.pnlLbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(3, 7);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(202, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // pnlLbSearch
            // 
            this.pnlLbSearch.AutoSize = true;
            this.pnlLbSearch.Controls.Add(this.lsvSearchView);
            this.pnlLbSearch.Location = new System.Drawing.Point(3, 33);
            this.pnlLbSearch.Name = "pnlLbSearch";
            this.pnlLbSearch.Size = new System.Drawing.Size(202, 248);
            this.pnlLbSearch.TabIndex = 1;
            // 
            // lsvSearchView
            // 
            this.lsvSearchView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSearchView.FormattingEnabled = true;
            this.lsvSearchView.Location = new System.Drawing.Point(0, 0);
            this.lsvSearchView.Name = "lsvSearchView";
            this.lsvSearchView.Size = new System.Drawing.Size(202, 248);
            this.lsvSearchView.TabIndex = 0;
            // 
            // UCSearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlLbSearch);
            this.Controls.Add(this.txbSearch);
            this.Name = "UCSearchBar";
            this.Size = new System.Drawing.Size(208, 284);
            this.pnlLbSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Panel pnlLbSearch;
        private System.Windows.Forms.ListBox lsvSearchView;
    }
}
