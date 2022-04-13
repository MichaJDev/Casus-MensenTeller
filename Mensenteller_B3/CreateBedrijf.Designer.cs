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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensentellerDataSet = new Mensenteller_B3.MensentellerDataSet();
            this.bedrijvenTableAdapter = new Mensenteller_B3.MensentellerDataSetTableAdapters.BedrijvenTableAdapter();
            this.CreateBedrijftextbox = new System.Windows.Forms.TextBox();
            this.CreateBedrijfbutton = new System.Windows.Forms.Button();
            this.BedrijfDeleteButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.EditBedrijfbutton = new System.Windows.Forms.Button();
            this.EditBedrijftextbox = new System.Windows.Forms.TextBox();
            this.TextBoxEditId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bedrijvenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(479, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
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
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.mensentellerDataSet;
            // 
            // mensentellerDataSet
            // 
            this.mensentellerDataSet.DataSetName = "MensentellerDataSet";
            this.mensentellerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
            // 
            // CreateBedrijftextbox
            // 
            this.CreateBedrijftextbox.Location = new System.Drawing.Point(61, 44);
            this.CreateBedrijftextbox.Name = "CreateBedrijftextbox";
            this.CreateBedrijftextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateBedrijftextbox.TabIndex = 1;
            // 
            // CreateBedrijfbutton
            // 
            this.CreateBedrijfbutton.Location = new System.Drawing.Point(61, 85);
            this.CreateBedrijfbutton.Name = "CreateBedrijfbutton";
            this.CreateBedrijfbutton.Size = new System.Drawing.Size(75, 23);
            this.CreateBedrijfbutton.TabIndex = 2;
            this.CreateBedrijfbutton.Text = "Create";
            this.CreateBedrijfbutton.UseVisualStyleBackColor = true;
            this.CreateBedrijfbutton.Click += new System.EventHandler(this.CreateBedrijfbutton_Click);
            // 
            // BedrijfDeleteButton
            // 
            this.BedrijfDeleteButton.Location = new System.Drawing.Point(555, 371);
            this.BedrijfDeleteButton.Name = "BedrijfDeleteButton";
            this.BedrijfDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.BedrijfDeleteButton.TabIndex = 3;
            this.BedrijfDeleteButton.Text = "Delete";
            this.BedrijfDeleteButton.UseVisualStyleBackColor = true;
            this.BedrijfDeleteButton.Click += new System.EventHandler(this.BedrijfDeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(664, 32);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // EditBedrijfbutton
            // 
            this.EditBedrijfbutton.Location = new System.Drawing.Point(280, 212);
            this.EditBedrijfbutton.Name = "EditBedrijfbutton";
            this.EditBedrijfbutton.Size = new System.Drawing.Size(75, 23);
            this.EditBedrijfbutton.TabIndex = 5;
            this.EditBedrijfbutton.Text = "Edit";
            this.EditBedrijfbutton.UseVisualStyleBackColor = true;
            this.EditBedrijfbutton.Click += new System.EventHandler(this.EditBedrijfbutton_Click);
            // 
            // EditBedrijftextbox
            // 
            this.EditBedrijftextbox.Location = new System.Drawing.Point(280, 173);
            this.EditBedrijftextbox.Name = "EditBedrijftextbox";
            this.EditBedrijftextbox.Size = new System.Drawing.Size(100, 20);
            this.EditBedrijftextbox.TabIndex = 6;
            // 
            // TextBoxEditId
            // 
            this.TextBoxEditId.Location = new System.Drawing.Point(280, 111);
            this.TextBoxEditId.Name = "TextBoxEditId";
            this.TextBoxEditId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxEditId.TabIndex = 7;
            // 
            // CreateBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxEditId);
            this.Controls.Add(this.EditBedrijftextbox);
            this.Controls.Add(this.EditBedrijfbutton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BedrijfDeleteButton);
            this.Controls.Add(this.CreateBedrijfbutton);
            this.Controls.Add(this.CreateBedrijftextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateBedrijf";
            this.Text = "CreateBedrijf";
            this.Load += new System.EventHandler(this.CreateBedrijf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MensentellerDataSet mensentellerDataSet;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        private MensentellerDataSetTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox CreateBedrijftextbox;
        private System.Windows.Forms.Button CreateBedrijfbutton;
        private System.Windows.Forms.Button BedrijfDeleteButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button EditBedrijfbutton;
        private System.Windows.Forms.TextBox EditBedrijftextbox;
        private System.Windows.Forms.TextBox TextBoxEditId;
    }
}