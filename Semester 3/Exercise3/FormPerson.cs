using System;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class FormPerson : Form
    {
        public Person Person { get; set; }

        public FormPerson()
        {
            InitializeComponent();
            this.Person = new Person("", "");
        }

        public FormPerson(Person person)
        {
            InitializeComponent();
            this.Person = person;

            textBoxName.Text = person.Name;
            textBoxNumber.Text = person.Num;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person = new Person(textBoxName.Text, textBoxNumber.Text);
            DialogResult = DialogResult.OK;
        }
    }
}