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
            this.CreateLocatietextbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locatiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Locaties1 = new Mensenteller_B3.DataSet_Locaties1();
            this.dataSet_Locaties = new Mensenteller_B3.DataSet_Locaties();
            this.locatiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatiesTableAdapter = new Mensenteller_B3.DataSet_LocatiesTableAdapters.LocatiesTableAdapter();
            this.EditLocatiebutton = new System.Windows.Forms.Button();
            this.EditIdLocatietextbox = new System.Windows.Forms.TextBox();
            this.locatiesTableAdapter1 = new Mensenteller_B3.DataSet_Locaties1TableAdapters.LocatiesTableAdapter();
            this.EditLocatietextbox = new System.Windows.Forms.TextBox();
            this.ZoneIdtextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateLocatiebutton
            // 
            this.CreateLocatiebutton.Location = new System.Drawing.Point(542, 227);
            this.CreateLocatiebutton.Name = "CreateLocatiebutton";
            this.CreateLocatiebutton.Size = new System.Drawing.Size(253, 92);
            this.CreateLocatiebutton.TabIndex = 0;
            this.CreateLocatiebutton.Text = "Create";
            this.CreateLocatiebutton.UseVisualStyleBackColor = true;
            this.CreateLocatiebutton.Click += new System.EventHandler(this.CreateLocatiebutton_Click);
            // 
            // CreateLocatietextbox
            // 
            this.CreateLocatietextbox.Location = new System.Drawing.Point(192, 299);
            this.CreateLocatietextbox.Name = "CreateLocatietextbox";
            this.CreateLocatietextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateLocatietextbox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(793, 219);
            this.dataGridView1.TabIndex = 2;
            // 
            // locatiesBindingSource1
            // 
            this.locatiesBindingSource1.DataMember = "Locaties";
            this.locatiesBindingSource1.DataSource = this.dataSet_Locaties1;
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
            this.EditLocatiebutton.Location = new System.Drawing.Point(542, 367);
            this.EditLocatiebutton.Name = "EditLocatiebutton";
            this.EditLocatiebutton.Size = new System.Drawing.Size(253, 80);
            this.EditLocatiebutton.TabIndex = 3;
            this.EditLocatiebutton.Text = "Edit";
            this.EditLocatiebutton.UseVisualStyleBackColor = true;
            this.EditLocatiebutton.Click += new System.EventHandler(this.EditLocatiebutton_Click);
            // 
            // EditIdLocatietextbox
            // 
            this.EditIdLocatietextbox.Location = new System.Drawing.Point(192, 349);
            this.EditIdLocatietextbox.Name = "EditIdLocatietextbox";
            this.EditIdLocatietextbox.Size = new System.Drawing.Size(100, 20);
            this.EditIdLocatietextbox.TabIndex = 4;
            // 
            // locatiesTableAdapter1
            // 
            this.locatiesTableAdapter1.ClearBeforeFill = true;
            // 
            // EditLocatietextbox
            // 
            this.EditLocatietextbox.Location = new System.Drawing.Point(192, 403);
            this.EditLocatietextbox.Name = "EditLocatietextbox";
            this.EditLocatietextbox.Size = new System.Drawing.Size(100, 20);
            this.EditLocatietextbox.TabIndex = 5;
            // 
            // ZoneIdtextbox
            // 
            this.ZoneIdtextbox.Location = new System.Drawing.Point(339, 298);
            this.ZoneIdtextbox.Name = "ZoneIdtextbox";
            this.ZoneIdtextbox.Size = new System.Drawing.Size(100, 20);
            this.ZoneIdtextbox.TabIndex = 6;
            // 
            // CreateLocatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZoneIdtextbox);
            this.Controls.Add(this.EditLocatietextbox);
            this.Controls.Add(this.EditIdLocatietextbox);
            this.Controls.Add(this.EditLocatiebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateLocatietextbox);
            this.Controls.Add(this.CreateLocatiebutton);
            this.Name = "CreateLocatie";
            this.Text = "CreateLocatie";
            this.Load += new System.EventHandler(this.CreateLocatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Locaties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateLocatiebutton;
        private System.Windows.Forms.TextBox CreateLocatietextbox;
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
        private System.Windows.Forms.TextBox ZoneIdtextbox;
    }
}