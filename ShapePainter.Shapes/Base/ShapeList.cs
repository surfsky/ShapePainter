using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePainter.Shapes
{
    [Serializable]
    public class ShapeList
    {
        public List<Shape> Items;
        public List<Shape> UndoItems;

        private ShapeList()
        {
           Items = new List<Shape>();
           UndoItems = new List<Shape>();
        }

        //
        private static ShapeList instance;
        public static ShapeList GetInstance()
        {
            if (instance == null)
                instance = new ShapeList();
            return instance;
        }

        public void Add(Shape fig)
        {
            Items.Add(fig);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

        public int Count()
        {
            return Items.Count;
        }
    }
}
