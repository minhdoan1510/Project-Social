
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace fLogin
{
    class pnlGame : Panel
    {
        Square s;
        int W;
        int level=1;
        Pen p;

        int grid;
        int rX, rY;
        
        Label score,flaws;
        int flw = 0;

        int counter = 15;
        Label lbltimer;
        public Timer timer;

        public delegate void SetHighScore(int score);
        public event SetHighScore OnSetHighScore;

        public int Level { get => level; set { level = value; OnSetHighScore(value); } }

        public pnlGame(int xLocation, int yLocation,int width,Label Score,Label Flaws,Label Timer)
        {
            this.Location = new Point(xLocation, yLocation);
            W = width-2;
            this.Size = new Size(width, width);
            this.score = Score;
            this.flaws = Flaws;
            this.lbltimer = Timer;
            this.BackColor = Color.White;
            this.MouseClick += PnlGame_MouseClick;
            this.Paint += PnlGame_Paint;

            this.timer = new Timer();
            this.timer.Tick += CountDown_Tick;
            this.timer.Interval = 1000;
           
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            counter--;
            Timer_update();
            if (counter < 1)
            {
                counter = 0;
                timer.Stop();
                MessageBox.Show("Het gio!!!!");
                Reset_Game();
            }
            

        }
        private void Reset_Timer()
        {

            counter = 15;
            Timer_update();
            timer.Start();
        }
        private void Reset_Game()
        {
            
            counter = 15;
            Level = 1;
            flw = 0;
            this.Invalidate();
            Score_Update();
            Flaws_update();
            Timer_update();
        }
        private void Score_Update()
        {

            score.Text = string.Format("Score : {0} ", Level - 1);
            score.Update();
        }
        private void Flaws_update()
        {
            flaws.Text = string.Format("Flaws : {0} ", flw);
            flaws.Update();
        }
        private void Timer_update()
        {
            if (counter < 0) counter = 0;
            lbltimer.Text = counter.ToString();
        }
        private int LevelColorDiff(int level)
        {
            if (level <= 58)
            {
                int[] col= { 105, 75, 60, 45, 30, 20, 18, 16, 15, 15, 15, 14, 14, 14, 13, 13, 13, 12, 12, 12, 11, 11, 11, 10, 10, 9, 9, 8, 8, 7, 7, 7, 7, 6, 6, 6, 6, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1 };
                return col[level - 1];
            }
            return 1;
        }
        private int UpdateGrid(int level)
        {
            if (level < 2) return 2;
            if (level < 4) return 3;
            if (level < 8) return 4;
            if (level < 13) return 5;
            if (level < 22) return 6;
            if (level < 32) return 7;
            if (level < 36) return 8;
            if (level < 40) return 9;
            if (level < 44) return 10;
            if (level < 48) return 11;
            return 12;
        }
        public static void DrawRoundedRectangle(Graphics g,
                                   Rectangle r, int d, Brush myBrush)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d,
                                                             0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);

            g.FillPath(myBrush, gp);
        }
        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            grid = UpdateGrid(Level);
            s = new Square(2, 2, W / grid-1, Color.FromArgb(255, 255, 255));
            p = new Pen(s.Color);
            p.Width = 3;
            int colorDiff = LevelColorDiff(Level);
            var brush = new SolidBrush(Color.White);

            Random rd = new Random();
            //right pos
            int rdX = rd.Next(grid);
            int rdY = rd.Next(grid);
            //random color
            int R = rd.Next(255 - colorDiff);
            int G = rd.Next(255 - colorDiff);
            int B = rd.Next(255 - colorDiff);
            
            for (int i = 0; i < grid; i++)
            {
                for (int j = 0; j < grid; j++)
                {
                    if (i == rdX && j == rdY)
                    {
                        brush = new SolidBrush(Color.FromArgb(R + colorDiff, G + colorDiff, B + colorDiff));
                        rX = s.X;
                        rY = s.Y;
                    }
                    else
                        brush = new SolidBrush(Color.FromArgb(R, G, B));
                    // g.FillRectangle(brush, s.Rectangle());
                    DrawRoundedRectangle(g, s.Rectangle(), 30, brush);
                    //g.DrawRectangle(p, s.Rectangle());
                    s.Location(s.X + W / grid, s.Y);

                }
                s.Location(2, s.Y + W / grid);

            }
   
        }

        private void Wrong_pos()
        {
            flw++;
            counter -= 3;
            Flaws_update();
            Timer_update();
        }

      
        private void Correct_pos()
        {
            s.Location(0, 0);
            Level++;
            Score_Update();

            Reset_Timer();

            this.Invalidate();
        }
   
        private void PnlGame_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left) return;
            
            if (e.X < rX || e.X > rX + W / grid || e.Y < rY || e.Y > rY + W / grid)
            {
                 if (Level == 1)
                    return;
                Wrong_pos();
            }
            else Correct_pos();

        }
        
    }
}
