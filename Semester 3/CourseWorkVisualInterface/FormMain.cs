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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormAdd formAdd = new FormAdd(e.X, e.Y);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    _shapes.Add(formAdd.getShape());
                    
                    
                }
                
                Invalidate();
            }
        }
    }
}

