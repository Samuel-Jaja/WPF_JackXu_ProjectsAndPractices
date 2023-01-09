using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using static Chapter5_2DLineCharts.Symbols;
using System.Windows.Shapes;
using System.Drawing;

namespace Chapter5_2DLineCharts
{
    public class Symbols
    {
        private SymbolTypeEnum symbolType;

        private double symbolSize;
        private Brush borderColor;
        private Brush fillColor;
        private double borderThickness;

        public Symbols()
        {
            symbolType = SymbolTypeEnum.None;
            symbolSize = 8.0;
            borderColor = Brushes.Black;
            fillColor = Brushes.Black;
            borderThickness = 1.0;
        }
        public double BorderThickness
        {
            get { return borderThickness; }
            set { borderThickness = value; }
        }
        public Brush BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }
        public Brush FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }
        public double SymbolSize
        {
            get { return symbolSize; }
            set { symbolSize = value; }
        }
        public SymbolTypeEnum SymbolType
        {
            get { return symbolType; }
            set { symbolType = value; }
        }
        public enum SymbolTypeEnum
        {
            Box = 0,
            Circle = 1,
            Cross = 2,
            Diamond = 3,
            Dot = 4,
            InvertedTriangle = 5,
            None = 6,
            OpenDiamond = 7,
            OpenInvertedTriangle = 8,
            OpenTriangle = 9,
            Square = 10,
            Star = 11,
            Triangle = 12,
            Plus = 13
        }

        public void AddSymbol(Canvas canvas, Point pt)
        {
            Polygon plg = new Polygon();
            plg.Stroke = BorderColor;
            plg.StrokeThickness = BorderThickness;
            Ellipse ellipse = new Ellipse();
            ellipse.Stroke = BorderColor;
            ellipse.StrokeThickness = BorderThickness;
            Line line = new Line();
            double halfSize = 0.5 * SymbolSize;
            Canvas.SetZIndex(plg, 5);
            Canvas.SetZIndex(ellipse, 5);

            switch (SymbolType)
            {
                case SymbolTypeEnum.Square:

                    plg.Fill = Brushes.White;
                    plg.Points.Add(new Point(pt.X - halfSize, pt.Y - halfSize));
                    plg.Points.Add(new Point(pt.X + halfSize, pt.Y - halfSize));
                    plg.Points.Add(new Point(pt.X + halfSize, pt.Y + halfSize));
                    plg.Points.Add(new Point(pt.X - halfSize, pt.Y + halfSize));
                    canvas.Children.Add(plg);
                    break;
                    //case SymbolTypeEnum.OpenDiamond:
                    //    plg.Fill = Brushes.White;
                    //    plg.Points.Add(new Point(pt.X - halfSize, pt.Y));
                    //    plg.Points.Add(new Point(pt.X, pt.Y - halfSize));
                    //    plg.Points.Add(new Point(pt.X + halfSize, pt.Y));
                    //    plg.Points.Add(new Point(pt.X, pt.Y + halfSize));
                    //    canvas.Children.Add(plg);
                    //    break;

                    //Complete this

            }



        }
    }
}
