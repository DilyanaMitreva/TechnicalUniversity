using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkVisualInterface.Services;

namespace CourseWorkVisualInterface
{
    public partial class FormExport : Form
    {
        private List<Shape> _shapes;

        private ISerializeShapeService _serializeShapeService;
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
                _serializeShapeService.SerializeAsJson(_shapes);
            }
            if (checkBoxXml.Checked)
            {
                _serializeShapeService.SerializeAsXml(_shapes);
            }
            if (checkBoxTxt.Checked)
            {
                _serializeShapeService.SerializeAsTxt(_shapes);
            }
            else
            {
                MessageBox.Show(Constant.ErrorMessages.SelectTypeForExport, Constant.Captions.ErrorCaption,
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
    }
}