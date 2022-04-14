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
            this.components = new System.ComponentModel.Container();
            this.CreateZonebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Zones = new Mensenteller_B3.DataSet_Zones();
            this.zonesTableAdapter = new Mensenteller_B3.DataSet_ZonesTableAdapters.ZonesTableAdapter();
            this.CreateZonetextbox = new System.Windows.Forms.TextBox();
            this.EditZonebutton = new System.Windows.Forms.Button();
            this.IdZonetextbox = new System.Windows.Forms.TextBox();
            this.ZoneNameEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateZonebutton
            // 
            this.CreateZonebutton.Location = new System.Drawing.Point(37, 290);
            this.CreateZonebutton.Name = "CreateZonebutton";
            this.CreateZonebutton.Size = new System.Drawing.Size(75, 23);
            this.CreateZonebutton.TabIndex = 0;
            this.CreateZonebutton.Text = "Create";
            this.CreateZonebutton.UseVisualStyleBackColor = true;
            this.CreateZonebutton.Click += new System.EventHandler(this.CreateZonebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 233);
            this.dataGridView1.TabIndex = 1;
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataMember = "Zones";
            this.zonesBindingSource.DataSource = this.dataSet_Zones;
            // 
            // dataSet_Zones
            // 
            this.dataSet_Zones.DataSetName = "DataSet_Zones";
            this.dataSet_Zones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonesTableAdapter
            // 
            this.zonesTableAdapter.ClearBeforeFill = true;
            // 
            // CreateZonetextbox
            // 
            this.CreateZonetextbox.Location = new System.Drawing.Point(136, 293);
            this.CreateZonetextbox.Name = "CreateZonetextbox";
            this.CreateZonetextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateZonetextbox.TabIndex = 2;
            // 
            // EditZonebutton
            // 
            this.EditZonebutton.Location = new System.Drawing.Point(26, 347);
            this.EditZonebutton.Name = "EditZonebutton";
            this.EditZonebutton.Size = new System.Drawing.Size(75, 23);
            this.EditZonebutton.TabIndex = 3;
            this.EditZonebutton.Text = "Edit";
            this.EditZonebutton.UseVisualStyleBackColor = true;
            this.EditZonebutton.Click += new System.EventHandler(this.EditZonebutton_Click);
            // 
            // IdZonetextbox
            // 
            this.IdZonetextbox.Location = new System.Drawing.Point(121, 349);
            this.IdZonetextbox.Name = "IdZonetextbox";
            this.IdZonetextbox.Size = new System.Drawing.Size(100, 20);
            this.IdZonetextbox.TabIndex = 4;
            // 
            // ZoneNameEdit
            // 
            this.ZoneNameEdit.Location = new System.Drawing.Point(121, 385);
            this.ZoneNameEdit.Name = "ZoneNameEdit";
            this.ZoneNameEdit.Size = new System.Drawing.Size(100, 20);
            this.ZoneNameEdit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // CreateZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoneNameEdit);
            this.Controls.Add(this.IdZonetextbox);
            this.Controls.Add(this.EditZonebutton);
            this.Controls.Add(this.CreateZonetextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateZonebutton);
            this.Name = "CreateZones";
            this.Text = "CreateZones";
            this.Load += new System.EventHandler(this.CreateZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateZonebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_Zones dataSet_Zones;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private DataSet_ZonesTableAdapters.ZonesTableAdapter zonesTableAdapter;
        private System.Windows.Forms.TextBox CreateZonetextbox;
        private System.Windows.Forms.Button EditZonebutton;
        private System.Windows.Forms.TextBox IdZonetextbox;
        private System.Windows.Forms.TextBox ZoneNameEdit;
        private System.Windows.Forms.Label label1;
    }
}