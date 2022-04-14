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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "CreateSensor";
        }

        #endregion
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateSensorbutton = new System.Windows.Forms.Button();
            this.CreateSensortextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // CreateSensorbutton
            // 
            this.CreateSensorbutton.Location = new System.Drawing.Point(82, 270);
            this.CreateSensorbutton.Name = "CreateSensorbutton";
            this.CreateSensorbutton.Size = new System.Drawing.Size(75, 23);
            this.CreateSensorbutton.TabIndex = 1;
            this.CreateSensorbutton.Text = "Create";
            this.CreateSensorbutton.UseVisualStyleBackColor = true;
            this.CreateSensorbutton.Click += new System.EventHandler(this.CreateSensorbutton_Click);
            // 
            // CreateSensortextbox
            // 
            this.CreateSensortextbox.Location = new System.Drawing.Point(82, 230);
            this.CreateSensortextbox.Name = "CreateSensortextbox";
            this.CreateSensortextbox.Size = new System.Drawing.Size(100, 20);
            this.CreateSensortextbox.TabIndex = 2;
            // 
            // CreateSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateSensortextbox);
            this.Controls.Add(this.CreateSensorbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateSensor";
            this.Text = "CreateSensor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CreateSensorbutton;
        private System.Windows.Forms.TextBox CreateSensortextbox;
>>>>>>> Stashed changes
    }
}