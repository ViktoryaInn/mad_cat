using System;
using System.Drawing;
using System.Windows.Forms;

namespace @try
{
    public class Animation 
    {
        Rectangle Rectangle;
        Image[] Images;
        Timer Timer = new Timer();
        bool flag = true;
        int index = 0;

        public Animation(int x, int y, int recSide, params string[] images)
        {
            Rectangle = new Rectangle(x, y, recSide, recSide);
            Images = new Image[images.Length];
            for (int i = 0; i < images.Length; i++)
                Images[i] = Image.FromFile(images[i]);

            Timer.Interval = 500;
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (index == Images.Length) flag = false;
            if (flag) index++;
            else index--;
            if (index == Images.Length - 1) flag = false;
            if (index == 0) flag = true;
        }

        //public void ChangeImage(params string[] images)
        //{
        //    for (int i = 0; i < images.Length; i++)
        //        Images[i] = Image.FromFile(images[i]);
        //}

        public void DrawAndChange(Graphics g, params string [] images)
        {
            for (int i = 0; i < images.Length; i++)
                Images[i] = Image.FromFile(images[i]);
            g.DrawImage(Images[index], Rectangle);
        }
    }
}
