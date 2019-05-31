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
            hearts[0] = new ImportantThing(130, 0, 40, 40, this, 18000, "..\\..\\images\\heart.jpg");
            hearts[1] = new ImportantThing(170, 0, 40, 40, this, 12000, "..\\..\\images\\heart.jpg");
            hearts[2] = new ImportantThing(210, 0, 40, 40, this, 6000, "..\\..\\images\\heart.jpg");
            catFaces[0] = new ImportantThing(130, 50, 40, 40, this, 12000, "..\\..\\images\\catFace.jpg");
            catFaces[1] = new ImportantThing(170, 50, 40, 40, this, 8000, "..\\..\\images\\catFace.jpg");
            catFaces[2] = new ImportantThing(210, 50, 40, 40, this, 4000, "..\\..\\images\\catFace.jpg");

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            //seconds += 100;
            //if ((seconds / 2000) % 2 == 0) flag = false;
            //else flag = true;
        }

        private void ShityCat_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            if (hearts[0].Visible() && hearts[1].Visible() && hearts[2].Visible() &&
                catFaces[0].Visible() && catFaces[1].Visible() && catFaces[2].Visible())
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\happy_0.jpg", "..\\..\\images\\happy_1.jpg");
            if (hearts[0].Visible() && hearts[1].Visible() && hearts[2].Visible() &&
                catFaces[0].Visible() && catFaces[1].Visible() && (!catFaces[2].Visible()))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\ok_0.jpg", "..\\..\\images\\ok_1.jpg");
            else if (hearts[0].Visible() && hearts[1].Visible() && hearts[2].Visible() &&
                catFaces[0].Visible() && (!catFaces[1].Visible()) && (!catFaces[2].Visible()))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\sad_0.jpg", "..\\..\\images\\sad_1.jpg");
            else if (hearts[0].Visible() && hearts[1].Visible() && hearts[2].Visible() &&
                (!catFaces[0].Visible()) && (!catFaces[1].Visible()) && (!catFaces[2].Visible()))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\very_sad_0.jpg", "..\\..\\images\\very_sad_1.jpg");
            else if (hearts[0].Visible() && hearts[1].Visible() && (!hearts[2].Visible()) &&
                (catFaces[0].Visible() && catFaces[1].Visible() && catFaces[2].Visible() ||
                catFaces[0].Visible() && catFaces[1].Visible() && (!catFaces[2].Visible()) ||
                catFaces[0].Visible() && (!catFaces[1].Visible()) && (!catFaces[2].Visible()) ||
                (!catFaces[0].Visible()) && (!catFaces[1].Visible()) && (!catFaces[2].Visible())))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\dream_0.jpg", "..\\..\\images\\dream_1.jpg");
            else if (hearts[0].Visible() && (!hearts[1].Visible()) && (!hearts[2].Visible()) &&
                (catFaces[0].Visible() && catFaces[1].Visible() && catFaces[2].Visible() ||
                catFaces[0].Visible() && catFaces[1].Visible() && (!catFaces[2].Visible()) ||
                catFaces[0].Visible() && (!catFaces[1].Visible()) && (!catFaces[2].Visible())))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\lff_0.jpg", "..\\..\\images\\lff_1.jpg");
            else if (!hearts[0].Visible() && !hearts[1].Visible() && !hearts[2].Visible() &&
                (catFaces[0].Visible() && !catFaces[1].Visible() && !catFaces[2].Visible() ||
                catFaces[0].Visible() && catFaces[1].Visible() && !catFaces[2].Visible() ||
                catFaces[0].Visible() && catFaces[1].Visible() && catFaces[2].Visible()) ||
                (!catFaces[0].Visible() && !catFaces[1].Visible() && !catFaces[2].Visible() &&
                hearts[0].Visible() && !hearts[1].Visible() && !hearts[2].Visible()))
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\mad_0.jpg", "..\\..\\images\\mad_1.jpg");
            else if (!hearts[0].Visible() && !hearts[1].Visible() && !hearts[2].Visible() &&
                !catFaces[0].Visible() && !catFaces[1].Visible() && !catFaces[2].Visible())
                cat.ChangeAndDraw(e.Graphics, "..\\..\\images\\dead_0.jpg", "..\\..\\images\\dead_1.jpg");
            
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
            //if ((hearts[2].Visible() == false) && (hearts[0].Visible() == true) && (hearts[1].Visible() == true))
            //    ChangeElement(2, 0, 1, hearts);
            //else if ((hearts[1].Visible() == false) && (hearts[0].Visible() == true) && (hearts[2].Visible() == false))
            //    ChangeElement(1, 0, 2, hearts);
            //else if ((hearts[0].Visible() == false) && (hearts[1].Visible() == false) && (hearts[2].Visible() == false))
            //    ChangeElement(0, 1, 2, hearts);
            if ((!hearts[2].Visible()) && (hearts[0].Visible()) && (hearts[1].Visible()))
                ChangeElement(2, 0, 1, hearts);
            else if ((!hearts[1].Visible()) && (hearts[0].Visible()) && (!hearts[2].Visible()))
                ChangeElement(1, 0, 2, hearts);
            else if ((!hearts[0].Visible()) && (!hearts[1].Visible()) && (!hearts[2].Visible()))
                ChangeElement(0, 1, 2, hearts);
        }

        private void ChangeElement(int a, int b, int c, ImportantThing [] things)
        {
            things[a].Restore();
            things[b].RestartTimer();
            things[c].RestartTimer();
        }

        private void toPlay_Click(object sender, EventArgs e)
        {
            toPlay.Image = Image.FromFile("..\\..\\images\\toPlay_c.jpg");
            if ((!catFaces[2].Visible()) && (catFaces[0].Visible()) && (catFaces[1].Visible()))
                ChangeElement(2, 0, 1, catFaces);
            else if ((!catFaces[1].Visible()) && (catFaces[0].Visible()) && (!catFaces[2].Visible()))
                ChangeElement(1, 0, 2, catFaces);
            else if ((!catFaces[0].Visible()) && (!catFaces[1].Visible()) && (!catFaces[2].Visible()))
                ChangeElement(0, 1, 2, catFaces);
        }

        private void toPlay_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toPlay_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
