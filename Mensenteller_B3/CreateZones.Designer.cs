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
            this.DgvCreateZone = new System.Windows.Forms.DataGridView();
            this.CreateZonebutton = new System.Windows.Forms.Button();
            this.EditZonebutton = new System.Windows.Forms.Button();
            this.CreateZoneNatextbox = new System.Windows.Forms.TextBox();
            this.ZoneEditIdtextbox = new System.Windows.Forms.TextBox();
            this.ZoneNaamEdittextbox = new System.Windows.Forms.TextBox();
            this.TLPCreateZone = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCreateBedrijf = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelEditName = new System.Windows.Forms.Label();
            this.ButtondDone = new System.Windows.Forms.Button();
            this.dataSet_Zones123 = new Mensenteller_B3.DataSet_Zones123();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zonesTableAdapter = new Mensenteller_B3.DataSet_Zones123TableAdapters.ZonesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateZone)).BeginInit();
            this.TLPCreateZone.SuspendLayout();
            this.TableLayoutPanelControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCreateZone
            // 
            this.DgvCreateZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCreateZone.AutoGenerateColumns = false;
            this.DgvCreateZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreateZone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bedrijvenIdDataGridViewTextBoxColumn});
            this.DgvCreateZone.DataSource = this.zonesBindingSource;
            this.DgvCreateZone.Location = new System.Drawing.Point(3, 3);
            this.DgvCreateZone.Name = "DgvCreateZone";
            this.DgvCreateZone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreateZone.Size = new System.Drawing.Size(1234, 322);
            this.DgvCreateZone.TabIndex = 0;
            // 
            // CreateZonebutton
            // 
            this.CreateZonebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateZonebutton.Location = new System.Drawing.Point(620, 3);
            this.CreateZonebutton.Name = "CreateZonebutton";
            this.CreateZonebutton.Size = new System.Drawing.Size(611, 122);
            this.CreateZonebutton.TabIndex = 1;
            this.CreateZonebutton.Text = "Create";
            this.CreateZonebutton.UseVisualStyleBackColor = true;
            this.CreateZonebutton.Click += new System.EventHandler(this.CreateZonebutton_Click);
            // 
            // EditZonebutton
            // 
            this.EditZonebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditZonebutton.Location = new System.Drawing.Point(620, 131);
            this.EditZonebutton.Name = "EditZonebutton";
            this.EditZonebutton.Size = new System.Drawing.Size(611, 122);
            this.EditZonebutton.TabIndex = 2;
            this.EditZonebutton.Text = "Edit";
            this.EditZonebutton.UseVisualStyleBackColor = true;
            this.EditZonebutton.Click += new System.EventHandler(this.EditZonebutton_Click);
            // 
            // CreateZoneNatextbox
            // 
            this.CreateZoneNatextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateZoneNatextbox.Location = new System.Drawing.Point(308, 51);
            this.CreateZoneNatextbox.Name = "CreateZoneNatextbox";
            this.CreateZoneNatextbox.Size = new System.Drawing.Size(300, 20);
            this.CreateZoneNatextbox.TabIndex = 3;
            // 
            // ZoneEditIdtextbox
            // 
            this.ZoneEditIdtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoneEditIdtextbox.Location = new System.Drawing.Point(308, 81);
            this.ZoneEditIdtextbox.Name = "ZoneEditIdtextbox";
            this.ZoneEditIdtextbox.Size = new System.Drawing.Size(300, 20);
            this.ZoneEditIdtextbox.TabIndex = 4;
            // 
            // ZoneNaamEdittextbox
            // 
            this.ZoneNaamEdittextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoneNaamEdittextbox.Location = new System.Drawing.Point(308, 20);
            this.ZoneNaamEdittextbox.Name = "ZoneNaamEdittextbox";
            this.ZoneNaamEdittextbox.Size = new System.Drawing.Size(300, 20);
            this.ZoneNaamEdittextbox.TabIndex = 5;
            // 
            // TLPCreateZone
            // 
            this.TLPCreateZone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLPCreateZone.AutoSize = true;
            this.TLPCreateZone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPCreateZone.ColumnCount = 1;
            this.TLPCreateZone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCreateZone.Controls.Add(this.TableLayoutPanelControl, 0, 1);
            this.TLPCreateZone.Controls.Add(this.DgvCreateZone, 0, 0);
            this.TLPCreateZone.Location = new System.Drawing.Point(12, 12);
            this.TLPCreateZone.Name = "TLPCreateZone";
            this.TLPCreateZone.RowCount = 2;
            this.TLPCreateZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCreateZone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPCreateZone.Size = new System.Drawing.Size(1240, 656);
            this.TLPCreateZone.TabIndex = 9;
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
            this.TableLayoutPanelControl.Controls.Add(this.CreateZonebutton, 1, 0);
            this.TableLayoutPanelControl.Controls.Add(this.EditZonebutton, 1, 1);
            this.TableLayoutPanelControl.Location = new System.Drawing.Point(3, 331);
            this.TableLayoutPanelControl.Name = "TableLayoutPanelControl";
            this.TableLayoutPanelControl.RowCount = 3;
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelControl.Size = new System.Drawing.Size(1234, 322);
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
            this.tableLayoutPanel2.Controls.Add(this.LabelCreateBedrijf, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CreateZoneNatextbox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 122);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // LabelCreateBedrijf
            // 
            this.LabelCreateBedrijf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreateBedrijf.AutoSize = true;
            this.LabelCreateBedrijf.Location = new System.Drawing.Point(3, 0);
            this.LabelCreateBedrijf.Name = "LabelCreateBedrijf";
            this.LabelCreateBedrijf.Size = new System.Drawing.Size(299, 122);
            this.LabelCreateBedrijf.TabIndex = 10;
            this.LabelCreateBedrijf.Text = "Create Bedrijf";
            this.LabelCreateBedrijf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEditName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZoneEditIdtextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ZoneNaamEdittextbox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 122);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 61);
            this.label4.TabIndex = 10;
            this.label4.Text = "Edit ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditName
            // 
            this.LabelEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Location = new System.Drawing.Point(3, 0);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(299, 61);
            this.LabelEditName.TabIndex = 9;
            this.LabelEditName.Text = "Edit Bedrijf ";
            this.LabelEditName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtondDone
            // 
            this.ButtondDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtondDone.AutoSize = true;
            this.ButtondDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtondDone.Location = new System.Drawing.Point(620, 259);
            this.ButtondDone.Name = "ButtondDone";
            this.ButtondDone.Size = new System.Drawing.Size(611, 60);
            this.ButtondDone.TabIndex = 7;
            this.ButtondDone.Text = "Done";
            this.ButtondDone.UseVisualStyleBackColor = true;
            this.ButtondDone.Click += new System.EventHandler(this.ButtondDone_Click);
            // 
            // dataSet_Zones123
            // 
            this.dataSet_Zones123.DataSetName = "DataSet_Zones123";
            this.dataSet_Zones123.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataMember = "Zones";
            this.zonesBindingSource.DataSource = this.dataSet_Zones123;
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
            // CreateZones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TLPCreateZone);
            this.Name = "CreateZones";
            this.Text = "CreateZone";
            this.Load += new System.EventHandler(this.CreateZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateZone)).EndInit();
            this.TLPCreateZone.ResumeLayout(false);
            this.TLPCreateZone.PerformLayout();
            this.TableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelControl.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Zones123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel TLPCreateZone;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCreateBedrijf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelEditName;
        private System.Windows.Forms.Button ButtondDone;
        private DataSet_Zones123 dataSet_Zones123;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private DataSet_Zones123TableAdapters.ZonesTableAdapter zonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijvenIdDataGridViewTextBoxColumn;
    }
}