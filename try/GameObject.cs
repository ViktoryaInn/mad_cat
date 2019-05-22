using System.Drawing;
using System.Windows.Forms;

namespace @try
{
    public abstract class GameObject
    {
        protected Form parent;
        protected Rectangle rectangle;
        protected Image[] images;

        public GameObject(Form papa, int x, int y, int width, int heigth, params string[] imagesFrom)
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
