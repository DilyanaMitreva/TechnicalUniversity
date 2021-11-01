using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkVisualInterface.Services;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        private readonly List<Shape> _shapes = new List<Shape>();
        private Shape _selectedShape;
        private Rectangle _frame;
        private Point _mouseCaptureLocation;

        public FormMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ShapeDrawService.Graphics = e.Graphics;
            base.OnPaint(e);
            foreach (var shape in _shapes)
            {
                shape.DrawShape(ShapeDrawService.DrawShape);
            }

            if (_frame != null)
            {
                if (_frame.Location != null)
                {
                    _frame.DrawShape(ShapeDrawService.DrawShape);
                }
            }
        }

        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.UpdateShape();
            }

            Invalidate();
        }


        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.AddShape(e);
            }

            if (e.Button == MouseButtons.Left)
            {
                _mouseCaptureLocation = e.Location;
                _frame = new Rectangle()
                {
                    ColorBorder = Color.Black,
                    FillColor = Color.Transparent,
                };

                foreach (Shape shape in _shapes)
                {
                    shape.IsSelected = shape.PointInShape(new PointImpl(e.X, e.Y));
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

            _frame.Location = new PointImpl()
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
                    shape.IsSelected = shape.Intersect(_frame);
                }
            }
            

            Invalidate();
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            _frame = null;

            Invalidate();
        }


        private void UpdateShape()
        {
            foreach (Shape shape in _shapes)
            {
                if (shape.IsSelected)
                {
                    this._selectedShape = shape;
                    break;
                }
            }

            if (_selectedShape == null)
            {
                return;
            }

            FormInput formUpdate = new FormInput(_selectedShape);
            this.ExecuteForm(formUpdate);
            if (formUpdate.DialogResult == DialogResult.OK)
            {
                _shapes.Remove(_selectedShape);
            }
        }

        private void AddShape(MouseEventArgs e)
        {
            FormInput formAdd = new FormInput(e.X, e.Y);

            this.ExecuteForm(formAdd);
        }

        private void ExecuteForm(FormInput formInput)
        {
            do
            {
                formInput.ShowDialog();
            } while (formInput.DialogResult == DialogResult.Retry);

            if (formInput.DialogResult == DialogResult.OK)
            {
                ShapeDrawService.Graphics = this.CreateGraphics();

                Shape createdShape = formInput.GetShape();

                createdShape.DrawShape(ShapeDrawService.DrawShape);

                this._shapes.Add(createdShape);

                ShapeDrawService.Graphics.Dispose();
            }
        }
    }
}