﻿using System.ComponentModel;

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
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelSide = new System.Windows.Forms.Label();
            this.textBoxSide = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelShapeType = new System.Windows.Forms.Label();
            this.labelParameters = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // buttonAddShape
            // 
            this.buttonAddShape.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddShape.Location = new System.Drawing.Point(245, 340);
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
            this.checkBoxCircle.Location = new System.Drawing.Point(8, 39);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxCircle.Size = new System.Drawing.Size(56, 49);
            this.checkBoxCircle.TabIndex = 1;
            this.checkBoxCircle.Text = "Circle";
            this.checkBoxCircle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.Click += new System.EventHandler(this.checkBoxCircle_Click);
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRectangle.Location = new System.Drawing.Point(155, 39);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxRectangle.Size = new System.Drawing.Size(82, 49);
            this.checkBoxRectangle.TabIndex = 2;
            this.checkBoxRectangle.Text = "Rectangle";
            this.checkBoxRectangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            this.checkBoxRectangle.Click += new System.EventHandler(this.checkBoxRectangle_Click);
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTriangle.Location = new System.Drawing.Point(273, 39);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTriangle.Size = new System.Drawing.Size(135, 49);
            this.checkBoxTriangle.TabIndex = 3;
            this.checkBoxTriangle.Text = "EquilateralTriangle";
            this.checkBoxTriangle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            this.checkBoxTriangle.Click += new System.EventHandler(this.checkBoxTriangle_Click);
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(12, 195);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(388, 22);
            this.textBoxRadius.TabIndex = 4;
            this.textBoxRadius.Visible = false;
            // 
            // labelRadius
            // 
            this.labelRadius.Location = new System.Drawing.Point(8, 172);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(56, 20);
            this.labelRadius.TabIndex = 5;
            this.labelRadius.Text = "Radius";
            this.labelRadius.Visible = false;
            // 
            // labelSide
            // 
            this.labelSide.Location = new System.Drawing.Point(8, 172);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(56, 20);
            this.labelSide.TabIndex = 9;
            this.labelSide.Text = "Side";
            this.labelSide.Visible = false;
            // 
            // textBoxSide
            // 
            this.textBoxSide.Location = new System.Drawing.Point(12, 195);
            this.textBoxSide.Name = "textBoxSide";
            this.textBoxSide.Size = new System.Drawing.Size(387, 22);
            this.textBoxSide.TabIndex = 8;
            this.textBoxSide.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(12, 233);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(396, 20);
            this.labelHeight.TabIndex = 11;
            this.labelHeight.Text = "Height";
            this.labelHeight.Visible = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(12, 256);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(392, 22);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.Visible = false;
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(12, 172);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(56, 20);
            this.labelWidth.TabIndex = 13;
            this.labelWidth.Text = "Width";
            this.labelWidth.Visible = false;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 195);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(392, 22);
            this.textBoxWidth.TabIndex = 12;
            this.textBoxWidth.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(159, 49);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelShapeType
            // 
            this.labelShapeType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShapeType.Location = new System.Drawing.Point(8, 9);
            this.labelShapeType.Name = "labelShapeType";
            this.labelShapeType.Size = new System.Drawing.Size(163, 27);
            this.labelShapeType.TabIndex = 19;
            this.labelShapeType.Text = "Select a shape type";
            // 
            // labelParameters
            // 
            this.labelParameters.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParameters.Location = new System.Drawing.Point(12, 91);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(392, 72);
            this.labelParameters.TabIndex = 21;
            this.labelParameters.Text = "Enter the required parameters for the shape\r\n(the unit of measurement is pixels (" + "px))\r\n";
            this.labelParameters.Visible = false;
            // 
            // FormInput
            // 
            this.AcceptButton = this.buttonAddShape;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(416, 401);
            this.Controls.Add(this.labelParameters);
            this.Controls.Add(this.labelShapeType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.textBoxSide);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.checkBoxTriangle);
            this.Controls.Add(this.checkBoxRectangle);
            this.Controls.Add(this.checkBoxCircle);
            this.Controls.Add(this.buttonAddShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Shape";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxWidth;

        private System.Windows.Forms.Button buttonAddShape;

        private System.Windows.Forms.ColorDialog colorDialog;


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
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.CheckBox checkBoxCircle;

        

        #endregion
    }
}