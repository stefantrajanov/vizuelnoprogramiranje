using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class BallPlacement
    {
        public Point Center { get; set; }
        public static Color Color { get; set; } = Color.White;
        public static int RADIUS { get; set; } = 30;

        public BallPlacement(Point center)
        {
            Center = center;
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 3);
            graphics.DrawEllipse(pen, Center.X - RADIUS, Center.Y - RADIUS, 2 * RADIUS, 2 * RADIUS);
            pen.Dispose();
        }


    }
}
