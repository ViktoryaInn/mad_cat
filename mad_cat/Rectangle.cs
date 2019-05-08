using System;
using System.Windows.Forms;
using System.Drawing;

namespace mad_cat
{
    public class Heart : GameObject
    {
        Rectangle rectangle;
        Pen pen;
        Color color;
        Form parent;
        Image[] images;
        int index = 0;

        public Heart(int x, int y, int width, int height, Form papa, Color colorPen,
            int widthPen, Color clr, params string [] imagesFrom) : base(papa, x, y, width, height, imagesFrom)
        {
            rectangle = new Rectangle(x, y, width, height);
            pen = new Pen(colorPen, widthPen);
            color = clr;
            parent = papa;
            images = new Image[imagesFrom.Length];
            for (int i = 0; i < imagesFrom.Length; i++)
                images[i] = Image.FromFile(imagesFrom[i]);
        }

        //public void Move(int x, int y, int widthForm, int heightForm)
        //{
        //    if (y == 0)
        //    {
        //        if (rectangle.X + x > 0)
        //            rectangle.X = rectangle.X + x;
        //        else rectangle.X = 0;
        //        if (rectangle.X + x >= widthForm) rectangle.X = 0;
        //    }
        //    else if (x == 0)
        //    {
        //        if (rectangle.Y + y > 0)
        //            rectangle.Y = rectangle.Y + y;
        //        else rectangle.Y = 0;
        //        if (rectangle.Y + y >= heightForm) rectangle.Y = 0;
        //    }
        //}

        public override void Draw(Graphics g)
        {
            var brush = new SolidBrush(color);
            g.DrawImage(images[index], rectangle);
            //g.DrawRectangle(pen, rectangle);
        }
    }
}
