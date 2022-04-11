namespace Mensenteller_B3
{
    partial class CreateModifyModern
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
            this.PanelCreateModify1 = new System.Windows.Forms.Panel();
            this.PanelCreateModify2 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanelCreateModify = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FlowLayoutPanelCreateModify.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCreateModify1
            // 
            this.PanelCreateModify1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelCreateModify1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCreateModify1.Location = new System.Drawing.Point(200, 0);
            this.PanelCreateModify1.Name = "PanelCreateModify1";
            this.PanelCreateModify1.Size = new System.Drawing.Size(600, 100);
            this.PanelCreateModify1.TabIndex = 0;
            // 
            // PanelCreateModify2
            // 
            this.PanelCreateModify2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCreateModify2.Location = new System.Drawing.Point(0, 0);
            this.PanelCreateModify2.Name = "PanelCreateModify2";
            this.PanelCreateModify2.Size = new System.Drawing.Size(800, 450);
            this.PanelCreateModify2.TabIndex = 1;
            // 
            // FlowLayoutPanelCreateModify
            // 
            this.FlowLayoutPanelCreateModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanelCreateModify.Controls.Add(this.HeaderPanel);
            this.FlowLayoutPanelCreateModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanelCreateModify.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanelCreateModify.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanelCreateModify.Name = "FlowLayoutPanelCreateModify";
            this.FlowLayoutPanelCreateModify.Size = new System.Drawing.Size(200, 450);
            this.FlowLayoutPanelCreateModify.TabIndex = 2;
            this.FlowLayoutPanelCreateModify.WrapContents = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(200, 100);
            this.HeaderPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create/Modify";
            // 
            // CreateModifyModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PanelCreateModify1);
            this.Controls.Add(this.FlowLayoutPanelCreateModify);
            this.Controls.Add(this.PanelCreateModify2);
            this.Name = "CreateModifyModern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FlowLayoutPanelCreateModify.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCreateModify1;
        private System.Windows.Forms.Panel PanelCreateModify2;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelCreateModify;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
    }
}