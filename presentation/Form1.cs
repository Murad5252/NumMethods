using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace presentation
{
    public partial class Form1 : Form
    {
        private const int MatrixRows = 3;
        private const int MatrixCols = 4;
        private TextBox[,] matrixInputs;
        private TableLayoutPanel matrixPanel;
        private Label lblMatrixTitle;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeMatrixInputs();
            InitializeMatrixGrid();
        }

        double f(double x)
        {
            return ExprParser.Eval(txtFunc.Text, x);
        }

        double fCauchy(double x, double y)
        {
            return ExprParser.Eval(txtCauchyFunc.Text, x, y);
        }

        //  Интегралы

        double LeftRect(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }

            return h * sum;
        }

        double RightRect(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }

            return h * sum;
        }

        double Trapezoid(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = (f(a) + f(b)) / 2;

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }

            return h * sum;
        }

        // Метод Коши

        void Euler(double x0, double y0, double h, int n)
        {
            double x = x0;
            double y = y0;

            txtOutput.AppendText("Обычный метод Эйлера\r\n");
            for (int i = 0; i < n; i++)
            {
                y = y + h * fCauchy(x, y);
                txtOutput.AppendText($"x={x:F2}, y={y:F4}\r\n");

               
                x = x + h;
            }
            txtOutput.AppendText("\r\n");
        }

        void ModifiedEuler(double x0, double y0, double h, int n)
        {
            double x = x0;
            double y = y0;

            txtOutput.AppendText("Модифицированный метод Эйлера\r\n");
            for (int i = 0; i < n; i++)
            {
                txtOutput.AppendText($"x={x:F2}, y={y:F4}\r\n");

                double y_pred = y + h * fCauchy(x, y);
                y = y + h / 2 * (fCauchy(x, y) + fCauchy(x + h, y_pred));

                x += h;
            }
            txtOutput.AppendText("\r\n");
        }

        // Рунге-Кутта
        string RungeKutta4Text(double x0, double y0, double h, int n)
        {
            double x = x0;
            double y = y0;
            var sb = new StringBuilder();

            sb.AppendLine("Рунге-Кутта");
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine($"x={x:F4}, y={y:F6}");

                double k1 = fCauchy(x, y);
                double k2 = fCauchy(x + h / 2, y + h * k1 / 2);
                double k3 = fCauchy(x + h / 2, y + h * k2 / 2);
                double k4 = fCauchy(x + h, y + h * k3);

                y = y + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
                x = x + h;
            }
            sb.AppendLine();
            return sb.ToString();
        }

        // Крамер и Гаусс

        // Ax = b методом Крамера
        double[] KramerSolve(double[,] A, double[] b)
        {
            int n = b.Length;
            double detA = Determinant(A);
            if (Math.Abs(detA) < 1e-12) throw new Exception("Матрица вырожденная (det=0)");

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                double[,] Ai = (double[,])A.Clone();
                for (int row = 0; row < n; row++) Ai[row, i] = b[row];
                x[i] = Determinant(Ai) / detA;
            }
            return x;
        }

        void InitializeMatrixGrid()
        {
            if (matrixInputs == null)
                return;
            string[,] defaults =
            {
                { "1", "2", "2", "11" },
                { "4", "5", "6", "32" },
                { "2", "2", "3", "15" }
            };

            for (int row = 0; row < MatrixRows; row++)
                for (int col = 0; col < MatrixCols; col++)
                    matrixInputs[row, col].Text = defaults[row, col];
        }

        void ReadMatrix3(out double[,] A, out double[] b)
        {
            if (matrixInputs == null)
            {
                throw new InvalidOperationException("Матрица не инициализирована.");
            }

            int n = MatrixRows;
            A = new double[n, n];
            b = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToDouble(matrixInputs[i, j].Text);
                }
                b[i] = Convert.ToDouble(matrixInputs[i, MatrixCols - 1].Text);
            }
        }

        void ShowResults(string title, string text)
        {
            var form = new ResultsForm(title, text);
            form.Show();
        }

        double Determinant(double[,] mat)
        {
            int n = mat.GetLength(0);
            if (n == 1) return mat[0, 0];
            if (n == 2) return mat[0, 0] * mat[1, 1] - mat[0, 1] * mat[1, 0];

            double det = 0;
            for (int p = 0; p < n; p++)
            {
                double[,] sub = new double[n - 1, n - 1];
                for (int i = 1; i < n; i++)
                {
                    int colIndex = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == p) continue;
                        sub[i - 1, colIndex] = mat[i, j];
                        colIndex++;
                    }
                }
                det += mat[0, p] * Math.Pow(-1, p) * Determinant(sub);
            }
            return det;
        }

        private void InitializeMatrixInputs()
        {
            if (matrixPanel != null)
                return;

            lblMatrixTitle = new Label
            {
                AutoSize  = true,
                Location  = new Point(6, 5),
                Font      = ThemeManager.FontSubtitle,
                ForeColor = ThemeManager.TextSecondary,
                Text      = "a·x + b·y + c·z = d"
            };
            pnlMatrixContent.Controls.Add(lblMatrixTitle);

            matrixPanel = new TableLayoutPanel
            {
                Location     = new Point(4, 26),
                AutoSize     = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount  = 8,
                RowCount     = MatrixRows,
                BackColor    = ThemeManager.Surface
            };

            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            matrixPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45));

            for (int i = 0; i < MatrixRows; i++)
            {
                matrixPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            var bracket = new Label
            {
                AutoSize  = true,
                Text      = "{",
                Font      = new Font("Segoe UI", 24F, FontStyle.Regular),
                ForeColor = ThemeManager.TextSecondary,
                Margin    = new Padding(0, 0, 5, 0)
            };
            matrixPanel.Controls.Add(bracket, 0, 0);
            matrixPanel.SetRowSpan(bracket, MatrixRows);

            matrixInputs = new TextBox[MatrixRows, MatrixCols];
            for (int row = 0; row < MatrixRows; row++)
            {
                int rowIndex = row + 1;
                matrixInputs[row, 0] = CreateMatrixTextBox();
                matrixInputs[row, 1] = CreateMatrixTextBox();
                matrixInputs[row, 2] = CreateMatrixTextBox();
                matrixInputs[row, 3] = CreateMatrixTextBox();

                matrixPanel.Controls.Add(matrixInputs[row, 0], 1, row);
                matrixPanel.Controls.Add(CreateMatrixLabel($"x{rowIndex} +"), 2, row);
                matrixPanel.Controls.Add(matrixInputs[row, 1], 3, row);
                matrixPanel.Controls.Add(CreateMatrixLabel($"y{rowIndex} +"), 4, row);
                matrixPanel.Controls.Add(matrixInputs[row, 2], 5, row);
                matrixPanel.Controls.Add(CreateMatrixLabel($"z{rowIndex} ="), 6, row);
                matrixPanel.Controls.Add(matrixInputs[row, 3], 7, row);
            }

            pnlMatrixContent.Controls.Add(matrixPanel);
        }

        private TextBox CreateMatrixTextBox()
        {
            return new TextBox
            {
                Width       = 40,
                Text        = "0",
                TextAlign   = HorizontalAlignment.Center,
                Font        = ThemeManager.FontInput,
                BackColor   = ThemeManager.InputBg,
                ForeColor   = ThemeManager.TextPrimary,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private Label CreateMatrixLabel(string text)
        {
            return new Label
            {
                AutoSize  = true,
                Text      = text,
                TextAlign = ContentAlignment.MiddleLeft,
                Font      = ThemeManager.FontLabel,
                ForeColor = ThemeManager.TextSecondary,
                Margin    = new Padding(3, 6, 3, 0)
            };
        }

        // Гаусс
        double[] GaussSolve(double[,] A, double[] b)
        {
            int n = b.Length;
            double[,] M = new double[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) M[i, j] = A[i, j];
                M[i, n] = b[i];
            }

            // Прямой ход
            for (int k = 0; k < n; k++)
            {
                // Поиск макс элемента
                int maxRow = k;
                for (int i = k + 1; i < n; i++)
                    if (Math.Abs(M[i, k]) > Math.Abs(M[maxRow, k])) maxRow = i;

                // Меняет местами
                if (maxRow != k)
                {
                    for (int j = k; j <= n; j++)
                    {
                        double tmp = M[k, j];
                        M[k, j] = M[maxRow, j];
                        M[maxRow, j] = tmp;
                    }
                }

                // Элемент нулевой
                if (Math.Abs(M[k, k]) < 1e-12) throw new Exception("Нулевой ведущий элемент");

                for (int i = k + 1; i < n; i++)
                {
                    double factor = M[i, k] / M[k, k];
                    for (int j = k; j <= n; j++) M[i, j] -= factor * M[k, j];
                }
            }

            // Обратный ход
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = M[i, n];
                for (int j = i + 1; j < n; j++) sum -= M[i, j] * x[j];
                x[i] = sum / M[i, i];
            }

            return x;
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                ExprParser.Eval(txtFunc.Text, 0);
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                int n = int.Parse(txtN.Text);

                txtOutput.Clear();

                txtOutput.AppendText("Интегралы\r\n");
                txtOutput.AppendText($"f(x) = {txtFunc.Text}\r\n\r\n");
                txtOutput.AppendText("Левые прямоугольники:  " + LeftRect(a, b, n)  + "\r\n");
                txtOutput.AppendText("Правые прямоугольники: " + RightRect(a, b, n) + "\r\n");
                txtOutput.AppendText("Трапеции:              " + Trapezoid(a, b, n) + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка: " + ex.Message +
                    "\n\nПримеры f(x):\n  x*x\n  sin(x)\n  x^3 + 2*x\n  sqrt(x)\n  Math.Sin(x)\n  1/(1+x*x)",
                    "Ошибка ввода");
            }
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            try
            {
                ExprParser.Eval(txtCauchyFunc.Text, 0, 0);
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h  = double.Parse(txtH.Text);
                int n     = int.Parse(txtN.Text);

                txtOutput.Clear();
                txtOutput.AppendText("Задача Коши\r\n");
                txtOutput.AppendText($"f(x,y) = {txtCauchyFunc.Text}\r\n\r\n");

                Euler(x0, y0, h, n);
                ModifiedEuler(x0, y0, h, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка: " + ex.Message +
                    "\n\nПримеры f(x,y):\n  x + y\n  x*x - y\n  sin(x) + cos(y)\n  x*y + 1",
                    "Ошибка ввода");
            }
        }

        private void btnRunge_Click(object sender, EventArgs e)
        {
            try
            {
                ExprParser.Eval(txtCauchyFunc.Text, 0, 0);
                double x0 = double.Parse(txtX0.Text);
                double y0 = double.Parse(txtY0.Text);
                double h  = double.Parse(txtH.Text);
                int n     = int.Parse(txtN.Text);

                txtOutput.Clear();
                txtOutput.AppendText("Runge-Kutta\r\n");
                txtOutput.AppendText($"f(x,y) = {txtCauchyFunc.Text}\r\n\r\n");
                txtOutput.AppendText(RungeKutta4Text(x0, y0, h, n));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка: " + ex.Message +
                    "\n\nПримеры f(x,y):\n  x + y\n  x*x - y\n  sin(x) + cos(y)\n  x*y + 1",
                    "Ошибка ввода");
            }
        }

        private void btnKramer_Click(object sender, EventArgs e)
        {
            try
            {
                ReadMatrix3(out double[,] A, out double[] b);
                double[] x = KramerSolve(A, b);
                var sb = new StringBuilder();
                sb.AppendLine("Крамер (3x3)");
                var names = new[] { "x", "y", "z" };
                for (int i = 0; i < x.Length; i++)
                {
                    string name = i < names.Length ? names[i] : $"x{i}";
                    sb.AppendLine($"{name} = {x[i]:F6}");
                }
                txtOutput.Clear();
                txtOutput.AppendText(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в Крамере: " + ex.Message);
            }
        }

        private void btnGauss_Click(object sender, EventArgs e)
        {
            try
            {
                ReadMatrix3(out double[,] A, out double[] b);
                double[] x = GaussSolve(A, b);
                var sb = new StringBuilder();
                sb.AppendLine("Гаусс (3x3)");
                var names = new[] { "x", "y", "z" };
                for (int i = 0; i < x.Length; i++)
                {
                    string name = i < names.Length ? names[i] : $"x{i}";
                    sb.AppendLine($"{name} = {x[i]:F6}");
                }
                txtOutput.Clear();
                txtOutput.AppendText(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в Гауссе: " + ex.Message);
            }
        }

    }
    static class ExprParser
    {
        public static double Eval(string expr, double x, double y = 0)
        {
            string s = Normalize(expr);
            var p = new Parser(s, x, y);
            double result = p.ParseExpr();
            if (p.Pos < s.Length)
                throw new Exception($"Неожиданный символ '{s[p.Pos]}' в позиции {p.Pos}");
            return result;
        }

        static string Normalize(string expr)
        {
            string s = System.Text.RegularExpressions.Regex.Replace(
                expr.Trim(), @"[Mm]ath\.", "");
            return s.ToLower();
        }

        class Parser
        {
            readonly string _s;
            readonly double _x;
            readonly double _y;
            public int Pos;

            public Parser(string s, double x, double y) { _s = s; _x = x; _y = y; }

            public double ParseExpr() => ParseAddSub();

            double ParseAddSub()
            {
                double v = ParseMulDiv();
                while (Pos < _s.Length && (_s[Pos] == '+' || _s[Pos] == '-'))
                {
                    char op = _s[Pos++];
                    double r = ParseMulDiv();
                    v = op == '+' ? v + r : v - r;
                }
                return v;
            }

            double ParseMulDiv()
            {
                double v = ParsePow();
                while (Pos < _s.Length && (_s[Pos] == '*' || _s[Pos] == '/'))
                {
                    char op = _s[Pos++];
                    double r = ParsePow();
                    v = op == '*' ? v * r : v / r;
                }
                return v;
            }

            double ParsePow()
            {
                double v = ParseUnary();
                if (Pos < _s.Length && _s[Pos] == '^')
                {
                    Pos++;
                    return Math.Pow(v, ParsePow());
                }
                return v;
            }

            double ParseUnary()
            {
                Skip();
                if (Pos < _s.Length && _s[Pos] == '-') { Pos++; return -ParsePrimary(); }
                if (Pos < _s.Length && _s[Pos] == '+') { Pos++; return ParsePrimary(); }
                return ParsePrimary();
            }

            double ParsePrimary()
            {
                Skip();
                if (Pos < _s.Length && _s[Pos] == '(')
                {
                    Pos++;
                    double v = ParseExpr();
                    if (Pos >= _s.Length || _s[Pos] != ')') throw new Exception("Ожидалась ')'");
                    Pos++;
                    return v;
                }
                if (Pos < _s.Length && char.IsLetter(_s[Pos])) return ParseIdent();
                return ParseNumber();
            }

            double ParseIdent()
            {
                int start = Pos;
                while (Pos < _s.Length && char.IsLetter(_s[Pos])) Pos++;
                string name = _s.Substring(start, Pos - start);
                Skip();
                if (Pos < _s.Length && _s[Pos] == '(')
                {
                    Pos++;
                    double arg = ParseExpr();
                    if (Pos >= _s.Length || _s[Pos] != ')') throw new Exception("Ожидалась ')'");
                    Pos++;
                    switch (name)
                    {
                        case "sin":   return Math.Sin(arg);
                        case "cos":   return Math.Cos(arg);
                        case "tan":   return Math.Tan(arg);
                        case "sqrt":  return Math.Sqrt(arg);
                        case "log":   return Math.Log10(arg);
                        case "ln":    return Math.Log(arg);
                        case "exp":   return Math.Exp(arg);
                        case "abs":   return Math.Abs(arg);
                        case "asin":  return Math.Asin(arg);
                        case "acos":  return Math.Acos(arg);
                        case "atan":  return Math.Atan(arg);
                        case "floor": return Math.Floor(arg);
                        case "ceil":  return Math.Ceiling(arg);
                        case "round": return Math.Round(arg);
                        case "pow":
                            if (Pos < _s.Length && _s[Pos - 1] == ')')
                                throw new Exception("pow() не поддерживается, используйте ^");
                            throw new Exception("pow() не поддерживается, используйте x^2");
                        default: throw new Exception(
                            $"Неизвестная функция '{name}'.\n" +
                            "Доступно: sin, cos, tan, sqrt, log, ln, exp, abs, asin, acos, atan, floor, ceil, round");
                    }
                }
                switch (name)
                {
                    case "x":  return _x;
                    case "y":  return _y;
                    case "pi": return Math.PI;
                    case "e":  return Math.E;
                    default: throw new Exception(
                        $"Неизвестный идентификатор '{name}'.\n" +
                        "Переменные: x, y. Константы: pi, e");
                }
            }

            double ParseNumber()
            {
                Skip();
                int start = Pos;
                while (Pos < _s.Length && (char.IsDigit(_s[Pos]) || _s[Pos] == '.')) Pos++;
                if (Pos == start) throw new Exception(
                    $"Ожидалось число или переменная в позиции {Pos}" +
                    (Pos < _s.Length ? $" (символ '{_s[Pos]}')" : ""));
                return double.Parse(_s.Substring(start, Pos - start),
                    System.Globalization.CultureInfo.InvariantCulture);
            }

            void Skip() { while (Pos < _s.Length && _s[Pos] == ' ') Pos++; }
        }
    }
}