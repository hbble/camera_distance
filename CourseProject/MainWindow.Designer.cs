namespace CourseProject {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.cameraGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labeld = new System.Windows.Forms.Label();
            this.numericRealHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.recButton = new System.Windows.Forms.Button();
            this.webcamOut = new System.Windows.Forms.PictureBox();
            this.camerasComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRealHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamOut)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraGroupBox
            // 
            this.cameraGroupBox.Controls.Add(this.label3);
            this.cameraGroupBox.Controls.Add(this.labeld);
            this.cameraGroupBox.Controls.Add(this.numericRealHeight);
            this.cameraGroupBox.Controls.Add(this.label2);
            this.cameraGroupBox.Controls.Add(this.stopButton);
            this.cameraGroupBox.Controls.Add(this.recButton);
            this.cameraGroupBox.Controls.Add(this.webcamOut);
            this.cameraGroupBox.Controls.Add(this.camerasComboBox);
            this.cameraGroupBox.Controls.Add(this.label1);
            this.cameraGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraGroupBox.Location = new System.Drawing.Point(0, 0);
            this.cameraGroupBox.Name = "cameraGroupBox";
            this.cameraGroupBox.Size = new System.Drawing.Size(600, 428);
            this.cameraGroupBox.TabIndex = 2;
            this.cameraGroupBox.TabStop = false;
            this.cameraGroupBox.Text = "WebCam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "cm";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeld.Location = new System.Drawing.Point(338, 22);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(159, 31);
            this.labeld.TabIndex = 9;
            this.labeld.Text = "Click \"Start\"";
            // 
            // numericRealHeight
            // 
            this.numericRealHeight.DecimalPlaces = 2;
            this.numericRealHeight.Location = new System.Drawing.Point(226, 37);
            this.numericRealHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericRealHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRealHeight.Name = "numericRealHeight";
            this.numericRealHeight.Size = new System.Drawing.Size(76, 20);
            this.numericRealHeight.TabIndex = 8;
            this.numericRealHeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Real height:";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(503, 39);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(85, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // recButton
            // 
            this.recButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recButton.Location = new System.Drawing.Point(503, 10);
            this.recButton.Name = "recButton";
            this.recButton.Size = new System.Drawing.Size(85, 23);
            this.recButton.TabIndex = 5;
            this.recButton.Text = "Start";
            this.recButton.UseVisualStyleBackColor = true;
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // webcamOut
            // 
            this.webcamOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webcamOut.Location = new System.Drawing.Point(6, 67);
            this.webcamOut.Name = "webcamOut";
            this.webcamOut.Size = new System.Drawing.Size(588, 355);
            this.webcamOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.webcamOut.TabIndex = 2;
            this.webcamOut.TabStop = false;
            // 
            // camerasComboBox
            // 
            this.camerasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camerasComboBox.FormattingEnabled = true;
            this.camerasComboBox.Location = new System.Drawing.Point(16, 37);
            this.camerasComboBox.Name = "camerasComboBox";
            this.camerasComboBox.Size = new System.Drawing.Size(175, 21);
            this.camerasComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Camera:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 428);
            this.Controls.Add(this.cameraGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.cameraGroupBox.ResumeLayout(false);
            this.cameraGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRealHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webcamOut)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox cameraGroupBox;
		private System.Windows.Forms.ComboBox camerasComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox webcamOut;
		private System.Windows.Forms.Button recButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.NumericUpDown numericRealHeight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labeld;
		private System.Windows.Forms.Label label3;
	}
}

