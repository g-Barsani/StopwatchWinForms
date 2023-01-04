using System.Diagnostics;
namespace StopwatchWinForms
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            //this.timespan.Text = "00:00:00:0000";
            stopwatch.Restart();
            stopwatch.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timespan.Text = string.Format("{0:hh\\:mm\\:ss\\:ffff}", stopwatch.Elapsed);

        }
    }
}