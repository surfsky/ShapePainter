using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePainter.Shapes
{
    public interface ISelectable
    {
        /// <summary>Detect if the shape contains point</summary>
       bool Contains(Point point);

        /// <summary>Draw the selection region</summary>
        void DrawSelection(Graphics g);
    }
}
