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
            this.DataGridViewZones = new System.Windows.Forms.DataGridView();
            this.zonesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonDone = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxAdress = new System.Windows.Forms.TextBox();
            this.zonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensentellerDataSet3 = new Mensenteller_B3.MensentellerDataSet3();
            this.zonesTableAdapter = new Mensenteller_B3.MensentellerDataSet3TableAdapters.ZonesTableAdapter();
            this.TableLayoutPanelModifyBedrijf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewZones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource1)).BeginInit();
            this.TableLayoutPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet3)).BeginInit();
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
            this.TableLayoutPanelModifyBedrijf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelModifyBedrijf.Controls.Add(this.DataGridViewZones, 0, 1);
            this.TableLayoutPanelModifyBedrijf.Controls.Add(this.TableLayoutPanelControl, 0, 2);
            this.TableLayoutPanelModifyBedrijf.Controls.Add(this.TextBoxAdress, 0, 0);
            this.TableLayoutPanelModifyBedrijf.Location = new System.Drawing.Point(12, 12);
            this.TableLayoutPanelModifyBedrijf.Name = "TableLayoutPanelModifyBedrijf";
            this.TableLayoutPanelModifyBedrijf.RowCount = 3;
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66667F));
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.TableLayoutPanelModifyBedrijf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanelModifyBedrijf.Size = new System.Drawing.Size(776, 405);
            this.TableLayoutPanelModifyBedrijf.TabIndex = 0;
            // 
            // DataGridViewZones
            // 
            this.DataGridViewZones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewZones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewZones.Location = new System.Drawing.Point(3, 46);
            this.DataGridViewZones.Name = "DataGridViewZones";
            this.DataGridViewZones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewZones.Size = new System.Drawing.Size(770, 220);
            this.DataGridViewZones.TabIndex = 0;
            this.DataGridViewZones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewZones_CellContentClick);
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
            this.TableLayoutPanelControl.Controls.Add(this.ButtonModify, 1, 0);
            this.TableLayoutPanelControl.Controls.Add(this.ButtonCreate, 0, 0);
            this.TableLayoutPanelControl.Controls.Add(this.ButtonDone, 1, 1);
            this.TableLayoutPanelControl.Controls.Add(this.ButtonDelete, 0, 1);
            this.TableLayoutPanelControl.Location = new System.Drawing.Point(3, 272);
            this.TableLayoutPanelControl.Name = "TableLayoutPanelControl";
            this.TableLayoutPanelControl.RowCount = 2;
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanelControl.Size = new System.Drawing.Size(770, 130);
            this.TableLayoutPanelControl.TabIndex = 2;
            // 
            // ButtonModify
            // 
            this.ButtonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonModify.AutoSize = true;
            this.ButtonModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonModify.Location = new System.Drawing.Point(388, 3);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(379, 98);
            this.ButtonModify.TabIndex = 1;
            this.ButtonModify.Text = "Modify";
            this.ButtonModify.UseVisualStyleBackColor = true;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCreate.AutoSize = true;
            this.ButtonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCreate.Location = new System.Drawing.Point(3, 3);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(379, 98);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonDone
            // 
            this.ButtonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDone.AutoSize = true;
            this.ButtonDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDone.Location = new System.Drawing.Point(388, 107);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(379, 20);
            this.ButtonDone.TabIndex = 3;
            this.ButtonDone.Text = "Done";
            this.ButtonDone.UseVisualStyleBackColor = true;
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDelete.Location = new System.Drawing.Point(3, 107);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(379, 20);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxAdress
            // 
            this.TextBoxAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAdress.Location = new System.Drawing.Point(3, 11);
            this.TextBoxAdress.Name = "TextBoxAdress";
            this.TextBoxAdress.ReadOnly = true;
            this.TextBoxAdress.Size = new System.Drawing.Size(770, 20);
            this.TextBoxAdress.TabIndex = 3;
            this.TextBoxAdress.TextChanged += new System.EventHandler(this.TextBoxAdress_TextChanged);
            // 
            // zonesBindingSource
            // 
            this.zonesBindingSource.DataMember = "Zones";
            this.zonesBindingSource.DataSource = this.mensentellerDataSet3;
            // 
            // mensentellerDataSet3
            // 
            this.mensentellerDataSet3.DataSetName = "MensentellerDataSet3";
            this.mensentellerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zonesTableAdapter
            // 
            this.zonesTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyBedrijf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelModifyBedrijf);
            this.Name = "ModifyBedrijf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zones";
            this.Load += new System.EventHandler(this.ModifyBedrijf_Load);
            this.TableLayoutPanelModifyBedrijf.ResumeLayout(false);
            this.TableLayoutPanelModifyBedrijf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewZones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource1)).EndInit();
            this.TableLayoutPanelControl.ResumeLayout(false);
            this.TableLayoutPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelModifyBedrijf;
        private System.Windows.Forms.DataGridView DataGridViewZones;
        private MensentellerDataSet3 mensentellerDataSet3;
        private System.Windows.Forms.BindingSource zonesBindingSource;
        private MensentellerDataSet3TableAdapters.ZonesTableAdapter zonesTableAdapter;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelControl;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonDone;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxAdress;
        private System.Windows.Forms.BindingSource zonesBindingSource1;
    }
}