using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using Rectangle = CourseWorkEntities.Shapes.Rectangle;

namespace CourseWorkVisualInterface
{
    public partial class FormInput : Form
    {
        private readonly bool _fromMenuBar;
        private readonly bool _updateShape;

        private readonly int _mouseXCoordinate;
        private readonly int _mouseYCoordinate;

        private readonly Color _defaultButtonColor = Color.Transparent;
        private Color _borderColor;
        private Color _fillColor;

        private Shape _shape;

        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(int mouseXCoordinate, int mouseYCoordinate)
        {
            _mouseXCoordinate = mouseXCoordinate;
            _mouseYCoordinate = mouseYCoordinate;
            InitializeComponent();
        }

        public FormInput(Shape selectedShape)
        {
            _shape = selectedShape;
            _updateShape = true;
            InitializeComponent();
        }

        public FormInput(bool fromMenuBar)
        {
            _fromMenuBar = fromMenuBar;
            InitializeComponent();
        }

        public Shape GetShape() => _shape;


        private void FormInput_Load(object sender, EventArgs e)
        {
            if (_shape is Circle circle)
            {
                LoadCircleData(circle);
                ShowCircleElements();
                ShowCoordinateElements();
                ShowColorElements();
            }
            else if (_shape is Rectangle rectangle)
            {
                LoadRectangleData(rectangle);
                ShowRectangleElements();
                ShowCoordinateElements();
                ShowColorElements();
            }
            else if (_shape is EquilateralTriangle triangle)
            {
                LoadEquilateralTriangleData(triangle);
                ShowEquilateralTriangleElements();
                ShowCoordinateElements();
                ShowColorElements();
            }
        }

        private void checkBoxCircle_Click(object sender, EventArgs e)
        {
            if (checkBoxCircle.Checked)
            {
                ResetRectangleElements();

                ResetEquilateralTriangleElements();

                ShowCircleElements();

                ShowColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ShowCoordinateElements();
                }
            }
            else
            {
                ResetCircleElements();

                ResetColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ResetCoordinateElements();
                }
            }
        }

        private void checkBoxRectangle_Click(object sender, EventArgs e)
        {
            if (checkBoxRectangle.Checked)
            {
                ResetCircleElements();
                ResetEquilateralTriangleElements();
                ShowRectangleElements();
                ShowColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ShowCoordinateElements();
                }
            }
            else
            {
                ResetRectangleElements();
                ResetColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ResetCoordinateElements();
                }
            }
        }

        private void checkBoxTriangle_Click(object sender, EventArgs e)
        {
            if (checkBoxTriangle.Checked)
            {
                ResetCircleElements();

                ResetRectangleElements();

                ShowEquilateralTriangleElements();

                ShowColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ShowCoordinateElements();
                }
            }
            else
            {
                ResetEquilateralTriangleElements();
                ResetColorElements();

                if (_fromMenuBar || _updateShape)
                {
                    ResetCoordinateElements();
                }
            }
        }

        private void addShape_Click(object sender, EventArgs e)
        {
            ValidateColors();

            if (checkBoxCircle.Checked)
            {
                if (ValidateTextBox(textBoxRadius, Constant.ErrorMessages.RadiusMessage, out int radius))
                {
                    if (_fromMenuBar || _updateShape)
                    {
                        if (ValidateTextBox(textBoxXCoordinate, Constant.ErrorMessages.XCoordinateMessage,
                                out int xCoordinate)
                            &&
                            ValidateTextBox(textBoxYCoordinate, Constant.ErrorMessages.YCoordinateMessage,
                                out int yCoordinate))
                        {
                            _shape = new Circle(xCoordinate, yCoordinate, radius, _borderColor, _fillColor);
                        }
                        else return;
                    }
                    else
                    {
                        _shape = new Circle(_mouseXCoordinate, _mouseYCoordinate, radius, _borderColor, _fillColor);
                    }
                }
                else return;
            }
            else if (checkBoxRectangle.Checked)
            {
                if (ValidateTextBox(textBoxHeight, Constant.ErrorMessages.HeightMessage, out int height) &&
                    ValidateTextBox(textBoxWidth, Constant.ErrorMessages.WidthMessage, out int width))
                {
                    if (_fromMenuBar || _updateShape)
                    {
                        if (ValidateTextBox(textBoxXCoordinate, Constant.ErrorMessages.XCoordinateMessage,
                                out int xCoordinate) &&
                            ValidateTextBox(textBoxYCoordinate, Constant.ErrorMessages.YCoordinateMessage,
                                out int yCoordinate))
                        {
                            _shape = new Rectangle(xCoordinate, yCoordinate, width, height, _borderColor, _fillColor);
                        }
                        else return;
                    }
                    else
                    {
                        _shape = new Rectangle(_mouseXCoordinate, _mouseYCoordinate, width, height, _borderColor,
                            _fillColor);
                    }
                }
                else return;
            }
            else if (checkBoxTriangle.Checked)
            {
                if (ValidateTextBox(textBoxSide, Constant.ErrorMessages.SideMessage, out int side))
                {
                    if (_fromMenuBar || _updateShape)
                    {
                        if (ValidateTextBox(textBoxXCoordinate, Constant.ErrorMessages.XCoordinateMessage,
                                out int xCoordinate) &&
                            ValidateTextBox(textBoxYCoordinate, Constant.ErrorMessages.YCoordinateMessage,
                                out int yCoordinate))
                        {
                            _shape = new EquilateralTriangle(xCoordinate, yCoordinate, side, _borderColor, _fillColor);
                        }
                        else return;
                    }
                    else
                    {
                        _shape = new EquilateralTriangle(_mouseXCoordinate, _mouseYCoordinate, side, _borderColor,
                            _fillColor);
                    }
                }
                else return;
            }
            else
            {
                MessageBox.Show(Constant.ErrorMessages.ChooseShapeMessage, Constant.Captions.ErrorCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Retry;
                return;
            }

            if (_shape != null)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void ValidateColors()
        {
            Random random = new Random();
            _borderColor = buttonBorderColor.BackColor;
            _fillColor = buttonFillColor.BackColor;

            if (_borderColor == _defaultButtonColor && _fillColor == _defaultButtonColor)
            {
                _borderColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                _fillColor = Color.FromArgb(100, _borderColor);
            }
            else if (_borderColor == _defaultButtonColor)
            {
                _borderColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            }
            else if (_fillColor == _defaultButtonColor)
            {
                _fillColor = Color.FromArgb(100, _borderColor);
            }
        }

        private bool ValidateTextBox(TextBox textBox, String errorMessage, out int result)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(errorMessage, Constant.Captions.ErrorCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Retry;
                result = -1;
                return false;
            }

            bool isNumber = int.TryParse(textBox.Text, out int number);

            if (isNumber)
            {
                if (number > 0)
                {
                    result = number;
                    return true;
                }
                else
                {
                    MessageBox.Show(Constant.ErrorMessages.PositiveNumberMessage, Constant.Captions.ErrorCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    result = -1;
                    return false;
                }
            }
            else
            {
                MessageBox.Show(Constant.ErrorMessages.NumberMessage, Constant.Captions.ErrorCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.Retry;
                result = -1;
                return false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonBorderColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonBorderColor.BackColor = colorDialog.Color;
            }
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonFillColor.BackColor = colorDialog.Color;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) => ResetForm();
        
        private void ResetForm()
        {
            if (checkBoxCircle.Checked)
            {
                ResetCircleElements();
            }
            else if (checkBoxRectangle.Checked)
            {
                ResetRectangleElements();
            }
            else if (checkBoxTriangle.Checked)
            {
                ResetEquilateralTriangleElements();
            }

            if (_fromMenuBar || _updateShape)
            {
                ResetCoordinateElements();
            }

            ResetColorElements();
        }

        private void ResetColorElements()
        {
            buttonBorderColor.BackColor = Color.Transparent;
            buttonBorderColor.Visible = false;

            buttonFillColor.BackColor = Color.Transparent;
            buttonFillColor.Visible = false;
        }

        private void ResetCircleElements()
        {
            checkBoxCircle.Checked = false;

            labelRadius.Visible = false;

            textBoxRadius.Text = String.Empty;
            textBoxRadius.Visible = false;

            labelParameters.Visible = false;
        }

        private void ResetRectangleElements()
        {
            checkBoxRectangle.Checked = false;

            labelHeight.Visible = false;
            labelWidth.Visible = false;

            textBoxHeight.Text = String.Empty;
            textBoxHeight.Visible = false;

            textBoxWidth.Text = String.Empty;
            textBoxWidth.Visible = false;

            labelParameters.Visible = false;
        }

        private void ResetEquilateralTriangleElements()
        {
            checkBoxTriangle.Checked = false;

            labelSide.Visible = false;

            textBoxSide.Text = String.Empty;
            textBoxSide.Visible = false;

            labelParameters.Visible = false;
        }

        private void ResetCoordinateElements()
        {
            labelCoordinates.Visible = false;

            labelXCoordinate.Visible = false;
            labelYCoordinate.Visible = false;

            textBoxXCoordinate.Text = String.Empty;
            textBoxXCoordinate.Visible = false;

            textBoxYCoordinate.Text = String.Empty;
            textBoxYCoordinate.Visible = false;
        }

        private void ShowCircleElements()
        {
            checkBoxCircle.Checked = true;

            labelParameters.Visible = true;

            labelRadius.Visible = true;
            textBoxRadius.Visible = true;
        }

        private void ShowRectangleElements()
        {
            checkBoxRectangle.Checked = true;

            labelParameters.Visible = true;

            labelHeight.Visible = true;
            labelWidth.Visible = true;

            textBoxHeight.Visible = true;
            textBoxWidth.Visible = true;
        }

        private void ShowEquilateralTriangleElements()
        {
            checkBoxTriangle.Checked = true;

            labelParameters.Visible = true;

            labelSide.Visible = true;
            textBoxSide.Visible = true;
        }

        private void ShowColorElements()
        {
            buttonBorderColor.Visible = true;
            buttonFillColor.Visible = true;
        }

        private void ShowCoordinateElements()
        {
            labelCoordinates.Visible = true;

            labelXCoordinate.Visible = true;
            textBoxXCoordinate.Visible = true;

            labelYCoordinate.Visible = true;
            textBoxYCoordinate.Visible = true;
        }

        private void LoadCircleData(Circle circle)
        {
            textBoxRadius.Text = circle.Radius.ToString();
            
            textBoxXCoordinate.Text = circle.Location.X.ToString();

            textBoxYCoordinate.Text = circle.Location.Y.ToString();
            
            buttonBorderColor.BackColor = circle.ColorBorder;
            
            buttonFillColor.BackColor = circle.FillColor;
        }

        private void LoadRectangleData(Rectangle rectangle)
        {
            
            textBoxHeight.Text = rectangle.Height.ToString();
            
            textBoxWidth.Text = rectangle.Width.ToString();
            
            textBoxXCoordinate.Text = rectangle.Location.X.ToString();
            
            textBoxYCoordinate.Text = rectangle.Location.Y.ToString();
            
            buttonBorderColor.BackColor = rectangle.ColorBorder;
            
            buttonFillColor.BackColor = rectangle.FillColor;
        }

        private void LoadEquilateralTriangleData(EquilateralTriangle triangle)
        {
            textBoxSide.Text = triangle.Side.ToString();
            
            textBoxXCoordinate.Text = triangle.Location.X.ToString();
            
            textBoxYCoordinate.Text = triangle.Location.Y.ToString();
            
            buttonBorderColor.BackColor = triangle.ColorBorder;
            
            buttonFillColor.BackColor = triangle.FillColor;
        }
    }
}