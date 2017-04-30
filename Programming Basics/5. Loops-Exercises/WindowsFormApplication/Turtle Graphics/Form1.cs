using System;
using Nakov.TurtleGraphics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turtle_Graphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(150);
            Turtle.PenUp();
            Turtle.Forward(50);
            Turtle.PenDown();
            Turtle.Forward(100);
            Turtle.PenUp();
            Turtle.Backward(150);
            Turtle.PenDown();
            Turtle.Rotate(-150);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonHexagonDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;

            // Draw a Hexagon
            for (int i = 0; i < 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStarDraw_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;

            // Draw a Star
            for (int i = 0; i < 5; i++)
            {
                Turtle.Rotate(144);
                Turtle.Forward(200);
            }
        }

        private void buttonSpiralDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;

            // Draw a Hexagon Spiral

            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(10 + i * 10);
                Turtle.Rotate(60);

            }
        }

        private void buttonSunDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;
            Turtle.PenSize = 0.5f * Turtle.PenSize;
            // Draw a Sun
            for (int i = 0; i < 36; i++)
            {
                Turtle.Rotate(170);
                Turtle.Forward(200);
            }
        }

        private void buttonSpiralTriangleDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 400;
            Turtle.PenSize = 0.5f * Turtle.PenSize;
            Turtle.PenColor = Color.Red;
            // Draw a Hexagon Spiral
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 22; i++)
                {
                    Turtle.Forward(10 + i * 10);
                    Turtle.Rotate(120);
                }
            }
        }
    }
}
