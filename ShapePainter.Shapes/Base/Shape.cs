using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ShapePainter.Shapes
{
    /// <summary>
    /// base shape
    /// </summary>
    [Serializable]
    public abstract class Shape : IMovable, ISelectable
    {
        [NonSerialized] public Graphics G;
        [NonSerialized] public Point TL;
        [NonSerialized] public Point BR;
        [NonSerialized] public Pen Pen;
        [NonSerialized] public bool IsSelected;

        public float X, Y, W, H;

        public Shape(Point tl, Point br)
        {
            TL = tl;
            BR = br;
            SetDimensions(TL, BR);
        }
       
        public virtual void Draw(Graphics g, Pen pen)
        {
        }

        public void SetDimensions(Point a, Point b)
        {
            if (b.X > a.X)
            {
                if (b.Y > a.Y)
                {
                    X = a.X;
                    Y = a.Y;
                    W = b.X - a.X;
                    H = b.Y - a.Y;
                }
                else
                {
                    X = a.X;
                    Y = b.Y;
                    W = b.X - a.X;
                    H = a.Y - b.Y;
                }
            }
            else
            {
                if (b.Y < a.Y)
                {
                    X = b.X;
                    Y = b.Y;
                    W = a.X - b.X;
                    H = a.Y - b.Y;
                }
                else
                {
                    X = b.X;
                    Y = a.Y;
                    W = a.X - b.X;
                    H = b.Y - a.Y;
                }
            }
        }

        

        public void Resize(Point br)
        {
            BR = br;
            SetDimensions(TL, BR);
        }

        public virtual bool Contains(Point point)
        {
            var rect = new Rectangle(TL.X, TL.Y, BR.X - TL.X, BR.Y - TL.Y);
            return rect.Contains(point);
            //return true;
        }

        public virtual void DrawSelection(Graphics g)
        {
            var solidBrush = new SolidBrush(Color.LimeGreen);
            g.FillRectangle(solidBrush, X - 10, Y - 10, 10, 10);
            g.FillRectangle(solidBrush, X + W, Y - 10, 10, 10);
            g.FillRectangle(solidBrush, X - 10, Y + H, 10, 10);
            g.FillRectangle(solidBrush, X + W, Y + H, 10, 10);
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dot;
            //pen.DashPattern = new float[] { 2, 2 };
            g.DrawRectangle(pen, X, Y, W, H);
        }

        public virtual void Move(Point a, Point b)
        {
            float dx = Abs(b.X - a.X);
            float dy = Abs(b.Y - a.Y);
            
            if (b.X > a.X)
            {
                if (b.Y > a.Y)
                {
                    X = X + dx;
                    Y = Y + dy;
                    TL.X +=(int) dx;
                    TL.Y += (int)dy;
                    BR.X += (int)dx;
                    BR.Y += (int)dy;
                }
                else
                {
                    X = X+dx;
                    Y = Y-dy;
                    TL.X += (int)dx;
                    TL.Y -= (int)dy;
                    BR.X += (int)dx;
                    BR.Y -= (int)dy;
                }
            }
            else
            {
                if (b.Y < a.Y)
                {
                    X = X-dx;
                    Y = Y-dy;
                    TL.X -= (int)dx;
                    TL.Y -= (int)dy;
                    BR.X -= (int)dx;
                    BR.Y -= (int)dy;
                }
                else
                {
                    X = X-dx;
                    Y = Y+dy;
                    TL.X -= (int)dx;
                    TL.Y += (int)dy;
                    BR.X -= (int)dx;
                    BR.Y += (int)dy;
                }
            }
        }
    }
}
