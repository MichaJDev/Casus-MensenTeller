namespace Mensenteller_B3
{
    partial class View
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
<<<<<<< Updated upstream
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "View";
        }

        #endregion
=======
            this.mensentellerDataSet = new Mensenteller_B3.MensentellerDataSet();
            this.mensentellerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mensentellerDataSet_bedrijven = new Mensenteller_B3.MensentellerDataSet_bedrijven();
            this.bedrijvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedrijvenTableAdapter = new Mensenteller_B3.MensentellerDataSet_bedrijvenTableAdapters.BedrijvenTableAdapter();
            this.sensorDataDataSet = new Mensenteller_B3.SensorDataDataSet();
            this.sensorReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorReadingTableAdapter = new Mensenteller_B3.SensorDataDataSetTableAdapters.SensorReadingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet_bedrijven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mensentellerDataSet
            // 
            this.mensentellerDataSet.DataSetName = "MensentellerDataSet";
            this.mensentellerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mensentellerDataSetBindingSource
            // 
            this.mensentellerDataSetBindingSource.DataSource = this.mensentellerDataSet;
            this.mensentellerDataSetBindingSource.Position = 0;
            // 
            // mensentellerDataSet_bedrijven
            // 
            this.mensentellerDataSet_bedrijven.DataSetName = "MensentellerDataSet_bedrijven";
            this.mensentellerDataSet_bedrijven.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedrijvenBindingSource
            // 
            this.bedrijvenBindingSource.DataMember = "Bedrijven";
            this.bedrijvenBindingSource.DataSource = this.mensentellerDataSet_bedrijven;
            // 
            // bedrijvenTableAdapter
            // 
            this.bedrijvenTableAdapter.ClearBeforeFill = true;
            // 
            // sensorDataDataSet
            // 
            this.sensorDataDataSet.DataSetName = "SensorDataDataSet";
            this.sensorDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorReadingBindingSource
            // 
            this.sensorReadingBindingSource.DataMember = "SensorReading";
            this.sensorReadingBindingSource.DataSource = this.sensorDataDataSet;
            // 
            // sensorReadingTableAdapter
            // 
            this.sensorReadingTableAdapter.ClearBeforeFill = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensentellerDataSet_bedrijven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedrijvenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mensentellerDataSetBindingSource;
        private MensentellerDataSet mensentellerDataSet;
        private MensentellerDataSet_bedrijven mensentellerDataSet_bedrijven;
        private System.Windows.Forms.BindingSource bedrijvenBindingSource;
        private MensentellerDataSet_bedrijvenTableAdapters.BedrijvenTableAdapter bedrijvenTableAdapter;
        private SensorDataDataSet sensorDataDataSet;
        private System.Windows.Forms.BindingSource sensorReadingBindingSource;
        private SensorDataDataSetTableAdapters.SensorReadingTableAdapter sensorReadingTableAdapter;
>>>>>>> Stashed changes
    }
}