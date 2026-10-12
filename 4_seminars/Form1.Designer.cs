namespace _4_seminars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            srcView = new DataGridView();
            btnFuelTypeSource = new Button();
            btnLocationSource = new Button();
            btnCarMakeSource = new Button();
            btnCarSource = new Button();
            ((System.ComponentModel.ISupportInitialize)srcView).BeginInit();
            SuspendLayout();
            // 
            // srcView
            // 
            srcView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            srcView.Location = new Point(203, 48);
            srcView.Name = "srcView";
            srcView.Size = new Size(556, 390);
            srcView.TabIndex = 0;
            srcView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnFuelTypeSource
            // 
            btnFuelTypeSource.Location = new Point(45, 22);
            btnFuelTypeSource.Name = "btnFuelTypeSource";
            btnFuelTypeSource.Size = new Size(97, 64);
            btnFuelTypeSource.TabIndex = 1;
            btnFuelTypeSource.Text = "FuelType";
            btnFuelTypeSource.UseVisualStyleBackColor = true;
            btnFuelTypeSource.Click += btnFuelTypeSource_Click;
            // 
            // btnLocationSource
            // 
            btnLocationSource.Location = new Point(45, 92);
            btnLocationSource.Name = "btnLocationSource";
            btnLocationSource.Size = new Size(97, 59);
            btnLocationSource.TabIndex = 2;
            btnLocationSource.Text = "Location";
            btnLocationSource.UseVisualStyleBackColor = true;
            btnLocationSource.Click += button1_Click;
            // 
            // btnCarMakeSource
            // 
            btnCarMakeSource.Location = new Point(45, 157);
            btnCarMakeSource.Name = "btnCarMakeSource";
            btnCarMakeSource.Size = new Size(97, 63);
            btnCarMakeSource.TabIndex = 3;
            btnCarMakeSource.Text = "CarMake";
            btnCarMakeSource.UseVisualStyleBackColor = true;
            btnCarMakeSource.Click += btnCarMakeSource_Click;
            // 
            // btnCarSource
            // 
            btnCarSource.Location = new Point(45, 226);
            btnCarSource.Name = "btnCarSource";
            btnCarSource.Size = new Size(97, 63);
            btnCarSource.TabIndex = 4;
            btnCarSource.Text = "Car";
            btnCarSource.UseVisualStyleBackColor = true;
            btnCarSource.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCarSource);
            Controls.Add(btnCarMakeSource);
            Controls.Add(btnLocationSource);
            Controls.Add(btnFuelTypeSource);
            Controls.Add(srcView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)srcView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView srcView;
        private Button btnFuelTypeSource;
        private Button btnLocationSource;
        private Button btnCarMakeSource;
        private Button btnCarSource;
    }
}
