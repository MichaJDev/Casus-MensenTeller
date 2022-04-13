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
            this.CreateBedrijfbutton = new System.Windows.Forms.Button();
            this.CreateBedrijftextbox = new System.Windows.Forms.TextBox();
            this.EditBedrijftextbox = new System.Windows.Forms.TextBox();
            this.EditBedrijfbutton = new System.Windows.Forms.Button();
            this.EdittextoxId = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_CreateBedrijven = new Mensenteller_B3.DataSet_CreateBedrijven();
            this.bedrijvenTableAdapter = new Mensenteller_B3.DataSet_CreateBedrijvenTableAdapters.BedrijvenTableAdapter();
            this.ButtondDone = new System.Windows.Forms.Button();
            this.TableLayoutPanelCreateBedrijf = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelEditName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelCreateBedrijf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CreateBedrijven)).BeginInit();
            this.TableLayoutPanelCreateBedrijf.SuspendLayout();
            this.TableLayoutPanelControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBedrijven
            // 
            this.DgvBedrijven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvBedrijven.AutoGenerateColumns = false;
            this.DgvBedrijven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBedrijven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.DgvBedrijven.DataSource = this.bedrijvenBindingSource;
            this.DgvBedrijven.Location = new System.Drawing.Point(3, 3);
            this.DgvBedrijven.Name = "DgvBedrijven";
            this.DgvBedrijven.Size = new System.Drawing.Size(770, 207);
            this.DgvBedrijven.TabIndex = 0;
            this.DgvBedrijven.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBedrijven_CellMouseClick);
            // 
            // CreateBedrijfbutton
            // 
            this.CreateBedrijfbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBedrijfbutton.AutoSize = true;
            this.CreateBedrijfbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateBedrijfbutton.Location = new System.Drawing.Point(388, 3);
            this.CreateBedrijfbutton.Name = "CreateBedrijfbutton";
            this.CreateBedrijfbutton.Size = new System.Drawing.Size(379, 76);
            this.CreateBedrijfbutton.TabIndex = 1;
            this.CreateBedrijfbutton.Text = "Create";
            this.CreateBedrijfbutton.UseVisualStyleBackColor = true;
            this.CreateBedrijfbutton.Click += new System.EventHandler(this.CreateBedrijfbutton_Click);
            // 
            // CreateBedrijftextbox
            // 
            this.CreateBedrijftextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBedrijftextbox.Location = new System.Drawing.Point(192, 28);
            this.CreateBedrijftextbox.Name = "CreateBedrijftextbox";
            this.CreateBedrijftextbox.Size = new System.Drawing.Size(184, 20);
            this.CreateBedrijftextbox.TabIndex = 2;
            // 
            // EditBedrijftextbox
            // 
            this.EditBedrijftextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBedrijftextbox.Location = new System.Drawing.Point(192, 9);
            this.EditBedrijftextbox.Name = "EditBedrijftextbox";
            this.EditBedrijftextbox.Size = new System.Drawing.Size(184, 20);
            this.EditBedrijftextbox.TabIndex = 4;
            // 
            // EditBedrijfbutton
            // 
            this.EditBedrijfbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBedrijfbutton.AutoSize = true;
            this.EditBedrijfbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBedrijfbutton.Location = new System.Drawing.Point(388, 85);
            this.EditBedrijfbutton.Name = "EditBedrijfbutton";
            this.EditBedrijfbutton.Size = new System.Drawing.Size(379, 76);
            this.EditBedrijfbutton.TabIndex = 5;
            this.EditBedrijfbutton.Text = "Edit";
            this.EditBedrijfbutton.UseVisualStyleBackColor = true;
            this.EditBedrijfbutton.Click += new System.EventHandler(this.EditBedrijfbutton_Click);
            // 
            // EdittextoxId
            // 
            this.EdittextoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EdittextoxId.Location = new System.Drawing.Point(192, 47);
            this.EdittextoxId.Name = "EdittextoxId";
            this.EdittextoxId.Size = new System.Drawing.Size(184, 20);
            this.EdittextoxId.TabIndex = 6;
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
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.dataSet_CreateBedrijven;
            // 
            // dataSet_CreateBedrijven
            // 
            this.dataSet_CreateBedrijven.DataSetName = "DataSet_CreateBedrijven";
            this.dataSet_CreateBedrijven.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
            // 
            // ButtondDone
            // 
            this.ButtondDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtondDone.AutoSize = true;
            this.ButtondDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtondDone.Location = new System.Drawing.Point(388, 167);
            this.ButtondDone.Name = "ButtondDone";
            this.ButtondDone.Size = new System.Drawing.Size(379, 37);
            this.ButtondDone.TabIndex = 7;
            this.ButtondDone.Text = "Done";
            this.ButtondDone.UseVisualStyleBackColor = true;
            this.ButtondDone.Click += new System.EventHandler(this.ButtondDone_Click);
            // 
            // TableLayoutPanelCreateBedrijf
            // 
            this.TableLayoutPanelCreateBedrijf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelCreateBedrijf.AutoSize = true;
            this.TableLayoutPanelCreateBedrijf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelCreateBedrijf.ColumnCount = 1;
            this.TableLayoutPanelCreateBedrijf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.Controls.Add(this.TableLayoutPanelControl, 0, 1);
            this.TableLayoutPanelCreateBedrijf.Controls.Add(this.DgvBedrijven, 0, 0);
            this.TableLayoutPanelCreateBedrijf.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanelCreateBedrijf.Name = "TableLayoutPanelCreateBedrijf";
            this.TableLayoutPanelCreateBedrijf.RowCount = 2;
            this.TableLayoutPanelCreateBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.Size = new System.Drawing.Size(776, 426);
            this.TableLayoutPanelCreateBedrijf.TabIndex = 8;
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
            this.TableLayoutPanelControl.Controls.Add(this.CreateBedrijfbutton, 1, 0);
            this.TableLayoutPanelControl.Controls.Add(this.EditBedrijfbutton, 1, 1);
            this.TableLayoutPanelControl.Location = new System.Drawing.Point(3, 216);
            this.TableLayoutPanelControl.Name = "TableLayoutPanelControl";
            this.TableLayoutPanelControl.RowCount = 3;
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelControl.Size = new System.Drawing.Size(770, 207);
            this.TableLayoutPanelControl.TabIndex = 9;
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelEditName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditBedrijftextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EdittextoxId, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 76);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // LabelEditName
            // 
            this.LabelEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Location = new System.Drawing.Point(3, 0);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(183, 38);
            this.LabelEditName.TabIndex = 9;
            this.LabelEditName.Text = "Edit Bedrijf ";
            this.LabelEditName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.Controls.Add(this.CreateBedrijftextbox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 76);
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
            this.LabelCreateBedrijf.Size = new System.Drawing.Size(183, 76);
            this.LabelCreateBedrijf.TabIndex = 10;
            this.LabelCreateBedrijf.Text = "Create Bedrijf";
            this.LabelCreateBedrijf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelCreateBedrijf);
            this.Name = "CreateBedrijf";
            this.Text = "CreateBedrijf";
            this.Load += new System.EventHandler(this.CreateBedrijf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_CreateBedrijven)).EndInit();
            this.TableLayoutPanelCreateBedrijf.ResumeLayout(false);
            this.TableLayoutPanelCreateBedrijf.PerformLayout();
            this.TableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelControl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox EditBedrijftextbox;
        private System.Windows.Forms.Button EditBedrijfbutton;
        private System.Windows.Forms.TextBox EdittextoxId;
        private System.Windows.Forms.Button ButtondDone;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCreateBedrijf;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCreateBedrijf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelEditName;
    }
}