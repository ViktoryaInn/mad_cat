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
        ImportantThing[] hearts = new ImportantThing[3];
        ImportantThing[] catFaces = new ImportantThing[3];
        Timer timer = new Timer();
        int seconds = 0;
        int recSide = 300;
        bool flag = true;
        PictureBox bellyful = new PictureBox();
        PictureBox happiness = new PictureBox();
        //LiveElements heart;
        //LiveElements catFace;

        public ShityCat()
        {
            InitializeComponent();
            cat = new Animation(100, 100, recSide, recSide, this, "..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");

            bellyful.Location = new Point(0, 0);
            bellyful.Size = new Size(130, 40);
            bellyful.Image = Image.FromFile("..\\..\\images\\bellyful.jpg");
            bellyful.SizeMode = PictureBoxSizeMode.StretchImage;
            happiness.Location = new Point(0, 50);
            happiness.Size = new Size(120, 40);
            happiness.Image = Image.FromFile("..\\..\\images\\happiness.jpg");
            happiness.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(bellyful);
            this.Controls.Add(happiness);

            //heart = new LiveElements(130, 0, 120, 40, 1000, this, "..\\..\\images\\hearts_3.jpg",
            //"..\\..\\images\\hearts_2.jpg", "..\\..\\images\\hearts_1.jpg", "..\\..\\images\\zero.jpg");
            //catFace = new LiveElements(130, 50, 120, 40, 2000, this, "..\\..\\images\\catFace_3.jpg",
            //"..\\..\\images\\catFace_2.jpg", "..\\..\\images\\catFace_1.jpg", "..\\..\\images\\zero.jpg");
            hearts[0] = new ImportantThing(130, 0, 40, 40, this, 12000, "..\\..\\images\\heart.jpg");
            hearts[1] = new ImportantThing(170, 0, 40, 40, this, 8000, "..\\..\\images\\heart.jpg");
            hearts[2] = new ImportantThing(210, 0, 40, 40, this, 4000, "..\\..\\images\\heart.jpg");

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            seconds += 100;
            if ((seconds / 2000) % 2 == 0) flag = false;
            else flag = true;
        }

        private void ShityCat_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            //heart.Draw(e.Graphics);
            //catFace.Draw(e.Graphics);
            if (flag == false)
            {
                cat.ChangeImage("..\\..\\images\\lff_0.jpg", "..\\..\\images\\lff_1.jpg");
                cat.Draw(e.Graphics);
            }
            else
            {
                cat.ChangeImage("..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");
                cat.Draw(e.Graphics);
            }
        }

        private void ShityCat_Load(object sender, EventArgs e)
        {

        }

        private void toFeed_MouseEnter(object sender, EventArgs e) => toFeed.Image = Image.FromFile("..\\..\\images\\toFeed_d.jpg");

        private void toFeed_MouseLeave(object sender, EventArgs e) => toFeed.Image = Image.FromFile("..\\..\\images\\toFeed.jpg");

        private void toPlay_MouseEnter(object sender, EventArgs e) => toPlay.Image = Image.FromFile("..\\..\\images\\toPlay_d.jpg");

        private void toPlay_MouseLeave(object sender, EventArgs e) => toPlay.Image = Image.FromFile("..\\..\\images\\toPlay.jpg");

        private void toFeed_Click(object sender, EventArgs e)
        {
            
            toFeed.Image = Image.FromFile("..\\..\\images\\toFeed_c.jpg");
            if ((hearts[2].Visible() == false) && (hearts[0].Visible() == true) && (hearts[1].Visible() == true))
            {
                hearts[2].Restore();
                hearts[0].RestartTimer();
                hearts[1].RestartTimer();
            }
            else
            {
                if ((hearts[2].Visible() == false) && (hearts[0].Visible() == true) && (hearts[1].Visible() == false))
                {
                    hearts[1].Restore();
                    hearts[0].RestartTimer();
                    hearts[2].RestartTimer();
                }
                else
                {
                    if ((hearts[2].Visible() == false) && (hearts[0].Visible() == false) && (hearts[1].Visible() == false))
                    {
                        hearts[0].Restore();
                        hearts[1].RestartTimer();
                        hearts[2].RestartTimer();
                    }
                    //нужно как-то связать сердечки и тацмер, чтобы они работали сообща , а не каждое жило своей отдельной жизнью так сказать
                }
            }
        }

        private void toPlay_Click(object sender, EventArgs e)
        {
            toPlay.Image = Image.FromFile("..\\..\\images\\toPlay_c.jpg");
        }
    }
}
