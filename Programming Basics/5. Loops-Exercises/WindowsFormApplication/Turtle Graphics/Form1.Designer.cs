namespace Turtle_Graphics
{
    partial class FormTurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonHexagonDraw = new System.Windows.Forms.Button();
            this.buttonStarDraw = new System.Windows.Forms.Button();
            this.buttonSpiralDraw = new System.Windows.Forms.Button();
            this.buttonSunDraw = new System.Windows.Forms.Button();
            this.buttonSpiralTriangleDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(13, 13);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 43);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(13, 73);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(75, 23);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // buttonHexagonDraw
            // 
            this.buttonHexagonDraw.Location = new System.Drawing.Point(13, 103);
            this.buttonHexagonDraw.Name = "buttonHexagonDraw";
            this.buttonHexagonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonHexagonDraw.TabIndex = 3;
            this.buttonHexagonDraw.Text = "Hexagon";
            this.buttonHexagonDraw.UseVisualStyleBackColor = true;
            this.buttonHexagonDraw.Click += new System.EventHandler(this.buttonHexagonDraw_Click);
            // 
            // buttonStarDraw
            // 
            this.buttonStarDraw.Location = new System.Drawing.Point(13, 133);
            this.buttonStarDraw.Name = "buttonStarDraw";
            this.buttonStarDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonStarDraw.TabIndex = 4;
            this.buttonStarDraw.Text = "Star";
            this.buttonStarDraw.UseVisualStyleBackColor = true;
            this.buttonStarDraw.Click += new System.EventHandler(this.buttonStarDraw_Click);
            // 
            // buttonSpiralDraw
            // 
            this.buttonSpiralDraw.Location = new System.Drawing.Point(13, 163);
            this.buttonSpiralDraw.Name = "buttonSpiralDraw";
            this.buttonSpiralDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonSpiralDraw.TabIndex = 5;
            this.buttonSpiralDraw.Text = "Spiral";
            this.buttonSpiralDraw.UseVisualStyleBackColor = true;
            this.buttonSpiralDraw.Click += new System.EventHandler(this.buttonSpiralDraw_Click);
            // 
            // buttonSunDraw
            // 
            this.buttonSunDraw.Location = new System.Drawing.Point(13, 193);
            this.buttonSunDraw.Name = "buttonSunDraw";
            this.buttonSunDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonSunDraw.TabIndex = 6;
            this.buttonSunDraw.Text = "Sun";
            this.buttonSunDraw.UseVisualStyleBackColor = true;
            this.buttonSunDraw.Click += new System.EventHandler(this.buttonSunDraw_Click);
            // 
            // buttonSpiralTriangleDraw
            // 
            this.buttonSpiralTriangleDraw.Location = new System.Drawing.Point(13, 223);
            this.buttonSpiralTriangleDraw.Name = "buttonSpiralTriangleDraw";
            this.buttonSpiralTriangleDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonSpiralTriangleDraw.TabIndex = 7;
            this.buttonSpiralTriangleDraw.Text = "Spiral Triangle";
            this.buttonSpiralTriangleDraw.UseVisualStyleBackColor = true;
            this.buttonSpiralTriangleDraw.Click += new System.EventHandler(this.buttonSpiralTriangleDraw_Click);
            // 
            // FormTurtleGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSpiralTriangleDraw);
            this.Controls.Add(this.buttonSunDraw);
            this.Controls.Add(this.buttonSpiralDraw);
            this.Controls.Add(this.buttonStarDraw);
            this.Controls.Add(this.buttonHexagonDraw);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "FormTurtleGraphics";
            this.Text = "TurtleGraphics-Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonHexagonDraw;
        private System.Windows.Forms.Button buttonStarDraw;
        private System.Windows.Forms.Button buttonSpiralDraw;
        private System.Windows.Forms.Button buttonSunDraw;
        private System.Windows.Forms.Button buttonSpiralTriangleDraw;
    }
}

