namespace Mensenteller_B3
{
    partial class View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusMensenButton = new System.Windows.Forms.Button();
            this.DgvSensorRead = new System.Windows.Forms.DataGridView();
            this.entryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet = new Mensenteller_B3.SensorDataDataSet();
            this.sensorReadingTableAdapter = new Mensenteller_B3.SensorDataDataSetTableAdapters.SensorReadingTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.enrtyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inUseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeStampDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureSensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet1 = new Mensenteller_B3.SensorDataDataSet1();
            this.pressureSensorsTableAdapter = new Mensenteller_B3.SensorDataDataSet1TableAdapters.PressureSensorsTableAdapter();
            this.Averagetextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSensorRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 207);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_paint);
            // 
            // StatusMensenButton
            // 
            this.StatusMensenButton.Location = new System.Drawing.Point(630, 57);
            this.StatusMensenButton.Name = "StatusMensenButton";
            this.StatusMensenButton.Size = new System.Drawing.Size(75, 23);
            this.StatusMensenButton.TabIndex = 1;
            this.StatusMensenButton.Text = "Status";
            this.StatusMensenButton.UseVisualStyleBackColor = true;
            this.StatusMensenButton.Click += new System.EventHandler(this.StatusMensenButton_Click);
            // 
            // DgvSensorRead
            // 
            this.DgvSensorRead.AllowUserToAddRows = false;
            this.DgvSensorRead.AllowUserToDeleteRows = false;
            this.DgvSensorRead.AutoGenerateColumns = false;
            this.DgvSensorRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSensorRead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryIdDataGridViewTextBoxColumn,
            this.sensorIdDataGridViewTextBoxColumn,
            this.peopleinDataGridViewTextBoxColumn,
            this.peopleoutDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn});
            this.DgvSensorRead.DataSource = this.sensorReadingBindingSource;
            this.DgvSensorRead.Location = new System.Drawing.Point(61, 256);
            this.DgvSensorRead.Name = "DgvSensorRead";
            this.DgvSensorRead.ReadOnly = true;
            this.DgvSensorRead.Size = new System.Drawing.Size(544, 150);
            this.DgvSensorRead.TabIndex = 2;
            this.DgvSensorRead.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSensorRead_CellContentClick);
            // 
            // entryIdDataGridViewTextBoxColumn
            // 
            this.entryIdDataGridViewTextBoxColumn.DataPropertyName = "EntryId";
            this.entryIdDataGridViewTextBoxColumn.HeaderText = "EntryId";
            this.entryIdDataGridViewTextBoxColumn.Name = "entryIdDataGridViewTextBoxColumn";
            this.entryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorIdDataGridViewTextBoxColumn
            // 
            this.sensorIdDataGridViewTextBoxColumn.DataPropertyName = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn.HeaderText = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn.Name = "sensorIdDataGridViewTextBoxColumn";
            this.sensorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleinDataGridViewTextBoxColumn
            // 
            this.peopleinDataGridViewTextBoxColumn.DataPropertyName = "People_in";
            this.peopleinDataGridViewTextBoxColumn.HeaderText = "People_in";
            this.peopleinDataGridViewTextBoxColumn.Name = "peopleinDataGridViewTextBoxColumn";
            this.peopleinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleoutDataGridViewTextBoxColumn
            // 
            this.peopleoutDataGridViewTextBoxColumn.DataPropertyName = "People_out";
            this.peopleoutDataGridViewTextBoxColumn.HeaderText = "People_out";
            this.peopleoutDataGridViewTextBoxColumn.Name = "peopleoutDataGridViewTextBoxColumn";
            this.peopleoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorReadingBindingSource
            // 
            this.sensorReadingBindingSource.DataMember = "SensorReading";
            this.sensorReadingBindingSource.DataSource = this.sensorDataDataSet;
            // 
            // sensorDataDataSet
            // 
            this.sensorDataDataSet.DataSetName = "SensorDataDataSet";
            this.sensorDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorReadingTableAdapter
            // 
            this.sensorReadingTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enrtyIdDataGridViewTextBoxColumn,
            this.sensorIdDataGridViewTextBoxColumn1,
            this.inUseDataGridViewCheckBoxColumn,
            this.timeStampDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pressureSensorsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(61, 424);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // enrtyIdDataGridViewTextBoxColumn
            // 
            this.enrtyIdDataGridViewTextBoxColumn.DataPropertyName = "EnrtyId";
            this.enrtyIdDataGridViewTextBoxColumn.HeaderText = "EnrtyId";
            this.enrtyIdDataGridViewTextBoxColumn.Name = "enrtyIdDataGridViewTextBoxColumn";
            this.enrtyIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorIdDataGridViewTextBoxColumn1
            // 
            this.sensorIdDataGridViewTextBoxColumn1.DataPropertyName = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn1.HeaderText = "SensorId";
            this.sensorIdDataGridViewTextBoxColumn1.Name = "sensorIdDataGridViewTextBoxColumn1";
            this.sensorIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inUseDataGridViewCheckBoxColumn
            // 
            this.inUseDataGridViewCheckBoxColumn.DataPropertyName = "InUse";
            this.inUseDataGridViewCheckBoxColumn.HeaderText = "InUse";
            this.inUseDataGridViewCheckBoxColumn.Name = "inUseDataGridViewCheckBoxColumn";
            this.inUseDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // timeStampDataGridViewTextBoxColumn1
            // 
            this.timeStampDataGridViewTextBoxColumn1.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn1.Name = "timeStampDataGridViewTextBoxColumn1";
            this.timeStampDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pressureSensorsBindingSource
            // 
            this.pressureSensorsBindingSource.DataMember = "PressureSensors";
            this.pressureSensorsBindingSource.DataSource = this.sensorDataDataSet1;
            // 
            // sensorDataDataSet1
            // 
            this.sensorDataDataSet1.DataSetName = "SensorDataDataSet1";
            this.sensorDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pressureSensorsTableAdapter
            // 
            this.pressureSensorsTableAdapter.ClearBeforeFill = true;
            // 
            // Averagetextbox
            // 
            this.Averagetextbox.Location = new System.Drawing.Point(504, 151);
            this.Averagetextbox.Name = "Averagetextbox";
            this.Averagetextbox.Size = new System.Drawing.Size(100, 20);
            this.Averagetextbox.TabIndex = 4;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 586);
            this.Controls.Add(this.Averagetextbox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.DgvSensorRead);
            this.Controls.Add(this.StatusMensenButton);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSensorRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StatusMensenButton;
        private System.Windows.Forms.DataGridView DgvSensorRead;
        private SensorDataDataSet sensorDataDataSet;
        private System.Windows.Forms.BindingSource sensorReadingBindingSource;
        private SensorDataDataSetTableAdapters.SensorReadingTableAdapter sensorReadingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SensorDataDataSet1 sensorDataDataSet1;
        private System.Windows.Forms.BindingSource pressureSensorsBindingSource;
        private SensorDataDataSet1TableAdapters.PressureSensorsTableAdapter pressureSensorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrtyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inUseDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox Averagetextbox;
    }
}