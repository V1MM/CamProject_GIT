namespace ExampleCam
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
            components = new System.ComponentModel.Container();
            groupBoxView = new GroupBox();
            imageBoxFace = new Emgu.CV.UI.ImageBox();
            imageBoxLive = new Emgu.CV.UI.ImageBox();
            groupBoxControl = new GroupBox();
            buttonFlipH = new Button();
            buttonFlipV = new Button();
            buttonStart = new Button();
            buttonConnect = new Button();
            CamStatus = new Label();
            RecStatus = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusLabelClock = new Label();
            statusLabelDate = new Label();
            groupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxFace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).BeginInit();
            groupBoxControl.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxView
            // 
            groupBoxView.Controls.Add(imageBoxFace);
            groupBoxView.Controls.Add(imageBoxLive);
            groupBoxView.Location = new Point(137, 31);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(830, 390);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "Live View";
            // 
            // imageBoxFace
            // 
            imageBoxFace.Location = new Point(612, 90);
            imageBoxFace.Name = "imageBoxFace";
            imageBoxFace.Size = new Size(198, 246);
            imageBoxFace.TabIndex = 2;
            imageBoxFace.TabStop = false;
            // 
            // imageBoxLive
            // 
            imageBoxLive.Location = new Point(6, 26);
            imageBoxLive.Name = "imageBoxLive";
            imageBoxLive.Size = new Size(572, 358);
            imageBoxLive.TabIndex = 2;
            imageBoxLive.TabStop = false;
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(buttonFlipH);
            groupBoxControl.Controls.Add(buttonFlipV);
            groupBoxControl.Controls.Add(buttonStart);
            groupBoxControl.Controls.Add(buttonConnect);
            groupBoxControl.Location = new Point(286, 439);
            groupBoxControl.Name = "groupBoxControl";
            groupBoxControl.Size = new Size(538, 142);
            groupBoxControl.TabIndex = 1;
            groupBoxControl.TabStop = false;
            groupBoxControl.Text = "Control Panel";
            groupBoxControl.Enter += groupBoxControl_Enter;
            // 
            // buttonFlipH
            // 
            buttonFlipH.Location = new Point(309, 38);
            buttonFlipH.Name = "buttonFlipH";
            buttonFlipH.Size = new Size(94, 83);
            buttonFlipH.TabIndex = 5;
            buttonFlipH.Text = "Flip H";
            buttonFlipH.UseVisualStyleBackColor = true;
            buttonFlipH.Click += buttonFlipH_Click;
            // 
            // buttonFlipV
            // 
            buttonFlipV.Location = new Point(418, 38);
            buttonFlipV.Name = "buttonFlipV";
            buttonFlipV.Size = new Size(94, 83);
            buttonFlipV.TabIndex = 4;
            buttonFlipV.Text = "Flip V";
            buttonFlipV.UseVisualStyleBackColor = true;
            buttonFlipV.Click += buttonFlipV_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(181, 38);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(97, 83);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(68, 38);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(98, 83);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // CamStatus
            // 
            CamStatus.AutoSize = true;
            CamStatus.BackColor = Color.RosyBrown;
            CamStatus.Location = new Point(986, 561);
            CamStatus.Name = "CamStatus";
            CamStatus.Size = new Size(129, 20);
            CamStatus.TabIndex = 2;
            CamStatus.Text = "Status: Disconnect";
            // 
            // RecStatus
            // 
            RecStatus.AutoSize = true;
            RecStatus.BackColor = Color.RosyBrown;
            RecStatus.Location = new Point(986, 583);
            RecStatus.Name = "RecStatus";
            RecStatus.Size = new Size(104, 20);
            RecStatus.TabIndex = 3;
            RecStatus.Text = "Recording: No";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // statusLabelClock
            // 
            statusLabelClock.AutoSize = true;
            statusLabelClock.Location = new Point(986, 9);
            statusLabelClock.Name = "statusLabelClock";
            statusLabelClock.Size = new Size(50, 20);
            statusLabelClock.TabIndex = 4;
            statusLabelClock.Text = "label1";
            // 
            // statusLabelDate
            // 
            statusLabelDate.AutoSize = true;
            statusLabelDate.Location = new Point(986, 31);
            statusLabelDate.Name = "statusLabelDate";
            statusLabelDate.Size = new Size(50, 20);
            statusLabelDate.TabIndex = 5;
            statusLabelDate.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 612);
            Controls.Add(statusLabelDate);
            Controls.Add(statusLabelClock);
            Controls.Add(RecStatus);
            Controls.Add(CamStatus);
            Controls.Add(groupBoxControl);
            Controls.Add(groupBoxView);
            Name = "Form1";
            Text = "z";
            groupBoxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBoxFace).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).EndInit();
            groupBoxControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxView;
        private GroupBox groupBoxControl;
        private Button buttonFlipH;
        private Button buttonFlipV;
        private Button buttonStart;
        private Button buttonConnect;
        private Emgu.CV.UI.ImageBox imageBoxLive;
        private Label CamStatus;
        private Label RecStatus;
        private System.Windows.Forms.Timer timer1;
        private Emgu.CV.UI.ImageBox imageBoxFace;
        private Label statusLabelClock;
        private Label statusLabelDate;
    }
}
