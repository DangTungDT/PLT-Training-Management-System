using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class RoundedButton : Button
    {
        private int _borderRadius = 10;
        private int _borderSize = 0;
        private Color _borderColor = Color.Transparent;

        [Category("Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(60, 131, 246); // #3C83F6
            ForeColor = Color.White;
            Size = new Size(120, 40);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, _borderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, _borderRadius - _borderSize))
            using (Pen penSurface = new Pen(this.Parent.BackColor, _borderSize > 0 ? _borderSize : 1))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                // Draw surface
                this.Region = new Region(pathSurface);
                pevent.Graphics.FillPath(new SolidBrush(this.BackColor), pathSurface);

                // Draw border
                if (_borderSize > 0)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }

                // Draw text
                TextRenderer.DrawText(
                    pevent.Graphics,
                    this.Text,
                    this.Font,
                    rectSurface,
                    this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius * 2f;

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
