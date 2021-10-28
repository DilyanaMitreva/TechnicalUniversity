using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        private List<Shape> _shapes = new List<Shape>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFunctionality_Click(object sender, EventArgs e)
        {
            FormFunctionality formFunctionality = new FormFunctionality();
            if (formFunctionality.ShowDialog() == DialogResult.OK)
            {
            }
        }


        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormAdd formAdd = new FormAdd(e.X, e.Y);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    _shapes.Add(formAdd.getShape());
                }
                
               // Invalidate();
            }
        }
    }
}