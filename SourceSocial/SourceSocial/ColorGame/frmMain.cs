using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApp2
{
    class frmMain : Form
    {
        pnlGame game;

        public frmMain()
        {
            Init();
        }
        void Init()
        {
            this.Size = new Size(800,650);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle1 = new Label();
            lblTitle1.Size = new Size(400/3, 50);
            lblTitle1.Text = "Color";
            lblTitle1.Font = new Font("Calibri", 20, FontStyle.Bold);
            lblTitle1.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle1.BackColor = Color.SteelBlue;
            lblTitle1.ForeColor = Color.White;
            lblTitle1.Location = new Point(100, 25);
            this.Controls.Add(lblTitle1);

            Label lblTitle2 = new Label();
            lblTitle2.Size = lblTitle1.Size;
            lblTitle2.Text = "Vision";
            lblTitle2.Font = new Font("Calibri", 20, FontStyle.Bold);
            lblTitle2.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle2.BackColor = Color.Teal;
            lblTitle2.ForeColor = Color.White;
            lblTitle2.Location = new Point(lblTitle1.Location.X+ 400 / 3, lblTitle1.Location.Y);
            this.Controls.Add(lblTitle2);

            Label lblTitle3 = new Label();
            lblTitle3.Size = lblTitle1.Size;
            lblTitle3.Text = "Test";
            lblTitle3.Font = new Font("Calibri", 20, FontStyle.Bold);
            lblTitle3.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle3.BackColor = Color.Turquoise;
            lblTitle3.ForeColor = Color.White;
            lblTitle3.Location = new Point(lblTitle2.Location.X + 400 / 3, lblTitle2.Location.Y );
            this.Controls.Add(lblTitle3);
            
            Label lblScore = new Label();
            lblScore.Size = new Size(150, 50);
            lblScore.Text = "Score : 0";
            lblScore.Font = new Font("Calibri", 20, FontStyle.Bold);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.BackColor = Color.ForestGreen;
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(this.Width-230, lblTitle3.Location.Y + 100);
            this.Controls.Add(lblScore);

            Label lblFlaws = new Label();
            lblFlaws.Text = "Flaws : 0";
            lblFlaws.Font = new Font("Calibri", 20, FontStyle.Bold);
            lblFlaws.Size = lblScore.Size;
            lblFlaws.TextAlign = ContentAlignment.MiddleCenter;
            lblFlaws.BackColor = Color.Red;
            lblFlaws.ForeColor = Color.White;
            lblFlaws.Location = new Point(lblScore.Location.X, lblScore.Location.Y + 50);
            this.Controls.Add(lblFlaws);

            Label timer = new Label();
            timer.Text = "15";
            timer.Font = new Font("Calibri", 40, FontStyle.Bold);
            timer.Size = new Size(150,100);
            timer.TextAlign = ContentAlignment.MiddleCenter;
            timer.BackColor = Color.White;
            timer.ForeColor = Color.Black;
            timer.Location = new Point(lblScore.Location.X, lblFlaws.Location.Y + 50);
            this.Controls.Add(timer);

            game = new pnlGame(100, 100, 400,lblScore,lblFlaws,timer);
            this.Controls.Add(game);
            
            
            
        }
    }
}
