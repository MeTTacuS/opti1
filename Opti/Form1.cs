using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Opti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrepareGraphs();
            DoMath();
        }

        private void DoMath()
        {
            //1712288
            int a = 8;
            int b = 8;
            Func<double, double> funkcija = x => (((x * x - a) * (x * x - a)) / b) - 1;

            DalijimasPusiau(funkcija);
            AuksinisPjuvis(funkcija);
            NiutonoMetodas(funkcija);
            TiksloFunkcija(funkcija);
        }

        private void DalijimasPusiau(Func<double, double> funkcija)
        {
            double r = 10;
            double l = 0;
            double L = r - l;
            double xm = (l + r) / 2;
            int i = 0;
            double prec = 0.0001;
            double ym;
            double x1;
            double y1;
            double x2;
            double y2;
            int funkcijuKvietimai = 0;

            Console.WriteLine("\n|| Dalijimo pusiau metodas ||\n");
            chartHalf.Series["l"].Points.AddXY(i, l);
            chartHalf.Series["r"].Points.AddXY(i, r);
            string[] row = { i.ToString(), l.ToString(), r.ToString(), 0.ToString(), 0.ToString(), 0.ToString() };
            dataGridViewHalf.Rows.Add(row);

            while (true)
            {
                i++;
                ym = funkcija(xm);
                x1 = l + L / 4;
                y1 = funkcija(x1);
                x2 = r - L / 4;
                y2 = funkcija(x2);
                funkcijuKvietimai += 3;

                if (y1 < ym)
                {
                    r = xm;
                    xm = x1;
                }
                else if (y2 < ym)
                {
                    l = xm;
                    xm = x2;
                }
                else
                {
                    l = x1;
                    r = x2;
                }

                L = r - l;

                chartHalf.Series["l"].Points.AddXY(i, l);
                chartHalf.Series["r"].Points.AddXY(i, r);
                chartHalf.Series["x1"].Points.AddXY(i, x1);
                chartHalf.Series["x2"].Points.AddXY(i, x2);
                row = new string[] { i.ToString(), l.ToString(), r.ToString(), x1.ToString(), xm.ToString(), x2.ToString() };
                dataGridViewHalf.Rows.Add(row);
                if (L < prec)
                {
                    ym = funkcija(xm);
                    x1 = l + L / 4;
                    y1 = funkcija(x1);
                    x2 = r - L / 4;
                    y2 = funkcija(x2);
                    funkcijuKvietimai += 3;
                    Console.WriteLine("Prireike {0} iteraciju bei {1} funkcijos kvietimu", i, funkcijuKvietimai);

                    if (y1 < ym)
                    {
                        Console.WriteLine("Atsakymas yra X = {0} Y = {1}", x1, y1);
                    }
                    else if (y2 < ym)
                    {
                        Console.WriteLine("Atsakymas yra X = {0} Y = {1}", x2, y2);
                    }
                    else
                    {
                        Console.WriteLine("Atsakymas yra X = {0} Y = {1}", xm, ym);
                    }
                    row = new string[] { "#", l.ToString(), r.ToString(), x1.ToString(), xm.ToString(), x2.ToString() };
                    dataGridViewHalf.Rows.Add(row);
                    break;
                }
            }
            
        }

        private void AuksinisPjuvis(Func<double, double> funkcija)
        {
            double prec = 0.0001;
            double theta = 0.61803;
            double r = 10;
            double l = 0;
            double L = r - l;
            int i = 0;
            double x1;
            double y1;
            double x2;
            double y2;
            int kvietimuSkaicius = 0;

            x1 = r - theta * L;
            x2 = l + theta * L;
            y1 = funkcija(x1);
            y2 = funkcija(x2);
            kvietimuSkaicius += 2;

            Console.WriteLine("\n|| Auksinio pjuvio metodas ||\n");

            chartGolden.Series["l"].Points.AddXY(i, l);
            chartGolden.Series["r"].Points.AddXY(i, r);
            chartGolden.Series["x1"].Points.AddXY(i, x1);
            chartGolden.Series["x2"].Points.AddXY(i, x2);

            string[] row = { i.ToString(), l.ToString(), r.ToString(), 0.ToString(), 0.ToString() };
            dataGridViewGolden.Rows.Add(row);

            while (true)
            {
                i++;
                if (y2 < y1)
                {
                    l = x1;
                    L = r - l;
                    x1 = x2;
                    x2 = l + theta * L;
                }
                else
                {
                    r = x2;
                    L = r - l;
                    x2 = x1;
                    x1 = r - theta * L;
                }

                chartGolden.Series["l"].Points.AddXY(i, l);
                chartGolden.Series["r"].Points.AddXY(i, r);
                chartGolden.Series["x1"].Points.AddXY(i, x1);
                chartGolden.Series["x2"].Points.AddXY(i, x2);
                row = new string[] { i.ToString(), l.ToString(), r.ToString(), x1.ToString(), x2.ToString() };
                dataGridViewGolden.Rows.Add(row);

                y2 = funkcija(x2);
                y1 = funkcija(x1);
                kvietimuSkaicius += 2;
                if (L < prec)
                {
                    Console.WriteLine("Prireike {0} iteraciju bei {1} funkcijos kvietimu", i, kvietimuSkaicius);
                    if (y2 < y1)
                        Console.WriteLine("Atsakymas yra X = {0} Y = {1}", x2, y2);
                    else
                        Console.WriteLine("Atsakymas yra X = {0} Y = {1}", x1, y1);
                    row = new string[] { "#", l.ToString(), r.ToString(), x1.ToString(), x2.ToString() };
                    dataGridViewGolden.Rows.Add(row);
                    break;
                }
                
            }
        }

        private void NiutonoMetodas(Func<double, double> funkcija)
        {
            double x0 = 5;
            double abs;
            int i = 1;
            double prec = 0.0001;
            int kvietimuSkaicius = 0;
            double yy1 = Differentiate.Derivative(funkcija, x0, 1);
            double yy2 = Differentiate.Derivative(funkcija, x0, 2);
            kvietimuSkaicius += 2;
            double x1 = x0 - (yy1 / yy2);
            abs = Math.Abs(x1 - x0);

            Console.WriteLine("\n|| Niutono metodas ||\n");

            chartNewton.Series["x0"].Points.AddXY(i, x0);
            chartNewton.Series["x1"].Points.AddXY(i, x1);

            string[] row = { i.ToString(), x0.ToString(), x1.ToString(), (x0 - x1).ToString("0." + new string('#', 339)) };
            dataGridViewNewton.Rows.Add(row);

            while (!(abs < prec))
            {
                yy1 = Differentiate.Derivative(funkcija, x1, 1);
                yy2 = Differentiate.Derivative(funkcija, x1, 2);
                kvietimuSkaicius += 2;
                i++;
                x0 = x1 - (yy1 / yy2);
                var temp = x1;
                x1 = x0;
                x0 = temp;

                abs = Math.Abs(x1 - x0);
                chartNewton.Series["x0"].Points.AddXY(i, x0);
                chartNewton.Series["x1"].Points.AddXY(i, x1);
                row = new string[] { i.ToString(), x0.ToString(), x1.ToString(), (x0 - x1).ToString("0." + new string('#', 339)) };
                dataGridViewNewton.Rows.Add(row);
            }
            kvietimuSkaicius += 1;
            Console.WriteLine("Prireike {0} iteraciju bei {1} funkcijos kvietimu", i, kvietimuSkaicius);
            Console.WriteLine("Atsakymas yra X = {0} Y = {1}", x1, funkcija(x1));
        }

        private void TiksloFunkcija(Func<double, double> funkcija)
        {
            chartGoal.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            chartGoal.ChartAreas[0].AxisX.Interval = 1;

            for (int i = -5; i < 6; i++)
            {
                chartGoal.Series[0].Points.AddXY(i, funkcija(i));
            }
        }

        private void PrepareGraphs()
        {
            // Half
            var chartl = chartHalf.ChartAreas[0];
            chartl.AxisX.IntervalType = DateTimeIntervalType.Number;
            chartl.AxisX.Interval = 1;
            chartl.AxisX.Minimum = 0;
            chartl.AxisY.Maximum = 10;

            dataGridViewHalf.ColumnCount = 6;
            dataGridViewHalf.Columns[0].Name = "i";
            dataGridViewHalf.Columns[0].Width = 20;
            dataGridViewHalf.Columns[1].Name = "l";
            dataGridViewHalf.Columns[1].Width = 105;
            dataGridViewHalf.Columns[2].Name = "r";
            dataGridViewHalf.Columns[2].Width = 105;
            dataGridViewHalf.Columns[3].Name = "x1";
            dataGridViewHalf.Columns[3].Width = 105;
            dataGridViewHalf.Columns[4].Name = "xm";
            dataGridViewHalf.Columns[4].Width = 105;
            dataGridViewHalf.Columns[5].Name = "x2";
            dataGridViewHalf.Columns[5].Width = 105;
            dataGridViewHalf.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewHalf.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewHalf.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewHalf.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridViewHalf.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewHalf.GridColor = Color.Black;
            dataGridViewHalf.RowHeadersVisible = false;

            // Golden Cut
            chartl = chartGolden.ChartAreas[0];
            chartl.AxisX.IntervalType = DateTimeIntervalType.Number;
            chartl.AxisX.Interval = 1;
            chartl.AxisX.Minimum = 0;
            chartl.AxisY.Maximum = 10;

            dataGridViewGolden.ColumnCount = 5;
            dataGridViewGolden.Columns[0].Name = "i";
            dataGridViewGolden.Columns[0].Width = 20;
            dataGridViewGolden.Columns[1].Name = "l";
            dataGridViewGolden.Columns[1].Width = 105;
            dataGridViewGolden.Columns[2].Name = "r";
            dataGridViewGolden.Columns[2].Width = 105;
            dataGridViewGolden.Columns[3].Name = "x1";
            dataGridViewGolden.Columns[3].Width = 105;
            dataGridViewGolden.Columns[4].Name = "x2";
            dataGridViewGolden.Columns[4].Width = 105;
            dataGridViewGolden.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewGolden.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewGolden.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewGolden.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridViewGolden.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewGolden.GridColor = Color.Black;
            dataGridViewGolden.RowHeadersVisible = false;

            // Newton
            chartl = chartNewton.ChartAreas[0];
            chartl.AxisX.IntervalType = DateTimeIntervalType.Number;
            chartl.AxisX.Interval = 1;
            chartl.AxisX.Minimum = 0;

            dataGridViewNewton.ColumnCount = 4;
            dataGridViewNewton.Columns[0].Name = "i";
            dataGridViewNewton.Columns[0].Width = 20;
            dataGridViewNewton.Columns[1].Name = "x(i-1)";
            dataGridViewNewton.Columns[1].Width = 105;
            dataGridViewNewton.Columns[2].Name = "xi";
            dataGridViewNewton.Columns[2].Width = 105;
            dataGridViewNewton.Columns[3].Name = "x(i-1) - xi";
            dataGridViewNewton.Columns[3].Width = 120;
            dataGridViewNewton.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridViewNewton.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewNewton.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewNewton.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridViewNewton.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridViewNewton.GridColor = Color.Black;
            dataGridViewNewton.RowHeadersVisible = false;
        }
    }
}
