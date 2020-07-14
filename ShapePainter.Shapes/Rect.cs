using System;
using System.Collections.Generic;
using System.Drawing;

namespace ShapePainter.Shapes
{
    [Serializable]
    public class Rect : Shape
    {
        public Rect(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, W, H);
            SolidBrush solidBrush = new SolidBrush(Color.Azure);
            g.FillRectangle(solidBrush, X, Y, W, H);
            if (IsSelected)
                DrawSelection(g);
        }


        public override bool Contains(Point point)
        {
            if ((point.X > X) && (point.Y > Y) && (point.X < X + W) && (point.Y < Y + H))
                return true;
            else
                return false;
        }

    }
}
