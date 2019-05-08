using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace mad_cat
{
    public partial class Form1 : Form
    {
        GameObject[] arr = new GameObject[3];
        Animation animation;
        Timer timer = new Timer();

        int recSide = 300;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            //arr[0] = new Heart(50, 50, recSide, recSide, this, Color.LightSkyBlue, 5, Color.LightPink);
            arr[1] = new Heart(100, 200, 70, 70, this, Color.LightSkyBlue, 5, Color.Cornsilk, "..\\..\\images\\май_харт.jpg");
            arr[2] = new Animation(340, 150, recSide, recSide, /*Color.LightSkyBlue, 5,*/ this, "..\\..\\images\\к_обычный0.jpg",
                "..\\..\\images\\к_обычный1.jpg");
            animation = (Animation)arr[2];

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    animation.Move(0, -20, this.Width, this.Height); break;
                case Keys.Down:
                    animation.Move(0, 20, this.Width, this.Height); break;
                case Keys.Left:
                    animation.Move(-20, 0, this.Width, this.Height); break;
                case Keys.Right:
                    animation.Move(20, 0, this.Width, this.Height); break;
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            //arr[0].Draw(e.Graphics);
            arr[1].Draw(e.Graphics);
            animation.Draw(e.Graphics);
        }

        private void ToFeed_Click(object sender, EventArgs e)
        {
            
        }

        private void ToPlay_Click(object sender, EventArgs e)
        {
            
        }
    }

    public abstract class GameObject
    {
        protected Form parent;
        protected Rectangle rectangle;
        protected Image[] images;

        public GameObject(Form papa, int x, int y, int width, int heigth, params string [] imagesFrom)
        {
            parent = papa;
            rectangle = new Rectangle(x, y, width, heigth);
            images = new Image[imagesFrom.Length];
            for (int i = 0; i < imagesFrom.Length; i++)
                images[i] = Image.FromFile(imagesFrom[i]);
        }

        public abstract void Draw(Graphics g);
    }


}
