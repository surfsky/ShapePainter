using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Math;

namespace ShapePainter.Shapes
{
    public class Text : Shape
    {
        public string T { get; set; } = "Hello";
        public Font Font { get; set; } = new Font("Arial", 12);
        public Brush Brush { get; set; } = new SolidBrush(Color.Red);

        public Text(Point a, Point b) : base(a, b)
        {
        }

        public override void Draw(Graphics g, Pen pen)
        {
            g.DrawString(T, this.Font, this.Brush, X, Y, StringFormat.GenericDefault);
            //var size = g.MeasureString(this.T, this.Font);
            //this.BR.X = this.TL.X + (int)size.Width;
            //this.BR.Y = this.TL.Y + (int)size.Height;
            //var rect = new Rectangle(this.TL, size.ToSize());
            if (IsSelected)
                DrawSelection(g);
        }
    }
}
