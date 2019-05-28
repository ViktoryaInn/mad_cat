using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace @try
{
    public class LiveElements
    {
        PictureBox pictureBox= new PictureBox();
        Image[] images;
        Timer timer= new Timer();
        int interval;
        int index = 0;
        bool flag = true;
        Form parent;

        public LiveElements(int x, int y, int width, int height, int interval, Form parent,  params string[] imgs)
        {
            pictureBox.Location = new Point(x,y);
            pictureBox.Size = new Size(width, height);
            images = new Image[imgs.Length];
            for (int i = 0; i < imgs.Length; i++)
                images[i] = Image.FromFile(imgs[i]);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackgroundImage = Image.FromFile("..\\..\\images\\фон.jpg");
            this.interval = interval;
            this.parent = parent;
            this.parent.Controls.Add(pictureBox);

            timer.Interval = interval;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public bool CurrentImage(Image img)
        {
            return (img == images[index]);
        }

        public void ChangeImage(Image img)
        {
            pictureBox.Image = img;
        }

        public void Click()
        {
            //if(images[index]==images[3])
            //{
            //    index=index -2;
            //}
            //else
            //{
            //    if(images[index]==images[2])
            //    {
            //        index=index-2;
            //    }
            //    else
            //    {
            //        if (images[index] == images[1]) index--;
            //    }
            //}

            if(index == images.Length-1)
            {
                index = index - 2;
            }
            else
            {
                if(index==2)
                {
                    index = index - 2;
                }
                else
                {
                    if (index == 1) index--;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (index != images.Length)
            {
                pictureBox.Image = images[index];//нулевая картинка - 3 сердечка, 1 - 2 сердечка, 2 - 1 сердечко, 3 - пустота
                index++;
            }
            else index = 0;
        }
    }
}
