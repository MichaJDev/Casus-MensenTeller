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
            this.components = new System.ComponentModel.Container();
            this.DgvSensorview = new System.Windows.Forms.DataGridView();
            this.dataSet_Sensor = new Mensenteller_B3.DataSet_Sensor();
            this.sensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorsTableAdapter = new Mensenteller_B3.DataSet_SensorTableAdapters.SensorsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSensorview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Sensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSensorview
            // 
            this.DgvSensorview.AutoGenerateColumns = false;
            this.DgvSensorview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSensorview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locatieIdDataGridViewTextBoxColumn});
            this.DgvSensorview.DataSource = this.sensorsBindingSource;
            this.DgvSensorview.Location = new System.Drawing.Point(77, 35);
            this.DgvSensorview.Name = "DgvSensorview";
            this.DgvSensorview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvSensorview.Size = new System.Drawing.Size(551, 150);
            this.DgvSensorview.TabIndex = 0;
            // 
            // dataSet_Sensor
            // 
            this.dataSet_Sensor.DataSetName = "DataSet_Sensor";
            this.dataSet_Sensor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorsBindingSource
            // 
            this.sensorsBindingSource.DataMember = "Sensors";
            this.sensorsBindingSource.DataSource = this.dataSet_Sensor;
            // 
            // sensorsTableAdapter
            // 
            this.sensorsTableAdapter.ClearBeforeFill = true;
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
            // locatieIdDataGridViewTextBoxColumn
            // 
            this.locatieIdDataGridViewTextBoxColumn.DataPropertyName = "LocatieId";
            this.locatieIdDataGridViewTextBoxColumn.HeaderText = "LocatieId";
            this.locatieIdDataGridViewTextBoxColumn.Name = "locatieIdDataGridViewTextBoxColumn";
            // 
            // SensorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvSensorview);
            this.Name = "SensorView";
            this.Text = "SensorView";
            this.Load += new System.EventHandler(this.SensorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSensorview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Sensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSensorview;
        private DataSet_Sensor dataSet_Sensor;
        private System.Windows.Forms.BindingSource sensorsBindingSource;
        private DataSet_SensorTableAdapters.SensorsTableAdapter sensorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatieIdDataGridViewTextBoxColumn;
    }
}