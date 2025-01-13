using System.Drawing.Printing;
using Emgu.CV;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using Emgu.CV.XImgproc;
using System.IO;
using Emgu.CV.Dai;

namespace ExampleCam
{
    public partial class Form1 : Form
    {
        private VideoCapture? _capture = null;
        private Mat? _frame;
        private bool IsConnect = true;
        private bool IsRecord = true;

        private System.Windows.Forms.Timer snapshortTimer = new System.Windows.Forms.Timer();

        private string imageSaveFolder = "";
        private bool isSnapshotActive = false;
        private bool isRecording = false;

        CascadeClassifier _cascadeClassifier = new CascadeClassifier(@"C:\Users\nenea\Downloads\emgucv-master\emgucv-master\opencv\haarcascade_frontalface_default.xml");

        public Form1()
        {
            InitializeComponent();
            buttonStart.Enabled = false;
            buttonFlipV.Enabled = false;
            buttonFlipH.Enabled = false;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

            snapshotTimer.Tick += SnapshotTimer_Tick;

        }

        private void ProcessFrame(object sender, EventArgs e)
        {

            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                using (var imageFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
                {
                    if (imageFrame != null)
                    {
                        var grayframe = imageFrame.Convert<Gray, byte>();
                        var faces = _cascadeClassifier.DetectMultiScale(grayframe, 1.1, 10);

                        foreach (var face in faces)
                        {
                            imageFrame.Draw(face, new Bgr(Color.MistyRose), 3);
                        }
                        imageBoxLive.Image = imageFrame;

                        if (faces.Length > 0)
                        {
                            Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, 190, 190);
                            grayframe.ROI = face_roi;
                            imageBoxFace.Image = grayframe.Copy();
                        }
                    }

                    //bool canCapture = _capture.Retrieve(_frame, 0);
                    //if (canCapture)
                    //{

                    //    imageBox1.Image = _frame;
                    //}

                }
            }
        }


        private async void buttonConnect_Click(object sender, EventArgs e)
        {



            if (IsConnect)
            {
                await WaitConnectCam();
                await Connect();

                buttonConnect.Text = "Disconnect";

                buttonStart.Enabled = true;
                buttonFlipV.Enabled = true;
                buttonFlipH.Enabled = true;
            }
            else
            {
                Disconnect();
                buttonConnect.Text = "Connect";
                buttonStart.Enabled = false;
                buttonFlipV.Enabled = false;
                buttonFlipH.Enabled = false;

            }
            IsConnect = !IsConnect;


        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {

            try
            {
                if (_capture != null)
                {
                    _capture.Pause();
                    _capture.ImageGrabbed -= ProcessFrame;
                    _capture.Dispose();

                }
                if (_frame != null)
                {
                    _frame.Dispose();
                }

                DisconnectCam();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }

        private void Disconnect()
        {
            try
            {
                if (_capture != null)
                {
                    _capture.Pause();
                    _capture.ImageGrabbed -= ProcessFrame;
                    _capture.Dispose();

                }
                if (_frame != null)
                {
                    _frame.Dispose();
                }

                DisconnectCam();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }

        private async Task Connect()
        {
            try
            {
                await Task.Run(() =>
                {
                    _capture = new VideoCapture();
                    _frame = new Mat();

                });

                if (_capture != null)
                {
                    _capture.ImageGrabbed += ProcessFrame;
                    ConnectCam();
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (IsRecord)
            {

                if (_capture != null)
                {
                    _capture.Start();
                }
                isRecording = true;
                Recording();
                buttonStart.Text = "Pause";
                buttonConnect.Enabled = false;
            }
            else
            {
                if (_capture != null)
                {
                    _capture.Pause();
                }
                isRecording = false;
                NoRecording();


                buttonStart.Text = "Start";
                buttonConnect.Enabled = true;
            }
            IsRecord = !IsRecord;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause();
            }
        }

        private void buttonFlipV_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.FlipHorizontal = !_capture.FlipHorizontal;
            }

        }

        private void buttonFlipH_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.FlipVertical = !_capture.FlipVertical;
            }

        }

        private async void ConnectCam()
        {
            CamStatus.Text = "Status:Connect";
            CamStatus.BackColor = Color.LimeGreen;
        }

        private async Task WaitConnectCam()
        {
            CamStatus.Text = "Status:Waiting";
            CamStatus.BackColor = Color.CadetBlue;
            await Task.Delay(1000);
        }

        private async void DisconnectCam()
        {
            CamStatus.Text = "Status: Disconnect";
            CamStatus.BackColor = Color.RosyBrown;
        }

        private async void Recording()
        {
            RecStatus.Text = "Recording: Yes";
            RecStatus.BackColor = Color.LimeGreen;
        }

        private async void NoRecording()
        {
            RecStatus.Text = "Recording: No";
            RecStatus.BackColor = Color.RosyBrown;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string formatStringClock = "HH:mm:ss";
            string formatStringDate = "yyyy-MMM-dd";

            DateTime dateNow = DateTime.Now;
            statusLabelClock.Text = dateNow.ToString(formatStringClock);
            statusLabelDate.Text = dateNow.ToString(formatStringDate);

        }

        private void groupBoxControl_Enter(object sender, EventArgs e)
        {

        }

        private void imageBoxFace_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxImageFolder.Text = diag.SelectedPath;
                imageSaveFolder = diag.SelectedPath;
            }
            else
            {
                textBoxImageFolder.Text = "You didn't select any folder! ";
            }

        }

        private void checkBoxSnap_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSnap.Checked == true)
            {
                if (isSnapshotActive)
                {
                    MessageBox.Show("Snapshot is currently active. Please stop it before enabling/disabling.");
                    checkBoxSnap.Checked = !checkBoxSnap.Checked;
                    return;
                }

                if (string.IsNullOrEmpty(imageSaveFolder))
                {
                    MessageBox.Show("Please select a folder to save images first!");
                    checkBoxSnap.Checked = false;
                    return;
                }
                try
                {

                    int interval = (int)numericUpDown1.Value * 1000;
                    snapshortTimer.Interval = interval;

                    if (interval == 0)
                    {
                        snapshortTimer.Stop();
                    }

                    snapshortTimer.Start();
                    isSnapshotActive = true;
                    buttonConnect.Enabled = false;
                }
                catch (Exception ex)
                {
                    checkBoxSnap.Checked = false;
                    MessageBox.Show("Inverval Should not be 0");

                }

                checkBoxRecog.Enabled = false;
            }
            else
            {
                checkBoxRecog.Enabled = true;
                snapshortTimer.Stop();
                isSnapshotActive = false;
                buttonConnect.Enabled = true;
            }

        }

        private void checkBoxRecog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecog.Checked)
            {
                checkBoxSnap.Enabled = false;
            }
            else
            {
                checkBoxSnap.Enabled = true;
            }
        }

        private void SnapshotTimer_Tick(object sender, EventArgs e)
        {
            if (!isRecording || !checkBoxSnap.Checked || _capture == null || _capture.Ptr == IntPtr.Zero) return;

            using (var imageFrame = _capture.QueryFrame().ToImage<Bgr, Byte>())
            {
                if (imageFrame != null)
                {
                    var grayFrame = imageFrame.Convert<Gray, byte>();
                    var faces = _cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 10);

                    if (faces.Length > 0)
                    {
                        try
                        {
                            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                            string filePath = Path.Combine(imageSaveFolder, $"Snapshot_{timestamp}.png");

                            Rectangle face_roi = new Rectangle(faces[0].X, faces[0].Y, faces[0].Width, faces[0].Height);
                            grayFrame.ROI = face_roi;
                            var faceImage = grayFrame.Copy();
                            // Save Image
                            faceImage.Save(filePath);

                            textBoxLog.AppendText($"Snapshot saved to : {filePath}{Environment.NewLine}");
                            textBoxLog.AppendText($"Timer Interval: {snapshortTimer.Interval} ms{Environment.NewLine}");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving snapshot: {ex.Message}");
                        }

                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int interval = (int)numericUpDown1.Value * 1000;


            if (interval == 0)
            {
                if (snapshortTimer.Enabled)
                {
                    MessageBox.Show("Interval cannot be 0. Please set a valid time interval.");
                    checkBoxSnap.Checked = false;
                    snapshortTimer.Stop();
                }
                return;
            }

            snapshortTimer.Interval = interval;

            if (isSnapshotActive)
            {
                textBoxLog.AppendText($"Timer Interval updated: {snapshortTimer.Interval} ms{Environment.NewLine}");
            }
        }

        private void snapshotTimer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
