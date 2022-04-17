namespace Mensenteller_B3
{
    partial class CreateLocatie
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
            this.CreateLocatiebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet_Locaties1 = new Mensenteller_B3.DataSet_Locaties1();
            this.dataSet_Locaties = new Mensenteller_B3.DataSet_Locaties();
            this.locatiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatiesTableAdapter = new Mensenteller_B3.DataSet_LocatiesTableAdapters.LocatiesTableAdapter();
            this.EditLocatiebutton = new System.Windows.Forms.Button();
            this.EditIdLocatietextbox = new System.Windows.Forms.TextBox();
            this.locatiesTableAdapter1 = new Mensenteller_B3.DataSet_Locaties1TableAdapters.LocatiesTableAdapter();
            this.EditLocatietextbox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanelCreateBedrijf = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxCreateLocatie = new System.Windows.Forms.TextBox();
            this.LabelCreateLocatie = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelEditName = new System.Windows.Forms.Label();
            this.ButtondDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).BeginInit();
            this.TableLayoutPanelCreateBedrijf.SuspendLayout();
            this.TableLayoutPanelControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateLocatiebutton
            // 
            this.CreateLocatiebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateLocatiebutton.AutoSize = true;
            this.CreateLocatiebutton.Location = new System.Drawing.Point(376, 3);
            this.CreateLocatiebutton.Name = "CreateLocatiebutton";
            this.CreateLocatiebutton.Size = new System.Drawing.Size(368, 76);
            this.CreateLocatiebutton.TabIndex = 0;
            this.CreateLocatiebutton.Text = "Create";
            this.CreateLocatiebutton.UseVisualStyleBackColor = true;
            this.CreateLocatiebutton.Click += new System.EventHandler(this.CreateLocatiebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataSet_Locaties1
            // 
            this.dataSet_Locaties1.DataSetName = "DataSet_Locaties1";
            this.dataSet_Locaties1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet_Locaties
            // 
            this.dataSet_Locaties.DataSetName = "DataSet_Locaties";
            this.dataSet_Locaties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatiesBindingSource
            // 
            this.locatiesBindingSource.DataMember = "Locaties";
            this.locatiesBindingSource.DataSource = this.dataSet_Locaties;
            // 
            // locatiesTableAdapter
            // 
            this.locatiesTableAdapter.ClearBeforeFill = true;
            // 
            // EditLocatiebutton
            // 
            this.EditLocatiebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditLocatiebutton.AutoSize = true;
            this.EditLocatiebutton.Location = new System.Drawing.Point(376, 85);
            this.EditLocatiebutton.Name = "EditLocatiebutton";
            this.EditLocatiebutton.Size = new System.Drawing.Size(368, 76);
            this.EditLocatiebutton.TabIndex = 3;
            this.EditLocatiebutton.Text = "Edit";
            this.EditLocatiebutton.UseVisualStyleBackColor = true;
            this.EditLocatiebutton.Click += new System.EventHandler(this.EditLocatiebutton_Click);
            // 
            // EditIdLocatietextbox
            // 
            this.EditIdLocatietextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditIdLocatietextbox.Location = new System.Drawing.Point(186, 47);
            this.EditIdLocatietextbox.Name = "EditIdLocatietextbox";
            this.EditIdLocatietextbox.Size = new System.Drawing.Size(178, 20);
            this.EditIdLocatietextbox.TabIndex = 4;
            this.EditIdLocatietextbox.TextChanged += new System.EventHandler(this.EditIdLocatietextbox_TextChanged);
            // 
            // locatiesTableAdapter1
            // 
            this.locatiesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditLocatietextbox
            // 
            this.EditLocatietextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EditLocatietextbox.Location = new System.Drawing.Point(186, 9);
            this.EditLocatietextbox.Name = "EditLocatietextbox";
            this.EditLocatietextbox.Size = new System.Drawing.Size(178, 20);
            this.EditLocatietextbox.TabIndex = 5;
            // 
            // TableLayoutPanelCreateBedrijf
            // 
            this.TableLayoutPanelCreateBedrijf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanelCreateBedrijf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanelCreateBedrijf.ColumnCount = 1;
            this.TableLayoutPanelCreateBedrijf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.Controls.Add(this.TableLayoutPanelControl, 0, 1);
            this.TableLayoutPanelCreateBedrijf.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelCreateBedrijf.Name = "TableLayoutPanelCreateBedrijf";
            this.TableLayoutPanelCreateBedrijf.RowCount = 2;
            this.TableLayoutPanelCreateBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanelCreateBedrijf.Size = new System.Drawing.Size(753, 425);
            this.TableLayoutPanelCreateBedrijf.TabIndex = 9;
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
            this.TableLayoutPanelControl.Location = new System.Drawing.Point(3, 215);
            this.TableLayoutPanelControl.Name = "TableLayoutPanelControl";
            this.TableLayoutPanelControl.RowCount = 3;
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelControl.Size = new System.Drawing.Size(747, 207);
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
            this.tableLayoutPanel2.Controls.Add(this.TextBoxCreateLocatie, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelCreateLocatie, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(367, 76);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // TextBoxCreateLocatie
            // 
            this.TextBoxCreateLocatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCreateLocatie.Location = new System.Drawing.Point(186, 28);
            this.TextBoxCreateLocatie.Name = "TextBoxCreateLocatie";
            this.TextBoxCreateLocatie.Size = new System.Drawing.Size(178, 20);
            this.TextBoxCreateLocatie.TabIndex = 11;
            this.TextBoxCreateLocatie.TextChanged += new System.EventHandler(this.TextBoxCreateLocatie_TextChanged);
            // 
            // LabelCreateLocatie
            // 
            this.LabelCreateLocatie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCreateLocatie.AutoSize = true;
            this.LabelCreateLocatie.Location = new System.Drawing.Point(3, 0);
            this.LabelCreateLocatie.Name = "LabelCreateLocatie";
            this.LabelCreateLocatie.Size = new System.Drawing.Size(177, 76);
            this.LabelCreateLocatie.TabIndex = 10;
            this.LabelCreateLocatie.Text = "Create Locatie";
            this.LabelCreateLocatie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 76);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edit ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEditName
            // 
            this.LabelEditName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditName.AutoSize = true;
            this.LabelEditName.Location = new System.Drawing.Point(3, 0);
            this.LabelEditName.Name = "LabelEditName";
            this.LabelEditName.Size = new System.Drawing.Size(177, 38);
            this.LabelEditName.TabIndex = 9;
            this.LabelEditName.Text = "Edit Locatie";
            this.LabelEditName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtondDone
            // 
            this.ButtondDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtondDone.AutoSize = true;
            this.ButtondDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtondDone.Location = new System.Drawing.Point(376, 167);
            this.ButtondDone.Name = "ButtondDone";
            this.ButtondDone.Size = new System.Drawing.Size(368, 37);
            this.ButtondDone.TabIndex = 7;
            this.ButtondDone.Text = "Done";
            this.ButtondDone.UseVisualStyleBackColor = true;
            this.ButtondDone.Click += new System.EventHandler(this.ButtondDone_Click);
            // 
            // CreateLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelCreateBedrijf);
            this.Controls.Add(this.EditLocatietextbox);
            this.Controls.Add(this.EditIdLocatietextbox);
            this.Controls.Add(this.EditLocatiebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateLocatiebutton);
            this.Name = "CreateLocatie";
            this.Text = "CreateLocatie";
            this.Load += new System.EventHandler(this.CreateLocatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).EndInit();
            this.TableLayoutPanelCreateBedrijf.ResumeLayout(false);
            this.TableLayoutPanelCreateBedrijf.PerformLayout();
            this.TableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelControl.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateLocatiebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_Locaties dataSet_Locaties;
        private System.Windows.Forms.BindingSource locatiesBindingSource;
        private DataSet_LocatiesTableAdapters.LocatiesTableAdapter locatiesTableAdapter;
        private System.Windows.Forms.Button EditLocatiebutton;
        private System.Windows.Forms.TextBox EditIdLocatietextbox;
        private DataSet_Locaties1 dataSet_Locaties1;
        private System.Windows.Forms.BindingSource locatiesBindingSource1;
        private DataSet_Locaties1TableAdapters.LocatiesTableAdapter locatiesTableAdapter1;
        private System.Windows.Forms.TextBox EditLocatietextbox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelCreateBedrijf;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelCreateLocatie;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelEditName;
        private System.Windows.Forms.Button ButtondDone;
        private System.Windows.Forms.TextBox TextBoxCreateLocatie;
    }
}
