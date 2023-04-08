using Captura;
using System.Windows;

namespace ScreenRecorder
{
    public partial class Form1 : Form
    {
        bool recordingInProgress = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



            var rec = new Recorder(new RecorderParams("out.avi", 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 70));
            Console.WriteLine();
            label1.Text = "Press 'Stop' to end recording.";


            // Finish Writing
            if (recordingInProgress)
            {
                rec.Dispose();
                recordingInProgress = false;
            }


        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            recordingInProgress = true;
        }
    }
}