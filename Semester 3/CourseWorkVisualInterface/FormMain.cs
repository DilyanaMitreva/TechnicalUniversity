using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseWorkEntities.Services;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        private Point _mouseCaptureLocation;

        private List<Shape> _shapes = new List<Shape>();

        private Shape _selectedShape;
        private Rectangle _frame;
        private readonly IAreaCalculationService _areaCalculationService;
        private readonly ISelectShapeService _selectShapeService;


        public FormMain()
        {
            this._areaCalculationService = new AreaCalculationService();
            this._selectShapeService = new SelectShapeService();
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

        private void selectAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0)
            {
                MessageBoxEmptyList();
                return;
            }

            _selectShapeService.SelectAllShapes(_shapes);
            Invalidate();
        }

        private void selectAllTrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            _selectShapeService.SelectAllShapesByType(_shapes, typeof(EquilateralTriangle));

            Invalidate();
        }

        private void selectAllRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            _selectShapeService.SelectAllShapesByType(_shapes, typeof(Rectangle));

            Invalidate();
        }

        private void selectAllCirclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            _selectShapeService.SelectAllShapesByType(_shapes, typeof(Circle));

            Invalidate();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInput formInput = new FormInput(true);
            this.ExecuteForm(formInput);
        }

        private void allShapesTotalAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double areaOfAllShapes = _areaCalculationService.AreaOfAllShapes(_shapes);

            string message = new StringBuilder().AppendLine($"The total area is {areaOfAllShapes:g2} pixels.")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void allShapeTypesTotalAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double allRectangles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Rectangle));
            double allCircles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Circle));
            double allEquilateralTriangles =
                _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine($"Rectangles: {allRectangles:g2}")
                .AppendLine($"Circles: {allCircles:g2}")
                .AppendLine($"Equilateral triangles: {allEquilateralTriangles:g2}")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void allEquilateralTriangleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double areaOfAllEquilateralTriangles =
                _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine(
                    $"The total area of all equilateral triangles is {areaOfAllEquilateralTriangles:g2} pixels.")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void allRectangleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double areaOfAllRectangles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = new StringBuilder()
                .AppendLine($"The total area of all rectangles is {areaOfAllRectangles:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void allCircleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double areaOfAllCircles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = new StringBuilder()
                .AppendLine($"The total area of all circles is {areaOfAllCircles:g2} pixels.")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void biggestAreaFromAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double biggestAreaOfAllShapes = _areaCalculationService.BiggestAreaOfAllShapes(_shapes);

            string message = new StringBuilder()
                .AppendLine($"The biggest area of all shapes is {biggestAreaOfAllShapes:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void biggestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double allRectangles = _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));
            double allCircles = _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Circle));
            double allEquilateralTriangles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine($"Rectangles: {allRectangles:g2}")
                .AppendLine($"Circles: {allCircles:g2}")
                .AppendLine($"Equilateral triangles: {allEquilateralTriangles:g2}")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void biggestTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double biggestAreaOfAllEquilateralTriangles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine(
                    $"The biggest equilateral triangle has area of {biggestAreaOfAllEquilateralTriangles:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void biggestRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_shapes.Count == 0)
            {
                MessageBoxEmptyList();
                return;
            }

            double biggestAreaOfAllRectangles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = $"The biggest rectangle has area of {biggestAreaOfAllRectangles:g2} pixels.";
            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void biggestCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double biggestAreaOfAllCircles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = new StringBuilder()
                .AppendLine($"The biggest circle has area of {biggestAreaOfAllCircles:g2} pixels.")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void smallestAreaFromAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double smallestAreaOfAllShapes = _areaCalculationService.SmallestAreaOfAllShapes(_shapes);

            string message = new StringBuilder()
                .AppendLine($"The smallest area of all shapes is {smallestAreaOfAllShapes:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void smallestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double allRectangles = _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));
            double allCircles = _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Circle));
            double allEquilateralTriangles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine($"Rectangles: {allRectangles:g2}")
                .AppendLine($"Circles: {allCircles:g2}")
                .AppendLine($"Equilateral triangles: {allEquilateralTriangles:g2}")
                .ToString();

            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void smallestTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double smallestAreaOfAllEquilateralTriangles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = new StringBuilder()
                .AppendLine(
                    $"The smallest equilateral triangle has area of {smallestAreaOfAllEquilateralTriangles:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void smallestRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double smallestAreaOfAllRectangles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = new StringBuilder()
                .AppendLine($"The smallest rectangle has area of {smallestAreaOfAllRectangles:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void smallestCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double smallestAreaOfAllCircles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = new StringBuilder()
                .AppendLine($"The smallest circle has area of {smallestAreaOfAllCircles:g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void totalUnusedSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            double areaOfAllShapes = _areaCalculationService.AreaOfAllShapes(_shapes);
            double sceneArea = this.Height * this.Width;

            string message = new StringBuilder()
                .AppendLine($"The unused area of the scene is {(sceneArea - areaOfAllShapes):g2} pixels.")
                .ToString();
            GenerateMessageBox(message, Constant.Captions.TotalUnusedSpace);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_shapes.Count(s => s.IsSelected) == 0)
            {
                MessageBoxEmptyList();
                return;
            }

            for (int i = _shapes.Count - 1; i >= 0; i--)
            {
                Shape shape = _shapes[i];
                if (shape.IsSelected)
                {
                    _shapes.Remove(shape);
                }
            }

            Invalidate();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            FormExport formExport = new FormExport(_shapes);
            do
            {
                formExport.ShowDialog();
            } while (formExport.DialogResult == DialogResult.Retry);

            if (formExport.DialogResult == DialogResult.OK)
            {
                // open file in windows??
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shapes = new List<Shape>();
            Invalidate();
        }

        private void MessageBoxEmptyList() =>
            MessageBox.Show(Constant.ErrorMessages.EmptyListMessage,
                Constant.Captions.ErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void GenerateMessageBox(string message, string caption)
            => MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        private bool ValidateListNotEmpty() => _shapes.Count == 0;
    }
}