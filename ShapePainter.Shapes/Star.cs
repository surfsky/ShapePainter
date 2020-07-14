using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapePainter.Shapes
{
    class Star : Shape
    {
        public Star(Point a, Point b) : base(a, b)
        {

        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y + H / 2, X + W / 3, Y + H / 3);
            g.DrawLine(pen, X + W / 3, Y + H / 3, X + W / 2, Y);
            g.DrawLine(pen, X + W / 2, Y, X + 2 * W / 3, Y + H / 3);
            g.DrawLine(pen, X + 2 * W / 3, Y + H / 3, X + W, Y + H / 2);
            g.DrawLine(pen, X + W, Y + H / 2, X + 2 * W / 3, Y + 2 * H / 3);
            g.DrawLine(pen, X + 2 * W / 3, Y + 2 * H / 3, X + W / 2, Y + H);
            g.DrawLine(pen, X + W / 2, Y + H, X + W / 3, Y + 2 * H / 3);
            g.DrawLine(pen, X + W / 3, Y + 2 * H / 3, X, Y + H / 2);
            SolidBrush solidBrush = new SolidBrush(Color.Azure);
            Point point1 = new Point((int)X, ((int)(Y + H / 2)));
            Point point2 = new Point((int)(X + W / 3), ((int)(Y + H / 3)));
            Point point3 = new Point((int)(X + W / 2), ((int)(Y)));
            Point point4 = new Point((int)(X + 2 * W / 3), ((int)(Y + H / 3)));
            Point point5 = new Point((int)(X + W), ((int)(Y + H / 2)));
            Point point6 = new Point((int)(X + 2 * W / 3), ((int)(Y + 2 * H / 3)));
            Point point7 = new Point((int)(X + W / 2), ((int)(Y + H)));
            Point point8 = new Point((int)(X + W / 3), ((int)(Y + 2 * H / 3)));
            Point[] triPoints = { point1, point2, point3, point4, point5, point6, point7, point8 };
            g.FillPolygon(solidBrush, triPoints);
            if (IsSelected)
            {
                DrawSelection(g);
            }
        }

        public override bool Contains(Point point)
        {
            float prod1, prod2, prod3;
            prod1 = ((X - point.X) * (Y + H / 3 - (Y + H / 2)) - (X + W / 3 - X) * (Y + H / 2 - point.Y));
            prod2 = ((X + W / 3 - point.X) * (Y + 2 * H / 3 - (Y + H / 3)) - (X + W / 3 - (X + W / 3)) * (Y + H / 3 - point.Y));
            prod3 = ((X + W / 3 - point.X) * (Y + H / 2 - (Y + 2 * H / 3)) - (X - (X + W / 3)) * (Y + 2 * H / 3 - point.Y));

            if (((prod1 > 0) && (prod2 > 0) && (prod3 > 0)) || ((prod1 < 0) && (prod2 < 0) && (prod3 < 0)))
            {

                return true;
            }
            else
            {
                prod1 = ((X + W / 3 - point.X) * (Y - (Y + H / 3)) - (X + W / 2 - (X + W / 3)) * (Y + H / 3 - point.Y));
                prod2 = ((X + W / 2 - point.X) * (Y + H / 3 - Y) - (X + 2 * W / 3 - (X + W / 2)) * (Y - point.Y));
                prod3 = ((X + 2 * W / 3 - point.X) * (Y + H / 3 - (Y + H / 3)) - (X + W / 3 - (X + 2 * W / 3)) * (Y + H / 3 - point.Y));

                if (((prod1 > 0) && (prod2 > 0) && (prod3 > 0)) || ((prod1 < 0) && (prod2 < 0) && (prod3 < 0)))
                    return true;
                else
                {
                    prod1 = ((X + 2 * W / 3 - point.X) * (Y + H / 2 - (Y + H / 3)) - (X + W - (X + 2 * W / 3)) * (Y + H / 3 - point.Y));
                    prod2 = ((X + W - point.X) * (Y + 2 * H / 3 - (Y + H / 2)) - (X + 2 * W / 3 - (X + W)) * (Y + H / 2 - point.Y));
                    prod3 = ((X + 2 * W / 3 - point.X) * (Y + H / 3 - (Y + 2 * H / 3)) - (X + 2 * W / 3 - (X + 2 * W / 3)) * (Y + 2 * H / 3 - point.Y));

                    if (((prod1 > 0) && (prod2 > 0) && (prod3 > 0)) || ((prod1 < 0) && (prod2 < 0) && (prod3 < 0)))
                        return true;
                    else
                    {
                        prod1 = ((X + 2 * W / 3 - point.X) * (Y + H - (Y + 2 * H / 3)) - (X + W / 2 - (X + 2 * W / 3)) * (Y + 2 * H / 3 - point.Y));
                        prod2 = ((X + W / 2 - point.X) * (Y + 2 * H / 3 - (Y + H)) - (X + W / 3 - (X + W / 2)) * (Y + H - point.Y));
                        prod3 = ((X + W / 3 - point.X) * (Y + 2 * H / 3 - (Y + 2 * H / 3)) - (X + 2 * W / 3 - (X + W / 3)) * (Y + 2 * H / 3 - point.Y));

                        if (((prod1 > 0) && (prod2 > 0) && (prod3 > 0)) || ((prod1 < 0) && (prod2 < 0) && (prod3 < 0)))
                            return true;
                        else
                        {
                            if ((point.X > X + W / 3) && (point.Y > Y + H / 3) && (point.X < X + 2 * W / 3) && (point.Y < Y + 2 * H / 3))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
