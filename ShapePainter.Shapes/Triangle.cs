using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapePainter.Shapes
{
    class Triangle : Shape
    {
        public Triangle(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y + H, X + W, Y + H);
            g.DrawLine(pen, X, Y + H, X + W / 2, Y);
            g.DrawLine(pen, X + W / 2, Y, X + W, Y + H);
            SolidBrush solidBrush = new SolidBrush(Color.Azure);
            Point point1 = new Point((int)X, ((int)(Y + H)));
            Point point2 = new Point((int)(X + W), ((int)(Y + H)));
            Point point3 = new Point((int)(X + W / 2), ((int)(Y)));
            Point[] triPoints = { point1, point2, point3 };
            g.FillPolygon(solidBrush, triPoints);
            if (IsSelected)
            {
                DrawSelection(g);
            }

        }

        public override bool Contains(Point point)
        {
            float prod1, prod2, prod3;
            prod1 = ((X - point.X) * (Y - (Y + H)) - (X + W / 2 - X) * (Y + H - point.Y));
            prod2 = ((X + W / 2 - point.X) * (Y + H - Y) - (X + W - (X + W / 2)) * (Y - point.Y));
            prod3 = ((X + W - point.X) * (Y + H - (Y + H)) - (X - (X + W) * (Y + H - point.Y)));
            if (((prod1 > 0) && (prod2 > 0) && (prod3 > 0)) || ((prod1 < 0) && (prod2 < 0) && (prod3 < 0)))
            {
                return true;
            }
            else
                return false;
        }
    }
}
