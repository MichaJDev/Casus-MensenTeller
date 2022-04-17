namespace Mensenteller_B3
{
    partial class CreateZones
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
            this.DgvCreateZone = new System.Windows.Forms.DataGridView();
            this.CreateZonebutton = new System.Windows.Forms.Button();
            this.EditZonebutton = new System.Windows.Forms.Button();
            this.CreateZoneNatextbox = new System.Windows.Forms.TextBox();
            this.ZoneEditIdtextbox = new System.Windows.Forms.TextBox();
            this.ZoneNaamEdittextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateZone)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCreateZone
            // 
            this.DgvCreateZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreateZone.Location = new System.Drawing.Point(0, 0);
            this.DgvCreateZone.Name = "DgvCreateZone";
            this.DgvCreateZone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreateZone.Size = new System.Drawing.Size(799, 191);
            this.DgvCreateZone.TabIndex = 0;
            // 
            // CreateZonebutton
            // 
            this.CreateZonebutton.Location = new System.Drawing.Point(582, 197);
            this.CreateZonebutton.Name = "CreateZonebutton";
            this.CreateZonebutton.Size = new System.Drawing.Size(217, 74);
            this.CreateZonebutton.TabIndex = 1;
            this.CreateZonebutton.Text = "Create";
            this.CreateZonebutton.UseVisualStyleBackColor = true;
            this.CreateZonebutton.Click += new System.EventHandler(this.CreateZonebutton_Click);
            // 
            // EditZonebutton
            // 
            this.EditZonebutton.Location = new System.Drawing.Point(582, 357);
            this.EditZonebutton.Name = "EditZonebutton";
            this.EditZonebutton.Size = new System.Drawing.Size(217, 81);
            this.EditZonebutton.TabIndex = 2;
            this.EditZonebutton.Text = "Edit";
            this.EditZonebutton.UseVisualStyleBackColor = true;
            this.EditZonebutton.Click += new System.EventHandler(this.EditZonebutton_Click);
            // 
            // CreateZoneNatextbox
            // 
            this.CreateZoneNatextbox.Location = new System.Drawing.Point(48, 233);
            this.CreateZoneNatextbox.Name = "CreateZoneNatextbox";
            this.CreateZoneNatextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateZoneNatextbox.TabIndex = 3;
            // 
            // ZoneEditIdtextbox
            // 
            this.ZoneEditIdtextbox.Location = new System.Drawing.Point(48, 328);
            this.ZoneEditIdtextbox.Name = "ZoneEditIdtextbox";
            this.ZoneEditIdtextbox.Size = new System.Drawing.Size(100, 20);
            this.ZoneEditIdtextbox.TabIndex = 4;
            // 
            // ZoneNaamEdittextbox
            // 
            this.ZoneNaamEdittextbox.Location = new System.Drawing.Point(48, 357);
            this.ZoneNaamEdittextbox.Name = "ZoneNaamEdittextbox";
            this.ZoneNaamEdittextbox.Size = new System.Drawing.Size(100, 20);
            this.ZoneNaamEdittextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam Create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID zone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naam zone";
            // 
            // CreateZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoneNaamEdittextbox);
            this.Controls.Add(this.ZoneEditIdtextbox);
            this.Controls.Add(this.CreateZoneNatextbox);
            this.Controls.Add(this.EditZonebutton);
            this.Controls.Add(this.CreateZonebutton);
            this.Controls.Add(this.DgvCreateZone);
            this.Name = "CreateZones";
            this.Text = "CreateZone";
            this.Load += new System.EventHandler(this.CreateZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCreateZone;
        private System.Windows.Forms.Button CreateZonebutton;
        private System.Windows.Forms.Button EditZonebutton;
        private System.Windows.Forms.TextBox CreateZoneNatextbox;
        private System.Windows.Forms.TextBox ZoneEditIdtextbox;
        private System.Windows.Forms.TextBox ZoneNaamEdittextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}