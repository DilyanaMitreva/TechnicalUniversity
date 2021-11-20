using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWorkEntities.Services;
using CourseWorkEntities.Shapes;
using CourseWorkEntities.Utilities;
using CourseWorkEntities.Utilities.Interfaces;

namespace CourseWorkVisualInterface
{
    public partial class FormExport : Form
    {
        private readonly List<Shape> _shapes;

        private readonly IConvertShapeService _convertShapeService;

        public FormExport()
        {
            _convertShapeService = new ConvertShapeService();
            InitializeComponent();
        }

        public FormExport(List<Shape> shapes)
        {
            this._shapes = shapes;
            _convertShapeService = new ConvertShapeService();
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (checkBoxJson.Checked)
            {
                _convertShapeService.ConvertToJsonFile(_shapes);
                GetMessageBox();
            }
            else if (checkBoxXml.Checked)
            {
                _convertShapeService.ConvertToXmlFile(_shapes);
                GetMessageBox();
            }
            else if (checkBoxTxt.Checked)
            {
                _convertShapeService.ConvertToTxtFile(_shapes);
                GetMessageBox();
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

        private void GetMessageBox()
            => MessageBox.Show(Constant.InformationMessages.ExportReady,
                Constant.Captions.Export,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
    }
}