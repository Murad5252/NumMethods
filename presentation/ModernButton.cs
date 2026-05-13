using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace presentation
{
    /// <summary>
    /// Owner-drawn button with rounded corners, hover/press colour transitions,
    /// and two visual styles: Primary (filled blue) and Secondary (outlined).
    /// Inherits from Button so all existing event subscriptions continue to work.
    /// </summary>
    internal class ModernButton : Button
    {
        public enum ButtonStyle { Primary, Secondary }

        private bool _hovered;
        private bool _pressed;
        private ButtonStyle _style = ButtonStyle.Primary;

        public ButtonStyle Style
        {
            get => _style;
            set { _style = value; Invalidate(); }
        }

        public ModernButton()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            Font = ThemeManager.FontButton;
            Height = 34;
            MinimumSize = new Size(80, 34);
        }

        protected override void OnMouseEnter(EventArgs e) { _hovered = true;  Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hovered = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _pressed = true;  Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e)   { _pressed = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            Color bg, fg;

            if (_style == ButtonStyle.Secondary)
            {
                bg = _pressed ? ThemeManager.Border
                   : _hovered ? Color.FromArgb(240, 238, 236)
                   : ThemeManager.Surface;
                fg = ThemeManager.TextPrimary;

                using (var path = RoundedPath(rect, 6))
                using (var bgBrush = new SolidBrush(bg))
                using (var borderPen = new Pen(ThemeManager.Border, 1f))
                {
                    g.FillPath(bgBrush, path);
                    g.DrawPath(borderPen, path);
                }
            }
            else // Primary
            {
                bg = _pressed ? ThemeManager.PrimaryPressed
                   : _hovered ? ThemeManager.PrimaryHover
                   : ThemeManager.Primary;
                fg = ThemeManager.PrimaryText;

                using (var path = RoundedPath(rect, 6))
                using (var bgBrush = new SolidBrush(bg))
                    g.FillPath(bgBrush, path);
            }

            if (!Enabled) fg = ThemeManager.TextMuted;

            using (var textBrush = new SolidBrush(fg))
            {
                var sf = new StringFormat
                {
                    Alignment     = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                    Trimming      = StringTrimming.EllipsisCharacter
                };
                g.DrawString(Text, Font, textBrush,
                             new RectangleF(2, 0, Width - 4, Height), sf);
            }
        }

        private static GraphicsPath RoundedPath(Rectangle r, int rad)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X,               r.Y,                rad * 2, rad * 2, 180, 90);
            path.AddArc(r.Right - rad * 2, r.Y,                rad * 2, rad * 2, 270, 90);
            path.AddArc(r.Right - rad * 2, r.Bottom - rad * 2, rad * 2, rad * 2,   0, 90);
            path.AddArc(r.X,               r.Bottom - rad * 2, rad * 2, rad * 2,  90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
