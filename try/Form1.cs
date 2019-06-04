using System;
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
        PictureBox bellyful;
        PictureBox happiness;
        LiveElements heart;
        LiveElements catFace;
        MessageBox messageBox;

        public ShityCat()
        {
            InitializeComponent();
            cat = new Animation(20, 100, 300, this, "..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");
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
        }

        private void ShityCat_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            cat.DrawAndChange(e.Graphics);
            if(heart.Lenght()==3 && catFace.Lenght()==3)
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
                cat.DrawAndChange(e.Graphics, "..\\..\\images\\dead_0.jpg", "..\\..\\images\\dead_1.jpg");
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
    }
}
