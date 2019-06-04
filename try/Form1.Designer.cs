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
            this.end_game = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.PictureBox();
            this.yes = new System.Windows.Forms.PictureBox();
            this.no = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPlay)).BeginInit();
            this.end_game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).BeginInit();
            this.SuspendLayout();
            // 
            // toFeed
            // 
            this.toFeed.Image = ((System.Drawing.Image)(resources.GetObject("toFeed.Image")));
            this.toFeed.Location = new System.Drawing.Point(435, 149);
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
            this.toPlay.Location = new System.Drawing.Point(435, 289);
            this.toPlay.Name = "toPlay";
            this.toPlay.Size = new System.Drawing.Size(200, 65);
            this.toPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toPlay.TabIndex = 1;
            this.toPlay.TabStop = false;
            this.toPlay.Click += new System.EventHandler(this.toPlay_Click);
            this.toPlay.MouseEnter += new System.EventHandler(this.toPlay_MouseEnter);
            this.toPlay.MouseLeave += new System.EventHandler(this.toPlay_MouseLeave);
            // 
            // end_game
            // 
            this.end_game.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("end_game.BackgroundImage")));
            this.end_game.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.end_game.Controls.Add(this.no);
            this.end_game.Controls.Add(this.yes);
            this.end_game.Controls.Add(this.text);
            this.end_game.Location = new System.Drawing.Point(35, 12);
            this.end_game.Name = "end_game";
            this.end_game.Size = new System.Drawing.Size(609, 433);
            this.end_game.TabIndex = 2;
            this.end_game.Visible = false;
            // 
            // text
            // 
            this.text.Image = ((System.Drawing.Image)(resources.GetObject("text.Image")));
            this.text.Location = new System.Drawing.Point(86, 50);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(441, 210);
            this.text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.text.TabIndex = 0;
            this.text.TabStop = false;
            // 
            // yes
            // 
            this.yes.Image = ((System.Drawing.Image)(resources.GetObject("yes.Image")));
            this.yes.Location = new System.Drawing.Point(148, 311);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(106, 71);
            this.yes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yes.TabIndex = 1;
            this.yes.TabStop = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            this.yes.MouseEnter += new System.EventHandler(this.yes_MouseEnter);
            this.yes.MouseLeave += new System.EventHandler(this.yes_MouseLeave);
            // 
            // no
            // 
            this.no.Image = ((System.Drawing.Image)(resources.GetObject("no.Image")));
            this.no.Location = new System.Drawing.Point(350, 311);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(151, 71);
            this.no.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.no.TabIndex = 2;
            this.no.TabStop = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            this.no.MouseEnter += new System.EventHandler(this.no_MouseEnter);
            this.no.MouseLeave += new System.EventHandler(this.no_MouseLeave);
            // 
            // ShityCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(671, 457);
            this.Controls.Add(this.end_game);
            this.Controls.Add(this.toPlay);
            this.Controls.Add(this.toFeed);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShityCat";
            this.Text = "ShityCat";
            this.Load += new System.EventHandler(this.ShityCat_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShityCat_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.toFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toPlay)).EndInit();
            this.end_game.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox toFeed;
        private System.Windows.Forms.PictureBox toPlay;
        private System.Windows.Forms.Panel end_game;
        private System.Windows.Forms.PictureBox text;
        private System.Windows.Forms.PictureBox no;
        private System.Windows.Forms.PictureBox yes;
    }
}

