using System;
using System.Drawing;
using System.Windows.Forms;

namespace mad_cat
{
    public class Animation : GameObject
    {
        Rectangle Rectangle;
        Image[] Images;
        Pen Pen;
        Form parent;
        //TextureBrush [] TextureBrushes;
        Timer Timer = new Timer();
        bool flag = true;
        int index = 0;

        public Animation(int x, int y, int width, int height, /*Color colorPen, int widthPen,*/ Form papa, params string[] images) : base(papa, x, y, width, height, images)
        {
            Rectangle = new Rectangle(x, y, width, height);
            Images = new Image[images.Length];
            for (int i = 0; i < images.Length; i++)
                Images[i] = Image.FromFile(images[i]);
            //Pen = new Pen(colorPen, widthPen);
            //for(int i =0; i<Images.Length; i++)
            //    TextureBrushes[i] = new TextureBrush(Images[i]);

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

        public void Move(int x, int y, int widthForm, int heightForm)
        {
            if (y == 0)
            {
                if (Rectangle.X + x > 0)
                    Rectangle.X = Rectangle.X + x;
                else Rectangle.X = 0;
                if (Rectangle.X + x >= widthForm) Rectangle.X = 0;
            }
            else if (x == 0)
            {
                if (Rectangle.Y + y > 0)
                    Rectangle.Y = Rectangle.Y + y;
                else Rectangle.Y = 0;
                if (Rectangle.Y + y >= heightForm) Rectangle.Y = 0;
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Images[index], Rectangle);
            //g.DrawRectangle(Pen, Rectangle);
            //parent.Invalidate();
        }
    }
}
