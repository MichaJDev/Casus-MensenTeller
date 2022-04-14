namespace Mensenteller_B3
{
    partial class LocatieView
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
            this.DgvViewLocatie = new System.Windows.Forms.DataGridView();
            this.dataSet_LocatiesView = new Mensenteller_B3.DataSet_LocatiesView();
            this.locatiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatiesTableAdapter = new Mensenteller_B3.DataSet_LocatiesViewTableAdapters.LocatiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewLocatiebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewLocatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_LocatiesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvViewLocatie
            // 
            this.DgvViewLocatie.AllowUserToAddRows = false;
            this.DgvViewLocatie.AllowUserToDeleteRows = false;
            this.DgvViewLocatie.AutoGenerateColumns = false;
            this.DgvViewLocatie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewLocatie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.zoneIdDataGridViewTextBoxColumn});
            this.DgvViewLocatie.DataSource = this.locatiesBindingSource;
            this.DgvViewLocatie.Location = new System.Drawing.Point(54, 32);
            this.DgvViewLocatie.Name = "DgvViewLocatie";
            this.DgvViewLocatie.ReadOnly = true;
            this.DgvViewLocatie.Size = new System.Drawing.Size(636, 119);
            this.DgvViewLocatie.TabIndex = 0;
            this.DgvViewLocatie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvViewLocatie_CellMouseClick);
            // 
            // dataSet_LocatiesView
            // 
            this.dataSet_LocatiesView.DataSetName = "DataSet_LocatiesView";
            this.dataSet_LocatiesView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatiesBindingSource
            // 
            this.locatiesBindingSource.DataMember = "Locaties";
            this.locatiesBindingSource.DataSource = this.dataSet_LocatiesView;
            // 
            // locatiesTableAdapter
            // 
            this.locatiesTableAdapter.ClearBeforeFill = true;
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
            // zoneIdDataGridViewTextBoxColumn
            // 
            this.zoneIdDataGridViewTextBoxColumn.DataPropertyName = "ZoneId";
            this.zoneIdDataGridViewTextBoxColumn.HeaderText = "ZoneId";
            this.zoneIdDataGridViewTextBoxColumn.Name = "zoneIdDataGridViewTextBoxColumn";
            this.zoneIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewLocatiebutton
            // 
            this.ViewLocatiebutton.Location = new System.Drawing.Point(66, 275);
            this.ViewLocatiebutton.Name = "ViewLocatiebutton";
            this.ViewLocatiebutton.Size = new System.Drawing.Size(75, 23);
            this.ViewLocatiebutton.TabIndex = 1;
            this.ViewLocatiebutton.Text = "View";
            this.ViewLocatiebutton.UseVisualStyleBackColor = true;
            this.ViewLocatiebutton.Click += new System.EventHandler(this.ViewLocatiebutton_Click);
            // 
            // LocatieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewLocatiebutton);
            this.Controls.Add(this.DgvViewLocatie);
            this.Name = "LocatieView";
            this.Text = "LocatieView";
            this.Load += new System.EventHandler(this.LocatieView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewLocatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_LocatiesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewLocatie;
        private DataSet_LocatiesView dataSet_LocatiesView;
        private System.Windows.Forms.BindingSource locatiesBindingSource;
        private DataSet_LocatiesViewTableAdapters.LocatiesTableAdapter locatiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ViewLocatiebutton;
    }
}