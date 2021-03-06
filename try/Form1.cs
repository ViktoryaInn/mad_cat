﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace @try
{
    public partial class ShityCat : Form
    {
        Animation cat;
        Timer timer = new Timer();
        Timer timer1 = new Timer();
        PictureBox bellyful;
        PictureBox happiness;
        LiveElements heart;
        LiveElements catFace;
        int seconds = 0;
        int sec = 0;

        public ShityCat()
        {
            InitializeComponent();
            cat = new Animation(20, 100, 300, "..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");
            bellyful = new PictureBox()
            {
                Location = new Point(10, 5),
                Size = new Size(130, 50),
                Image = Image.FromFile("..\\..\\images\\bellyful.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(bellyful);
            happiness = new PictureBox()
            {
                Location = new Point(10, 60),
                Size = new Size(120, 40),
                Image = Image.FromFile("..\\..\\images\\happiness.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };
            this.Controls.Add(happiness);

            heart = new LiveElements(3, 140, 5, 40, 2000, this, Image.FromFile("..\\..\\images\\heart.jpg"));
            catFace = new LiveElements(3, 140, 60, 40, 3000, this, Image.FromFile("..\\..\\images\\catFace.jpg"));

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            seconds += timer.Interval;
        }

        private void ShityCat_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            cat.DrawAndChange(e.Graphics);
            if (heart.Lenght() == 3 && catFace.Lenght() == 3)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");
            else if (heart.Lenght() == 3 && catFace.Lenght() == 2)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\ok_0.jpg", "..\\..\\images\\ok_1.jpg");
            else if (heart.Lenght() == 3 && catFace.Lenght() == 1)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\sad_0.jpg", "..\\..\\images\\sad_1.jpg");
            else if (heart.Lenght() == 3 && catFace.Lenght() == 0)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\very_sad_0.jpg", "..\\..\\images\\very_sad_1.jpg");
            else if (heart.Lenght() == 2 && catFace.Lenght() == 3 || heart.Lenght() == 2 && catFace.Lenght() == 2
                || heart.Lenght() == 2 && catFace.Lenght() == 1 || heart.Lenght() == 2 && catFace.Lenght() == 0)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\dream_0.jpg", "..\\..\\images\\dream_1.jpg");
            else if (heart.Lenght() == 1 && catFace.Lenght() == 3 || heart.Lenght() == 1 && catFace.Lenght() == 2
                || heart.Lenght() == 1 && catFace.Lenght() == 1)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\lff_0.jpg", "..\\..\\images\\lff_1.jpg");
            else if (heart.Lenght() == 0 && catFace.Lenght() == 3 || heart.Lenght() == 0 && catFace.Lenght() == 2
                || heart.Lenght() == 0 && catFace.Lenght() == 1 || heart.Lenght() == 1 && catFace.Lenght() == 0)
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\mad_0.jpg", "..\\..\\images\\mad_1.jpg");
            else if (heart.Lenght() == 0 && catFace.Lenght() == 0)
            {
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\dead_0.jpg", "..\\..\\images\\dead_1.jpg");
                timer1.Interval = 5000;
                timer1.Tick += timer1_Tick;
                timer1.Start();

               
            }
        }

        private void toFeed_Click(object sender, EventArgs e)
        {
            toFeed.Image = Image.FromFile("..\\..\\images\\toFeed_c.jpg");
            if (heart.Lenght() == 2) RestoreElement(0, heart);
            else if (heart.Lenght() == 1) RestoreElement(1, heart);
            else if (heart.Lenght() == 0) RestoreElement(2, heart);
        }

        private void toPlay_Click(object sender, EventArgs e)
        {
            toPlay.Image = Image.FromFile("..\\..\\images\\toPlay_c.jpg");
            if (catFace.Lenght() == 2) RestoreElement(0, catFace);
            else if (catFace.Lenght() == 1) RestoreElement(1, catFace);
            else if (catFace.Lenght() == 0) RestoreElement(2, catFace);
        }
        private void RestoreElement(int i, LiveElements le)
        {
            le.Restore(i);
            le.RestartTimer();
        }

        private void toFeed_MouseEnter(object sender, EventArgs e) => toFeed.Image = Image.FromFile("..\\..\\images\\toFeed_d.jpg");

        private void toFeed_MouseLeave(object sender, EventArgs e) => toFeed.Image = Image.FromFile("..\\..\\images\\toFeed.jpg");

        private void toPlay_MouseEnter(object sender, EventArgs e) => toPlay.Image = Image.FromFile("..\\..\\images\\toPlay_d.jpg");

        private void toPlay_MouseLeave(object sender, EventArgs e) => toPlay.Image = Image.FromFile("..\\..\\images\\toPlay.jpg");

        private void ShityCat_Load(object sender, EventArgs e)
        {

        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            heart.Restore(0);
            heart.Restore(1);
            heart.Restore(2);
            catFace.Restore(0);
            catFace.Restore(1);
            catFace.Restore(2);
            end_game.Visible = false;
            sec = 0;
        }

        private void yes_MouseEnter(object sender, EventArgs e) => yes.Image = Image.FromFile("..\\..\\images\\yes_m.jpg");

        private void yes_MouseLeave(object sender, EventArgs e) => yes.Image = Image.FromFile("..\\..\\images\\yes.jpg");

        private void no_MouseEnter(object sender, EventArgs e) => no.Image = Image.FromFile("..\\..\\images\\no_m.jpg");

        private void no_MouseLeave(object sender, EventArgs e) => no.Image = Image.FromFile("..\\..\\images\\no.jpg");

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 5000;
            if (sec == 5000)
            {
                end_game.Visible = true;
                timer1.Stop();
            }
        }
    }
}
