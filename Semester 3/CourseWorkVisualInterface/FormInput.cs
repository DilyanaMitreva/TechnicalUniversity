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
        private Shape _shape;

        private int _xCoordinate;
        private int _yCoordinate;


        public FormInput()
        {
            InitializeComponent();
        }

        public FormInput(int xCoordinate, int yCoordinate)
        {
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
            InitializeComponent();
        }

        public FormInput(Shape selectedShape)
        {
            this._shape = selectedShape;
            this.Text = "Update a shape";
            InitializeComponent();
            
        }

        public Shape GetShape() => _shape;


        private void FormInput_Load(object sender, EventArgs e)
        {
            if (_shape is Circle circle)
            {
                checkBoxCircle.Checked = true;

                labelRadius.Visible = true;
                textBoxRadius.Visible = true;
                textBoxRadius.Text = circle.Radius.ToString();

                labelParameters.Visible = true;
            }
            else if (_shape is Rectangle rectangle)
            {
                checkBoxRectangle.Checked = true;

                labelHeight.Visible = true;
                labelWidth.Visible = true;

                textBoxHeight.Visible = true;
                textBoxHeight.Text = rectangle.Height.ToString();

                textBoxWidth.Visible = true;
                textBoxWidth.Text = rectangle.Width.ToString();

                labelParameters.Visible = true;
            }
            else if (_shape is EquilateralTriangle triangle)
            {
                checkBoxTriangle.Checked = true;

                labelSide.Visible = true;
                textBoxSide.Visible = true;
                textBoxSide.Text = triangle.Side.ToString();

                labelParameters.Visible = true;
            }
        }

        private void checkBoxCircle_Click(object sender, EventArgs e)
        {
            if (checkBoxCircle.Checked)
            {
                labelRadius.Visible = true;
                textBoxRadius.Visible = true;

                checkBoxTriangle.Checked = false;
                checkBoxRectangle.Checked = false;

                labelHeight.Visible = false;
                textBoxHeight.Visible = false;

                labelParameters.Visible = true;

                labelWidth.Visible = false;
                textBoxWidth.Visible = false;

                labelSide.Visible = false;
                textBoxSide.Visible = false;
            }
            else
            {
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;

                labelParameters.Visible = false;
            }
        }

        private void checkBoxRectangle_Click(object sender, EventArgs e)
        {
            if (checkBoxRectangle.Checked)
            {
                labelHeight.Visible = true;
                labelWidth.Visible = true;

                textBoxHeight.Visible = true;
                textBoxWidth.Visible = true;

                labelParameters.Visible = true;

                checkBoxCircle.Checked = false;
                checkBoxTriangle.Checked = false;

                labelRadius.Visible = false;
                textBoxRadius.Visible = false;

                labelSide.Visible = false;
                textBoxSide.Visible = false;
            }
            else
            {
                labelHeight.Visible = false;
                labelWidth.Visible = false;

                textBoxHeight.Visible = false;
                textBoxWidth.Visible = false;

                labelParameters.Visible = false;
            }
        }

        private void checkBoxTriangle_Click(object sender, EventArgs e)
        {
            if (checkBoxTriangle.Checked)
            {
                labelSide.Visible = true;
                textBoxSide.Visible = true;

                checkBoxCircle.Checked = false;
                checkBoxRectangle.Checked = false;

                labelParameters.Visible = true;

                labelHeight.Visible = false;
                textBoxHeight.Visible = false;

                labelWidth.Visible = false;
                textBoxWidth.Visible = false;

                labelRadius.Visible = false;
                textBoxRadius.Visible = false;
            }
            else
            {
                labelSide.Visible = false;
                textBoxSide.Visible = false;
                labelParameters.Visible = false;
            }
        }

        private void addShape_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color borderColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            Color fillColor = Color.FromArgb(100, borderColor);

            // _xCoordinate = _shape != null ? _shape.Location.X : 0;
            // _yCoordinate = _shape != null ? _shape.Location.Y : 0;

            this._xCoordinate = this._xCoordinate != default ? this._xCoordinate : this._shape.Location.X;
            this._yCoordinate = this._yCoordinate != default ? this._yCoordinate : this._shape.Location.Y;

            if (checkBoxCircle.Checked)
            {
                if (textBoxRadius.Text == "")
                {
                    MessageBox.Show(Constant.Messages.MessageRadius, Constant.Messages.ErrorCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    return;
                }
                else
                {
                    bool isNumber = int.TryParse(textBoxRadius.Text, out int radius);

                    if (isNumber)
                    {
                        _shape = new Circle(_xCoordinate, _yCoordinate, radius, borderColor, fillColor);
                    }
                    else
                    {
                        MessageBox.Show(Constant.Messages.MessageNumber, Constant.Messages.ErrorCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        DialogResult = DialogResult.Retry;
                        return;
                    }
                }
            }
            else if (checkBoxRectangle.Checked)
            {
                if (textBoxHeight.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageHeight, Constant.Messages.ErrorCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    return;
                }
                else if (textBoxWidth.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageLength, Constant.Messages.ErrorCaption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    return;
                }
                else
                {
                    bool isNumber = int.TryParse(textBoxHeight.Text, out int height);

                    bool isNumber2 = int.TryParse(textBoxWidth.Text, out int lenght);

                    if (isNumber && isNumber2)
                    {
                        _shape = new Rectangle(_xCoordinate, _yCoordinate, lenght,
                            height, borderColor, fillColor);
                    }
                    else
                    {
                        MessageBox.Show(Constant.Messages.MessageNumber, Constant.Messages.ErrorCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        DialogResult = DialogResult.Retry;
                        return;
                    }
                }
            }
            else if (checkBoxTriangle.Checked)
            {
                if (textBoxSide.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageSide, Constant.Messages.ErrorCaption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Retry;
                    return;
                }
                else
                {
                    bool isNumber = int.TryParse(textBoxSide.Text, out int side);

                    if (isNumber)
                    {
                        _shape = new EquilateralTriangle(_xCoordinate, _yCoordinate, side, borderColor,
                            fillColor);
                    }
                    else
                    {
                        MessageBox.Show(Constant.Messages.MessageNumber, Constant.Messages.ErrorCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        DialogResult = DialogResult.Retry;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show(Constant.Messages.MessageChooseShape, Constant.Messages.ErrorCaption,
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}