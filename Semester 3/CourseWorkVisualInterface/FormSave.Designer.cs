using System.ComponentModel;

namespace CourseWorkVisualInterface
{
    partial class FormSave
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
            this.checkBoxTxtFile = new System.Windows.Forms.CheckBox();
            this.checkBoxXml = new System.Windows.Forms.CheckBox();
            this.checkBoxJson = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxTxtFile
            // 
            this.checkBoxTxtFile.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTxtFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTxtFile.Location = new System.Drawing.Point(10, 47);
            this.checkBoxTxtFile.Name = "checkBoxTxtFile";
            this.checkBoxTxtFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTxtFile.Size = new System.Drawing.Size(86, 62);
            this.checkBoxTxtFile.TabIndex = 2;
            this.checkBoxTxtFile.Text = "TXT";
            this.checkBoxTxtFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxTxtFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxXml
            // 
            this.checkBoxXml.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxXml.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXml.Location = new System.Drawing.Point(213, 47);
            this.checkBoxXml.Name = "checkBoxXml";
            this.checkBoxXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxXml.Size = new System.Drawing.Size(95, 62);
            this.checkBoxXml.TabIndex = 3;
            this.checkBoxXml.Text = "XML";
            this.checkBoxXml.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxJson
            // 
            this.checkBoxJson.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxJson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJson.Location = new System.Drawing.Point(102, 47);
            this.checkBoxJson.Name = "checkBoxJson";
            this.checkBoxJson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxJson.Size = new System.Drawing.Size(105, 62);
            this.checkBoxJson.TabIndex = 4;
            this.checkBoxJson.Text = "JSON";
            this.checkBoxJson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxJson.UseVisualStyleBackColor = true;
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
            // FormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxJson);
            this.Controls.Add(this.checkBoxXml);
            this.Controls.Add(this.checkBoxTxtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBoxJson;
        private System.Windows.Forms.CheckBox checkBoxXml;
        private System.Windows.Forms.CheckBox checkBoxTxtFile;
        

        #endregion
    }
}