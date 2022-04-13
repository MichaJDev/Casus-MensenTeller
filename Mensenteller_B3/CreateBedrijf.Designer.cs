namespace Mensenteller_B3
{
    partial class CreateBedrijf
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
            this.DgvBedrijven = new System.Windows.Forms.DataGridView();
            this.dataSet_CreateBedrijven = new Mensenteller_B3.DataSet_CreateBedrijven();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedrijvenTableAdapter = new Mensenteller_B3.DataSet_CreateBedrijvenTableAdapters.BedrijvenTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateBedrijfbutton = new System.Windows.Forms.Button();
            this.CreateBedrijftextbox = new System.Windows.Forms.TextBox();
            this.DeleteBedrijfbutton = new System.Windows.Forms.Button();
            this.EditBedrijftextbox = new System.Windows.Forms.TextBox();
            this.EditBedrijfbutton = new System.Windows.Forms.Button();
            this.EdittextoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CreateBedrijven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBedrijven
            // 
            this.DgvBedrijven.AutoGenerateColumns = false;
            this.DgvBedrijven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBedrijven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DgvBedrijven.DataSource = this.bedrijvenBindingSource;
            this.DgvBedrijven.Location = new System.Drawing.Point(462, 177);
            this.DgvBedrijven.Name = "DgvBedrijven";
            this.DgvBedrijven.Size = new System.Drawing.Size(240, 150);
            this.DgvBedrijven.TabIndex = 0;
            this.DgvBedrijven.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBedrijven_CellMouseClick);
            // 
            // dataSet_CreateBedrijven
            // 
            this.dataSet_CreateBedrijven.DataSetName = "DataSet_CreateBedrijven";
            this.dataSet_CreateBedrijven.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.dataSet_CreateBedrijven;
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
            // 
            // CreateBedrijfbutton
            // 
            this.CreateBedrijfbutton.Location = new System.Drawing.Point(52, 79);
            this.CreateBedrijfbutton.Name = "CreateBedrijfbutton";
            this.CreateBedrijfbutton.Size = new System.Drawing.Size(75, 23);
            this.CreateBedrijfbutton.TabIndex = 1;
            this.CreateBedrijfbutton.Text = "Create";
            this.CreateBedrijfbutton.UseVisualStyleBackColor = true;
            this.CreateBedrijfbutton.Click += new System.EventHandler(this.CreateBedrijfbutton_Click);
            // 
            // CreateBedrijftextbox
            // 
            this.CreateBedrijftextbox.Location = new System.Drawing.Point(64, 36);
            this.CreateBedrijftextbox.Name = "CreateBedrijftextbox";
            this.CreateBedrijftextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateBedrijftextbox.TabIndex = 2;
            // 
            // DeleteBedrijfbutton
            // 
            this.DeleteBedrijfbutton.Location = new System.Drawing.Point(503, 380);
            this.DeleteBedrijfbutton.Name = "DeleteBedrijfbutton";
            this.DeleteBedrijfbutton.Size = new System.Drawing.Size(75, 23);
            this.DeleteBedrijfbutton.TabIndex = 3;
            this.DeleteBedrijfbutton.Text = "Delete";
            this.DeleteBedrijfbutton.UseVisualStyleBackColor = true;
            this.DeleteBedrijfbutton.Click += new System.EventHandler(this.DeleteBedrijfbutton_Click);
            // 
            // EditBedrijftextbox
            // 
            this.EditBedrijftextbox.Location = new System.Drawing.Point(372, 36);
            this.EditBedrijftextbox.Name = "EditBedrijftextbox";
            this.EditBedrijftextbox.Size = new System.Drawing.Size(100, 20);
            this.EditBedrijftextbox.TabIndex = 4;
            // 
            // EditBedrijfbutton
            // 
            this.EditBedrijfbutton.Location = new System.Drawing.Point(239, 78);
            this.EditBedrijfbutton.Name = "EditBedrijfbutton";
            this.EditBedrijfbutton.Size = new System.Drawing.Size(75, 23);
            this.EditBedrijfbutton.TabIndex = 5;
            this.EditBedrijfbutton.Text = "Edit";
            this.EditBedrijfbutton.UseVisualStyleBackColor = true;
            this.EditBedrijfbutton.Click += new System.EventHandler(this.EditBedrijfbutton_Click);
            // 
            // EdittextoxId
            // 
            this.EdittextoxId.Location = new System.Drawing.Point(230, 36);
            this.EdittextoxId.Name = "EdittextoxId";
            this.EdittextoxId.Size = new System.Drawing.Size(100, 20);
            this.EdittextoxId.TabIndex = 6;
            // 
            // CreateBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EdittextoxId);
            this.Controls.Add(this.EditBedrijfbutton);
            this.Controls.Add(this.EditBedrijftextbox);
            this.Controls.Add(this.DeleteBedrijfbutton);
            this.Controls.Add(this.CreateBedrijftextbox);
            this.Controls.Add(this.CreateBedrijfbutton);
            this.Controls.Add(this.DgvBedrijven);
            this.Name = "CreateBedrijf";
            this.Text = "CreateBedrijf";
            this.Load += new System.EventHandler(this.CreateBedrijf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CreateBedrijven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBedrijven;
        private DataSet_CreateBedrijven dataSet_CreateBedrijven;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        private DataSet_CreateBedrijvenTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button CreateBedrijfbutton;
        private System.Windows.Forms.TextBox CreateBedrijftextbox;
        private System.Windows.Forms.Button DeleteBedrijfbutton;
        private System.Windows.Forms.TextBox EditBedrijftextbox;
        private System.Windows.Forms.Button EditBedrijfbutton;
        private System.Windows.Forms.TextBox EdittextoxId;
    }
}