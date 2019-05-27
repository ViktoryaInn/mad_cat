namespace @try
{
    partial class ShityCat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShityCat));
            this.toFeed = new System.Windows.Forms.PictureBox();
            this.toPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // toFeed
            // 
            this.toFeed.Image = ((System.Drawing.Image)(resources.GetObject("toFeed.Image")));
            this.toFeed.Location = new System.Drawing.Point(550, 100);
            this.toFeed.Margin = new System.Windows.Forms.Padding(0);
            this.toFeed.Name = "toFeed";
            this.toFeed.Size = new System.Drawing.Size(209, 70);
            this.toFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toFeed.TabIndex = 0;
            this.toFeed.TabStop = false;
            this.toFeed.Click += new System.EventHandler(this.toFeed_Click);
            this.toFeed.MouseEnter += new System.EventHandler(this.toFeed_MouseEnter);
            this.toFeed.MouseLeave += new System.EventHandler(this.toFeed_MouseLeave);
            // 
            // toPlay
            // 
            this.toPlay.Image = ((System.Drawing.Image)(resources.GetObject("toPlay.Image")));
            this.toPlay.Location = new System.Drawing.Point(550, 250);
            this.toPlay.Name = "toPlay";
            this.toPlay.Size = new System.Drawing.Size(200, 65);
            this.toPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toPlay.TabIndex = 1;
            this.toPlay.TabStop = false;
            this.toPlay.Click += new System.EventHandler(this.toPlay_Click);
            this.toPlay.MouseEnter += new System.EventHandler(this.toPlay_MouseEnter);
            this.toPlay.MouseLeave += new System.EventHandler(this.toPlay_MouseLeave);
            // 
            // ShityCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.toPlay);
            this.Controls.Add(this.toFeed);
            this.DoubleBuffered = true;
            this.Name = "ShityCat";
            this.Text = "ShityCat";
            this.Load += new System.EventHandler(this.ShityCat_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShityCat_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.toFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox toFeed;
        private System.Windows.Forms.PictureBox toPlay;
    }
}

