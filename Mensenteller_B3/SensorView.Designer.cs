namespace Mensenteller_B3
{
    partial class SensorView
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
            this.SensorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SensorLabel
            // 
            this.SensorLabel.AutoSize = true;
            this.SensorLabel.Location = new System.Drawing.Point(228, 130);
            this.SensorLabel.Name = "SensorLabel";
            this.SensorLabel.Size = new System.Drawing.Size(35, 13);
            this.SensorLabel.TabIndex = 0;
            this.SensorLabel.Text = "label1";
            this.SensorLabel.Click += new System.EventHandler(this.SensorLabel_Click);
            // 
            // SensorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SensorLabel);
            this.Name = "SensorView";
            this.Text = "SensorView";
            this.Load += new System.EventHandler(this.SensorView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SensorLabel;
    }
}