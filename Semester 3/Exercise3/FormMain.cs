using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class FormMain : Form
    {
        private PhoneBook _phoneBook = new PhoneBook();

        public FormMain()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            FormPerson personForm = new FormPerson();

            if (personForm.ShowDialog() == DialogResult.OK)
            {
                _phoneBook.Add(personForm.Person);
            }

            textBoxSearch_TextChanged(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
            {
                return;
            }
            _phoneBook.Delete((Person)listBoxPeople.SelectedItem);
            textBoxSearch_TextChanged(null, null);
            
        }

        private void listBoxPeople_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
                return;

            Person person = (Person)listBoxPeople.SelectedItem;

            FormPerson personForm = new FormPerson(person);

            if (personForm.ShowDialog() == DialogResult.OK)
            {
                textBoxSearch_TextChanged(null, null);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxPeople.Items.Clear();

            foreach (var person in _phoneBook.Search(textBoxSearch.Text))
            {
                listBoxPeople.Items.Add(person);
            }
        }
    }
}