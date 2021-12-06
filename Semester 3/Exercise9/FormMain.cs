using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Exercise9Library;
using Rectangle = Exercise9Library.Rectangle;

namespace Exercise9
{
    public partial class FormMain : Form, IGraphics
    {
        private List<Shape> _shapes = new List<Shape>();
        private Point _mouseCaptureLocation;
        private Rectangle _frame;
        private Graphics _graphics;

        public FormMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            _graphics = e.Graphics;

            foreach (Shape shape in _shapes)
            {
                shape.Paint(this);
            }

            if (_frame != null)
            {
                _frame.Paint(this);
            }

            _graphics = null;
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseCaptureLocation = e.Location;
            _frame = new Rectangle
            {
                ColorBorder = Color.Black
            };


            if (e.Button == MouseButtons.Middle)
            {
                foreach (Shape selectedShape in _shapes)
                {
                    selectedShape.Selected = selectedShape.PointInShape(e.Location);
                }

                Invalidate();
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_frame == null)
            {
                return;
            }

            _frame.Location = new Point
            {
                X = Math.Min(_mouseCaptureLocation.X, e.Location.X),
                Y = Math.Min(_mouseCaptureLocation.Y, e.Location.Y)
            };

            _frame.Width = Math.Abs(_mouseCaptureLocation.X - e.Location.X);
            _frame.Height = Math.Abs(_mouseCaptureLocation.Y - e.Location.Y);

            if (e.Button == MouseButtons.Left)
            {
                foreach (Shape shape in _shapes)
                {
                    shape.Selected = shape.Intersect(_frame);
                }
            }

            Invalidate();
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            Color borderColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Color fillColor = Color.FromArgb(100, borderColor);

            if (e.Button == MouseButtons.Right && _frame != null)
            {
                int area = 0;

                foreach (Shape shape in _shapes)
                {
                    shape.Selected = false;
                    area += shape.Area;
                }

                _frame.ColorBorder = borderColor;
                _frame.ColorFill = fillColor;
                _shapes.Add(_frame);
                _frame.Selected = true;
                area += _frame.Area;

                toolStripStatusLabelArea.Text = area.ToString();
            }


            _frame = null;

            Invalidate();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            int area = 0;
            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                if (_shapes[i].Selected)
                {
                    _shapes.RemoveAt(i);
                }
                else area += _shapes[i].Area;
            }

            toolStripStatusLabelArea.Text = area.ToString();

            Invalidate();
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.Selected)
                {
                    FormProperties formProperties = new FormProperties(true);
                    formProperties.Rectangle = (Rectangle)shape;

                    formProperties.ShowDialog();

                    Invalidate();

                    break;
                }
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProperties formProperties = new FormProperties(false);

            if (formProperties.ShowDialog() == DialogResult.OK)
            {
                foreach (var rectangle in _shapes.Where(r => r.ColorBorder == formProperties.SelectedColor))
                {
                    rectangle.Selected = true;
                }
            }

            Invalidate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("data.txt"))
            {
                return;
            }

            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("data.txt", FileMode.Open, FileAccess.Read))
            {
                _shapes = (List<Shape>)formatter.Deserialize(stream);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("data.txt", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fileStream, _shapes);
            }
        }

        public void DrawRectangle(Color borderColor, Color fillColor, int x, int y, int width, int height)
        {
            if (_graphics != null)
            {
                using (Brush brush = new SolidBrush(fillColor))
                {
                    _graphics.FillRectangle(brush, x, y, width, height);
                }

                using (Pen pen = new Pen(borderColor))
                {
                   _graphics.DrawRectangle(pen, x, y, width, height);
                }
            }
        }
    }
}