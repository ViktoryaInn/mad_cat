namespace mad_cat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToFeed = new System.Windows.Forms.PictureBox();
            this.ToPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ToFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // ToFeed
            // 
            this.ToFeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ToFeed.Image = ((System.Drawing.Image)(resources.GetObject("ToFeed.Image")));
            this.ToFeed.Location = new System.Drawing.Point(900, 26);
            this.ToFeed.Name = "ToFeed";
            this.ToFeed.Size = new System.Drawing.Size(470, 250);
            this.ToFeed.TabIndex = 0;
            this.ToFeed.TabStop = false;
            this.ToFeed.Click += new System.EventHandler(this.ToFeed_Click);
            // 
            // ToPlay
            // 
            this.ToPlay.Image = ((System.Drawing.Image)(resources.GetObject("ToPlay.Image")));
            this.ToPlay.Location = new System.Drawing.Point(917, 282);
            this.ToPlay.Name = "ToPlay";
            this.ToPlay.Size = new System.Drawing.Size(470, 250);
            this.ToPlay.TabIndex = 1;
            this.ToPlay.TabStop = false;
            this.ToPlay.Click += new System.EventHandler(this.ToPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.ToPlay);
            this.Controls.Add(this.ToFeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ToFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ToFeed;
        private System.Windows.Forms.PictureBox ToPlay;
    }
}

