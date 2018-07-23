using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace CourseProject {
	public partial class MainWindow : Form {

		//webcam
		Capture capture; //controller
		private int selectedCam;

        //recognition
        private int count = 0;
		MCvAvgComp[] Faces; //face
		private double d;

		HaarCascade faceCascade =new HaarCascade
			("C:\\Emgu\\emgucv-windows-x64 2.4.0.1717\\opencv\\data\\haarcascades\\haarcascade_frontalface_default.xml");
		

		public MainWindow() {
			InitializeComponent();
			
			//webcam list
			FilterInfoCollection captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			foreach (FilterInfo device in captureDevices) {
				camerasComboBox.Items.Add(device.Name);
			}

			camerasComboBox.SelectedIndex = 0;
			

		}

		private void recButton_Click(object sender, EventArgs e) {
			selectedCam = camerasComboBox.SelectedIndex;

			capture = null;
			capture = new Capture(0);
			capture.Start();
			capture.ImageGrabbed += ProcessFrame;
			

			recButton.Enabled = false;
			stopButton.Enabled = true;
		}

		private void ProcessFrame(object sender, EventArgs e) {

			Image<Bgr, byte> frame = capture.RetrieveBgrFrame();
			
			if (Faces != null && Faces.Length != 0)
				frame.Draw(Faces[0].rect, new Bgr(0, 255, 127), 5);


			if (count == 10) {

				Image<Gray, byte> grayFrame = frame.Convert<Gray, byte>();

				//finding faces
				Faces = faceCascade.Detect(grayFrame);

				if (Faces.Length != 0) {//when found calculate distance
					frame.Draw(Faces[0].rect, new Bgr(0, 255, 127), 5);
					d = calculate(Faces[0].rect.Height); //calculate

                    //updating window info
                    Action updateLabel = () => labeld.Text = d.ToString("0.00") + " cm";
					labeld.Invoke(updateLabel);
				}
				else {
					Action updateLabel = () => labeld.Text = "NaN";
					labeld.Invoke(updateLabel);
				}


				count = 0;
			}

			webcamOut.Image = frame.ToBitmap();
			count++;
		}

		private double calculate(int hPx) {

			double h = Convert.ToDouble(numericRealHeight.Value);
			double H = hPx / 1400.0;
			double f = 0.4;

			double d = f * (1 + h / H);

			return d;

		}

		private void stopButton_Click(object sender, EventArgs e) {

			count = 0;

			if (capture != null) {
				capture.Stop();
				capture.ImageGrabbed -= ProcessFrame;
				webcamOut.Image = null;

				recButton.Enabled = true;
				stopButton.Enabled = false;

                labeld.Text = "Stopped";
            }
		}

		private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
			stopButton_Click(sender, e);
		}
	}
}
