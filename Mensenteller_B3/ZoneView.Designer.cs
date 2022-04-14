namespace Mensenteller_B3
{
    partial class ZoneView
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
            this.DgvZoneview = new System.Windows.Forms.DataGridView();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Zones1 = new Mensenteller_B3.DataSet_Zones1();
            this.ZoneViewButton = new System.Windows.Forms.Button();
            this.zonesTableAdapter = new Mensenteller_B3.DataSet_Zones1TableAdapters.ZonesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZoneview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvZoneview
            // 
            this.DgvZoneview.AutoGenerateColumns = false;
            this.DgvZoneview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvZoneview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bedrijvenIdDataGridViewTextBoxColumn});
            this.DgvZoneview.DataSource = this.zonesBindingSource;
            this.DgvZoneview.Location = new System.Drawing.Point(12, 46);
            this.DgvZoneview.Name = "DgvZoneview";
            this.DgvZoneview.Size = new System.Drawing.Size(715, 150);
            this.DgvZoneview.TabIndex = 0;
            this.DgvZoneview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZoneview_CellContentClick);
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataMember = "Zones";
            this.zonesBindingSource.DataSource = this.dataSet_Zones1;
            // 
            // dataSet_Zones1
            // 
            this.dataSet_Zones1.DataSetName = "DataSet_Zones1";
            this.dataSet_Zones1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ZoneViewButton
            // 
            this.ZoneViewButton.Location = new System.Drawing.Point(78, 285);
            this.ZoneViewButton.Name = "ZoneViewButton";
            this.ZoneViewButton.Size = new System.Drawing.Size(75, 23);
            this.ZoneViewButton.TabIndex = 1;
            this.ZoneViewButton.Text = "View";
            this.ZoneViewButton.UseVisualStyleBackColor = true;
            this.ZoneViewButton.Click += new System.EventHandler(this.ZoneViewButton_Click);
            // 
            // zonesTableAdapter
            // 
            this.zonesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // bedrijvenIdDataGridViewTextBoxColumn
            // 
            this.bedrijvenIdDataGridViewTextBoxColumn.DataPropertyName = "BedrijvenId";
            this.bedrijvenIdDataGridViewTextBoxColumn.HeaderText = "BedrijvenId";
            this.bedrijvenIdDataGridViewTextBoxColumn.Name = "bedrijvenIdDataGridViewTextBoxColumn";
            // 
            // ZoneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZoneViewButton);
            this.Controls.Add(this.DgvZoneview);
            this.Name = "ZoneView";
            this.Text = "ZoneView";
            this.Load += new System.EventHandler(this.ZoneView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvZoneview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvZoneview;
        private System.Windows.Forms.Button ZoneViewButton;
        private DataSet_Zones1 dataSet_Zones1;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private DataSet_Zones1TableAdapters.ZonesTableAdapter zonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijvenIdDataGridViewTextBoxColumn;
    }
}