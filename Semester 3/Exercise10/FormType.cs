using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Exercise10
{
    public partial class FormType : Form
    {
        public FormType()
        {
            InitializeComponent();
        }

        public FormType(Type type)
        {
            InitializeComponent();
            listBoxMethods.Items.Clear();

            foreach (MethodInfo method in type.GetMethods())
            {
                string paramethers = method.GetParameters()
                    .Select(p => p.ParameterType.Name + " " + p.Name)
                    .DefaultIfEmpty()
                    .Aggregate((f, s) => $"{f}, {s}");

                listBoxMethods.Items.Add($"{method.Name} ({paramethers})");
            }
        }
    }
}