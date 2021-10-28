namespace CourseWorkVisualInterface
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
            this.buttonFunctionality = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonFunctionality
            // 
            this.buttonFunctionality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFunctionality.Location = new System.Drawing.Point(12, 424);
            this.buttonFunctionality.Name = "buttonFunctionality";
            this.buttonFunctionality.Size = new System.Drawing.Size(159, 29);
            this.buttonFunctionality.TabIndex = 0;
            this.buttonFunctionality.Text = "More Functions";
            this.buttonFunctionality.UseVisualStyleBackColor = true;
            this.buttonFunctionality.Click += new System.EventHandler(this.buttonFunctionality_Click);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Location = new System.Drawing.Point(2, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(992, 418);
            this.canvas.TabIndex = 2;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 465);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.buttonFunctionality);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonFunctionality;

        private System.Windows.Forms.Panel canvas;
        

        #endregion
    }
}