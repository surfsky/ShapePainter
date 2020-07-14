using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ShapePainter.Shapes;

namespace ShapePainter
{
    public partial class FormMain : Form
    {
        ShapeList _shapes = ShapeList.GetInstance();
        string _shapeName;
        bool _drawing = false;
        bool _pressed = false;
        bool _moving = false;
        Point _tl;
        Point _br;


        //------------------------------------------
        // Init
        //------------------------------------------
        public FormMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.RectButtonClicked(null, null);
        }


        //------------------------------------------
        // Select or Create
        //------------------------------------------
        private void OnPanelMousePressed(object sender, MouseEventArgs e) 
        {
            if (_drawing)
            {
                SearchForFigure(e.Location);
                _tl = e.Location;
                var figure = ShapeFactory.Create(_shapeName, _tl, _tl);
                if (figure != null)
                    _shapes.Add(figure);
                _pressed = true;
            }
            else if (_shapes.Count() > 0)
            {
                Point point = e.Location;
                SearchForFigure(point);
            }
        }



        private void OnPanelMouseReleased(object sender, MouseEventArgs e)
        {
            if(_pressed)
            {
                _shapes.UndoItems.Clear();
                _pressed = false;
            }
            else if (_moving)
            {
                _moving = false;
                Cursor.Current = Cursors.Default;
            }
        }

        private void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
           if(_pressed)
            {
                _br = e.Location;
                _shapes.Items[_shapes.Count() - 1].Resize(_br);
                Draw();
            }
            else if (_moving)
            {
                bool found = false;
                int i = 0;
                while((!found)&&(i< _shapes.Items.Count))
                {
                    if ((_shapes.Items[i].IsSelected))
                    {
                        Cursor.Current = Cursors.Cross;
                        _br = e.Location;
                        _shapes.Items[i].Move(_tl, _br);
                        
                        Draw();
                        _tl = _br;
                        found = true;
                    }
                    i++;
                }
            }
        }

        /// <summary>查找当前点对应的图形并显示外框</summary>
        private void SearchForFigure(Point point)
        {
            bool found = false;
            int i = _shapes.Items.Count - 1;
            while ((i >= 0) && (!found))
            {
                if (_shapes.Items[i] is ISelectable)
                {
                    if ((_shapes.Items[i].Contains(point)) && (!_drawing) && (!_shapes.Items[i].IsSelected))
                    {
                        for (int j = i - 1; j >= 0; j--)
                            _shapes.Items[j].IsSelected = false;
                        found = true;
                        _shapes.Items[i].IsSelected = true;
                        Console.WriteLine(i + "Is selected");
                    }
                    else if ((_shapes.Items[i].IsSelected) && (_shapes.Items[i].Contains(point)) && (_shapes.Items[i] is IMovable))
                    {
                        found = true;
                        _moving = true;
                        _tl = point;
                    }
                    else if ((_shapes.Items[i].IsSelected) || ((_drawing) && (_shapes.Items[i].IsSelected)))
                    {
                        _shapes.Items[i].IsSelected = false;
                    }
                    Draw();
                }
                i--;
            }
        }

        // 绘制
        public void Draw()
        {
            Bitmap bmp = BuildImage();
            pictureBox1.Image = bmp;
        }

        /// <summary>生成图片</summary>
        private Bitmap BuildImage()
        {
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var pen = new Pen(Color.Black, 2);
            foreach (var item in _shapes.Items)
            {
                item.Draw(g, pen);
            }
            return bmp;
        }


        //------------------------------------------
        // Undo & Redo
        //------------------------------------------
        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
                Undo();
            else if(e.Control&& e.KeyCode==Keys.Y)
                Redo();
        }

        private void Undo()
        {
            pictureBox1.Refresh();
            if (_shapes.Count() > 0)
            {
                _shapes.UndoItems.Add(_shapes.Items[_shapes.Count() - 1]);
                _shapes.RemoveAt(_shapes.Count() - 1);
                Draw();
            }
        }

        private void Redo()
        {
            if(_shapes.UndoItems.Count()>0)
            {
                _shapes.Add(_shapes.UndoItems[_shapes.UndoItems.Count() - 1]);
                _shapes.UndoItems.RemoveAt(_shapes.UndoItems.Count() - 1);
            }
            Draw();
        }


        //------------------------------------------
        // Create figure
        //------------------------------------------
        private void SetFigure(string name)
        {
            _shapeName = name;
            _drawing = true;
        }
        private void RectButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Rect");
        }
        private void OvalButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Oval");
        }
        private void LineButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Line");
        }
        private void RhombusButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Rhombus");
        }
        private void TriButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Triangle");
        }
        private void CircleButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Circle");
        }
        private void StarButtonClicked(object sender, EventArgs e)
        {
            SetFigure("Star");
        }
        private void BtnText_Click(object sender, EventArgs e)
        {
            SetFigure("Text");
        }



        //------------------------------------------
        // select
        //------------------------------------------
        private void SelectTool_Click(object sender, EventArgs e)
        {
            _drawing = false;
        }

        //------------------------------------------
        // save and load
        //------------------------------------------
        // save config file
        private void SaveButtonClicked(object sender, EventArgs e)
        {
            Serialize();
        }

        // load config file
        private void LoadButtonClicked(object sender, EventArgs e)
        {
            try
            {
                Deserialize();
                Draw();
            }
            catch {}
        }

        // 保存图片
        private void btnSavePic_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "png file|*.png";
            if( DialogResult.OK == dlg.ShowDialog())
            {
                var path = dlg.FileName;
                var img = BuildImage();
                img.Save(path, ImageFormat.Png);
            }
        }

        // serialize
        public void Serialize()
        {
            var f = new StreamWriter("figures.txt");
            foreach (Shape fig in _shapes.Items)
            {
                var type = fig.GetType().ToString();
                f.WriteLine(string.Format("{0},{1},{2},{3},{4}", type, fig.TL.X, fig.TL.Y, fig.BR.X, fig.BR.Y));
                //f.WriteLine(type + "," + fig.TL.X.ToString() + "," + fig.TL.Y.ToString() + "," + fig.BR.X.ToString() + "," + fig.BR.Y.ToString() + ",");
            }
            f.Close();
        }

        // deserialize
        private void Deserialize()
        {
            if (!File.Exists("figures.txt"))
            {
                MessageBox.Show("Unexist figures.txt", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new NotImplementedException();
            }

            var f = new StreamReader("figures.txt");
            _shapes.Items.Clear();
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                string[] data = s.Split(new char[] { ',' });
                try
                {
                    float x = float.Parse(data[1], CultureInfo.InvariantCulture.NumberFormat);
                    float y = float.Parse(data[2], CultureInfo.InvariantCulture.NumberFormat);
                    float w = float.Parse(data[3], CultureInfo.InvariantCulture.NumberFormat);
                    float h = float.Parse(data[4], CultureInfo.InvariantCulture.NumberFormat);
                    Point a = new Point((int)x, (int)y);
                    Point b = new Point((int)w, (int)h);
                    String type = data[0];
                    var figure = ShapeFactory.Create(type, a, b);
                    _shapes.Add(figure);
                }
                catch { }
            }
            f.Close();
        }

    }

}
