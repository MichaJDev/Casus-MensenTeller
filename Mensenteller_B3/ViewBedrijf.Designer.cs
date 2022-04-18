namespace Mensenteller_B3
{
    partial class ViewBedrijf
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
            this.DgvBedrijfview = new System.Windows.Forms.DataGridView();
            this.BedrijfView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBedrijfview
            // 
            this.DgvBedrijfview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBedrijfview.Location = new System.Drawing.Point(67, 42);
            this.DgvBedrijfview.Name = "DgvBedrijfview";
            this.DgvBedrijfview.Size = new System.Drawing.Size(615, 150);
            this.DgvBedrijfview.TabIndex = 0;
            this.DgvBedrijfview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBedrijfview_CellContentClick);
            // 
            // BedrijfView
            // 
            this.BedrijfView.Location = new System.Drawing.Point(67, 270);
            this.BedrijfView.Name = "BedrijfView";
            this.BedrijfView.Size = new System.Drawing.Size(75, 23);
            this.BedrijfView.TabIndex = 1;
            this.BedrijfView.Text = "View";
            this.BedrijfView.UseVisualStyleBackColor = true;
            this.BedrijfView.Click += new System.EventHandler(this.BedrijfView_Click);
            // 
            // ViewBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BedrijfView);
            this.Controls.Add(this.DgvBedrijfview);
            this.Name = "ViewBedrijf";
            this.Text = "ViewBedrijf";
            this.Load += new System.EventHandler(this.ViewBedrijf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBedrijfview;
        private System.Windows.Forms.Button BedrijfView;
    }
}