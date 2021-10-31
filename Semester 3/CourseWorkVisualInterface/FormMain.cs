using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkVisualInterface.Services;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        private readonly List<Shape> _shapes = new List<Shape>();
        private Shape _selectedShape;

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
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.AddShape(e);
            }

            if (e.Button == MouseButtons.Left)
            {
                foreach (Shape shape in _shapes)
                {
                    shape.IsSelected = shape.PointInShape(new PointImpl(e.X, e.Y));
                }
            }

            Invalidate();
        }

        private void FormMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.UpdateShape();
            }
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

            FormInput formUpdate = new FormInput(_selectedShape);
            this.ExecureForm(formUpdate);
        }

        private void AddShape(MouseEventArgs e)
        {
            FormInput formAdd = new FormInput(e.X, e.Y);

            this.ExecureForm(formAdd);
        }

        private void ExecureForm(FormInput formInput)
        {
            do
            {
                formInput.ShowDialog();
            } while (formInput.DialogResult == DialogResult.Retry);

            if (formInput.DialogResult == DialogResult.OK)
            {
                ShapeDrawService.Graphics = this.CreateGraphics();

                Shape createdShape = formInput.getShape();

                createdShape.DrawShape(ShapeDrawService.DrawShape);

                this._shapes.Add(createdShape);

                ShapeDrawService.Graphics.Dispose();
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}