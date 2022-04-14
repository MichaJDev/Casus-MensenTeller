namespace Mensenteller_B3
{
    partial class BedrijfViewButton
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
            this.BedrijvViewbutton = new System.Windows.Forms.Button();
            this.DgvBedrijfview = new System.Windows.Forms.DataGridView();
            this.dataSet_Bedrijven1 = new Mensenteller_B3.DataSet_Bedrijven1();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedrijvenTableAdapter = new Mensenteller_B3.DataSet_Bedrijven1TableAdapters.BedrijvenTableAdapter();
            this.LBLname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Bedrijven1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BedrijvViewbutton
            // 
            this.BedrijvViewbutton.Location = new System.Drawing.Point(78, 263);
            this.BedrijvViewbutton.Name = "BedrijvViewbutton";
            this.BedrijvViewbutton.Size = new System.Drawing.Size(75, 23);
            this.BedrijvViewbutton.TabIndex = 0;
            this.BedrijvViewbutton.Text = "View";
            this.BedrijvViewbutton.UseVisualStyleBackColor = true;
            this.BedrijvViewbutton.Click += new System.EventHandler(this.BedrijvViewbutton_Click);
            // 
            // DgvBedrijfview
            // 
            this.DgvBedrijfview.AllowUserToAddRows = false;
            this.DgvBedrijfview.AllowUserToDeleteRows = false;
            this.DgvBedrijfview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBedrijfview.Location = new System.Drawing.Point(25, 47);
            this.DgvBedrijfview.Name = "DgvBedrijfview";
            this.DgvBedrijfview.ReadOnly = true;
            this.DgvBedrijfview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBedrijfview.Size = new System.Drawing.Size(678, 150);
            this.DgvBedrijfview.TabIndex = 1;
            this.DgvBedrijfview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBedrijfview_CellContentClick);
            // 
            // dataSet_Bedrijven1
            // 
            this.dataSet_Bedrijven1.DataSetName = "DataSet_Bedrijven1";
            this.dataSet_Bedrijven1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.dataSet_Bedrijven1;
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
            // 
            // LBLname
            // 
            this.LBLname.AutoSize = true;
            this.LBLname.Location = new System.Drawing.Point(127, 13);
            this.LBLname.Name = "LBLname";
            this.LBLname.Size = new System.Drawing.Size(0, 13);
            this.LBLname.TabIndex = 2;
            // 
            // BedrijfViewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLname);
            this.Controls.Add(this.DgvBedrijfview);
            this.Controls.Add(this.BedrijvViewbutton);
            this.Name = "BedrijfViewButton";
            this.Text = "BedrijfView";
            this.Load += new System.EventHandler(this.BedrijfViewButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBedrijfview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Bedrijven1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BedrijvViewbutton;
        private System.Windows.Forms.DataGridView DgvBedrijfview;
        private DataSet_Bedrijven1 dataSet_Bedrijven1;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        private DataSet_Bedrijven1TableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private System.Windows.Forms.Label LBLname;
    }
}