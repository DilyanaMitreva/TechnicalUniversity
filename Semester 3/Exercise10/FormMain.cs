using System;
using System.Reflection;
using System.Windows.Forms;

namespace Exercise10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenAssembly_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBoxTypes.Items.Clear();

                string filePath = ofd.FileName;

                Assembly assembly = Assembly.LoadFile(filePath);

                foreach (var type in assembly.GetTypes())
                {
                    listBoxTypes.Items.Add(type);
                }
            }
        }

        private void listBoxTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxTypes.SelectedItem == null)
            {
                return;
            }

            Type selectedType = (Type)listBoxTypes.SelectedItem;
            FormType ft = new FormType(selectedType);
            ft.ShowDialog();
        }
    }
}