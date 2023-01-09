using System;
using System.Windows;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static Chapter5_2DLineCharts.Symbols;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Chapter5_2DLineCharts
{
    public class ChartStyle
    {
        private Canvas chartCanvas;
        private double xmin = 0;
        private double xmax = 10;
        private double ymin = 0;
        private double ymax = 10;

        public Canvas ChartCanvas
        {
            get { return chartCanvas; }
            set { chartCanvas = value; }
        }
        public double Xmin
        {
            get { return xmin; }
            set { xmin = value; }
        }
        public double Xmax
        {
            get { return xmax; }
            set { xmax = value; }
        }
        public double Ymin
        {
            get { return ymin; }
            set { ymin = value; }
        }
        public double Ymax
        {
            get { return ymax; }
            set { ymax = value; }
        }
        public Point NormalizePoint(Point pt)
        {
            if (ChartCanvas.Width.ToString() == "NaN")
                ChartCanvas.Width = 270;
            if (ChartCanvas.Height.ToString() == "NaN")
                ChartCanvas.Height = 250;
            Point result = new System.Windows.Point();
            result.X = (int)((pt.X - Xmin) * ChartCanvas.Width / (Xmax - Xmin));
            result.Y = (int)((int)ChartCanvas.Height - (pt.Y - Ymin) * ChartCanvas.Height / (Ymax - Ymin));
            return result;
        }
    }
 }
