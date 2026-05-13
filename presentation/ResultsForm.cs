using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace presentation
{
    /// <summary>
    /// Modal results dialog — themed to match the main form.
    /// </summary>
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(string title, string text)
            : this()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            BuildUi(title, text);
        }

        private void BuildUi(string title, string text)
        {
            // ── Window setup ──────────────────────────────────────────────────
            Text = title;
            ClientSize = new Size(480, 400);
            MinimumSize = new Size(360, 260);
            BackColor = ThemeManager.Background;
            Font = ThemeManager.FontLabel;
            StartPosition = FormStartPosition.CenterParent;
            AutoScaleMode = AutoScaleMode.Font;
            AutoScaleDimensions = new SizeF(6F, 13F);

            // ── Header strip ──────────────────────────────────────────────────
            var pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 44,
                BackColor = ThemeManager.Header
            };

            var lblTitle = new Label
            {
                AutoSize = true,
                Font = ThemeManager.FontCardTitle,
                ForeColor = Color.White,
                Location = new Point(14, 12),
                Text = title
            };
            pnlHeader.Controls.Add(lblTitle);

            // ── Accent bar ────────────────────────────────────────────────────
            var pnlAccent = new Panel
            {
                Dock = DockStyle.Top,
                Height = 3,
                BackColor = ThemeManager.Primary
            };

            // ── Content area ──────────────────────────────────────────────────
            var pnlContent = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(12, 10, 12, 12),
                BackColor = ThemeManager.Surface
            };

            var txtResults = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                Font = ThemeManager.FontOutput,
                BackColor = ThemeManager.InputBg,
                ForeColor = ThemeManager.TextPrimary,
                Text = text
            };
            pnlContent.Controls.Add(txtResults);

            // ── Close button bar ──────────────────────────────────────────────
            var pnlBottom = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = ThemeManager.Surface,
                Padding = new Padding(12, 8, 12, 8)
            };

            var pnlBottomBorder = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 1,
                BackColor = ThemeManager.Border
            };

            var btnClose = new ModernButton
            {
                Text = "Закрыть",
                Size = new Size(100, 34),
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                Style = ModernButton.ButtonStyle.Secondary
            };
            btnClose.Location = new Point(pnlBottom.ClientSize.Width - 112,
                                          (pnlBottom.ClientSize.Height - 34) / 2);
            btnClose.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            btnClose.Click += (s, e) => Close();

            pnlBottom.Controls.Add(btnClose);

            // ── Wire up ───────────────────────────────────────────────────────
            Controls.Add(pnlContent);
            Controls.Add(pnlBottomBorder);
            Controls.Add(pnlBottom);
            Controls.Add(pnlAccent);
            Controls.Add(pnlHeader);
        }
    }
}
