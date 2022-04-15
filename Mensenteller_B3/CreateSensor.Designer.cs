namespace Mensenteller_B3
{
    partial class CreateSensor
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
            this.DgvCreateSensor = new System.Windows.Forms.DataGridView();
            this.CreateSensorbutton = new System.Windows.Forms.Button();
            this.EditSensorbutton = new System.Windows.Forms.Button();
            this.CreatSensorNatextbox = new System.Windows.Forms.TextBox();
            this.SensorIdtextbox = new System.Windows.Forms.TextBox();
            this.EditNaamsensortextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCreateSensor
            // 
            this.DgvCreateSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreateSensor.Location = new System.Drawing.Point(-1, -2);
            this.DgvCreateSensor.Name = "DgvCreateSensor";
            this.DgvCreateSensor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreateSensor.Size = new System.Drawing.Size(799, 187);
            this.DgvCreateSensor.TabIndex = 0;
            // 
            // CreateSensorbutton
            // 
            this.CreateSensorbutton.Location = new System.Drawing.Point(611, 191);
            this.CreateSensorbutton.Name = "CreateSensorbutton";
            this.CreateSensorbutton.Size = new System.Drawing.Size(187, 83);
            this.CreateSensorbutton.TabIndex = 1;
            this.CreateSensorbutton.Text = "Create";
            this.CreateSensorbutton.UseVisualStyleBackColor = true;
            this.CreateSensorbutton.Click += new System.EventHandler(this.CreateSensorbutton_Click);
            // 
            // EditSensorbutton
            // 
            this.EditSensorbutton.Location = new System.Drawing.Point(611, 362);
            this.EditSensorbutton.Name = "EditSensorbutton";
            this.EditSensorbutton.Size = new System.Drawing.Size(187, 88);
            this.EditSensorbutton.TabIndex = 2;
            this.EditSensorbutton.Text = "Edit";
            this.EditSensorbutton.UseVisualStyleBackColor = true;
            this.EditSensorbutton.Click += new System.EventHandler(this.EditSensorbutton_Click);
            // 
            // CreatSensorNatextbox
            // 
            this.CreatSensorNatextbox.Location = new System.Drawing.Point(39, 232);
            this.CreatSensorNatextbox.Name = "CreatSensorNatextbox";
            this.CreatSensorNatextbox.Size = new System.Drawing.Size(100, 20);
            this.CreatSensorNatextbox.TabIndex = 3;
            // 
            // SensorIdtextbox
            // 
            this.SensorIdtextbox.Location = new System.Drawing.Point(28, 337);
            this.SensorIdtextbox.Name = "SensorIdtextbox";
            this.SensorIdtextbox.Size = new System.Drawing.Size(100, 20);
            this.SensorIdtextbox.TabIndex = 4;
            // 
            // EditNaamsensortextbox
            // 
            this.EditNaamsensortextbox.Location = new System.Drawing.Point(28, 377);
            this.EditNaamsensortextbox.Name = "EditNaamsensortextbox";
            this.EditNaamsensortextbox.Size = new System.Drawing.Size(100, 20);
            this.EditNaamsensortextbox.TabIndex = 5;
            // 
            // CreateSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditNaamsensortextbox);
            this.Controls.Add(this.SensorIdtextbox);
            this.Controls.Add(this.CreatSensorNatextbox);
            this.Controls.Add(this.EditSensorbutton);
            this.Controls.Add(this.CreateSensorbutton);
            this.Controls.Add(this.DgvCreateSensor);
            this.Name = "CreateSensor";
            this.Text = "CreateSensor";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreateSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCreateSensor;
        private System.Windows.Forms.Button CreateSensorbutton;
        private System.Windows.Forms.Button EditSensorbutton;
        private System.Windows.Forms.TextBox CreatSensorNatextbox;
        private System.Windows.Forms.TextBox SensorIdtextbox;
        private System.Windows.Forms.TextBox EditNaamsensortextbox;
    }
}