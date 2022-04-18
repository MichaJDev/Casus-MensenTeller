namespace Mensenteller_B3
{
    partial class ViewLocatie
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
            this.DvgEntreeSensors = new System.Windows.Forms.DataGridView();
            this.ViewLocatieButton = new System.Windows.Forms.Button();
            this.DvgDrukSensors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DvgEntreeSensors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDrukSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgEntreeSensors
            // 
            this.DvgEntreeSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgEntreeSensors.Location = new System.Drawing.Point(45, 26);
            this.DvgEntreeSensors.Name = "DvgEntreeSensors";
            this.DvgEntreeSensors.Size = new System.Drawing.Size(334, 157);
            this.DvgEntreeSensors.TabIndex = 0;
            this.DvgEntreeSensors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvviewLocatie_CellContentClick);
            // 
            // ViewLocatieButton
            // 
            this.ViewLocatieButton.Location = new System.Drawing.Point(130, 315);
            this.ViewLocatieButton.Name = "ViewLocatieButton";
            this.ViewLocatieButton.Size = new System.Drawing.Size(75, 23);
            this.ViewLocatieButton.TabIndex = 1;
            this.ViewLocatieButton.Text = "View";
            this.ViewLocatieButton.UseVisualStyleBackColor = true;
            this.ViewLocatieButton.Click += new System.EventHandler(this.ViewLocatieButton_Click);
            // 
            // DvgDrukSensors
            // 
            this.DvgDrukSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgDrukSensors.Location = new System.Drawing.Point(428, 26);
            this.DvgDrukSensors.Name = "DvgDrukSensors";
            this.DvgDrukSensors.Size = new System.Drawing.Size(334, 157);
            this.DvgDrukSensors.TabIndex = 2;
            // 
            // ViewLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DvgDrukSensors);
            this.Controls.Add(this.ViewLocatieButton);
            this.Controls.Add(this.DvgEntreeSensors);
            this.Name = "ViewLocatie";
            this.Text = "ViewLocatie";
            this.Load += new System.EventHandler(this.ViewLocatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgEntreeSensors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DvgDrukSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgEntreeSensors;
        private System.Windows.Forms.Button ViewLocatieButton;
        private System.Windows.Forms.DataGridView DvgDrukSensors;
    }
}