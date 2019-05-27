using System.Windows.Forms;
using System.Drawing;

namespace @try
{
    public class ImportantThing : GameObject
    {
        Rectangle Rectangle;
        Image[] Images;
        Form Parent;
        int Interval;
        Timer timer = new Timer();
        int seconds;
        int tenSeconds = 10000;
        int index=0;
        bool flag = true;
        
        public ImportantThing(int x, int y, int width, int height, Form papa, int interval, params string[] images) : base(papa, x, y, width, height, images)
        {
            Rectangle = new Rectangle(x, y, width, height);
            Parent = papa;
            //Images = Image.FromFile(images);
            Images = new Image[images.Length];
            for (int i = 0; i < images.Length; i++)
                Images[i] = Image.FromFile(images[i]);
            //index = images.Length - 1;

            Interval = interval;

            timer.Interval = interval;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            //seconds += tenSeconds;
            //if (index == 0) index=Images.Length-1;
            //if(seconds%Interval==0  && index!=0) index--;

            if (index == Images.Length) flag = false;
            if (flag) index++;
            else index--;
            if (index == Images.Length - 1) flag = false;
            if (index == 0) flag = true;
        }

        //создать метод чэйндж имэйдж и проверку на текущую картинку

        public override void Draw(Graphics g)
        {
            g.DrawImage(Images[index], Rectangle);
        }
    }
}
