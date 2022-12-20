using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chapter5_2DLineCharts
{
    /// <summary>
    /// Interaction logic for SimpleLineChart.xaml
    /// </summary>
    public partial class SimpleLineChart : Window
    {

        private double xmin = 0;
        private double xmax = 6.5;
        private double ymin = -1.1;
        private double ymax = 1.1;
        private Polyline pl;
        public SimpleLineChart()
        {
            InitializeComponent();
        }

        private void AddChart()
        {
            // Draw sine curve: 
            pl = new Polyline();
            pl.Stroke = Brushes.Black;
            for (int i = 0; i < 70; i++)
            {
                double x = i / 5.0;
                double y = Math.Sin(x);
                pl.Points.Add(NormalizePoint(new Point(x, y)));
            }
            chartCanvas.Children.Add(pl);
            // Draw cosine curve: 
            pl = new Polyline();
            pl.Stroke = Brushes.Black;
            pl.StrokeDashArray = new DoubleCollection(new double[] { 4, 3 });
            for (int i = 0; i < 70; i++)
            {
                double x = i / 5.0;
                double y = Math.Cos(x);
                pl.Points.Add(NormalizePoint(new Point(x, y)));
            }
            chartCanvas.Children.Add(pl);
        }
        private Point NormalizePoint(Point pt)
        {
            Point result = new Point();
            result.X = (pt.X - xmin) * chartCanvas.Width / (xmax - xmin);
            result.Y = chartCanvas.Height - (pt.Y - ymin) * chartCanvas.Height / (ymax - ymin);
            return result;
        }
        private void chartGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            chartCanvas.Width = chartGrid.ActualWidth;
            chartCanvas.Height = chartGrid.ActualHeight;
            chartCanvas.Children.Clear();
            AddChart();
        }
       
    }
}
