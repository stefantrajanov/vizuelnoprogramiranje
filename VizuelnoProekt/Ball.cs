using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class Ball
    {
        public Point Center { get; set; }
        public Color Color { get; set; }
        public static int RADIUS { get; set; } = 30;

        public int number { get; set; }

        public Ball(Point center, Color color, int number)
        {
            Center = center;
            Color = color;
            this.number = number;
        }

        public void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color);
            graphics.FillEllipse(brush, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);

            brush = new SolidBrush(Color.White);

            // draw another extra ball inside the ball and it should have 2/3 of the size of the ball

            graphics.FillEllipse(brush, Center.X - RADIUS / 2, Center.Y - RADIUS / 2, RADIUS, RADIUS);

            brush = new SolidBrush(Color.Black);

            // write a number inside the ball and it should be exactly in the center of the ball
            Font font = new Font("Arial", 16);
            if (number >= 10)
            {
                graphics.DrawString($"{number}", font, brush, Center.X - 15, Center.Y - 10);
            }
            else
            {
                graphics.DrawString($"{number}", font, brush, Center.X - 10, Center.Y - 10);
            }
            brush.Dispose();
        }
    }
}
