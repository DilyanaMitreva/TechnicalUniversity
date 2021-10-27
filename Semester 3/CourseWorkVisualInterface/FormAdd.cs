using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;

namespace CourseWorkVisualInterface
{
    public partial class FormAdd : Form
    {
        private Shape shape;

        private Color outlineColor;

        private Color fillColor;

        public FormAdd()
        {
            InitializeComponent();
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
                
                labelLenght.Visible = false;
                textBoxLenght.Visible = false;
                
                labelSide.Visible = false;
                textBoxSide.Visible = false;

                labelCoordinates.Visible = true;
                labelXCoordinate.Visible = true;
                labelYCoordinate.Visible = true;

                textBoxXCoordinate.Visible = true;
                textBoxYCoordinate.Visible = true;

                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;

            }
            else
            {
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;
                
                labelCoordinates.Visible = false;
                labelXCoordinate.Visible = false;
                labelYCoordinate.Visible = false;

                textBoxXCoordinate.Visible = false;
                textBoxYCoordinate.Visible = false;
                
                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;
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

                checkBoxCircle.Checked = false;
                checkBoxTriangle.Checked = false;
                
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;
                
                labelSide.Visible = false;
                textBoxSide.Visible = false;
                
                labelCoordinates.Visible = true;
                labelXCoordinate.Visible = true;
                labelYCoordinate.Visible = true;

                textBoxXCoordinate.Visible = true;
                textBoxYCoordinate.Visible = true;
                
                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;
            }
            else
            {
                labelHeight.Visible = false;
                labelLenght.Visible = false;

                textBoxHeight.Visible = false;
                textBoxLenght.Visible = false;
                
                labelCoordinates.Visible = false;
                labelXCoordinate.Visible = false;
                labelYCoordinate.Visible = false;

                textBoxXCoordinate.Visible = false;
                textBoxYCoordinate.Visible = false;
                
                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;
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
                
                labelHeight.Visible = false;
                textBoxHeight.Visible = false;
                
                labelLenght.Visible = false;
                textBoxLenght.Visible = false;
                
                labelRadius.Visible = false;
                textBoxRadius.Visible = false;
                
                labelCoordinates.Visible = true;
                labelXCoordinate.Visible = true;
                labelYCoordinate.Visible = true;

                textBoxXCoordinate.Visible = true;
                textBoxYCoordinate.Visible = true;
                
                buttonFillColor.Visible = true;
                buttonOutlineColor.Visible = true;
            }
            else
            {
                labelSide.Visible = false;
                textBoxSide.Visible = false;
                
                labelCoordinates.Visible = false;
                labelXCoordinate.Visible = false;
                labelYCoordinate.Visible = false;

                textBoxXCoordinate.Visible = false;
                textBoxYCoordinate.Visible = false;
                
                buttonFillColor.Visible = false;
                buttonOutlineColor.Visible = false;
            }
        }

        private void addShape_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonOutlineColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                outlineColor = colorDialog.Color;
            }
        }

        private void buttonFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog.Color;
            }
        }
    }
}