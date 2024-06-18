using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizuelnoProekt
{
    public class Scene
    {
        public List<BallPlacement> ballPlacement;
        public List<Ball> balls;

        public Scene()
        {
            ballPlacement = new List<BallPlacement>();
            balls = new List<Ball>();
        }

        public void AddBallPlacement(BallPlacement ballPlacement)
        {
            this.ballPlacement.Add(ballPlacement);
        }

        public void AddBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void Draw(System.Drawing.Graphics graphics)
        {
            foreach (BallPlacement ball in ballPlacement)
            {
                ball.Draw(graphics);
            }

            foreach (Ball ball in balls)
            {
                ball.Draw(graphics);
            }
        }

    }
}
