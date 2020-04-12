namespace WindowsFormsApp1
{
    partial class loader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loader));
            this.panelLoader = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.loaderDots = new System.Windows.Forms.Label();
            this.panelLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoader
            // 
            this.panelLoader.BackColor = System.Drawing.Color.FloralWhite;
            this.panelLoader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoader.Controls.Add(this.panelLine);
            this.panelLoader.Location = new System.Drawing.Point(383, 252);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(304, 27);
            this.panelLoader.TabIndex = 0;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(198)))), ((int)(((byte)(45)))));
            this.panelLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLine.Location = new System.Drawing.Point(1, 1);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(0, 23);
            this.panelLine.TabIndex = 1;
            // 
            // timerLoader
            // 
            this.timerLoader.Enabled = true;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ParsekCTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(455, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Загрузка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loaderDots
            // 
            this.loaderDots.AutoSize = true;
            this.loaderDots.Font = new System.Drawing.Font("ParsekCTT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loaderDots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.loaderDots.Location = new System.Drawing.Point(569, 204);
            this.loaderDots.Name = "loaderDots";
            this.loaderDots.Size = new System.Drawing.Size(39, 34);
            this.loaderDots.TabIndex = 1;
            this.loaderDots.Text = "...";
            this.loaderDots.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(198)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(736, 458);
            this.ControlBox = false;
            this.Controls.Add(this.loaderDots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLoader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Timer timerLoader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loaderDots;
    }
}