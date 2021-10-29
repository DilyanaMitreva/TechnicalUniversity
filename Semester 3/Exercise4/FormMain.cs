using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class FormMain : Form
    {
        private List<Shape> _shapes = new List<Shape>();

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (Shape shape in _shapes)
            {
                shape.Paint(e.Graphics);
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            Shape shape = null;

            if (e.Button == MouseButtons.Left)
            {
                shape = new Circle(e.Location, 100, Color.Red, Color.Aqua);
            }
            else if (e.Button == MouseButtons.Right)
            {
                shape = new Rectangle(e.Location, 200, 300, Color.Blue, Color.Chartreuse);
            }

            else if (e.Button == MouseButtons.Middle)
            {
                foreach (Shape selectedShape in _shapes)
                {
                    selectedShape.Selected = selectedShape.PointInShape(e.Location);
                }
            }

            // Random r = new Random();
            // Color borderColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            // Color fillColor =  Color.FromArgb(100, c);
            if (shape != null)
            {
                _shapes.Add(shape);
            }

            Invalidate();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                if (_shapes[i].Selected)
                {
                    _shapes.RemoveAt(i);
                }
            }

            Invalidate();
        }
    }
}