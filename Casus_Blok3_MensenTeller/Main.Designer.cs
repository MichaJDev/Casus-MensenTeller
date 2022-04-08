namespace Casus_Blok3_MensenTeller
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMbutton = new System.Windows.Forms.Button();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMbutton
            // 
            this.CMbutton.Location = new System.Drawing.Point(336, 246);
            this.CMbutton.Name = "CMbutton";
            this.CMbutton.Size = new System.Drawing.Size(164, 39);
            this.CMbutton.TabIndex = 0;
            this.CMbutton.Text = "Create/Modify";
            this.CMbutton.UseVisualStyleBackColor = true;
            // 
            // Viewbutton
            // 
            this.Viewbutton.Location = new System.Drawing.Point(336, 329);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(161, 39);
            this.Viewbutton.TabIndex = 1;
            this.Viewbutton.Text = "View";
            this.Viewbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(293, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "\t\tMain";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 548);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Viewbutton);
            this.Controls.Add(this.CMbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CMbutton;
        private Button Viewbutton;
        private TextBox textBox1;
    }
}