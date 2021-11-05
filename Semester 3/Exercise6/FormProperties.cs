using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class FormProperties : Form
    {
        private bool _edit;
        public Rectangle Rectangle { get; set; }

        public Color SelectedColor => buttonColor.BackColor;

        public FormProperties(bool edit)
        {
            this._edit = edit;
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            if (_edit)
            {
                textBoxHeight.Text = Rectangle.Height.ToString();
                textBoxWidth.Text = Rectangle.Width.ToString();
                buttonColor.BackColor = Rectangle.ColorBorder;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (_edit)
            {
                Rectangle.Width = int.Parse(textBoxWidth.Text);
                Rectangle.Height = int.Parse(textBoxHeight.Text);

                Rectangle.ColorBorder = buttonColor.BackColor;
                Rectangle.ColorFill = Color.FromArgb(100, Rectangle.ColorBorder);
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }
    }
}