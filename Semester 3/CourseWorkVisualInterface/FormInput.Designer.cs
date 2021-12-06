using System.ComponentModel;

namespace CourseWorkVisualInterface
{
    partial class FormInput
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
            this.buttonAddShape = new System.Windows.Forms.Button();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxEquilateralTriangle = new System.Windows.Forms.CheckBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelShapeType = new System.Windows.Forms.Label();
            this.labelParameters = new System.Windows.Forms.Label();
            this.buttonBorderColor = new System.Windows.Forms.Button();
            this.buttonFillColor = new System.Windows.Forms.Button();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.labelXCoordinate = new System.Windows.Forms.Label();
            this.labelYCoordinate = new System.Windows.Forms.Label();
            this.textBoxXCoordinate = new System.Windows.Forms.TextBox();
            this.textBoxYCoordinate = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxSide = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddShape.Location = new System.Drawing.Point(318, 568);
            this.buttonAddShape.Name = "buttonAddShape";
            this.buttonAddShape.Size = new System.Drawing.Size(159, 49);
            this.buttonAddShape.TabIndex = 0;
            this.buttonAddShape.Text = "Add Shape";
            this.buttonAddShape.UseVisualStyleBackColor = true;
            this.buttonAddShape.Click += new System.EventHandler(this.addShape_Click);
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCircle.Location = new System.Drawing.Point(9, 58);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCircle.Size = new System.Drawing.Size(108, 68);
            this.checkBoxCircle.TabIndex = 1;
            this.checkBoxCircle.Text = "Circle";
            this.checkBoxCircle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.Click += new System.EventHandler(this.checkBoxCircle_Click);
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRectangle.Location = new System.Drawing.Point(187, 58);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRectangle.Size = new System.Drawing.Size(100, 68);
            this.checkBoxRectangle.TabIndex = 2;
            this.checkBoxRectangle.Text = "Rectangle";
            this.checkBoxRectangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            this.checkBoxRectangle.Click += new System.EventHandler(this.checkBoxRectangle_Click);
            // 
            // checkBoxEquilateralTriangle
            // 
            this.checkBoxEquilateralTriangle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxEquilateralTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEquilateralTriangle.Location = new System.Drawing.Point(334, 58);
            this.checkBoxEquilateralTriangle.Name = "checkBoxEquilateralTriangle";
            this.checkBoxEquilateralTriangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEquilateralTriangle.Size = new System.Drawing.Size(144, 68);
            this.checkBoxEquilateralTriangle.TabIndex = 3;
            this.checkBoxEquilateralTriangle.Text = "EquilateralTriangle";
            this.checkBoxEquilateralTriangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxEquilateralTriangle.UseVisualStyleBackColor = true;
            this.checkBoxEquilateralTriangle.Click += new System.EventHandler(this.checkBoxTriangle_Click);
            // 
            // labelRadius
            // 
            this.labelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRadius.Location = new System.Drawing.Point(8, 197);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(133, 20);
            this.labelRadius.TabIndex = 5;
            this.labelRadius.Text = "Radius";
            this.labelRadius.Visible = false;
            // 
            // labelSide
            // 
            this.labelSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide.Location = new System.Drawing.Point(10, 197);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(133, 20);
            this.labelSide.TabIndex = 9;
            this.labelSide.Text = "Side";
            this.labelSide.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(8, 258);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(469, 20);
            this.labelHeight.TabIndex = 11;
            this.labelHeight.Text = "Height";
            this.labelHeight.Visible = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(9, 281);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(469, 22);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.Visible = false;
            // 
            // labelWidth
            // 
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(8, 197);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(133, 20);
            this.labelWidth.TabIndex = 13;
            this.labelWidth.Text = "Width";
            this.labelWidth.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(8, 568);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(159, 49);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelShapeType
            // 
            this.labelShapeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShapeType.Location = new System.Drawing.Point(8, 28);
            this.labelShapeType.Name = "labelShapeType";
            this.labelShapeType.Size = new System.Drawing.Size(216, 27);
            this.labelShapeType.TabIndex = 19;
            this.labelShapeType.Text = "Select a shape type";
            // 
            // labelParameters
            // 
            this.labelParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParameters.Location = new System.Drawing.Point(13, 129);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(465, 60);
            this.labelParameters.TabIndex = 21;
            this.labelParameters.Text = "Enter the required parameters for the shape\r\n(the unit of measurement is pixels (" + "px))\r\n";
            this.labelParameters.Visible = false;
            // 
            // buttonBorderColor
            // 
            this.buttonBorderColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBorderColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonBorderColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorderColor.Location = new System.Drawing.Point(9, 318);
            this.buttonBorderColor.Name = "buttonBorderColor";
            this.buttonBorderColor.Size = new System.Drawing.Size(159, 49);
            this.buttonBorderColor.TabIndex = 23;
            this.buttonBorderColor.Text = "Border Color";
            this.buttonBorderColor.UseVisualStyleBackColor = false;
            this.buttonBorderColor.Visible = false;
            this.buttonBorderColor.Click += new System.EventHandler(this.buttonBorderColor_Click);
            // 
            // buttonFillColor
            // 
            this.buttonFillColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFillColor.BackColor = System.Drawing.Color.Transparent;
            this.buttonFillColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFillColor.Location = new System.Drawing.Point(320, 318);
            this.buttonFillColor.Name = "buttonFillColor";
            this.buttonFillColor.Size = new System.Drawing.Size(159, 49);
            this.buttonFillColor.TabIndex = 22;
            this.buttonFillColor.Text = "Fill Color";
            this.buttonFillColor.UseVisualStyleBackColor = false;
            this.buttonFillColor.Visible = false;
            this.buttonFillColor.Click += new System.EventHandler(this.buttonFillColor_Click);
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordinates.Location = new System.Drawing.Point(9, 385);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(465, 47);
            this.labelCoordinates.TabIndex = 24;
            this.labelCoordinates.Text = "Enter the coordinates\r\n\r\n";
            this.labelCoordinates.Visible = false;
            // 
            // labelXCoordinate
            // 
            this.labelXCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXCoordinate.Location = new System.Drawing.Point(13, 426);
            this.labelXCoordinate.Name = "labelXCoordinate";
            this.labelXCoordinate.Size = new System.Drawing.Size(35, 37);
            this.labelXCoordinate.TabIndex = 25;
            this.labelXCoordinate.Text = "X";
            this.labelXCoordinate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelXCoordinate.Visible = false;
            // 
            // labelYCoordinate
            // 
            this.labelYCoordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYCoordinate.Location = new System.Drawing.Point(320, 426);
            this.labelYCoordinate.Name = "labelYCoordinate";
            this.labelYCoordinate.Size = new System.Drawing.Size(60, 37);
            this.labelYCoordinate.TabIndex = 26;
            this.labelYCoordinate.Text = "Y";
            this.labelYCoordinate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYCoordinate.Visible = false;
            // 
            // textBoxXCoordinate
            // 
            this.textBoxXCoordinate.Location = new System.Drawing.Point(13, 466);
            this.textBoxXCoordinate.Name = "textBoxXCoordinate";
            this.textBoxXCoordinate.Size = new System.Drawing.Size(159, 22);
            this.textBoxXCoordinate.TabIndex = 27;
            this.textBoxXCoordinate.Visible = false;
            // 
            // textBoxYCoordinate
            // 
            this.textBoxYCoordinate.Location = new System.Drawing.Point(319, 466);
            this.textBoxYCoordinate.Name = "textBoxYCoordinate";
            this.textBoxYCoordinate.Size = new System.Drawing.Size(159, 22);
            this.textBoxYCoordinate.TabIndex = 28;
            this.textBoxYCoordinate.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.resetToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(8, 220);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(469, 22);
            this.textBoxRadius.TabIndex = 30;
            this.textBoxRadius.Visible = false;
            // 
            // textBoxSide
            // 
            this.textBoxSide.Location = new System.Drawing.Point(8, 220);
            this.textBoxSide.Name = "textBoxSide";
            this.textBoxSide.Size = new System.Drawing.Size(469, 22);
            this.textBoxSide.TabIndex = 31;
            this.textBoxSide.Visible = false;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(8, 220);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(469, 22);
            this.textBoxWidth.TabIndex = 32;
            this.textBoxWidth.Visible = false;
            // 
            // FormInput
            // 
            this.AcceptButton = this.buttonAddShape;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(489, 629);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxSide);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxYCoordinate);
            this.Controls.Add(this.textBoxXCoordinate);
            this.Controls.Add(this.labelYCoordinate);
            this.Controls.Add(this.labelXCoordinate);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.buttonBorderColor);
            this.Controls.Add(this.buttonFillColor);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.labelShapeType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.checkBoxEquilateralTriangle);
            this.Controls.Add(this.checkBoxRectangle);
            this.Controls.Add(this.checkBoxCircle);
            this.Controls.Add(this.buttonAddShape);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape information";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;

        private System.Windows.Forms.TextBox textBoxYCoordinate;
        private System.Windows.Forms.TextBox textBoxXCoordinate;

        private System.Windows.Forms.Label labelYCoordinate;

        private System.Windows.Forms.Label labelCoordinates;

        private System.Windows.Forms.Label labelXCoordinate;

        private System.Windows.Forms.Button buttonFillColor;

        private System.Windows.Forms.Button buttonBorderColor;

        private System.Windows.Forms.TextBox textBoxWidth;

        private System.Windows.Forms.Button buttonAddShape;
        
        private System.Windows.Forms.Label labelParameters;

        private System.Windows.Forms.Label labelShapeType;

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelWidth;

        private System.Windows.Forms.TextBox textBoxSide;
        
        private System.Windows.Forms.Label labelHeight;


        private System.Windows.Forms.Label labelSide;
   

        private System.Windows.Forms.Label labelRadius;

        private System.Windows.Forms.TextBox textBoxRadius;
        

        private System.Windows.Forms.CheckBox checkBoxRectangle;
        private System.Windows.Forms.CheckBox checkBoxEquilateralTriangle;
        private System.Windows.Forms.CheckBox checkBoxCircle;

        

        #endregion
    }
}