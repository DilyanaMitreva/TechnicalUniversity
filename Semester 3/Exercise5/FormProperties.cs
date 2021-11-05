using System;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class FormProperties : Form
    {
        public Rectangle Rectangle { get; set; }

        public FormProperties()
        {
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            textBoxHeight.Text = Rectangle.Height.ToString();
            textBoxWidth.Text = Rectangle.Widht.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Rectangle.Widht = int.Parse(textBoxWidth.Text);
            Rectangle.Height = int.Parse(textBoxHeight.Text);

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}