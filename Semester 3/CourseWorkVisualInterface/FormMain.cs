using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkVisualInterface.Services;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        private List<Shape> _shapes = new List<Shape>();

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
            else if (e.Button == MouseButtons.Left)
            {
            }

            Invalidate();
        }

        private void AddShape(MouseEventArgs e)
        {
            FormAdd formAdd = new FormAdd(e.X, e.Y);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                ShapeDrawService.Graphics = this.CreateGraphics();

                Shape createdShape = formAdd.Shape;

                createdShape.DrawShape(ShapeDrawService.DrawShape);

                _shapes.Add(createdShape);

                ShapeDrawService.Graphics.Dispose();
            }
        }
    }
}