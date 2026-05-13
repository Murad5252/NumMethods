using System.Drawing;

namespace presentation
{
    /// <summary>
    /// Central color and font definitions — Windows 11 / Fluent Design palette.
    /// Change values here to retheme the entire application.
    /// </summary>
    internal static class ThemeManager
    {
        // ── Surfaces ──────────────────────────────────────────────────────────
        public static readonly Color Background  = Color.FromArgb(243, 246, 250);
        public static readonly Color Surface     = Color.White;
        public static readonly Color InputBg     = Color.FromArgb(250, 249, 248);

        // ── Header / Brand ────────────────────────────────────────────────────
        public static readonly Color Header      = Color.FromArgb(0, 90, 158);

        // ── Primary action (Windows 11 blue) ─────────────────────────────────
        public static readonly Color Primary        = Color.FromArgb(0, 120, 212);
        public static readonly Color PrimaryHover   = Color.FromArgb(0, 103, 192);
        public static readonly Color PrimaryPressed = Color.FromArgb(0,  84, 153);
        public static readonly Color PrimaryText    = Color.White;

        // ── Text ──────────────────────────────────────────────────────────────
        public static readonly Color TextPrimary   = Color.FromArgb(32,  31,  30);
        public static readonly Color TextSecondary = Color.FromArgb(96,  94,  92);
        public static readonly Color TextMuted     = Color.FromArgb(161, 159, 157);

        // ── Borders / Dividers ────────────────────────────────────────────────
        public static readonly Color Border      = Color.FromArgb(220, 218, 216);
        public static readonly Color DividerLine = Color.FromArgb(237, 235, 233);

        // ── Fonts — all Segoe UI to match Windows 11 ─────────────────────────
        public static readonly Font FontAppTitle  = new Font("Segoe UI", 15F, FontStyle.Bold);
        public static readonly Font FontSubtitle  = new Font("Segoe UI",  9F, FontStyle.Regular);
        public static readonly Font FontCardTitle = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font FontLabel     = new Font("Segoe UI",  9F, FontStyle.Regular);
        public static readonly Font FontInput     = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font FontButton    = new Font("Segoe UI",  9F, FontStyle.Bold);
        public static readonly Font FontOutput    = new Font("Consolas",  9.5F, FontStyle.Regular);
    }
}
