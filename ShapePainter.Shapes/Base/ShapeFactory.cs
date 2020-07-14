using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;


namespace ShapePainter.Shapes
{
    public class ShapeFactory
    {
        public static Shape Create(string type, Point a, Point b)
        {
            switch (type)
            {
                case "Rect":     return new Rect(a, b);
                case "Line":     return new Line(a, b);
                case "Oval":     return new Oval(a, b);
                case "Rhombus":  return new Rhombus(a, b);
                case "Star":     return new Star(a, b);
                case "Text":     return new Text(a, b);
                case "Triangle": return new Triangle(a, b);
                default:         return null;
            }
        }
    }
}
