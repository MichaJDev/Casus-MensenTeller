namespace Mensenteller_B3
{
    partial class ViewZone
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
            this.DgvZoneview = new System.Windows.Forms.DataGridView();
            this.ViewZonebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZoneview)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvZoneview
            // 
            this.DgvZoneview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvZoneview.Location = new System.Drawing.Point(68, 32);
            this.DgvZoneview.Name = "DgvZoneview";
            this.DgvZoneview.Size = new System.Drawing.Size(544, 150);
            this.DgvZoneview.TabIndex = 0;
            // 
            // ViewZonebutton
            // 
            this.ViewZonebutton.Location = new System.Drawing.Point(125, 292);
            this.ViewZonebutton.Name = "ViewZonebutton";
            this.ViewZonebutton.Size = new System.Drawing.Size(75, 23);
            this.ViewZonebutton.TabIndex = 1;
            this.ViewZonebutton.Text = "View";
            this.ViewZonebutton.UseVisualStyleBackColor = true;
            this.ViewZonebutton.Click += new System.EventHandler(this.ViewZonebutton_Click);
            // 
            // ViewZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ViewZonebutton);
            this.Controls.Add(this.DgvZoneview);
            this.Name = "ViewZone";
            this.Text = "ViewZone";
            this.Load += new System.EventHandler(this.ViewZone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvZoneview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvZoneview;
        private System.Windows.Forms.Button ViewZonebutton;
    }
}