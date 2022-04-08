namespace Casus_Blok3_MensenTeller
{
    partial class Create_and_Modify
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgvCM = new System.Windows.Forms.DataGridView();
            this.AddbuttonCM = new System.Windows.Forms.Button();
            this.EditbuttonCM = new System.Windows.Forms.Button();
            this.DeletebuttonCM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCM)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(298, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\t\tCreate / Modify";
            // 
            // DgvCM
            // 
            this.DgvCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCM.Location = new System.Drawing.Point(467, 245);
            this.DgvCM.Name = "DgvCM";
            this.DgvCM.RowTemplate.Height = 25;
            this.DgvCM.Size = new System.Drawing.Size(367, 184);
            this.DgvCM.TabIndex = 1;
            // 
            // AddbuttonCM
            // 
            this.AddbuttonCM.Location = new System.Drawing.Point(450, 461);
            this.AddbuttonCM.Name = "AddbuttonCM";
            this.AddbuttonCM.Size = new System.Drawing.Size(75, 23);
            this.AddbuttonCM.TabIndex = 2;
            this.AddbuttonCM.Text = "Add";
            this.AddbuttonCM.UseVisualStyleBackColor = true;
            // 
            // EditbuttonCM
            // 
            this.EditbuttonCM.Location = new System.Drawing.Point(563, 463);
            this.EditbuttonCM.Name = "EditbuttonCM";
            this.EditbuttonCM.Size = new System.Drawing.Size(75, 23);
            this.EditbuttonCM.TabIndex = 3;
            this.EditbuttonCM.Text = "Edit";
            this.EditbuttonCM.UseVisualStyleBackColor = true;
            // 
            // DeletebuttonCM
            // 
            this.DeletebuttonCM.Location = new System.Drawing.Point(689, 460);
            this.DeletebuttonCM.Name = "DeletebuttonCM";
            this.DeletebuttonCM.Size = new System.Drawing.Size(75, 23);
            this.DeletebuttonCM.TabIndex = 4;
            this.DeletebuttonCM.Text = "Delete";
            this.DeletebuttonCM.UseVisualStyleBackColor = true;
            // 
            // Create_and_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.DeletebuttonCM);
            this.Controls.Add(this.EditbuttonCM);
            this.Controls.Add(this.AddbuttonCM);
            this.Controls.Add(this.DgvCM);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create_and_Modify";
            this.Text = "Create_and_Modify";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private DataGridView DgvCM;
        private Button AddbuttonCM;
        private Button EditbuttonCM;
        private Button DeletebuttonCM;
    }
}