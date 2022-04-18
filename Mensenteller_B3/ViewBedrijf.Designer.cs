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
            this.lblBedrijf = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
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
            // lblBedrijf
            // 
            this.lblBedrijf.AutoSize = true;
            this.lblBedrijf.Location = new System.Drawing.Point(730, 42);
            this.lblBedrijf.Name = "lblBedrijf";
            this.lblBedrijf.Size = new System.Drawing.Size(35, 13);
            this.lblBedrijf.TabIndex = 2;
            this.lblBedrijf.Text = "label1";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(726, 55);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(124, 42);
            this.lblStats.TabIndex = 3;
            this.lblStats.Text = "label2";
            // 
            // ViewBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblBedrijf);
            this.Controls.Add(this.BedrijfView);
            this.Controls.Add(this.DgvBedrijfview);
            this.Name = "ViewBedrijf";
            this.Text = "ViewBedrijf";
            this.Load += new System.EventHandler(this.ViewBedrijf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBedrijfview;
        private System.Windows.Forms.Button BedrijfView;
        private System.Windows.Forms.Label lblBedrijf;
        private System.Windows.Forms.Label lblStats;
    }
}