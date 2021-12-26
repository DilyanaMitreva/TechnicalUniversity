using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CourseWorkEntities.Constants;
using CourseWorkEntities.Exceptions;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;
using CourseWorkVisualInterface.Services;
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
        private readonly ISerializeShapeService _serializeShapeService;
        private readonly IDeserializeService _deserializeService;
        private readonly IMoveShapeService _moveShapeService;


        public FormMain()
        {
            this._areaCalculationService = new AreaCalculationService();
            this._selectShapeService = new SelectShapeService();
            this._serializeShapeService = new SerializeShapeService();
            this._deserializeService = new DeserializeService();
            this._moveShapeService = new MoveShapeService();

            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                foreach (var shape in _shapes)
                {
                    shape.DrawShape(ShapeDrawService.DrawShape, e.Graphics);
                }

                if (_frame?.Location != null)
                {
                    _frame.DrawShape(ShapeDrawService.DrawShape, e.Graphics);
                }
            }
            catch (ShapeNotSupportedException exception)
            {
                GenerateMessageBox(exception.Message,
                    Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                GenerateMessageBox(exception.Message,
                    Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _shapes = _deserializeService.DeserializeSave();
            }
            catch (FileNotFoundException exception)
            {
            }
            catch (Exception exception)
            {
                GenerateMessageBox(exception.Message,
                    Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _serializeShapeService.SerializeSave(_shapes);
            }
            catch (EmptyCollectionException exception)
            {
            }
            catch (Exception exception)
            {
                GenerateMessageBox(exception.Message,
                    Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] moveButtons = new Keys[] { Keys.Up, Keys.Down, Keys.Right, Keys.Left };

            if (e.KeyCode == Keys.Delete)
            {
                DeleteShapes();
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                _selectShapeService.SelectAllShapes(_shapes);
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                try
                {
                    _serializeShapeService.SerializeSave(_shapes);
                }
                catch (EmptyCollectionException ex)
                {
                }
                catch (Exception ex)
                {
                    GenerateMessageBox(ex.Message, Captions.ErrorCaption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    GenerateMessageBox( Messages.SaveMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            if (moveButtons.Contains(e.KeyCode))
            {
                List<Shape> selectedShapes = _shapes.Where(s => s.IsSelected).ToList();
                _moveShapeService.Move(selectedShapes, e.KeyCode);
            }

            Invalidate();
        }

        private Shape GetFirstSelected()
            => _shapes.FirstOrDefault(s => s.IsSelected);


        private void UpdateShape()
        {
            this._selectedShape = GetFirstSelected();

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

            Invalidate();
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
                Shape createdShape = formInput.GetShape();
                this._shapes.Add(createdShape);
                Invalidate();
            }
        }

        private void selectAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectShapeService.SelectAllShapes(_shapes);
            Invalidate();
        }

        private void selectAllTrianglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectShapeService.SelectAllShapesByType(_shapes, typeof(EquilateralTriangle));

            Invalidate();
        }

        private void selectAllRectanglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectShapeService.SelectAllShapesByType(_shapes, typeof(Rectangle));

            Invalidate();
        }

        private void selectAllCirclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double areaOfAllShapes = _areaCalculationService.AreaOfAllShapes(_shapes);

            string message = String.Format( Messages.AreaTemplateMessages.AllAreaMessage, areaOfAllShapes);

            GenerateMessageBox(message,  Captions.AllAreaCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void allShapeTypesTotalAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = _areaCalculationService.AllShapesAreaByType(_shapes);

            GenerateMessageBox(message,  Captions.AllAreaCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void allEquilateralTriangleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double areaOfAllEquilateralTriangles =
                _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = String.Format( Messages.AreaTemplateMessages.AllAreaOfTypeMessage,
                nameof(EquilateralTriangle), areaOfAllEquilateralTriangles);

            GenerateMessageBox(message,  Captions.AllAreaCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void allRectangleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double areaOfAllRectangles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = String.Format( Messages.AreaTemplateMessages.AllAreaOfTypeMessage,
                nameof(Rectangle), areaOfAllRectangles);

            GenerateMessageBox(message,  Captions.AllAreaCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void allCircleAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double areaOfAllCircles = _areaCalculationService.AreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = String.Format( Messages.AreaTemplateMessages.AllAreaOfTypeMessage,
                nameof(Circle), areaOfAllCircles);

            GenerateMessageBox(message,  Captions.AllAreaCaption, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void biggestAreaFromAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double biggestAreaOfAllShapes = _areaCalculationService.BiggestAreaOfAllShapes(_shapes);

            string message = String.Format( Messages.AreaTemplateMessages.BiggestAreaMessage, biggestAreaOfAllShapes);
            GenerateMessageBox(message,  Captions.BiggestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void biggestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = _areaCalculationService.AllShapesBiggestAreaByType(_shapes);

            GenerateMessageBox(message,  Captions.BiggestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void biggestTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double biggestAreaOfAllEquilateralTriangles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = String.Format( Messages.AreaTemplateMessages.BiggestAreaOfTypeMessage,
                nameof(EquilateralTriangle), biggestAreaOfAllEquilateralTriangles);
            GenerateMessageBox(message,  Captions.BiggestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void biggestRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double biggestAreaOfAllRectangles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = String.Format( Messages.AreaTemplateMessages.BiggestAreaOfTypeMessage,
                nameof(Rectangle), biggestAreaOfAllRectangles);

            GenerateMessageBox(message,  Captions.BiggestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void biggestCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double biggestAreaOfAllCircles =
                _areaCalculationService.BiggestAreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = String.Format( Messages.AreaTemplateMessages.BiggestAreaOfTypeMessage,
                nameof(Circle), biggestAreaOfAllCircles);

            GenerateMessageBox(message,  Captions.BiggestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void smallestAreaFromAllShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double smallestAreaOfAllShapes = _areaCalculationService.SmallestAreaOfAllShapes(_shapes);

            string message = String.Format( Messages.AreaTemplateMessages.SmallestAreaMessage, smallestAreaOfAllShapes);
            GenerateMessageBox(message,  Captions.SmallestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void smallestAreaFromTypeOfShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = _areaCalculationService.AllShapesSmallestAreaByType(_shapes);

            GenerateMessageBox(message,  Captions.SmallestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void smallestTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double smallestAreaOfAllEquilateralTriangles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(EquilateralTriangle));

            string message = String.Format( Messages.AreaTemplateMessages.SmallestAreaOfTypeMessage,
                nameof(EquilateralTriangle), smallestAreaOfAllEquilateralTriangles);

            GenerateMessageBox(message,  Captions.SmallestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void smallestRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double smallestAreaOfAllRectangles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Rectangle));

            string message = String.Format( Messages.AreaTemplateMessages.SmallestAreaOfTypeMessage,
                nameof(Rectangle), smallestAreaOfAllRectangles);

            GenerateMessageBox(message,  Captions.SmallestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void smallestCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double smallestAreaOfAllCircles =
                _areaCalculationService.SmallestAreaOfAllShapesFromType(_shapes, typeof(Circle));

            string message = String.Format( Messages.AreaTemplateMessages.SmallestAreaOfTypeMessage,
                nameof(Circle), smallestAreaOfAllCircles);

            GenerateMessageBox(message,  Captions.SmallestArea, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void totalUnusedSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidateListNotEmpty())
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double areaOfAllShapes = _areaCalculationService.AreaOfAllShapes(_shapes);
            double sceneArea = this.Height * this.Width;

            string message = String.Format( Messages.AreaTemplateMessages.UnusedSpaceMessage,
                sceneArea - areaOfAllShapes);
            GenerateMessageBox(message,  Captions.TotalUnusedSpace, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => DeleteShapes();

        private void DeleteShapes()
        {
            if (_shapes.Count(s => s.IsSelected) == 0)
            {
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                GenerateMessageBox( Messages.ExceptionMessages.EmptyListMessage,
                     Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormExport formExport = new FormExport(_shapes);
            do
            {
                formExport.ShowDialog();
            } while (formExport.DialogResult == DialogResult.Retry);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _shapes = new List<Shape>();
            Invalidate();
        }


        private static void GenerateMessageBox(string message, string caption, MessageBoxButtons messageBoxButtons,
            MessageBoxIcon messageBoxIcon) =>
            MessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon);

        private bool ValidateListNotEmpty() => _shapes.Count == 0;
    }
}