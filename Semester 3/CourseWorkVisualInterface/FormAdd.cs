using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkVisualInterface
{
    public partial class FormAdd : Form
    {
        private Shape _shape;

        private Color _outlineColor = Color.Black;

        private Color _fillColor = Color.Transparent;

        private int _shapeXCoordinate;
        private int _shapeYCoordinate;

        public FormAdd()
        {
            InitializeComponent();
        }

        public FormAdd(int x, int y)
        {
            InitializeComponent();
            this._shapeXCoordinate = x;
            this._shapeYCoordinate = y;
        }

        public Shape getShape() => _shape;

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

                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;
            }
            else
            {
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;

                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;

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

                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;
            }
            else
            {
                labelHeight.Visible = false;
                labelLenght.Visible = false;

                textBoxHeight.Visible = false;
                textBoxLenght.Visible = false;

                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;

                labelParameters.Visible = false;
            }
        }

        private void checkBoxTriangle_CheckedChanged(object sender, EventArgs e)
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

                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;
            }
            else
            {
                labelSide.Visible = false;
                textBoxSide.Visible = false;

                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;

                labelParameters.Visible = false;
            }
        }

        private void addShape_Click(object sender, EventArgs e)
        {
            if (checkBoxCircle.Checked)
            {
                if (textBoxRadius.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageRadius);
                }

                bool isNumber = decimal.TryParse(textBoxRadius.Text, out decimal radius);

                if (isNumber)
                {
                    _shape = new Circle(_shapeXCoordinate, _shapeYCoordinate, radius, _outlineColor, _fillColor);
                }
                else
                {
                    MessageBox.Show(Constant.Messages.MessageNumber);
                }
            }
            else if (checkBoxRectangle.Checked)
            {
                if (textBoxHeight.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageHeight);
                }
                else if (textBoxLenght.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageLenght);
                }

                bool isNumber = decimal.TryParse(textBoxHeight.Text, out decimal height);

                bool isNumber2 = decimal.TryParse(textBoxLenght.Text, out decimal lenght);

                if (isNumber && isNumber2)
                {
                    _shape = new CourseWorkEntities.Shapes.Rectangle(_shapeXCoordinate, _shapeYCoordinate, lenght,
                        height, _outlineColor, _fillColor);
                }
                else
                {
                    MessageBox.Show(Constant.Messages.MessageNumber);
                }
            }
            else if (checkBoxTriangle.Checked)
            {
                if (textBoxSide.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageSide);
                }

                bool isNumber = decimal.TryParse(textBoxSide.Text, out decimal side);

                if (isNumber)
                {
                    _shape = new Triangle(_shapeXCoordinate, _shapeYCoordinate, side, _outlineColor, _fillColor);
                }
                else
                {
                    MessageBox.Show(Constant.Messages.MessageNumber);
                }
            }

            else
            {
                MessageBox.Show(Constant.Messages.MessageChooseShape);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOutlineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _outlineColor = colorDialog.Color;
            }
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog.Color;
            }
        }
    }
}