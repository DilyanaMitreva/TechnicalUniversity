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
            InitializeComponent();
        }

        public Shape getShape() => _shape;


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
                labelLenght.Visible = true;

                textBoxHeight.Visible = true;
                textBoxHeight.Text = rectangle.Height.ToString();

                textBoxLenght.Visible = true;
                textBoxLenght.Text = rectangle.Width.ToString();

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

                labelLenght.Visible = false;
                textBoxLenght.Visible = false;

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
                labelLenght.Visible = true;

                textBoxHeight.Visible = true;
                textBoxLenght.Visible = true;

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
                labelLenght.Visible = false;

                textBoxHeight.Visible = false;
                textBoxLenght.Visible = false;

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

                labelLenght.Visible = false;
                textBoxLenght.Visible = false;

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
                else if (textBoxLenght.Text == null)
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

                    bool isNumber2 = int.TryParse(textBoxLenght.Text, out int lenght);

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