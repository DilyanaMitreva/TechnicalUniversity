namespace Exercise10
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonOpenAssembly = new System.Windows.Forms.Button();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.labelTypes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenAssembly
            // 
            this.buttonOpenAssembly.Location = new System.Drawing.Point(12, 401);
            this.buttonOpenAssembly.Name = "buttonOpenAssembly";
            this.buttonOpenAssembly.Size = new System.Drawing.Size(397, 53);
            this.buttonOpenAssembly.TabIndex = 0;
            this.buttonOpenAssembly.Text = "Open";
            this.buttonOpenAssembly.UseVisualStyleBackColor = true;
            this.buttonOpenAssembly.Click += new System.EventHandler(this.buttonOpenAssembly_Click);
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.ItemHeight = 16;
            this.listBoxTypes.Location = new System.Drawing.Point(12, 39);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(397, 356);
            this.listBoxTypes.TabIndex = 1;
            this.listBoxTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTypes_MouseDoubleClick);
            // 
            // labelTypes
            // 
            this.labelTypes.Location = new System.Drawing.Point(12, 9);
            this.labelTypes.Name = "labelTypes";
            this.labelTypes.Size = new System.Drawing.Size(397, 27);
            this.labelTypes.TabIndex = 2;
            this.labelTypes.Text = "Types in Assembly";
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonOpenAssembly;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 484);
            this.Controls.Add(this.labelTypes);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.buttonOpenAssembly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly Viewer";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelTypes;

        private System.Windows.Forms.Button buttonOpenAssembly;
        private System.Windows.Forms.ListBox listBoxTypes;

        #endregion
    }
}