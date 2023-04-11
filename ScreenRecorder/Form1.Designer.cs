namespace ScreenRecorder
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
            buttonStop = new Button();
            label1 = new Label();
            buttonCapture = new Button();
            videoView1 = new VisioForge.Core.UI.WinForms.VideoView();
            SuspendLayout();
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(18, 12);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(78, 29);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "start";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(102, 12);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(94, 29);
            buttonCapture.TabIndex = 6;
            buttonCapture.Text = "stop";
            buttonCapture.UseVisualStyleBackColor = true;
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(213, 12);
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(250, 125);
            videoView1.StatusOverlay = null;
            videoView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 159);
            Controls.Add(videoView1);
            Controls.Add(buttonCapture);
            Controls.Add(label1);
            Controls.Add(buttonStop);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonStop;
        private Label label1;
        private Button buttonCapture;
        private VisioForge.Core.UI.WinForms.VideoView videoView1;
    }
}