using System.Windows.Forms;
using System.Drawing;

namespace @try
{
    public class ImportantThing : GameObject
    {
        Rectangle Rectangle;
        Image[] images;
        Form Parent;
        int Interval;
        Timer timer = new Timer();
        int seconds;
        int tenSeconds = 10000;
        int index = 0;
        bool flag = true;

        public ImportantThing(int x, int y, int width, int height, Form papa, int interval, params string[] imgs) : base(papa, x, y, width, height, imgs)
        {
            Rectangle = new Rectangle(x, y, width, height);
            Parent = papa;
            this.images = new Image[imgs.Length];
            for (int i = 0; i < imgs.Length; i++)
                this.images[i] = Image.FromFile(imgs[i]);
            Interval = interval;

            timer.Interval = interval;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        //может всё-таки создавать три отдельных сердечка , а не один объект с тремя картинками??

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            //seconds += tenSeconds;
            //if (index == 0) index=imgs.Length-1;
            //if(seconds%Interval==0  && index!=0) index--;

            if (index == images.Length) flag = false;
            if (flag) index++;
            else index--;
            if (index == images.Length - 1) flag = false;
            if (index == 0) flag = true;
        }

        //создать метод чэйндж имэйдж и проверку на текущую картинку(CurrentImage())



        public override void Draw(Graphics g)
        {
            g.DrawImage(images[index], rectangle);
        }
    }
}
