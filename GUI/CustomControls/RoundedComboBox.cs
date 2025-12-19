using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class RoundedComboBox : UserControl
    {
        private ComboBox comboBox;
        private int _borderRadius = 8;
        private int _borderSize = 1;
        private Color _borderColor = Color.FromArgb(200, 200, 200);

        [Category("Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }
        private void UpdateRegion()
        {
            using (GraphicsPath path = GetRoundedPath(this.ClientRectangle, _borderRadius))
            {
                this.Region = new Region(path);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
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

        [Browsable(true)]
        public ComboBox.ObjectCollection Items => comboBox.Items;

        [Browsable(true)]
        public object SelectedItem
        {
            get => comboBox.SelectedItem;
            set => comboBox.SelectedItem = value;
        }

        public RoundedComboBox()
        {
            this.Size = new Size(180, 36);
            this.BackColor = Color.White;
            this.DoubleBuffered = true;

            comboBox = new ComboBox();
            comboBox.Dock = DockStyle.Fill;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Margin = new Padding(8, 6, 8, 6);

            this.Controls.Add(comboBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-1, -1);

            using (GraphicsPath path = GetRoundedPath(rect, _borderRadius))
            using (Pen pen = new Pen(_borderColor, _borderSize))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
                if (_borderSize > 0)
                    e.Graphics.DrawPath(pen, path);
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
    }
}
