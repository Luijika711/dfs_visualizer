using System.Diagnostics;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //TODO:mai multe culori
        const int cell_size = 50;
        int[,] mat = new int[20, 20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(1000, 1000);
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(0, 0, 1000, 1000));
            for (int i = 0; i < 1000; i += 50)
            {
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, 0), new Point(i, 1000));
                g.DrawLine(new Pen(Color.Black, 2), new Point(0, i), new Point(1000, i));
            }
            panel1.BackgroundImage = img;
            for(int i = 0; i < 20; ++i)
            {
                for (int j = 0; j < 20; ++j) mat[i, j] = 0;
            }
        }
        bool alright(int i , int j)
        {
            if (i >= 0 && j >= 0 && i <= 19 && j <= 19)
                if(mat[i, j] == 0)
                    return true;
            return false;
        }
        async void flood_fill(int i ,int j )
        {
            if(alright(i , j))
            {
                mat[i,j] = 1;
                await Task.Delay(300);
                flood_fill(i + 1, j);
                flood_fill(i - 1, j);
                flood_fill(i, j + 1);
                flood_fill(i, j - 1);
                Image img = panel1.BackgroundImage;
                Graphics g = Graphics.FromImage(img);
                g.FillRectangle(new SolidBrush(Color.Green),new Rectangle(50 * j , 50*i,50,50));
                g.DrawRectangle(new Pen(Color.Black,2), new Rectangle(50 * j, 50 * i, 50, 50));
                panel1.BackgroundImage = img;
                panel1.Invalidate();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int j = e.X / cell_size;
            int i = e.Y / cell_size;

            if(e.Button == MouseButtons.Right)
            {
                mat[i,j] = -1;
                Debug.Print(i.ToString() + "|" + j.ToString());

                Image img = panel1.BackgroundImage;
                Graphics g = Graphics.FromImage(img);
                g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(50 *j, 50 *i, 50, 50));
                img.Save("thing.png");

                panel1.BackgroundImage = img;
                panel1.Invalidate();

            }
            else
            {
                flood_fill(i, j);
            }
            
        }
    }
}