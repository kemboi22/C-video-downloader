namespace Downloader
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Label();
            this.btnPercent = new System.Windows.Forms.Label();
            this.Downloaded = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.btnDownloaded = new System.Windows.Forms.Label();
            this.btnSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(439, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(520, 106);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "&PAUSE";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(601, 106);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 2;
            this.btnResume.Text = "&RESUME";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(56, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(662, 23);
            this.txtURL.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(63, 62);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(650, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "STATUS";
            // 
            // btnStatus
            // 
            this.btnStatus.AutoSize = true;
            this.btnStatus.Location = new System.Drawing.Point(84, 44);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(22, 15);
            this.btnStatus.TabIndex = 7;
            this.btnStatus.Text = "???";
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSize = true;
            this.btnPercent.Location = new System.Drawing.Point(690, 44);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(23, 15);
            this.btnPercent.TabIndex = 8;
            this.btnPercent.Text = "0%";
            // 
            // Downloaded
            // 
            this.Downloaded.AutoSize = true;
            this.Downloaded.Location = new System.Drawing.Point(12, 148);
            this.Downloaded.Name = "Downloaded";
            this.Downloaded.Size = new System.Drawing.Size(92, 15);
            this.Downloaded.TabIndex = 10;
            this.Downloaded.Text = "DOWNLOADED:";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(61, 186);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(43, 15);
            this.Speed.TabIndex = 10;
            this.Speed.Text = "SPEED:";
            // 
            // btnDownloaded
            // 
            this.btnDownloaded.AutoSize = true;
            this.btnDownloaded.Location = new System.Drawing.Point(110, 148);
            this.btnDownloaded.Name = "btnDownloaded";
            this.btnDownloaded.Size = new System.Drawing.Size(31, 15);
            this.btnDownloaded.TabIndex = 10;
            this.btnDownloaded.Text = "0MB";
            this.btnDownloaded.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.AutoSize = true;
            this.btnSpeed.Location = new System.Drawing.Point(110, 186);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(45, 15);
            this.btnSpeed.TabIndex = 10;
            this.btnSpeed.Text = "OMB/S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 245);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.btnDownloaded);
            this.Controls.Add(this.Downloaded);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "File downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnPause;
        private Button btnResume;
        private Label label1;
        private TextBox txtURL;
        private ProgressBar progressBar;
        private Label label2;
        private Label btnStatus;
        private Label btnPercent;
        private Label Downloaded;
        private Label Speed;
        private Label btnDownloaded;
        private Label btnSpeed;
    }
}