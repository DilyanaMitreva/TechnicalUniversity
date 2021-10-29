using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class FormMain : Form
    {
        private List<Shape> _shapes = new List<Shape>();
        private Point _mouseCaptureLocation;
        private Rectangle _frame;

        public FormMain()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Shape shape in _shapes)
            {
                shape.Paint(e.Graphics);
            }

            if (_frame != null)
            {
                _frame.Paint(e.Graphics);
            }
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
                    if (selectedShape.PointInShape(e.Location))
                    {
                        selectedShape.Selected = true;
                    }
                    else selectedShape.Selected = false;

                    break;
                }
            }

            Invalidate();
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

            _frame.Widht = Math.Abs(_mouseCaptureLocation.X - e.Location.X);
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
            if (e.Button == MouseButtons.Right && _frame != null)
            {
                int area = 0;

                foreach (Shape shape in _shapes)
                {
                    shape.Selected = false;
                    area += shape.Area;
                }

                _frame.ColorFill = Color.Transparent;
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
                    FormProperties formProperties = new FormProperties();
                    formProperties.Rectangle = (Rectangle)shape;

                    formProperties.ShowDialog();
                    
                    Invalidate();
                    
                    break;
                }
            }
        }
    }
}