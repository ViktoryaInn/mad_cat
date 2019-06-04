using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace @try
{
    public class LiveElements
    {
        PictureBox[] pictureBoxes;
        Timer timer = new Timer();
        int seconds = 0;
        int oneSecond = 1000;

        //Image image;
        //int interval;
        //int index = 0;
        //bool flag = true;
        //Form parent;

        public LiveElements(int pbLenght, int x, int y, int eSize, int interval, Form parent, Image img)
        {
            pictureBoxes = new PictureBox[pbLenght];
            for(int i=0; i<pictureBoxes.Length;i++)
            {
                pictureBoxes[i] = new PictureBox
                {
                    Location = new Point(x + i*eSize, y),
                    Size = new Size(eSize, eSize),
                    Image = img,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                parent.Controls.Add(pictureBoxes[i]);
            }


            timer.Interval = interval;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds += oneSecond;
            for(int i=0; i<pictureBoxes.Length; i++)
            {
                if (seconds < timer.Interval + (i * timer.Interval)) pictureBoxes[i].Visible = true;
                else pictureBoxes[i].Visible = false;
            }
        }

        public PictureBox TakeElement(int index)
        {
            PictureBox result=new PictureBox();
            for(int i=0; i<pictureBoxes.Length;i++)
            {
                if (i == index)
                {
                    result = pictureBoxes[i];
                    break;
                }
            }
            return result;
        }

        public void Restore(int index)
        {
            PictureBox result = new PictureBox();
            for (int i = 0; i < pictureBoxes.Length; i++)
            {

                if (i == index)
                {
                    pictureBoxes[i].Visible = true;
                    seconds = 0;
                }
            }   
        }

        public void RestartTimer()
        {
            seconds = 0;
        }

        public int Lenght()
        {
            int result = 0;
            foreach(var pb in pictureBoxes)
            {
                if (pb.Visible) result++;
            }
            return result;
        }
    }
}
