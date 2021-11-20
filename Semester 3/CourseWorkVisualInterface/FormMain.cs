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

            if (_frame?.Location != null)
            {
                _frame.DrawShape(ShapeDrawService.DrawShape);
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
                _shapes.Add(formUpdate.GetShape());
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

            string message = String.Format(Constant.InformationMessages.AllAreaMessage, areaOfAllShapes);

            GenerateMessageBox(message, Constant.Captions.AllAreaCaption);
        }

        private void allShapeTypesTotalAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            string message = _areaCalculationService.AllShapesAreaByType(_shapes);

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

            string message = String.Format(Constant.InformationMessages.AllAreaOfTypeMessage,
                nameof(EquilateralTriangle), areaOfAllEquilateralTriangles);

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

            string message = String.Format(Constant.InformationMessages.AllAreaOfTypeMessage,
                nameof(Rectangle), areaOfAllRectangles);

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

            string message = String.Format(Constant.InformationMessages.AllAreaOfTypeMessage,
                nameof(Circle), areaOfAllCircles);

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

            string message = String.Format(Constant.InformationMessages.BiggestAreaMessage, biggestAreaOfAllShapes);
            GenerateMessageBox(message, Constant.Captions.BiggestArea);
        }

        private void biggestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            string message = _areaCalculationService.AllShapesBiggestAreaByType(_shapes);

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

            string message = String.Format(Constant.InformationMessages.BiggestAreaOfTypeMessage,
                nameof(EquilateralTriangle), biggestAreaOfAllEquilateralTriangles);
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

            string message = String.Format(Constant.InformationMessages.BiggestAreaOfTypeMessage,
                nameof(Rectangle), biggestAreaOfAllRectangles);

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

            string message = String.Format(Constant.InformationMessages.BiggestAreaOfTypeMessage,
                nameof(Circle), biggestAreaOfAllCircles);

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

            string message = String.Format(Constant.InformationMessages.SmallestAreaMessage, smallestAreaOfAllShapes);
            GenerateMessageBox(message, Constant.Captions.SmallestArea);
        }

        private void smallestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                MessageBoxEmptyList();
                return;
            }

            string message = _areaCalculationService.AllShapesSmallestAreaByType(_shapes);

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

            string message = String.Format(Constant.InformationMessages.SmallestAreaOfTypeMessage,
                nameof(EquilateralTriangle), smallestAreaOfAllEquilateralTriangles);

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

            string message = String.Format(Constant.InformationMessages.SmallestAreaOfTypeMessage,
                nameof(Rectangle), smallestAreaOfAllRectangles);

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

            string message = String.Format(Constant.InformationMessages.SmallestAreaOfTypeMessage,
                nameof(Circle), smallestAreaOfAllCircles);

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

            string message = String.Format(Constant.InformationMessages.UnusedSpaceMessage,
                (sceneArea - areaOfAllShapes));
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