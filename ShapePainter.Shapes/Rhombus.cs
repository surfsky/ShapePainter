using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ShapePainter.Shapes
{
    class Rhombus : Shape
    {
        public Rhombus(Point a, Point b) : base(a, b)
        {

        }



        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y + H / 2, X + W / 2, Y);
            g.DrawLine(pen, X + W / 2, Y, X + W, Y + H / 2);
            g.DrawLine(pen, X + W, Y + H / 2, X + W / 2, Y + H);
            g.DrawLine(pen, X + W / 2, Y + H, X, Y + H / 2);
            SolidBrush solidBrush = new SolidBrush(Color.Azure);
            Point point1 = new Point((int)X, ((int)(Y + H / 2)));
            Point point2 = new Point((int)(X + W / 2), ((int)(Y)));
            Point point3 = new Point((int)(X + W), ((int)(Y + H / 2)));
            Point point4 = new Point((int)(X + W / 2), ((int)(Y + H)));
            Point[] triPoints = { point1, point2, point3, point4 };
            g.FillPolygon(solidBrush, triPoints);
            if (IsSelected)
            {
                DrawSelection(g);
            }
        }

        public override bool Contains(Point point)
        {
            float axis1 = W / 2;//принимается за меньшую
            float axis2 = H / 2;
            if (axis1 > axis2)
                axis1 = axis2;
            Point center = new Point((int)(X + W / 2), (int)(Y + H / 2));
            float dist = (float)Sqrt(Pow((center.X - point.X), 2) + Pow((center.Y - point.Y), 2));
            if (dist < axis1)
                return true;
            else
                return false;
        }
    }
}
