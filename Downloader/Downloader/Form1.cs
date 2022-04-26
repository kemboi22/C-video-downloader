using AltoHttp;

namespace Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            httpDownloader = new HttpDownloader(txtURL.Text, $"{Application.StartupPath}\\{Path.GetFileName(txtURL.Text)}");
            httpDownloader.DownloadCompleted += httpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += httpDownloader_ProgressChanged;
            httpDownloader.Start();
        }

        private void httpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            btnPercent.Text = $"{e.Progress.ToString("0.00")}%";
            btnSpeed.Text = String.Format("{0}MB/s", (e.SpeedInBytes/1024d/1024d).ToString("0.00"));
            btnDownloaded.Text = String.Format("{0}MB", (httpDownloader.TotalBytesReceived/1024d/1024d).ToString("0.00"));
            btnStatus.Text = "Downloading...";

        }

        private void httpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                btnStatus.Text = "Finish";
                btnStatus.Text = "100%";
            });
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(httpDownloader != null)
            {
                httpDownloader.Pause();
            }
            
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
            {
                httpDownloader.Resume();
            }

        }
    }
}