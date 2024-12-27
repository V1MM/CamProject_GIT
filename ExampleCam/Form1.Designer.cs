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
            imageBoxLive = new Emgu.CV.UI.ImageBox();
            imageBoxFace = new Emgu.CV.UI.ImageBox();
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
            groupBox1 = new GroupBox();
            Recognizer = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            textBoxImageFolder = new TextBox();
            buttonBrowser = new Button();
            label2 = new Label();
            label1 = new Label();
            checkBoxSnap = new CheckBox();
            checkBoxRecog = new CheckBox();
            groupBox2 = new GroupBox();
            textBoxLog = new TextBox();
            groupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxFace).BeginInit();
            groupBoxControl.SuspendLayout();
            groupBox1.SuspendLayout();
            Recognizer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxView
            // 
            groupBoxView.Controls.Add(imageBoxLive);
            groupBoxView.Location = new Point(81, 31);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(537, 402);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "Live View";
            // 
            // imageBoxLive
            // 
            imageBoxLive.Location = new Point(15, 26);
            imageBoxLive.Name = "imageBoxLive";
            imageBoxLive.Size = new Size(511, 358);
            imageBoxLive.TabIndex = 2;
            imageBoxLive.TabStop = false;
            // 
            // imageBoxFace
            // 
            imageBoxFace.Location = new Point(6, 23);
            imageBoxFace.Name = "imageBoxFace";
            imageBoxFace.Size = new Size(189, 181);
            imageBoxFace.TabIndex = 2;
            imageBoxFace.TabStop = false;
            imageBoxFace.Click += imageBoxFace_Click;
            // 
            // groupBoxControl
            // 
            groupBoxControl.Controls.Add(buttonFlipH);
            groupBoxControl.Controls.Add(buttonFlipV);
            groupBoxControl.Controls.Add(buttonStart);
            groupBoxControl.Controls.Add(buttonConnect);
            groupBoxControl.Location = new Point(331, 439);
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
            CamStatus.Location = new Point(1050, 561);
            CamStatus.Name = "CamStatus";
            CamStatus.Size = new Size(129, 20);
            CamStatus.TabIndex = 2;
            CamStatus.Text = "Status: Disconnect";
            // 
            // RecStatus
            // 
            RecStatus.AutoSize = true;
            RecStatus.BackColor = Color.RosyBrown;
            RecStatus.Location = new Point(1050, 583);
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
            statusLabelClock.Location = new Point(28, 561);
            statusLabelClock.Name = "statusLabelClock";
            statusLabelClock.Size = new Size(42, 20);
            statusLabelClock.TabIndex = 4;
            statusLabelClock.Text = "Time";
            // 
            // statusLabelDate
            // 
            statusLabelDate.AutoSize = true;
            statusLabelDate.Location = new Point(28, 583);
            statusLabelDate.Name = "statusLabelDate";
            statusLabelDate.Size = new Size(35, 20);
            statusLabelDate.TabIndex = 5;
            statusLabelDate.Text = "Day";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(imageBoxFace);
            groupBox1.Location = new Point(624, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 213);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Face";
            // 
            // Recognizer
            // 
            Recognizer.Controls.Add(numericUpDown1);
            Recognizer.Controls.Add(textBoxImageFolder);
            Recognizer.Controls.Add(buttonBrowser);
            Recognizer.Controls.Add(label2);
            Recognizer.Controls.Add(label1);
            Recognizer.Controls.Add(checkBoxSnap);
            Recognizer.Controls.Add(checkBoxRecog);
            Recognizer.Location = new Point(842, 31);
            Recognizer.Name = "Recognizer";
            Recognizer.Size = new Size(337, 213);
            Recognizer.TabIndex = 7;
            Recognizer.TabStop = false;
            Recognizer.Text = "Recognizer";
            Recognizer.Enter += groupBox2_Enter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(159, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // textBoxImageFolder
            // 
            textBoxImageFolder.Location = new Point(7, 123);
            textBoxImageFolder.Name = "textBoxImageFolder";
            textBoxImageFolder.Size = new Size(314, 27);
            textBoxImageFolder.TabIndex = 6;
            // 
            // buttonBrowser
            // 
            buttonBrowser.Location = new Point(227, 167);
            buttonBrowser.Name = "buttonBrowser";
            buttonBrowser.Size = new Size(94, 29);
            buttonBrowser.TabIndex = 5;
            buttonBrowser.Text = "Browse";
            buttonBrowser.UseVisualStyleBackColor = true;
            buttonBrowser.Click += buttonBrowser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 94);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 4;
            label2.Text = "Training Image(s) Folder";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 58);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 3;
            label1.Text = "sec / image";
            // 
            // checkBoxSnap
            // 
            checkBoxSnap.AutoSize = true;
            checkBoxSnap.Location = new Point(6, 56);
            checkBoxSnap.Name = "checkBoxSnap";
            checkBoxSnap.Size = new Size(142, 24);
            checkBoxSnap.TabIndex = 1;
            checkBoxSnap.Text = "On/Off Snapshot";
            checkBoxSnap.UseVisualStyleBackColor = true;
            checkBoxSnap.CheckedChanged += checkBoxSnap_CheckedChanged;
            // 
            // checkBoxRecog
            // 
            checkBoxRecog.AutoSize = true;
            checkBoxRecog.Location = new Point(6, 26);
            checkBoxRecog.Name = "checkBoxRecog";
            checkBoxRecog.Size = new Size(155, 24);
            checkBoxRecog.TabIndex = 0;
            checkBoxRecog.Text = "On/Off Recognizer";
            checkBoxRecog.UseVisualStyleBackColor = true;
            checkBoxRecog.CheckedChanged += checkBoxRecog_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxLog);
            groupBox2.Location = new Point(630, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 175);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Log";
            // 
            // textBoxLog
            // 
            textBoxLog.BorderStyle = BorderStyle.FixedSingle;
            textBoxLog.Location = new Point(9, 25);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.Size = new Size(534, 132);
            textBoxLog.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 612);
            Controls.Add(groupBox2);
            Controls.Add(Recognizer);
            Controls.Add(groupBox1);
            Controls.Add(statusLabelDate);
            Controls.Add(statusLabelClock);
            Controls.Add(RecStatus);
            Controls.Add(CamStatus);
            Controls.Add(groupBoxControl);
            Controls.Add(groupBoxView);
            Name = "Form1";
            Text = "z";
            groupBoxView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBoxFace).EndInit();
            groupBoxControl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            Recognizer.ResumeLayout(false);
            Recognizer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private GroupBox Recognizer;
        private GroupBox groupBox2;
        private CheckBox checkBoxSnap;
        private CheckBox checkBoxRecog;
        private TextBox textBoxLog;
        private Button buttonBrowser;
        private Label label2;
        private Label label1;
        private TextBox textBoxImageFolder;
        private NumericUpDown numericUpDown1;
    }
}
