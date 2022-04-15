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
            this.DgvviewLocatie = new System.Windows.Forms.DataGridView();
            this.ViewLocatieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvviewLocatie)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvviewLocatie
            // 
            this.DgvviewLocatie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvviewLocatie.Location = new System.Drawing.Point(69, 32);
            this.DgvviewLocatie.Name = "DgvviewLocatie";
            this.DgvviewLocatie.Size = new System.Drawing.Size(484, 150);
            this.DgvviewLocatie.TabIndex = 0;
            this.DgvviewLocatie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvviewLocatie_CellContentClick);
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
            // ViewLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewLocatieButton);
            this.Controls.Add(this.DgvviewLocatie);
            this.Name = "ViewLocatie";
            this.Text = "ViewLocatie";
            this.Load += new System.EventHandler(this.ViewLocatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvviewLocatie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvviewLocatie;
        private System.Windows.Forms.Button ViewLocatieButton;
    }
}