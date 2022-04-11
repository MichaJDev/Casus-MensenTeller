namespace Mensenteller_B3
{
    partial class Main
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
            this.Createbedrijfbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Createbedrijfbut
            // 
            this.Createbedrijfbut.Location = new System.Drawing.Point(182, 105);
            this.Createbedrijfbut.Name = "Createbedrijfbut";
            this.Createbedrijfbut.Size = new System.Drawing.Size(75, 23);
            this.Createbedrijfbut.TabIndex = 0;
            this.Createbedrijfbut.Text = "Create Bedrijf (T)";
            this.Createbedrijfbut.UseVisualStyleBackColor = true;
            this.Createbedrijfbut.Click += new System.EventHandler(this.Createbedrijfbut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Createbedrijfbut);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Createbedrijfbut;
    }
}