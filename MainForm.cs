using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QR472
{
    public partial class MainForm : Form
    {
        private TextBox[,] textBoxes;
        public MainForm()
        {
            InitializeComponent();

            textBoxes = new TextBox[,]
            {
                { e_TextBox11, e_TextBox12, e_TextBox13 },
                { e_TextBox21, e_TextBox22, e_TextBox23 },
                { e_TextBox31, e_TextBox32, e_TextBox33 }
            };
        }

        private double[] GetColumn(double[,] matrix, int columnIndex)
        {
            return Enumerable.Range(0, matrix.GetLength(0)).Select(x => matrix[x, columnIndex]).ToArray();
        }

        private double CalculateMagnitude(double[] vector)
        {
            return Math.Sqrt(vector.Sum(element => element * element));
        }

        private double CalculateInnerProduct(double[] vector1, double[] vector2)
        {
            return vector1.Zip(vector2, (a, b) => a * b).Sum();
        }

        private void decomposeButton_Click(object sender, EventArgs e)
        {
            double[,] numbers = new double[3, 3];

            try
            {
                TryParseMatrix(numbers);
                // we have a successful parse, continue on...

                errorTextBox.Clear();

                var r = new double[3];
                var q = new double[3][];
                var r_upper = new double[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    double[] column = GetColumn(numbers, i);
                    for (int j = 0; j < i; j++)
                    {
                        double r_ij = CalculateInnerProduct(column, q[j]);
                        r_upper[j, i] = r_ij;

                        for (int k = 0; k < column.Length; k++)
                        {
                            column[k] -= r_ij * q[j][k];
                        }
                    }
                    r[i] = CalculateMagnitude(column);
                    q[i] = column.Select(element => element / r[i]).ToArray();
                }

                // fill out our q matrix
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        string controlName = $"q{i + 1}{j + 1}";
                        TextBox textBox = Controls.Find(controlName, true).FirstOrDefault() as TextBox;
                        if (textBox != null)
                        {
                            textBox.Text = q[i][j].GoodFormat();
                        }
                    }
                }

                // set the lower part of the R matrix to 0.
                r21.Text = 0.ToString();
                r31.Text = 0.ToString();
                r32.Text = 0.ToString();

                // set the diagonals to the magnitude
                r11.Text = r[0].GoodFormat();
                r22.Text = r[1].GoodFormat();
                r33.Text = r[2].GoodFormat();

                // Set the values above the diagonal for the R matrix
                for (int i = 0; i < 3; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        string controlName = $"r{i + 1}{j + 1}";
                        TextBox textBox = Controls.Find(controlName, true).FirstOrDefault() as TextBox;
                        if (textBox != null)
                        {
                            textBox.Text = r_upper[i, j].GoodFormat();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                errorTextBox.Text = ex.Message;
            }


        }

        private void TryParseMatrix(double[,] numbers)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        numbers[i, j] = double.Parse(textBoxes[i, j].Text);
                    }
                    catch (Exception e)
                    {
                        throw new Exception($"Error converting value '{textBoxes[i, j].Text}' at ({i}, {j})", e);
                    }
                }
            }
        }

        private void entryLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.DarkGray, 4);

            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, entryLayoutPanel.Width - 1, entryLayoutPanel.Height - 1));

            borderPen.Dispose();
        }

        private void entryLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkGray))
            {
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

                e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
        }

        private void qLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkGray))
            {
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

                e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
        }

        private void rLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var pen = new Pen(Color.DarkGray))
            {
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

                e.Graphics.DrawLine(pen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
            }
        }

        private void qLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.DarkGray, 4);

            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, qLayoutPanel.Width - 1, qLayoutPanel.Height - 1));

            borderPen.Dispose();
        }

        private void rLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.DarkGray, 4);

            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, rLayoutPanel.Width - 1, rLayoutPanel.Height - 1));

            borderPen.Dispose();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in entryLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Clear();
                }
            }
        }

    }

    // Formating extension function.
    static class DoubleExtension
    {
        public static string GoodFormat(this double value, int precision = 5)
        {
            // Thresholds for different formatting
            const double SmallValueThreshold = 0.0001;
            const double LargeValueThreshold = 100000;
            const double ZeroTreshold = 1e-15;

            if (Math.Abs(value) < ZeroTreshold)
                return "0";
            else if (Math.Abs(value) < SmallValueThreshold && value != 0.0)
                return value.ToString($"G{precision}");
            else if (Math.Abs(value) >= LargeValueThreshold)
                return value.ToString($"G{precision}");
            else
                return value.ToString("F" + Math.Max(0, precision - (int)Math.Floor(Math.Log10(Math.Abs(value))) - 1));
        }
    }
}