using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Exceptions;
using CourseWorkEntities.Services;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkVisualInterface
{
    public partial class FormExport : Form
    {
        private readonly List<Shape> _shapes;

        private readonly ISerializeShapeService _serializeShapeService;

        public FormExport()
        {
            _serializeShapeService = new SerializeShapeService();
            InitializeComponent();
        }

        public FormExport(List<Shape> shapes)
        {
            this._shapes = shapes;
            _serializeShapeService = new SerializeShapeService();
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxJson.Checked)
            {
                try
                {
                    _serializeShapeService.SerializeToJsonFile(_shapes);
                }
                catch (EmptyCollectionException exception)
                {
                    CreateMessageBox(exception.Message, Constant.Captions.ErrorCaption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (checkBoxXml.Checked)
            {
                try
                {
                    _serializeShapeService.SerializeToXmlFile(_shapes);
                }
                catch (EmptyCollectionException exception)
                {
                    CreateMessageBox(exception.Message, Constant.Captions.ErrorCaption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (checkBoxTxt.Checked)
            {
                try
                {
                    _serializeShapeService.SerializeToTxtFile(_shapes);
                }
                catch (EmptyCollectionException exception)
                {
                    CreateMessageBox(exception.Message, Constant.Captions.ErrorCaption, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Constant.ExceptionMessages.SelectTypeForExport, Constant.Captions.ErrorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Retry;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void checkBoxTxt_Click(object sender, EventArgs e)
        {
            checkBoxJson.Checked = false;
            checkBoxXml.Checked = false;
        }

        private void checkBoxJson_Click(object sender, EventArgs e)
        {
            checkBoxTxt.Checked = false;
            checkBoxXml.Checked = false;
        }

        private void checkBoxXml_Click(object sender, EventArgs e)
        {
            checkBoxJson.Checked = false;
            checkBoxTxt.Checked = false;
        }

        private static void CreateMessageBox(string message, string caption, MessageBoxButtons messageBoxButtons,
            MessageBoxIcon messageBoxIcon) =>
            MessageBox.Show(message, caption, messageBoxButtons, messageBoxIcon);
    }
}