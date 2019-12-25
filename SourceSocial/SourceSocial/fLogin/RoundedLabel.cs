using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedLabel : Label
{
    [Browsable(true)]
    public Color _BackColor { get; set; }

    public RoundedLabel() : base()
    {
        this.DoubleBuffered = true;

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, _BackColor, _BackColor, 90);

        using (GraphicsPath gp = new GraphicsPath())
        {
            gp.AddArc(new Rectangle(new Point(0, 0), new Size(this.Height, this.Height)), 90, 180);
            gp.AddLine(new Point(this.Height / 2, 0), new Point(this.Width - (this.Height / 2), 0));
            gp.AddArc(new Rectangle(new Point(this.Width - this.Height, 0), new Size(this.Height, this.Height)), -90, 180);
            gp.CloseFigure();

            e.Graphics.FillPath(brush, gp);
        }
        base.OnPaint(e);
    }


}