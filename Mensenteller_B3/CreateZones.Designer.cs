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
            this.TableLayoutPanelCreateZone = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCreateZone = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelEditName = new System.Windows.Forms.Label();
            this.ButtondDone = new System.Windows.Forms.Button();
            this.mensentellerDataSet7 = new Mensenteller_B3.MensentellerDataSet7();
            this.zonesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zonesTableAdapter1 = new Mensenteller_B3.MensentellerDataSet7TableAdapters.ZonesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones)).BeginInit();
            this.TableLayoutPanelCreateZone.SuspendLayout();
            this.TableLayoutPanelControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateZonebutton
            // 
            this.CreateZonebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateZonebutton.AutoSize = true;
            this.CreateZonebutton.Location = new System.Drawing.Point(430, 3);
            this.CreateZonebutton.Name = "CreateZonebutton";
            this.CreateZonebutton.Size = new System.Drawing.Size(422, 67);
            this.CreateZonebutton.TabIndex = 0;
            this.CreateZonebutton.Text = "Create";
            this.CreateZonebutton.UseVisualStyleBackColor = true;
            this.CreateZonebutton.Click += new System.EventHandler(this.CreateZonebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bedrijvenIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zonesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(855, 182);
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
            this.CreateZonetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateZonetextbox.Location = new System.Drawing.Point(213, 23);
            this.CreateZonetextbox.Name = "CreateZonetextbox";
            this.CreateZonetextbox.Size = new System.Drawing.Size(205, 20);
            this.CreateZonetextbox.TabIndex = 2;
            // 
            // EditZonebutton
            // 
            this.EditZonebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditZonebutton.AutoSize = true;
            this.EditZonebutton.Location = new System.Drawing.Point(430, 76);
            this.EditZonebutton.Name = "EditZonebutton";
            this.EditZonebutton.Size = new System.Drawing.Size(422, 67);
            this.EditZonebutton.TabIndex = 3;
            this.EditZonebutton.Text = "Edit";
            this.EditZonebutton.UseVisualStyleBackColor = true;
            this.EditZonebutton.Click += new System.EventHandler(this.EditZonebutton_Click);
            // 
            // IdZonetextbox
            // 
            this.IdZonetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IdZonetextbox.Location = new System.Drawing.Point(213, 40);
            this.IdZonetextbox.Name = "IdZonetextbox";
            this.IdZonetextbox.Size = new System.Drawing.Size(205, 20);
            this.IdZonetextbox.TabIndex = 4;
            // 
            // ZoneNameEdit
            // 
            this.ZoneNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoneNameEdit.Location = new System.Drawing.Point(213, 6);
            this.ZoneNameEdit.Name = "ZoneNameEdit";
            this.ZoneNameEdit.Size = new System.Drawing.Size(205, 20);
            this.ZoneNameEdit.TabIndex = 5;
            // 
            // TableLayoutPanelCreateZone
            // 
            this.TableLayoutPanelCreateZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelCreateZone.AutoScroll = true;
            this.TableLayoutPanelCreateZone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelCreateZone.ColumnCount = 1;
            this.TableLayoutPanelCreateZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateZone.Controls.Add(this.TableLayoutPanelControl, 0, 1);
            this.TableLayoutPanelCreateZone.Controls.Add(this.dataGridView1, 0, 0);
            this.TableLayoutPanelCreateZone.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanelCreateZone.Name = "TableLayoutPanelCreateZone";
            this.TableLayoutPanelCreateZone.RowCount = 2;
            this.TableLayoutPanelCreateZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateZone.Size = new System.Drawing.Size(861, 377);
            this.TableLayoutPanelCreateZone.TabIndex = 9;
            // 
            // TableLayoutPanelControl
            // 
            this.TableLayoutPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelControl.AutoSize = true;
            this.TableLayoutPanelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelControl.ColumnCount = 2;
            this.TableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelControl.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TableLayoutPanelControl.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.TableLayoutPanelControl.Controls.Add(this.ButtondDone, 1, 2);
            this.TableLayoutPanelControl.Controls.Add(this.EditZonebutton, 1, 1);
            this.TableLayoutPanelControl.Controls.Add(this.CreateZonebutton, 1, 0);
            this.TableLayoutPanelControl.Location = new System.Drawing.Point(3, 191);
            this.TableLayoutPanelControl.Name = "TableLayoutPanelControl";
            this.TableLayoutPanelControl.RowCount = 3;
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelControl.Size = new System.Drawing.Size(855, 183);
            this.TableLayoutPanelControl.TabIndex = 9;
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
            this.tableLayoutPanel2.Controls.Add(this.LabelCreateZone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreateZonetextbox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 67);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // LabelCreateZone
            // 
            this.LabelCreateZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreateZone.AutoSize = true;
            this.LabelCreateZone.Location = new System.Drawing.Point(3, 0);
            this.LabelCreateZone.Name = "LabelCreateZone";
            this.LabelCreateZone.Size = new System.Drawing.Size(204, 67);
            this.LabelCreateZone.TabIndex = 10;
            this.LabelCreateZone.Text = "Create Zone";
            this.LabelCreateZone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEditName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.IdZonetextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ZoneNameEdit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 67);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Edit ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditName
            // 
            this.LabelEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Location = new System.Drawing.Point(3, 0);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(204, 33);
            this.LabelEditName.TabIndex = 9;
            this.LabelEditName.Text = "Edit Zone";
            this.LabelEditName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtondDone
            // 
            this.ButtondDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtondDone.AutoSize = true;
            this.ButtondDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtondDone.Location = new System.Drawing.Point(430, 149);
            this.ButtondDone.Name = "ButtondDone";
            this.ButtondDone.Size = new System.Drawing.Size(422, 31);
            this.ButtondDone.TabIndex = 7;
            this.ButtondDone.Text = "Done";
            this.ButtondDone.UseVisualStyleBackColor = true;
            // 
            // mensentellerDataSet7
            // 
            this.mensentellerDataSet7.DataSetName = "MensentellerDataSet7";
            this.mensentellerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonesBindingSource1
            // 
            this.zonesBindingSource1.DataMember = "Zones";
            this.zonesBindingSource1.DataSource = this.mensentellerDataSet7;
            // 
            // zonesTableAdapter1
            // 
            this.zonesTableAdapter1.ClearBeforeFill = true;
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
            // bedrijvenIdDataGridViewTextBoxColumn
            // 
            this.bedrijvenIdDataGridViewTextBoxColumn.DataPropertyName = "BedrijvenId";
            this.bedrijvenIdDataGridViewTextBoxColumn.HeaderText = "BedrijvenId";
            this.bedrijvenIdDataGridViewTextBoxColumn.Name = "bedrijvenIdDataGridViewTextBoxColumn";
            this.bedrijvenIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreateZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 401);
            this.Controls.Add(this.TableLayoutPanelCreateZone);
            this.Name = "CreateZones";
            this.Text = "CreateZones";
            this.Load += new System.EventHandler(this.CreateZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones)).EndInit();
            this.TableLayoutPanelCreateZone.ResumeLayout(false);
            this.TableLayoutPanelCreateZone.PerformLayout();
            this.TableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelControl.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCreateZone;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCreateZone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelEditName;
        private System.Windows.Forms.Button ButtondDone;
        private MensentellerDataSet7 mensentellerDataSet7;
        private System.Windows.Forms.BindingSource zonesBindingSource1;
        private MensentellerDataSet7TableAdapters.ZonesTableAdapter zonesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijvenIdDataGridViewTextBoxColumn;
    }
}