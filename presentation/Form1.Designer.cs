namespace presentation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Instantiate everything ────────────────────────────────────────
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.lblAppTitle        = new System.Windows.Forms.Label();
            this.lblAppSubtitle     = new System.Windows.Forms.Label();

            this.pnlContent         = new System.Windows.Forms.Panel();
            this.tlpMain            = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCards           = new System.Windows.Forms.TableLayoutPanel();

            this.pnlIntegral        = new System.Windows.Forms.Panel();
            this.pnlIntAccent       = new System.Windows.Forms.Panel();
            this.lblIntTitle        = new System.Windows.Forms.Label();

            this.pnlCauchy          = new System.Windows.Forms.Panel();
            this.pnlCauchyAccent    = new System.Windows.Forms.Panel();
            this.lblCauchyTitle     = new System.Windows.Forms.Label();

            this.pnlMatrixCard      = new System.Windows.Forms.Panel();
            this.pnlMatrixAccent    = new System.Windows.Forms.Panel();
            this.lblMatrixCardTitle = new System.Windows.Forms.Label();
            this.pnlMatrixButtons   = new System.Windows.Forms.Panel();
            this.pnlMatrixContent   = new System.Windows.Forms.Panel();

            this.pnlOutput          = new System.Windows.Forms.Panel();
            this.pnlOutputAccent    = new System.Windows.Forms.Panel();
            this.lblOutputTitle     = new System.Windows.Forms.Label();

            // Existing controls (same names preserved for logic compatibility)
            this.txtA        = new System.Windows.Forms.TextBox();
            this.txtB        = new System.Windows.Forms.TextBox();
            this.txtN        = new System.Windows.Forms.TextBox();
            this.txtFunc     = new System.Windows.Forms.TextBox();
            this.lblA        = new System.Windows.Forms.Label();
            this.lblB        = new System.Windows.Forms.Label();
            this.lblN        = new System.Windows.Forms.Label();
            this.lblFunc     = new System.Windows.Forms.Label();
            this.btnIntegral = new presentation.ModernButton();

            this.txtX0       = new System.Windows.Forms.TextBox();
            this.txtY0       = new System.Windows.Forms.TextBox();
            this.txtH        = new System.Windows.Forms.TextBox();
            this.lblX0       = new System.Windows.Forms.Label();
            this.lblY0       = new System.Windows.Forms.Label();
            this.lblH        = new System.Windows.Forms.Label();
            this.btnEuler    = new presentation.ModernButton();
            this.btnRunge    = new presentation.ModernButton();
            this.lblCauchyFunc = new System.Windows.Forms.Label();
            this.txtCauchyFunc = new System.Windows.Forms.TextBox();

            this.btnKramer   = new presentation.ModernButton();
            this.btnGauss    = new presentation.ModernButton();
            this.txtOutput   = new System.Windows.Forms.TextBox();

            // ── Suspend layouts ───────────────────────────────────────────────
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlIntegral.SuspendLayout();
            this.pnlCauchy.SuspendLayout();
            this.pnlMatrixCard.SuspendLayout();
            this.pnlMatrixButtons.SuspendLayout();
            this.pnlOutput.SuspendLayout();
            this.SuspendLayout();

            // ══════════════════════════════════════════════════════════════════
            //  HEADER BAR
            // ══════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = ThemeManager.Header;
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 62;
            this.pnlHeader.Name      = "pnlHeader";
            this.pnlHeader.Padding   = new System.Windows.Forms.Padding(0);

            this.lblAppTitle.AutoSize  = true;
            this.lblAppTitle.Font      = ThemeManager.FontAppTitle;
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location  = new System.Drawing.Point(18, 10);
            this.lblAppTitle.Name      = "lblAppTitle";
            this.lblAppTitle.Text      = "Численные методы";

            this.lblAppSubtitle.AutoSize  = true;
            this.lblAppSubtitle.Font      = ThemeManager.FontSubtitle;
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(185, 255, 255, 255);
            this.lblAppSubtitle.Location  = new System.Drawing.Point(20, 38);
            this.lblAppSubtitle.Name      = "lblAppSubtitle";
            this.lblAppSubtitle.Text      = "Вычислительная математика  ·  .NET Framework 4.7.2";

            // ══════════════════════════════════════════════════════════════════
            //  CONTENT CONTAINER + OUTER TABLE
            // ══════════════════════════════════════════════════════════════════
            this.pnlContent.BackColor = ThemeManager.Background;
            this.pnlContent.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name      = "pnlContent";
            this.pnlContent.Padding   = new System.Windows.Forms.Padding(14, 12, 14, 14);

            // Row 0 = fixed-height card strip, Row 1 = fill output
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Name        = "tlpMain";
            this.tlpMain.RowCount    = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent, 100F));

            // Three equal columns — cards grow/shrink with the window
            this.tlpCards.ColumnCount = 3;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpCards.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.tlpCards.Margin    = new System.Windows.Forms.Padding(0);
            this.tlpCards.Name      = "tlpCards";
            this.tlpCards.RowCount  = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(
                System.Windows.Forms.SizeType.Percent, 100F));

            // ══════════════════════════════════════════════════════════════════
            //  INTEGRAL CARD
            // ══════════════════════════════════════════════════════════════════
            this.pnlIntAccent.BackColor = ThemeManager.Primary;
            this.pnlIntAccent.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlIntAccent.Height    = 4;
            this.pnlIntAccent.Name      = "pnlIntAccent";

            this.lblIntTitle.BackColor = ThemeManager.Surface;
            this.lblIntTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblIntTitle.Font      = ThemeManager.FontCardTitle;
            this.lblIntTitle.ForeColor = ThemeManager.TextPrimary;
            this.lblIntTitle.Height    = 32;
            this.lblIntTitle.Name      = "lblIntTitle";
            this.lblIntTitle.Padding   = new System.Windows.Forms.Padding(12, 6, 0, 0);
            this.lblIntTitle.Text      = "∫  Интегралы";

            this.lblA.AutoSize  = true;
            this.lblA.Font      = ThemeManager.FontLabel;
            this.lblA.ForeColor = ThemeManager.TextSecondary;
            this.lblA.Location  = new System.Drawing.Point(14, 50);
            this.lblA.Name      = "lblA";
            this.lblA.Text      = "a:";

            this.txtA.BackColor   = ThemeManager.InputBg;
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtA.Font        = ThemeManager.FontInput;
            this.txtA.ForeColor   = ThemeManager.TextPrimary;
            this.txtA.Location    = new System.Drawing.Point(62, 47);
            this.txtA.Name        = "txtA";
            this.txtA.Size        = new System.Drawing.Size(190, 26);
            this.txtA.TabIndex    = 1;
            this.txtA.Text        = "0";

            this.lblB.AutoSize  = true;
            this.lblB.Font      = ThemeManager.FontLabel;
            this.lblB.ForeColor = ThemeManager.TextSecondary;
            this.lblB.Location  = new System.Drawing.Point(14, 82);
            this.lblB.Name      = "lblB";
            this.lblB.Text      = "b:";

            this.txtB.BackColor   = ThemeManager.InputBg;
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font        = ThemeManager.FontInput;
            this.txtB.ForeColor   = ThemeManager.TextPrimary;
            this.txtB.Location    = new System.Drawing.Point(62, 79);
            this.txtB.Name        = "txtB";
            this.txtB.Size        = new System.Drawing.Size(190, 26);
            this.txtB.TabIndex    = 3;
            this.txtB.Text        = "1";

            this.lblN.AutoSize  = true;
            this.lblN.Font      = ThemeManager.FontLabel;
            this.lblN.ForeColor = ThemeManager.TextSecondary;
            this.lblN.Location  = new System.Drawing.Point(14, 114);
            this.lblN.Name      = "lblN";
            this.lblN.Text      = "n:";

            this.txtN.BackColor   = ThemeManager.InputBg;
            this.txtN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtN.Font        = ThemeManager.FontInput;
            this.txtN.ForeColor   = ThemeManager.TextPrimary;
            this.txtN.Location    = new System.Drawing.Point(62, 111);
            this.txtN.Name        = "txtN";
            this.txtN.Size        = new System.Drawing.Size(190, 26);
            this.txtN.TabIndex    = 5;
            this.txtN.Text        = "10";

            this.lblFunc.AutoSize  = true;
            this.lblFunc.Font      = ThemeManager.FontLabel;
            this.lblFunc.ForeColor = ThemeManager.TextSecondary;
            this.lblFunc.Location  = new System.Drawing.Point(14, 146);
            this.lblFunc.Name      = "lblFunc";
            this.lblFunc.Text      = "f(x):";

            this.txtFunc.BackColor   = ThemeManager.InputBg;
            this.txtFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunc.Font        = ThemeManager.FontInput;
            this.txtFunc.ForeColor   = ThemeManager.TextPrimary;
            this.txtFunc.Location    = new System.Drawing.Point(62, 143);
            this.txtFunc.Name        = "txtFunc";
            this.txtFunc.Size        = new System.Drawing.Size(190, 26);
            this.txtFunc.TabIndex    = 6;
            this.txtFunc.Text        = "x*x";

            this.btnIntegral.Location  = new System.Drawing.Point(14, 178);
            this.btnIntegral.Name      = "btnIntegral";
            this.btnIntegral.Size      = new System.Drawing.Size(238, 34);
            this.btnIntegral.TabIndex  = 7;
            this.btnIntegral.Text      = "Вычислить интеграл";
            this.btnIntegral.Click    += new System.EventHandler(this.btnIntegral_Click);

            this.pnlIntegral.BackColor = ThemeManager.Surface;
            this.pnlIntegral.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntegral.Margin    = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.pnlIntegral.Name      = "pnlIntegral";

            // ══════════════════════════════════════════════════════════════════
            //  CAUCHY CARD
            // ══════════════════════════════════════════════════════════════════
            this.pnlCauchyAccent.BackColor = ThemeManager.Primary;
            this.pnlCauchyAccent.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlCauchyAccent.Height    = 4;
            this.pnlCauchyAccent.Name      = "pnlCauchyAccent";

            this.lblCauchyTitle.BackColor = ThemeManager.Surface;
            this.lblCauchyTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblCauchyTitle.Font      = ThemeManager.FontCardTitle;
            this.lblCauchyTitle.ForeColor = ThemeManager.TextPrimary;
            this.lblCauchyTitle.Height    = 32;
            this.lblCauchyTitle.Name      = "lblCauchyTitle";
            this.lblCauchyTitle.Padding   = new System.Windows.Forms.Padding(12, 6, 0, 0);
            this.lblCauchyTitle.Text      = "y' = f(x, y)    Задача Коши";

            this.lblX0.AutoSize  = true;
            this.lblX0.Font      = ThemeManager.FontLabel;
            this.lblX0.ForeColor = ThemeManager.TextSecondary;
            this.lblX0.Location  = new System.Drawing.Point(14, 50);
            this.lblX0.Name      = "lblX0";
            this.lblX0.Text      = "x₀:";

            this.txtX0.BackColor   = ThemeManager.InputBg;
            this.txtX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX0.Font        = ThemeManager.FontInput;
            this.txtX0.ForeColor   = ThemeManager.TextPrimary;
            this.txtX0.Location    = new System.Drawing.Point(62, 47);
            this.txtX0.Name        = "txtX0";
            this.txtX0.Size        = new System.Drawing.Size(190, 26);
            this.txtX0.TabIndex    = 8;
            this.txtX0.Text        = "0";

            this.lblY0.AutoSize  = true;
            this.lblY0.Font      = ThemeManager.FontLabel;
            this.lblY0.ForeColor = ThemeManager.TextSecondary;
            this.lblY0.Location  = new System.Drawing.Point(14, 82);
            this.lblY0.Name      = "lblY0";
            this.lblY0.Text      = "y₀:";

            this.txtY0.BackColor   = ThemeManager.InputBg;
            this.txtY0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY0.Font        = ThemeManager.FontInput;
            this.txtY0.ForeColor   = ThemeManager.TextPrimary;
            this.txtY0.Location    = new System.Drawing.Point(62, 79);
            this.txtY0.Name        = "txtY0";
            this.txtY0.Size        = new System.Drawing.Size(190, 26);
            this.txtY0.TabIndex    = 10;
            this.txtY0.Text        = "1";

            this.lblH.AutoSize  = true;
            this.lblH.Font      = ThemeManager.FontLabel;
            this.lblH.ForeColor = ThemeManager.TextSecondary;
            this.lblH.Location  = new System.Drawing.Point(14, 114);
            this.lblH.Name      = "lblH";
            this.lblH.Text      = "h:";

            this.txtH.BackColor   = ThemeManager.InputBg;
            this.txtH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtH.Font        = ThemeManager.FontInput;
            this.txtH.ForeColor   = ThemeManager.TextPrimary;
            this.txtH.Location    = new System.Drawing.Point(62, 111);
            this.txtH.Name        = "txtH";
            this.txtH.Size        = new System.Drawing.Size(190, 26);
            this.txtH.TabIndex    = 12;
            this.txtH.Text        = "0,1";

            this.lblCauchyFunc.AutoSize  = true;
            this.lblCauchyFunc.Font      = ThemeManager.FontLabel;
            this.lblCauchyFunc.ForeColor = ThemeManager.TextSecondary;
            this.lblCauchyFunc.Location  = new System.Drawing.Point(14, 146);
            this.lblCauchyFunc.Name      = "lblCauchyFunc";
            this.lblCauchyFunc.Text      = "f(x,y):";

            this.txtCauchyFunc.BackColor   = ThemeManager.InputBg;
            this.txtCauchyFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauchyFunc.Font        = ThemeManager.FontInput;
            this.txtCauchyFunc.ForeColor   = ThemeManager.TextPrimary;
            this.txtCauchyFunc.Location    = new System.Drawing.Point(62, 143);
            this.txtCauchyFunc.Name        = "txtCauchyFunc";
            this.txtCauchyFunc.Size        = new System.Drawing.Size(190, 26);
            this.txtCauchyFunc.TabIndex    = 18;
            this.txtCauchyFunc.Text        = "x + y";

            // Two buttons side by side — saves vertical space
            this.btnEuler.Location  = new System.Drawing.Point(14, 178);
            this.btnEuler.Name      = "btnEuler";
            this.btnEuler.Size      = new System.Drawing.Size(126, 34);
            this.btnEuler.TabIndex  = 13;
            this.btnEuler.Text      = "Эйлер / МЭ";
            this.btnEuler.Click    += new System.EventHandler(this.btnEuler_Click);

            this.btnRunge.Location  = new System.Drawing.Point(146, 178);
            this.btnRunge.Name      = "btnRunge";
            this.btnRunge.Size      = new System.Drawing.Size(96, 34);
            this.btnRunge.Style     = presentation.ModernButton.ButtonStyle.Secondary;
            this.btnRunge.TabIndex  = 15;
            this.btnRunge.Text      = "RK4";
            this.btnRunge.Click    += new System.EventHandler(this.btnRunge_Click);

            this.pnlCauchy.BackColor = ThemeManager.Surface;
            this.pnlCauchy.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlCauchy.Margin    = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlCauchy.Name      = "pnlCauchy";

            // ══════════════════════════════════════════════════════════════════
            //  MATRIX CARD
            // ══════════════════════════════════════════════════════════════════
            this.pnlMatrixAccent.BackColor = ThemeManager.Primary;
            this.pnlMatrixAccent.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlMatrixAccent.Height    = 4;
            this.pnlMatrixAccent.Name      = "pnlMatrixAccent";

            this.lblMatrixCardTitle.BackColor = ThemeManager.Surface;
            this.lblMatrixCardTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblMatrixCardTitle.Font      = ThemeManager.FontCardTitle;
            this.lblMatrixCardTitle.ForeColor = ThemeManager.TextPrimary;
            this.lblMatrixCardTitle.Height    = 32;
            this.lblMatrixCardTitle.Name      = "lblMatrixCardTitle";
            this.lblMatrixCardTitle.Padding   = new System.Windows.Forms.Padding(12, 6, 0, 0);
            this.lblMatrixCardTitle.Text      = "Σ  Лин. системы  3×3";

            // Buttons at the bottom of the matrix card
            this.btnKramer.Location  = new System.Drawing.Point(12, 9);
            this.btnKramer.Name      = "btnKramer";
            this.btnKramer.Size      = new System.Drawing.Size(120, 34);
            this.btnKramer.TabIndex  = 16;
            this.btnKramer.Text      = "Крамер";
            this.btnKramer.Click    += new System.EventHandler(this.btnKramer_Click);

            this.btnGauss.Location   = new System.Drawing.Point(140, 9);
            this.btnGauss.Name       = "btnGauss";
            this.btnGauss.Size       = new System.Drawing.Size(120, 34);
            this.btnGauss.Style      = presentation.ModernButton.ButtonStyle.Secondary;
            this.btnGauss.TabIndex   = 17;
            this.btnGauss.Text       = "Гаусс";
            this.btnGauss.Click     += new System.EventHandler(this.btnGauss_Click);

            this.pnlMatrixButtons.BackColor = ThemeManager.Surface;
            this.pnlMatrixButtons.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMatrixButtons.Height    = 52;
            this.pnlMatrixButtons.Name      = "pnlMatrixButtons";

            // Dynamic matrix controls from InitializeMatrixInputs() go into this panel
            this.pnlMatrixContent.BackColor = ThemeManager.Surface;
            this.pnlMatrixContent.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrixContent.Name      = "pnlMatrixContent";
            this.pnlMatrixContent.AutoScroll = true;

            this.pnlMatrixCard.BackColor    = ThemeManager.Surface;
            this.pnlMatrixCard.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatrixCard.Margin       = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pnlMatrixCard.Name         = "pnlMatrixCard";

            // ══════════════════════════════════════════════════════════════════
            //  OUTPUT CARD
            // ══════════════════════════════════════════════════════════════════
            this.pnlOutputAccent.BackColor = ThemeManager.Primary;
            this.pnlOutputAccent.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlOutputAccent.Height    = 4;
            this.pnlOutputAccent.Name      = "pnlOutputAccent";

            this.lblOutputTitle.BackColor = ThemeManager.Surface;
            this.lblOutputTitle.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblOutputTitle.Font      = ThemeManager.FontCardTitle;
            this.lblOutputTitle.ForeColor = ThemeManager.TextPrimary;
            this.lblOutputTitle.Height    = 32;
            this.lblOutputTitle.Name      = "lblOutputTitle";
            this.lblOutputTitle.Padding   = new System.Windows.Forms.Padding(12, 6, 0, 0);
            this.lblOutputTitle.Text      = "►  Результаты";

            this.txtOutput.BackColor   = ThemeManager.InputBg;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font        = ThemeManager.FontOutput;
            this.txtOutput.ForeColor   = ThemeManager.TextPrimary;
            this.txtOutput.Multiline   = true;
            this.txtOutput.Name        = "txtOutput";
            this.txtOutput.Padding     = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtOutput.ReadOnly    = true;
            this.txtOutput.ScrollBars  = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.TabIndex    = 14;

            this.pnlOutput.BackColor   = ThemeManager.Surface;
            this.pnlOutput.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutput.Margin      = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlOutput.Name        = "pnlOutput";

            // ══════════════════════════════════════════════════════════════════
            //  WIRE PARENT-CHILD RELATIONSHIPS
            //  Rule: Dock=Fill added first, then Dock=Bottom, then Dock=Top
            //        (last added Dock=Top lands at the absolute top)
            // ══════════════════════════════════════════════════════════════════

            // Header
            this.pnlHeader.Controls.Add(this.lblAppSubtitle);
            this.pnlHeader.Controls.Add(this.lblAppTitle);

            // Integral card: absolute controls, then Dock=Top items last→topmost
            this.pnlIntegral.Controls.Add(this.btnIntegral);
            this.pnlIntegral.Controls.Add(this.txtFunc);
            this.pnlIntegral.Controls.Add(this.lblFunc);
            this.pnlIntegral.Controls.Add(this.txtN);
            this.pnlIntegral.Controls.Add(this.lblN);
            this.pnlIntegral.Controls.Add(this.txtB);
            this.pnlIntegral.Controls.Add(this.lblB);
            this.pnlIntegral.Controls.Add(this.txtA);
            this.pnlIntegral.Controls.Add(this.lblA);
            this.pnlIntegral.Controls.Add(this.lblIntTitle);   // Dock=Top (below accent)
            this.pnlIntegral.Controls.Add(this.pnlIntAccent);  // Dock=Top (topmost)

            // Cauchy card
            this.pnlCauchy.Controls.Add(this.btnRunge);
            this.pnlCauchy.Controls.Add(this.btnEuler);
            this.pnlCauchy.Controls.Add(this.txtCauchyFunc);
            this.pnlCauchy.Controls.Add(this.lblCauchyFunc);
            this.pnlCauchy.Controls.Add(this.txtH);
            this.pnlCauchy.Controls.Add(this.lblH);
            this.pnlCauchy.Controls.Add(this.txtY0);
            this.pnlCauchy.Controls.Add(this.lblY0);
            this.pnlCauchy.Controls.Add(this.txtX0);
            this.pnlCauchy.Controls.Add(this.lblX0);
            this.pnlCauchy.Controls.Add(this.lblCauchyTitle);
            this.pnlCauchy.Controls.Add(this.pnlCauchyAccent);

            // Matrix buttons strip
            this.pnlMatrixButtons.Controls.Add(this.btnGauss);
            this.pnlMatrixButtons.Controls.Add(this.btnKramer);

            // Matrix card: Fill → Bottom → Top
            this.pnlMatrixCard.Controls.Add(this.pnlMatrixContent);    // Dock=Fill
            this.pnlMatrixCard.Controls.Add(this.pnlMatrixButtons);    // Dock=Bottom
            this.pnlMatrixCard.Controls.Add(this.lblMatrixCardTitle);  // Dock=Top
            this.pnlMatrixCard.Controls.Add(this.pnlMatrixAccent);     // Dock=Top (topmost)

            // Output card: Fill → Top
            this.pnlOutput.Controls.Add(this.txtOutput);               // Dock=Fill
            this.pnlOutput.Controls.Add(this.lblOutputTitle);          // Dock=Top
            this.pnlOutput.Controls.Add(this.pnlOutputAccent);         // Dock=Top (topmost)

            // Cards strip
            this.tlpCards.Controls.Add(this.pnlIntegral,   0, 0);
            this.tlpCards.Controls.Add(this.pnlCauchy,     1, 0);
            this.tlpCards.Controls.Add(this.pnlMatrixCard, 2, 0);

            // Main vertical layout
            this.tlpMain.Controls.Add(this.tlpCards,  0, 0);
            this.tlpMain.Controls.Add(this.pnlOutput, 0, 1);

            // Content wrapper
            this.pnlContent.Controls.Add(this.tlpMain);

            // Form: Fill first, then Top
            this.Controls.Add(this.pnlContent);  // Dock=Fill
            this.Controls.Add(this.pnlHeader);   // Dock=Top

            // ══════════════════════════════════════════════════════════════════
            //  FORM PROPERTIES
            // ══════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = ThemeManager.Background;
            this.ClientSize          = new System.Drawing.Size(1020, 720);
            this.Font                = ThemeManager.FontLabel;
            this.MinimumSize         = new System.Drawing.Size(830, 600);
            this.Name                = "Form1";
            this.Text                = "Численные методы";

            // ── Resume layouts ─────────────────────────────────────────────────
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpCards.ResumeLayout(false);
            this.pnlIntegral.ResumeLayout(false);
            this.pnlIntegral.PerformLayout();
            this.pnlCauchy.ResumeLayout(false);
            this.pnlCauchy.PerformLayout();
            this.pnlMatrixButtons.ResumeLayout(false);
            this.pnlMatrixCard.ResumeLayout(false);
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Infrastructure ─────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlHeader;
        private System.Windows.Forms.Label         lblAppTitle;
        private System.Windows.Forms.Label         lblAppSubtitle;
        private System.Windows.Forms.Panel         pnlContent;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpCards;

        // ── Integral card ──────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlIntegral;
        private System.Windows.Forms.Panel         pnlIntAccent;
        private System.Windows.Forms.Label         lblIntTitle;

        // ── Cauchy card ────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlCauchy;
        private System.Windows.Forms.Panel         pnlCauchyAccent;
        private System.Windows.Forms.Label         lblCauchyTitle;

        // ── Matrix card ────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlMatrixCard;
        private System.Windows.Forms.Panel         pnlMatrixAccent;
        private System.Windows.Forms.Label         lblMatrixCardTitle;
        private System.Windows.Forms.Panel         pnlMatrixButtons;
        private System.Windows.Forms.Panel         pnlMatrixContent;

        // ── Output card ────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel         pnlOutput;
        private System.Windows.Forms.Panel         pnlOutputAccent;
        private System.Windows.Forms.Label         lblOutputTitle;

        // ── Existing controls (names preserved) ────────────────────────────────
        private System.Windows.Forms.TextBox       txtA;
        private System.Windows.Forms.TextBox       txtB;
        private System.Windows.Forms.TextBox       txtN;
        private System.Windows.Forms.TextBox       txtFunc;
        private System.Windows.Forms.Label         lblA;
        private System.Windows.Forms.Label         lblB;
        private System.Windows.Forms.Label         lblN;
        private System.Windows.Forms.Label         lblFunc;
        private presentation.ModernButton          btnIntegral;

        private System.Windows.Forms.TextBox       txtX0;
        private System.Windows.Forms.TextBox       txtY0;
        private System.Windows.Forms.TextBox       txtH;
        private System.Windows.Forms.Label         lblX0;
        private System.Windows.Forms.Label         lblY0;
        private System.Windows.Forms.Label         lblH;
        private presentation.ModernButton          btnEuler;
        private presentation.ModernButton          btnRunge;
        private System.Windows.Forms.Label         lblCauchyFunc;
        private System.Windows.Forms.TextBox       txtCauchyFunc;

        private presentation.ModernButton          btnKramer;
        private presentation.ModernButton          btnGauss;
        private System.Windows.Forms.TextBox       txtOutput;
    }
}
