using System.Drawing;


namespace ConsoleApp2
{
    class Square
    {
        public Color Color { get; }
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public Square(int x, int y, int w, Color c)
        {
            X = x;
            Y = y;
            Width = Height = w;
            Color = c;
        }

        public Rectangle Rectangle()
        {
            return new Rectangle(X, Y, Width, Height);
        }
        public void Location(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
}
