using System;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String number = textBoxNumber.Text;

            Person person = new Person(name, number);

            listBoxPeople.Items.Add(person);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
            {
                return;
            }

            listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
        }

        private void listBoxPeople_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
                return;

            Person person = (Person)listBoxPeople.SelectedItem;

            MessageBox.Show($"{person.Name}'s num:{person.Num}");
        }
    }
}