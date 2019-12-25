using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace fLogin
{
    public partial class UCLoading : UserControl
    {
        Bitmap load;
        Timer timer;
        public UCLoading()
        {
            InitializeComponent();
            load = new Bitmap(ResizeImage( Bitmap.FromFile(Application.StartupPath + @"\Picture\Loading.png")));
            ptbLoad.Location = new Point(this.Size.Width / 2 - 13, this.Size.Height / 2 - 13);
            this.SizeChanged += UCLoading_SizeChanged;
            timer = new Timer() { Interval = 10 };
            timer.Tick += Timer_Tick;
            ptbLoad.Paint += PtbLoad_Paint;
            DoubleBuffered = true;
            timer.Start();
            this.Dock = DockStyle.Fill;
        }

        private void PtbLoad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(12, 12);
            g.RotateTransform(k);
            g.TranslateTransform(-12, -12);
            g.DrawImage(load, 0, 0);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        int k = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            k += 10;
            this.Invalidate();
        }
        private void UCLoading_SizeChanged(object sender, EventArgs e)
        {
            ptbLoad.Location = new Point(this.Size.Width / 2 - 13, this.Size.Height / 2 - 13);
        }
        public static Bitmap ResizeImage(Image image)
        {
          
            var destRect = new Rectangle(0, 0, 25, 25);
            var destImage = new Bitmap(25, 25);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
