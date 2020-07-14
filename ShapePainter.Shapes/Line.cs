using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Math;

namespace ShapePainter.Shapes
{
    class Line : Shape
    {
        public Line(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawLine(pen, TL, BR);
            if (IsSelected)
            {
                DrawSelection(g);
            }
        }

        public override bool Contains(Point p)
        {
            bool result = false;
            float x1 = TL.X;
            float y1 = TL.Y;
            float x2 = BR.X;
            float y2 = BR.Y;
            int i = 1;
            float Y = p.Y - 15;
            try
            {
                result = (((p.X <= TL.X && p.X >= BR.X) || (p.X >= TL.X && p.X <= BR.X)) &&
                   ((p.X <= TL.Y && p.Y >= BR.Y) || (p.Y >= TL.Y && p.Y <= BR.Y)) &&
                (Math.Abs(((TL.X - p.X) / (TL.Y - p.Y)) - ((TL.X - BR.X) / (TL.Y - BR.Y))) < 2));
                return result;
            }
            catch
            {
                return false;
            }
        }

        public override void DrawSelection(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(Color.LimeGreen);
            g.FillRectangle(solidBrush, TL.X - 10, TL.Y - 10, 10, 10);
            g.FillRectangle(solidBrush, BR.X, BR.Y, 10, 10);
        }

        public override void Move(Point a, Point b)
        {
            int dx = Abs(b.X - a.X);
            int dy = Abs(b.Y - a.Y);
            if (b.X > a.X)
            {
                if (b.Y > a.Y)
                {
                    TL.X += dx;
                    TL.Y += dy;
                    BR.X += dx;
                    BR.Y += dy;
                }
                else
                {
                    TL.X += dx;
                    TL.Y -= dy;
                    BR.X += dx;
                    BR.Y -= dy;
                }
            }
            else
            {
                if (b.Y < a.Y)
                {
                    TL.X -= dx;
                    TL.Y -= dy;
                    BR.X -= dx;
                    BR.Y -= dy;
                }
                else
                {
                    TL.X -= dx;
                    TL.Y += dy;
                    BR.X -= dx;
                    BR.Y += dy;
                }
            }
        }
    }
}
