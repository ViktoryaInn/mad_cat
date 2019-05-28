using System.Windows.Forms;
using System.Drawing;

namespace @try
{
    public class ImportantThing 
    {
        PictureBox pictureBox = new PictureBox();
        Image image;
        Form parent;
        int interval;
        Timer timer = new Timer();
        int seconds=0;
        int oneSecond = 1000;

        public ImportantThing(int x, int y, int width, int height, Form papa,int interval, string img)
        {
            pictureBox.Location = new Point(x, y);
            pictureBox.Size = new Size(width, height);
            pictureBox.BackgroundImage = Image.FromFile("..\\..\\images\\фон.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            parent = papa;
            parent.Controls.Add(pictureBox);
            image = Image.FromFile(img);         
            this.interval = interval;

            timer.Interval = oneSecond;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        //может всё-таки создавать три отдельных сердечка , а не один объект с тремя картинками??

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            seconds += oneSecond;
            if (seconds < interval)
                pictureBox.Image = image;
            else //pictureBox.Image = Image.FromFile("..\\..\\images\\фон.jpg");
                pictureBox.Visible = false;
        }

        public void Restore()
        {
            pictureBox.Visible = true;
        }

        public bool Visible()
        {
            return pictureBox.Visible;
        }
        //создать метод чэйндж имэйдж и проверку на текущую картинку(CurrentImage())
    }
}
