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
        private bool _fromMenuBar;

        private int _mouseXCoordinate;
        private int _mouseYCoordinate;

        private Color _defaultButtonColor;
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
            this._shape = selectedShape;
            InitializeComponent();
        }

        public FormInput(bool fromMenuBar)
        {
            this._fromMenuBar = fromMenuBar;
            InitializeComponent();
        }

        public Shape GetShape() => _shape;


        private void FormInput_Load(object sender, EventArgs e)
        {
            if (_shape is Circle circle)
            {
                checkBoxCircle.Checked = true;

                labelParameters.Visible = true;

                labelRadius.Visible = true;
                textBoxRadius.Visible = true;
                textBoxRadius.Text = circle.Radius.ToString();


                labelCoordinates.Visible = true;

                labelXCoordinate.Visible = true;
                textBoxXCoordinate.Text = circle.Location.X.ToString();

                labelYCoordinate.Visible = true;
                textBoxYCoordinate.Text = circle.Location.Y.ToString();

                buttonBorderColor.Visible = true;
                buttonBorderColor.BackColor = circle.ColorBorder;

                buttonFillColor.Visible = true;
                buttonFillColor.BackColor = circle.FillColor;
            }
            else if (_shape is Rectangle rectangle)
            {
                checkBoxRectangle.Checked = true;

                labelParameters.Visible = true;

                labelHeight.Visible = true;
                labelWidth.Visible = true;

                textBoxHeight.Visible = true;
                textBoxHeight.Text = rectangle.Height.ToString();

                textBoxWidth.Visible = true;
                textBoxWidth.Text = rectangle.Width.ToString();

                labelCoordinates.Visible = true;

                labelXCoordinate.Visible = true;
                textBoxXCoordinate.Text = rectangle.Location.X.ToString();

                labelYCoordinate.Visible = true;
                textBoxYCoordinate.Text = rectangle.Location.Y.ToString();

                buttonBorderColor.Visible = true;
                buttonBorderColor.BackColor = rectangle.ColorBorder;

                buttonFillColor.Visible = true;
                buttonFillColor.BackColor = rectangle.FillColor;
            }
            else if (_shape is EquilateralTriangle triangle)
            {
                checkBoxTriangle.Checked = true;

                labelParameters.Visible = true;

                labelSide.Visible = true;
                textBoxSide.Visible = true;
                textBoxSide.Text = triangle.Side.ToString();

                labelCoordinates.Visible = true;

                labelXCoordinate.Visible = true;
                textBoxXCoordinate.Text = triangle.Location.X.ToString();

                labelYCoordinate.Visible = true;
                textBoxYCoordinate.Text = triangle.Location.Y.ToString();

                buttonBorderColor.Visible = true;
                buttonBorderColor.BackColor = triangle.ColorBorder;

                buttonFillColor.Visible = true;
                buttonFillColor.BackColor = triangle.FillColor;
            }
        }

        private void checkBoxCircle_Click(object sender, EventArgs e)
        {
            if (checkBoxCircle.Checked)
            {
                labelParameters.Visible = true;

                labelRadius.Visible = true;
                textBoxRadius.Visible = true;

                buttonBorderColor.Visible = true;
                buttonFillColor.Visible = true;

                checkBoxTriangle.Checked = false;
                checkBoxRectangle.Checked = false;

                labelHeight.Visible = false;
                textBoxHeight.Visible = false;

                labelWidth.Visible = false;
                textBoxWidth.Visible = false;

                labelSide.Visible = false;
                textBoxSide.Visible = false;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = true;

                    labelXCoordinate.Visible = true;
                    textBoxXCoordinate.Visible = true;

                    labelYCoordinate.Visible = true;
                    textBoxYCoordinate.Visible = true;
                }
            }
            else
            {
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;

                labelParameters.Visible = false;

                buttonBorderColor.Visible = false;
                buttonFillColor.Visible = false;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = false;

                    labelXCoordinate.Visible = false;
                    textBoxXCoordinate.Visible = false;

                    labelYCoordinate.Visible = false;
                    textBoxYCoordinate.Visible = false;
                }
            }
        }

        private void checkBoxRectangle_Click(object sender, EventArgs e)
        {
            if (checkBoxRectangle.Checked)
            {
                labelParameters.Visible = true;

                labelHeight.Visible = true;
                labelWidth.Visible = true;

                textBoxHeight.Visible = true;
                textBoxWidth.Visible = true;

                buttonBorderColor.Visible = true;
                buttonFillColor.Visible = true;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = true;

                    labelXCoordinate.Visible = true;
                    textBoxXCoordinate.Visible = true;

                    labelYCoordinate.Visible = true;
                    textBoxYCoordinate.Visible = true;
                }

                checkBoxCircle.Checked = false;
                checkBoxTriangle.Checked = false;

                labelRadius.Visible = false;
                textBoxRadius.Visible = false;

                labelSide.Visible = false;
                textBoxSide.Visible = false;
            }
            else
            {
                labelParameters.Visible = false;

                labelHeight.Visible = false;
                labelWidth.Visible = false;

                textBoxHeight.Visible = false;
                textBoxWidth.Visible = false;

                buttonBorderColor.Visible = false;
                buttonFillColor.Visible = false;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = false;

                    labelXCoordinate.Visible = false;
                    textBoxXCoordinate.Visible = false;

                    labelYCoordinate.Visible = false;
                    textBoxYCoordinate.Visible = false;
                }
            }
        }

        private void checkBoxTriangle_Click(object sender, EventArgs e)
        {
            if (checkBoxTriangle.Checked)
            {
                labelParameters.Visible = true;

                labelSide.Visible = true;
                textBoxSide.Visible = true;

                buttonBorderColor.Visible = true;
                buttonFillColor.Visible = true;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = true;

                    labelXCoordinate.Visible = true;
                    textBoxXCoordinate.Visible = true;

                    labelYCoordinate.Visible = true;
                    textBoxYCoordinate.Visible = true;
                }

                checkBoxCircle.Checked = false;
                checkBoxRectangle.Checked = false;

                labelHeight.Visible = false;
                textBoxHeight.Visible = false;

                labelWidth.Visible = false;
                textBoxWidth.Visible = false;

                labelRadius.Visible = false;
                textBoxRadius.Visible = false;
            }
            else
            {
                labelParameters.Visible = false;

                labelSide.Visible = false;
                textBoxSide.Visible = false;

                buttonBorderColor.Visible = false;
                buttonFillColor.Visible = false;

                if (_fromMenuBar)
                {
                    labelCoordinates.Visible = false;

                    labelXCoordinate.Visible = false;
                    textBoxXCoordinate.Visible = false;

                    labelYCoordinate.Visible = false;
                    textBoxYCoordinate.Visible = false;
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
                    if (_fromMenuBar)
                    {
                        if (ValidateTextBox(textBoxXCoordinate, Constant.ErrorMessages.XCoordinateMessage,
                                out int xCoordinate) &&
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
                    if (_fromMenuBar)
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
                    if (_fromMenuBar)
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
                MessageBox.Show(Constant.ErrorMessages.ChooseShapeMessage, Constant.ErrorMessages.ErrorCaption,
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
            _defaultButtonColor = buttonCancel.BackColor;
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
                MessageBox.Show(errorMessage, Constant.ErrorMessages.ErrorCaption,
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
                    MessageBox.Show(Constant.ErrorMessages.PositiveNumberMessage, Constant.ErrorMessages.ErrorCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    result = -1;
                    return false;
                }
            }
            else
            {
                MessageBox.Show(Constant.ErrorMessages.NumberMessage, Constant.ErrorMessages.ErrorCaption,
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
    }
}