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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllTrianglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllRectanglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allShapesTotalAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allShapeTypesTotalAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEquilateralTriangleAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRectangleAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCircleAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestAreaFromAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestAreaFromTypeOfShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallestAreaFromAllShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallestAreaFromTypeOfShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallestTriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallestRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallestCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalUnusedSpaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.selectToolStripMenuItem, this.addToolStripMenuItem, this.functionsToolStripMenuItem, this.deleteToolStripMenuItem, this.exportToolStripMenuItem, this.resetToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.selectAllShapesToolStripMenuItem, this.selectAllTrianglesToolStripMenuItem, this.selectAllRectanglesToolStripMenuItem, this.selectAllCirclesToolStripMenuItem });
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectAllShapesToolStripMenuItem
            // 
            this.selectAllShapesToolStripMenuItem.Name = "selectAllShapesToolStripMenuItem";
            this.selectAllShapesToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.selectAllShapesToolStripMenuItem.Text = "Select all Shapes";
            this.selectAllShapesToolStripMenuItem.Click += new System.EventHandler(this.selectAllShapesToolStripMenuItem_Click);
            // 
            // selectAllTrianglesToolStripMenuItem
            // 
            this.selectAllTrianglesToolStripMenuItem.Name = "selectAllTrianglesToolStripMenuItem";
            this.selectAllTrianglesToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.selectAllTrianglesToolStripMenuItem.Text = "Select all Triangles";
            this.selectAllTrianglesToolStripMenuItem.Click += new System.EventHandler(this.selectAllTrianglesToolStripMenuItem_Click);
            // 
            // selectAllRectanglesToolStripMenuItem
            // 
            this.selectAllRectanglesToolStripMenuItem.Name = "selectAllRectanglesToolStripMenuItem";
            this.selectAllRectanglesToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.selectAllRectanglesToolStripMenuItem.Text = "Select all Rectangles";
            this.selectAllRectanglesToolStripMenuItem.Click += new System.EventHandler(this.selectAllRectanglesToolStripMenuItem_Click);
            // 
            // selectAllCirclesToolStripMenuItem
            // 
            this.selectAllCirclesToolStripMenuItem.Name = "selectAllCirclesToolStripMenuItem";
            this.selectAllCirclesToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.selectAllCirclesToolStripMenuItem.Text = "Select all Circles";
            this.selectAllCirclesToolStripMenuItem.Click += new System.EventHandler(this.selectAllCirclesToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.addToolStripMenuItem.Text = "Add Shape";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.allShapesTotalAreaToolStripMenuItem, this.allShapeTypesTotalAreaToolStripMenuItem, this.biggestAreaFromAllShapesToolStripMenuItem, this.biggestAreaFromTypeOfShapeToolStripMenuItem, this.smallestAreaFromAllShapesToolStripMenuItem, this.smallestAreaFromTypeOfShapeToolStripMenuItem, this.totalUnusedSpaceToolStripMenuItem });
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // allShapesTotalAreaToolStripMenuItem
            // 
            this.allShapesTotalAreaToolStripMenuItem.Name = "allShapesTotalAreaToolStripMenuItem";
            this.allShapesTotalAreaToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.allShapesTotalAreaToolStripMenuItem.Text = "All shapes total area";
            this.allShapesTotalAreaToolStripMenuItem.Click += new System.EventHandler(this.allShapesTotalAreaToolStripMenuItem_Click);
            // 
            // allShapeTypesTotalAreaToolStripMenuItem
            // 
            this.allShapeTypesTotalAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.allEquilateralTriangleAreaToolStripMenuItem, this.allRectangleAreaToolStripMenuItem, this.allCircleAreaToolStripMenuItem });
            this.allShapeTypesTotalAreaToolStripMenuItem.Name = "allShapeTypesTotalAreaToolStripMenuItem";
            this.allShapeTypesTotalAreaToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.allShapeTypesTotalAreaToolStripMenuItem.Text = "All shape types total area";
            this.allShapeTypesTotalAreaToolStripMenuItem.Click += new System.EventHandler(this.allShapeTypesTotalAreaToolStripMenuItem_Click);
            // 
            // allEquilateralTriangleAreaToolStripMenuItem
            // 
            this.allEquilateralTriangleAreaToolStripMenuItem.Name = "allEquilateralTriangleAreaToolStripMenuItem";
            this.allEquilateralTriangleAreaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.allEquilateralTriangleAreaToolStripMenuItem.Text = "Equilateral Triangle";
            this.allEquilateralTriangleAreaToolStripMenuItem.Click += new System.EventHandler(this.allEquilateralTriangleAreaToolStripMenuItem_Click);
            // 
            // allRectangleAreaToolStripMenuItem
            // 
            this.allRectangleAreaToolStripMenuItem.Name = "allRectangleAreaToolStripMenuItem";
            this.allRectangleAreaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.allRectangleAreaToolStripMenuItem.Text = "Rectangle";
            this.allRectangleAreaToolStripMenuItem.Click += new System.EventHandler(this.allRectangleAreaToolStripMenuItem_Click);
            // 
            // allCircleAreaToolStripMenuItem
            // 
            this.allCircleAreaToolStripMenuItem.Name = "allCircleAreaToolStripMenuItem";
            this.allCircleAreaToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.allCircleAreaToolStripMenuItem.Text = "Circle";
            this.allCircleAreaToolStripMenuItem.Click += new System.EventHandler(this.allCircleAreaToolStripMenuItem_Click);
            // 
            // biggestAreaFromAllShapesToolStripMenuItem
            // 
            this.biggestAreaFromAllShapesToolStripMenuItem.Name = "biggestAreaFromAllShapesToolStripMenuItem";
            this.biggestAreaFromAllShapesToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.biggestAreaFromAllShapesToolStripMenuItem.Text = "Biggest area from all shapes";
            this.biggestAreaFromAllShapesToolStripMenuItem.Click += new System.EventHandler(this.biggestAreaFromAllShapesToolStripMenuItem_Click);
            // 
            // biggestAreaFromTypeOfShapeToolStripMenuItem
            // 
            this.biggestAreaFromTypeOfShapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.biggestTriangleToolStripMenuItem, this.biggestRectangleToolStripMenuItem, this.biggestCircleToolStripMenuItem });
            this.biggestAreaFromTypeOfShapeToolStripMenuItem.Name = "biggestAreaFromTypeOfShapeToolStripMenuItem";
            this.biggestAreaFromTypeOfShapeToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.biggestAreaFromTypeOfShapeToolStripMenuItem.Text = "Biggest area from type of shape";
            this.biggestAreaFromTypeOfShapeToolStripMenuItem.Click += new System.EventHandler(this.biggestAreaFromTypeOfShapeToolStripMenuItem_Click);
            // 
            // biggestTriangleToolStripMenuItem
            // 
            this.biggestTriangleToolStripMenuItem.Name = "biggestTriangleToolStripMenuItem";
            this.biggestTriangleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.biggestTriangleToolStripMenuItem.Text = "EquilateralTriangle";
            this.biggestTriangleToolStripMenuItem.Click += new System.EventHandler(this.biggestTriangleToolStripMenuItem_Click);
            // 
            // biggestRectangleToolStripMenuItem
            // 
            this.biggestRectangleToolStripMenuItem.Name = "biggestRectangleToolStripMenuItem";
            this.biggestRectangleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.biggestRectangleToolStripMenuItem.Text = "Rectangle";
            this.biggestRectangleToolStripMenuItem.Click += new System.EventHandler(this.biggestRectangleToolStripMenuItem_Click);
            // 
            // biggestCircleToolStripMenuItem
            // 
            this.biggestCircleToolStripMenuItem.Name = "biggestCircleToolStripMenuItem";
            this.biggestCircleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.biggestCircleToolStripMenuItem.Text = "Circle";
            this.biggestCircleToolStripMenuItem.Click += new System.EventHandler(this.biggestCircleToolStripMenuItem_Click);
            // 
            // smallestAreaFromAllShapesToolStripMenuItem
            // 
            this.smallestAreaFromAllShapesToolStripMenuItem.Name = "smallestAreaFromAllShapesToolStripMenuItem";
            this.smallestAreaFromAllShapesToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.smallestAreaFromAllShapesToolStripMenuItem.Text = "Smallest area from all shapes";
            this.smallestAreaFromAllShapesToolStripMenuItem.Click += new System.EventHandler(this.smallestAreaFromAllShapesToolStripMenuItem_Click);
            // 
            // smallestAreaFromTypeOfShapeToolStripMenuItem
            // 
            this.smallestAreaFromTypeOfShapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.smallestTriangleToolStripMenuItem, this.smallestRectangleToolStripMenuItem, this.smallestCircleToolStripMenuItem });
            this.smallestAreaFromTypeOfShapeToolStripMenuItem.Name = "smallestAreaFromTypeOfShapeToolStripMenuItem";
            this.smallestAreaFromTypeOfShapeToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.smallestAreaFromTypeOfShapeToolStripMenuItem.Text = "Smallest area from type of shape";
            this.smallestAreaFromTypeOfShapeToolStripMenuItem.Click += new System.EventHandler(this.smallestAreaFromTypeOfShapeToolStripMenuItem_Click);
            // 
            // smallestTriangleToolStripMenuItem
            // 
            this.smallestTriangleToolStripMenuItem.Name = "smallestTriangleToolStripMenuItem";
            this.smallestTriangleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.smallestTriangleToolStripMenuItem.Text = "EquilateralTriangle";
            this.smallestTriangleToolStripMenuItem.Click += new System.EventHandler(this.smallestTriangleToolStripMenuItem_Click);
            // 
            // smallestRectangleToolStripMenuItem
            // 
            this.smallestRectangleToolStripMenuItem.Name = "smallestRectangleToolStripMenuItem";
            this.smallestRectangleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.smallestRectangleToolStripMenuItem.Text = "Rectangle";
            this.smallestRectangleToolStripMenuItem.Click += new System.EventHandler(this.smallestRectangleToolStripMenuItem_Click);
            // 
            // smallestCircleToolStripMenuItem
            // 
            this.smallestCircleToolStripMenuItem.Name = "smallestCircleToolStripMenuItem";
            this.smallestCircleToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.smallestCircleToolStripMenuItem.Text = "Circle";
            this.smallestCircleToolStripMenuItem.Click += new System.EventHandler(this.smallestCircleToolStripMenuItem_Click);
            // 
            // totalUnusedSpaceToolStripMenuItem
            // 
            this.totalUnusedSpaceToolStripMenuItem.Name = "totalUnusedSpaceToolStripMenuItem";
            this.totalUnusedSpaceToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.totalUnusedSpaceToolStripMenuItem.Text = "Total unused space";
            this.totalUnusedSpaceToolStripMenuItem.Click += new System.EventHandler(this.totalUnusedSpaceToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.exportToolStripMenuItem.Text = "Export Scene";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 643);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;


        private System.Windows.Forms.ToolStripMenuItem allEquilateralTriangleAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRectangleAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCircleAreaToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem allShapeTypesTotalAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggestAreaFromAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggestAreaFromTypeOfShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallestAreaFromAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallestAreaFromTypeOfShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalUnusedSpaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallestTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallestRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallestCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggestTriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggestRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biggestCircleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllShapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllRectanglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllCirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllTrianglesToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allShapesTotalAreaToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

        #endregion
    }
}