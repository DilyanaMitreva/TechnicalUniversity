using System.ComponentModel;

namespace CourseWorkVisualInterface
{
    partial class FormExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxTxt = new System.Windows.Forms.CheckBox();
            this.checkBoxXml = new System.Windows.Forms.CheckBox();
            this.checkBoxJson = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxTxt
            // 
            this.checkBoxTxt.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTxt.Location = new System.Drawing.Point(12, 47);
            this.checkBoxTxt.Name = "checkBoxTxt";
            this.checkBoxTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTxt.Size = new System.Drawing.Size(86, 62);
            this.checkBoxTxt.TabIndex = 2;
            this.checkBoxTxt.Text = "TXT";
            this.checkBoxTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxTxt.UseVisualStyleBackColor = true;
            this.checkBoxTxt.Click += new System.EventHandler(this.checkBoxTxt_Click);
            // 
            // checkBoxXml
            // 
            this.checkBoxXml.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXml.Location = new System.Drawing.Point(250, 47);
            this.checkBoxXml.Name = "checkBoxXml";
            this.checkBoxXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxXml.Size = new System.Drawing.Size(95, 62);
            this.checkBoxXml.TabIndex = 3;
            this.checkBoxXml.Text = "XML";
            this.checkBoxXml.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxXml.UseVisualStyleBackColor = true;
            this.checkBoxXml.Click += new System.EventHandler(this.checkBoxXml_Click);
            // 
            // checkBoxJson
            // 
            this.checkBoxJson.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxJson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJson.Location = new System.Drawing.Point(130, 47);
            this.checkBoxJson.Name = "checkBoxJson";
            this.checkBoxJson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxJson.Size = new System.Drawing.Size(105, 62);
            this.checkBoxJson.TabIndex = 4;
            this.checkBoxJson.Text = "JSON";
            this.checkBoxJson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJson.UseVisualStyleBackColor = true;
            this.checkBoxJson.Click += new System.EventHandler(this.checkBoxJson_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select the file type\r\n";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(203, 146);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 49);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "OK";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 146);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 49);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 205);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxJson);
            this.Controls.Add(this.checkBoxXml);
            this.Controls.Add(this.checkBoxTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.Button buttonSave;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBoxJson;
        private System.Windows.Forms.CheckBox checkBoxXml;
        private System.Windows.Forms.CheckBox checkBoxTxt;
        

        #endregion
    }
}