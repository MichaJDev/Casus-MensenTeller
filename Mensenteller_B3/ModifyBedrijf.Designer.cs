namespace Mensenteller_B3
{
    partial class ModifyBedrijf
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
            this.TableLayoutPanelModifyBedrijf = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mensentellerDataSet3 = new Mensenteller_B3.MensentellerDataSet3();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zonesTableAdapter = new Mensenteller_B3.MensentellerDataSet3TableAdapters.ZonesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanelModifyBedrijf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelModifyBedrijf
            // 
            this.TableLayoutPanelModifyBedrijf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelModifyBedrijf.AutoSize = true;
            this.TableLayoutPanelModifyBedrijf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelModifyBedrijf.ColumnCount = 1;
            this.TableLayoutPanelModifyBedrijf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelModifyBedrijf.Controls.Add(this.dataGridView1, 0, 0);
            this.TableLayoutPanelModifyBedrijf.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanelModifyBedrijf.Name = "TableLayoutPanelModifyBedrijf";
            this.TableLayoutPanelModifyBedrijf.RowCount = 4;
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelModifyBedrijf.Size = new System.Drawing.Size(776, 426);
            this.TableLayoutPanelModifyBedrijf.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bedrijvenIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zonesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // mensentellerDataSet3
            // 
            this.mensentellerDataSet3.DataSetName = "MensentellerDataSet3";
            this.mensentellerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataMember = "Zones";
            this.zonesBindingSource.DataSource = this.mensentellerDataSet3;
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
            // ModifyBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelModifyBedrijf);
            this.Name = "ModifyBedrijf";
            this.Text = "ModifyBedrijf";
            this.Load += new System.EventHandler(this.ModifyBedrijf_Load);
            this.TableLayoutPanelModifyBedrijf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelModifyBedrijf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MensentellerDataSet3 mensentellerDataSet3;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private MensentellerDataSet3TableAdapters.ZonesTableAdapter zonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrijvenIdDataGridViewTextBoxColumn;
    }
}