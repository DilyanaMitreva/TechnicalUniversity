using System;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkVisualInterface
{
    public partial class FormAdd : Form
    {
        private readonly int _shapeXCoordinate;
        private readonly int _shapeYCoordinate;

        public Shape Shape { get; set; }

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
                if (textBoxRadius.Text == null)
                {
                    MessageBox.Show(Constant.Messages.MessageRadius);
                }

                bool isNumber = int.TryParse(textBoxRadius.Text, out int radius);

                if (isNumber)
                {
                    Shape = new Circle(_shapeXCoordinate, _shapeYCoordinate, radius, borderColor, fillColor);
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
                    MessageBox.Show(Constant.Messages.MessageWidth);
                }

                bool isNumber = int.TryParse(textBoxHeight.Text, out int height);

                bool isNumber2 = int.TryParse(textBoxLenght.Text, out int lenght);

                if (isNumber && isNumber2)
                {
                    Shape = new CourseWorkEntities.Shapes.Rectangle(_shapeXCoordinate, _shapeYCoordinate, lenght,
                        height, borderColor, fillColor);
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

                bool isNumber = int.TryParse(textBoxSide.Text, out int side);

                if (isNumber)
                {
                    Shape = new EquilateralTriangle(_shapeXCoordinate, _shapeYCoordinate, side, borderColor,
                        fillColor);
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

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}