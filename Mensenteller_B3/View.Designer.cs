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
            this.DgvBedrijfview = new System.Windows.Forms.DataGridView();
            this.sensorReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet = new Mensenteller_B3.SensorDataDataSet();
            this.sensorReadingTableAdapter = new Mensenteller_B3.SensorDataDataSetTableAdapters.SensorReadingTableAdapter();
            this.pressureSensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet1 = new Mensenteller_B3.SensorDataDataSet1();
            this.pressureSensorsTableAdapter = new Mensenteller_B3.SensorDataDataSet1TableAdapters.PressureSensorsTableAdapter();
            this.Averagetextbox = new System.Windows.Forms.TextBox();
            this.BedrijfViewbutton = new System.Windows.Forms.Button();
            this.dataSet_bedrijvenview = new Mensenteller_B3.DataSet_bedrijvenview();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedrijvenTableAdapter = new Mensenteller_B3.DataSet_bedrijvenviewTableAdapters.BedrijvenTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_bedrijvenview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
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
            // DgvBedrijfview
            // 
            this.DgvBedrijfview.AllowUserToAddRows = false;
            this.DgvBedrijfview.AllowUserToDeleteRows = false;
            this.DgvBedrijfview.AutoGenerateColumns = false;
            this.DgvBedrijfview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBedrijfview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DgvBedrijfview.DataSource = this.bedrijvenBindingSource;
            this.DgvBedrijfview.Location = new System.Drawing.Point(61, 256);
            this.DgvBedrijfview.Name = "DgvBedrijfview";
            this.DgvBedrijfview.ReadOnly = true;
            this.DgvBedrijfview.Size = new System.Drawing.Size(544, 150);
            this.DgvBedrijfview.TabIndex = 2;
            this.DgvBedrijfview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSensorRead_CellContentClick);
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
            // BedrijfViewbutton
            // 
            this.BedrijfViewbutton.Location = new System.Drawing.Point(728, 314);
            this.BedrijfViewbutton.Name = "BedrijfViewbutton";
            this.BedrijfViewbutton.Size = new System.Drawing.Size(75, 23);
            this.BedrijfViewbutton.TabIndex = 5;
            this.BedrijfViewbutton.Text = "View";
            this.BedrijfViewbutton.UseVisualStyleBackColor = true;
            this.BedrijfViewbutton.Click += new System.EventHandler(this.BedrijfViewbutton_Click);
            // 
            // dataSet_bedrijvenview
            // 
            this.dataSet_bedrijvenview.DataSetName = "DataSet_bedrijvenview";
            this.dataSet_bedrijvenview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.dataSet_bedrijvenview;
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 586);
            this.Controls.Add(this.BedrijfViewbutton);
            this.Controls.Add(this.Averagetextbox);
            this.Controls.Add(this.DgvBedrijfview);
            this.Controls.Add(this.StatusMensenButton);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_bedrijvenview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StatusMensenButton;
        private System.Windows.Forms.DataGridView DgvBedrijfview;
        private SensorDataDataSet sensorDataDataSet;
        private System.Windows.Forms.BindingSource sensorReadingBindingSource;
        private SensorDataDataSetTableAdapters.SensorReadingTableAdapter sensorReadingTableAdapter;
        private SensorDataDataSet1 sensorDataDataSet1;
        private System.Windows.Forms.BindingSource pressureSensorsBindingSource;
        private SensorDataDataSet1TableAdapters.PressureSensorsTableAdapter pressureSensorsTableAdapter;
        private System.Windows.Forms.TextBox Averagetextbox;
        private System.Windows.Forms.Button BedrijfViewbutton;
        private DataSet_bedrijvenview dataSet_bedrijvenview;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        private DataSet_bedrijvenviewTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}