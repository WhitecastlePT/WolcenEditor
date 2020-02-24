namespace WolcenEditor
{
    partial class WolcenSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WolcenSplashScreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.versionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(171, 275);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 1);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Constantia", 8F);
            this.versionLabel.ForeColor = System.Drawing.Color.Lime;
            this.versionLabel.Location = new System.Drawing.Point(367, 263);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(65, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version 0.0.1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Lime;
            this.titleLabel.Location = new System.Drawing.Point(12, 263);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Wolcen editor by h.m.c.";
            // 
            // WolcenSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WolcenEditor.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(444, 290);
            this.ControlBox = false;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WolcenSplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wolcen Editor";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}