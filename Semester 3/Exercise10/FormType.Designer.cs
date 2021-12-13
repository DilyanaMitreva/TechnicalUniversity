using System.ComponentModel;

namespace Exercise10
{
    partial class FormType
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
            this.listBoxMethods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxMethods
            // 
            this.listBoxMethods.FormattingEnabled = true;
            this.listBoxMethods.ItemHeight = 16;
            this.listBoxMethods.Location = new System.Drawing.Point(12, 12);
            this.listBoxMethods.Name = "listBoxMethods";
            this.listBoxMethods.Size = new System.Drawing.Size(739, 436);
            this.listBoxMethods.TabIndex = 0;
            // 
            // FormType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 476);
            this.Controls.Add(this.listBoxMethods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMethods";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxMethods;

        #endregion
    }
}