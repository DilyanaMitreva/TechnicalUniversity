using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkVisualInterface
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void buttonFunctionality_Click(object sender, EventArgs e)
        {
            FormFunctionality formFunctionality = new FormFunctionality();
            if (formFunctionality.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}