using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapePainter.Shapes
{
    [Serializable]
    class Oval : Shape
    {
        public Oval(Point a, Point b) : base(a, b)
        {

        }


        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, X, Y, W, H);
            SolidBrush solidBrush = new SolidBrush(Color.Azure);
            g.FillEllipse(solidBrush, X, Y, W, H);
            if (IsSelected)
            {
                DrawSelection(g);
            }
        }

        public override bool Contains(Point point)
        {
            int semiMinorAxis = (int)(H / 2);
            int semiMajorAxis = (int)(W / 2);
            if (semiMinorAxis > semiMajorAxis)
            {
                var temp = semiMajorAxis;
                semiMajorAxis = semiMinorAxis;
                semiMinorAxis = semiMajorAxis;
            }
            Point center = new Point((int)(X + W / 2), (int)(Y + H / 2));
            Point normalized = new Point(point.X - center.X,
                                         point.Y - center.Y);

            return ((double)(normalized.X * normalized.X)
                     / (semiMajorAxis * semiMajorAxis)) + ((double)(normalized.Y * normalized.Y) / (semiMinorAxis * semiMinorAxis))
                <= 1.0;
        }

    }
}
