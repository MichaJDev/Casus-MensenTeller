namespace Mensenteller_B3
{
    partial class CreateSensor
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
            this.DgvCreateSensor = new System.Windows.Forms.DataGridView();
            this.CreateSensorbutton = new System.Windows.Forms.Button();
            this.EditSensorbutton = new System.Windows.Forms.Button();
            this.CreatSensorNatextbox = new System.Windows.Forms.TextBox();
            this.SensorIdtextbox = new System.Windows.Forms.TextBox();
            this.EditNaamsensortextbox = new System.Windows.Forms.TextBox();
            this.TLPSensor = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelComboBox = new System.Windows.Forms.Label();
            this.TLPCheckBox = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBoxEntree = new System.Windows.Forms.CheckBox();
            this.CheckBoxDruk = new System.Windows.Forms.CheckBox();
            this.LabelSensorType = new System.Windows.Forms.Label();
            this.LabelSensorNaam = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelEditId = new System.Windows.Forms.Label();
            this.LabelEditSensorNaam = new System.Windows.Forms.Label();
            this.ButtonDone = new System.Windows.Forms.Button();
            this.dataSet_Sensors123 = new Mensenteller_B3.DataSet_Sensors123();
            this.sensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorsTableAdapter = new Mensenteller_B3.DataSet_Sensors123TableAdapters.SensorsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateSensor)).BeginInit();
            this.TLPSensor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TLPCheckBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Sensors123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCreateSensor
            // 
            this.DgvCreateSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCreateSensor.AutoGenerateColumns = false;
            this.DgvCreateSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreateSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locatieIdDataGridViewTextBoxColumn});
            this.DgvCreateSensor.DataSource = this.sensorsBindingSource;
            this.DgvCreateSensor.Location = new System.Drawing.Point(3, 3);
            this.DgvCreateSensor.Name = "DgvCreateSensor";
            this.DgvCreateSensor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreateSensor.Size = new System.Drawing.Size(1234, 322);
            this.DgvCreateSensor.TabIndex = 0;
            // 
            // CreateSensorbutton
            // 
            this.CreateSensorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateSensorbutton.AutoSize = true;
            this.CreateSensorbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateSensorbutton.Location = new System.Drawing.Point(620, 3);
            this.CreateSensorbutton.Name = "CreateSensorbutton";
            this.CreateSensorbutton.Size = new System.Drawing.Size(611, 138);
            this.CreateSensorbutton.TabIndex = 1;
            this.CreateSensorbutton.Text = "Create";
            this.CreateSensorbutton.UseVisualStyleBackColor = true;
            this.CreateSensorbutton.Click += new System.EventHandler(this.CreateSensorbutton_Click);
            // 
            // EditSensorbutton
            // 
            this.EditSensorbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditSensorbutton.AutoSize = true;
            this.EditSensorbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditSensorbutton.Location = new System.Drawing.Point(620, 147);
            this.EditSensorbutton.Name = "EditSensorbutton";
            this.EditSensorbutton.Size = new System.Drawing.Size(611, 113);
            this.EditSensorbutton.TabIndex = 2;
            this.EditSensorbutton.Text = "Edit";
            this.EditSensorbutton.UseVisualStyleBackColor = true;
            this.EditSensorbutton.Click += new System.EventHandler(this.EditSensorbutton_Click);
            // 
            // CreatSensorNatextbox
            // 
            this.CreatSensorNatextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatSensorNatextbox.Location = new System.Drawing.Point(308, 13);
            this.CreatSensorNatextbox.Name = "CreatSensorNatextbox";
            this.CreatSensorNatextbox.Size = new System.Drawing.Size(300, 20);
            this.CreatSensorNatextbox.TabIndex = 3;
            // 
            // SensorIdtextbox
            // 
            this.SensorIdtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SensorIdtextbox.Location = new System.Drawing.Point(308, 74);
            this.SensorIdtextbox.Name = "SensorIdtextbox";
            this.SensorIdtextbox.Size = new System.Drawing.Size(300, 20);
            this.SensorIdtextbox.TabIndex = 4;
            // 
            // EditNaamsensortextbox
            // 
            this.EditNaamsensortextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditNaamsensortextbox.Location = new System.Drawing.Point(308, 18);
            this.EditNaamsensortextbox.Name = "EditNaamsensortextbox";
            this.EditNaamsensortextbox.Size = new System.Drawing.Size(300, 20);
            this.EditNaamsensortextbox.TabIndex = 5;
            // 
            // TLPSensor
            // 
            this.TLPSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPSensor.AutoSize = true;
            this.TLPSensor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPSensor.ColumnCount = 1;
            this.TLPSensor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPSensor.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.TLPSensor.Controls.Add(this.DgvCreateSensor, 0, 0);
            this.TLPSensor.Location = new System.Drawing.Point(12, 12);
            this.TLPSensor.Name = "TLPSensor";
            this.TLPSensor.RowCount = 2;
            this.TLPSensor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPSensor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPSensor.Size = new System.Drawing.Size(1240, 656);
            this.TLPSensor.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CreateSensorbutton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EditSensorbutton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonDone, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1234, 322);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelComboBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TLPCheckBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CreatSensorNatextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelSensorType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelSensorNaam, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboBox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 138);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // LabelComboBox
            // 
            this.LabelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelComboBox.AutoSize = true;
            this.LabelComboBox.Location = new System.Drawing.Point(3, 92);
            this.LabelComboBox.Name = "LabelComboBox";
            this.LabelComboBox.Size = new System.Drawing.Size(299, 46);
            this.LabelComboBox.TabIndex = 10;
            this.LabelComboBox.Text = "Sensor Id:";
            this.LabelComboBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLPCheckBox
            // 
            this.TLPCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPCheckBox.AutoSize = true;
            this.TLPCheckBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPCheckBox.ColumnCount = 2;
            this.TLPCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCheckBox.Controls.Add(this.CheckBoxEntree, 0, 0);
            this.TLPCheckBox.Controls.Add(this.CheckBoxDruk, 1, 0);
            this.TLPCheckBox.Location = new System.Drawing.Point(308, 49);
            this.TLPCheckBox.Name = "TLPCheckBox";
            this.TLPCheckBox.RowCount = 1;
            this.TLPCheckBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPCheckBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPCheckBox.Size = new System.Drawing.Size(300, 40);
            this.TLPCheckBox.TabIndex = 8;
            // 
            // CheckBoxEntree
            // 
            this.CheckBoxEntree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxEntree.AutoSize = true;
            this.CheckBoxEntree.Location = new System.Drawing.Point(3, 3);
            this.CheckBoxEntree.Name = "CheckBoxEntree";
            this.CheckBoxEntree.Size = new System.Drawing.Size(144, 34);
            this.CheckBoxEntree.TabIndex = 11;
            this.CheckBoxEntree.Text = "EntreeSens";
            this.CheckBoxEntree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxEntree.UseVisualStyleBackColor = true;
            this.CheckBoxEntree.CheckedChanged += new System.EventHandler(this.CheckBoxEntree_CheckedChanged);
            // 
            // CheckBoxDruk
            // 
            this.CheckBoxDruk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxDruk.AutoSize = true;
            this.CheckBoxDruk.Location = new System.Drawing.Point(153, 3);
            this.CheckBoxDruk.Name = "CheckBoxDruk";
            this.CheckBoxDruk.Size = new System.Drawing.Size(144, 34);
            this.CheckBoxDruk.TabIndex = 12;
            this.CheckBoxDruk.Text = "DrukSens";
            this.CheckBoxDruk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxDruk.UseVisualStyleBackColor = true;
            this.CheckBoxDruk.CheckedChanged += new System.EventHandler(this.CheckBoxDruk_CheckedChanged);
            // 
            // LabelSensorType
            // 
            this.LabelSensorType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSensorType.AutoSize = true;
            this.LabelSensorType.Location = new System.Drawing.Point(3, 46);
            this.LabelSensorType.Name = "LabelSensorType";
            this.LabelSensorType.Size = new System.Drawing.Size(299, 46);
            this.LabelSensorType.TabIndex = 9;
            this.LabelSensorType.Text = "Sensor Type:";
            this.LabelSensorType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSensorNaam
            // 
            this.LabelSensorNaam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSensorNaam.AutoSize = true;
            this.LabelSensorNaam.Location = new System.Drawing.Point(3, 16);
            this.LabelSensorNaam.Name = "LabelSensorNaam";
            this.LabelSensorNaam.Size = new System.Drawing.Size(299, 13);
            this.LabelSensorNaam.TabIndex = 5;
            this.LabelSensorNaam.Text = "Naam:";
            this.LabelSensorNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox
            // 
            this.ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(308, 104);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(300, 21);
            this.ComboBox.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.LabelEditId, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LabelEditSensorNaam, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SensorIdtextbox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.EditNaamsensortextbox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 147);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 113);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // LabelEditId
            // 
            this.LabelEditId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditId.AutoSize = true;
            this.LabelEditId.Location = new System.Drawing.Point(3, 56);
            this.LabelEditId.Name = "LabelEditId";
            this.LabelEditId.Size = new System.Drawing.Size(299, 57);
            this.LabelEditId.TabIndex = 7;
            this.LabelEditId.Text = "Edit Id:";
            this.LabelEditId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditSensorNaam
            // 
            this.LabelEditSensorNaam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditSensorNaam.AutoSize = true;
            this.LabelEditSensorNaam.Location = new System.Drawing.Point(3, 0);
            this.LabelEditSensorNaam.Name = "LabelEditSensorNaam";
            this.LabelEditSensorNaam.Size = new System.Drawing.Size(299, 56);
            this.LabelEditSensorNaam.TabIndex = 6;
            this.LabelEditSensorNaam.Text = "Edit Sensor:";
            this.LabelEditSensorNaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonDone
            // 
            this.ButtonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDone.AutoSize = true;
            this.ButtonDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDone.Location = new System.Drawing.Point(620, 266);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(611, 53);
            this.ButtonDone.TabIndex = 10;
            this.ButtonDone.Text = "Done";
            this.ButtonDone.UseVisualStyleBackColor = true;
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // dataSet_Sensors123
            // 
            this.dataSet_Sensors123.DataSetName = "DataSet_Sensors123";
            this.dataSet_Sensors123.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorsBindingSource
            // 
            this.sensorsBindingSource.DataMember = "Sensors";
            this.sensorsBindingSource.DataSource = this.dataSet_Sensors123;
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
            // CreateSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TLPSensor);
            this.Name = "CreateSensor";
            this.Text = "CreateSensor";
            this.Load += new System.EventHandler(this.CreateSensor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateSensor)).EndInit();
            this.TLPSensor.ResumeLayout(false);
            this.TLPSensor.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TLPCheckBox.ResumeLayout(false);
            this.TLPCheckBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Sensors123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCreateSensor;
        private System.Windows.Forms.Button CreateSensorbutton;
        private System.Windows.Forms.Button EditSensorbutton;
        private System.Windows.Forms.TextBox CreatSensorNatextbox;
        private System.Windows.Forms.TextBox SensorIdtextbox;
        private System.Windows.Forms.TextBox EditNaamsensortextbox;
        private System.Windows.Forms.TableLayoutPanel TLPSensor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LabelEditId;
        private System.Windows.Forms.Label LabelEditSensorNaam;
        private System.Windows.Forms.Label LabelSensorNaam;
        private System.Windows.Forms.Button ButtonDone;
        private System.Windows.Forms.TableLayoutPanel TLPCheckBox;
        private System.Windows.Forms.CheckBox CheckBoxDruk;
        private System.Windows.Forms.CheckBox CheckBoxEntree;
        private System.Windows.Forms.Label LabelSensorType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelComboBox;
        private System.Windows.Forms.ComboBox ComboBox;
        private DataSet_Sensors123 dataSet_Sensors123;
        private System.Windows.Forms.BindingSource sensorsBindingSource;
        private DataSet_Sensors123TableAdapters.SensorsTableAdapter sensorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatieIdDataGridViewTextBoxColumn;
    }
}