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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Bedrijvenview = new Mensenteller_B3.DataSet_Bedrijvenview();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet = new Mensenteller_B3.SensorDataDataSet();
            this.sensorReadingTableAdapter = new Mensenteller_B3.SensorDataDataSetTableAdapters.SensorReadingTableAdapter();
            this.pressureSensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorDataDataSet1 = new Mensenteller_B3.SensorDataDataSet1();
            this.pressureSensorsTableAdapter = new Mensenteller_B3.SensorDataDataSet1TableAdapters.PressureSensorsTableAdapter();
            this.Averagetextbox = new System.Windows.Forms.TextBox();
            this.BedrijfViewbutton = new System.Windows.Forms.Button();
            this.bedrijvenTableAdapter = new Mensenteller_B3.DataSet_BedrijvenviewTableAdapters.BedrijvenTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Bedrijvenview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 207);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_paint);
            // 
            // StatusMensenButton
            // 
            this.StatusMensenButton.Location = new System.Drawing.Point(623, 289);
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgvBedrijfview.DataSource = this.bedrijvenBindingSource1;
            this.DgvBedrijfview.Location = new System.Drawing.Point(623, 3);
            this.DgvBedrijfview.Name = "DgvBedrijfview";
            this.DgvBedrijfview.ReadOnly = true;
            this.DgvBedrijfview.Size = new System.Drawing.Size(544, 150);
            this.DgvBedrijfview.TabIndex = 2;
            this.DgvBedrijfview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSensorRead_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bedrijvenBindingSource1
            // 
            this.bedrijvenBindingSource1.DataMember = "Bedrijven";
            this.bedrijvenBindingSource1.DataSource = this.dataSet_Bedrijvenview;
            // 
            // dataSet_Bedrijvenview
            // 
            this.dataSet_Bedrijvenview.DataSetName = "DataSet_Bedrijvenview";
            this.dataSet_Bedrijvenview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
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
            this.Averagetextbox.Location = new System.Drawing.Point(3, 289);
            this.Averagetextbox.Name = "Averagetextbox";
            this.Averagetextbox.Size = new System.Drawing.Size(100, 20);
            this.Averagetextbox.TabIndex = 4;
            // 
            // BedrijfViewbutton
            // 
            this.BedrijfViewbutton.Location = new System.Drawing.Point(623, 575);
            this.BedrijfViewbutton.Name = "BedrijfViewbutton";
            this.BedrijfViewbutton.Size = new System.Drawing.Size(75, 23);
            this.BedrijfViewbutton.TabIndex = 5;
            this.BedrijfViewbutton.Text = "View";
            this.BedrijfViewbutton.UseVisualStyleBackColor = true;
            this.BedrijfViewbutton.Click += new System.EventHandler(this.BedrijfViewbutton_Click);
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgvBedrijfview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BedrijfViewbutton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusMensenButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Averagetextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 657);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ButtonDone
            // 
            this.ButtonDone.Location = new System.Drawing.Point(623, 638);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(75, 16);
            this.ButtonDone.TabIndex = 6;
            this.ButtonDone.Text = "Done";
            this.ButtonDone.UseVisualStyleBackColor = true;
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Bedrijvenview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureSensorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        //private DataSet_bedrijvenview dataSet_bedrijvenview;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        //private DataSet_bedrijvenviewTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataSet_Bedrijvenview dataSet_Bedrijvenview;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource1;
        private DataSet_BedrijvenviewTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonDone;
    }
}