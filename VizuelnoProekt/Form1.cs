using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizuelnoProekt
{
    public partial class Game : Form
    {
        private Scene scene;

        public List<Point> points = new List<Point>();

        public static Random random = new Random();

        public List<int> generatedBallNumbers;
        public static int counter = 0;
        public static int pointIndex = 0;
        public Game()
        {
            InitializeComponent();
            scene = new Scene();
            points = new List<Point>();
            generatedBallNumbers = new List<int>();
            AddBallPlacement();
            ballTimer.Start();
            this.DoubleBuffered = true;
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }


        //test function za da gi dodade site topki naednas
        private void AddBalls()
        {
            foreach (Point point in points)
            {
                scene.AddBall(new Ball(point, RandomColor(), GenerateRandomBallNumber()));
            }
            Invalidate(true);
        }
        private Color RandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        // function that generates random ints from 1 to 46 but not repeating
        private int GenerateRandomBallNumber()
        {
            int number = random.Next(1, 47);
            while (generatedBallNumbers.Contains(number))
            {
                number = random.Next(1, 47);
            }
            generatedBallNumbers.Add(number);
            return number;
        }

        private void AddBallPlacement()
        {

            // topkite so se levo (kolku da bidat odaleceni od levata ramka)
            int left_nineBalls = 300;

            // topkite so se desno (kolku da bidat odaleceni od desnata ramka)
            int right_nineBalls = 1300;

            // dolnite topkite (startno kolku da bidat odaleceni od levite topki)
            int bottom_column_threeBalls = 500;

            // startna pozicija za topkite od gornata ramka
            int top_balls_start_position = 180;
            int bottom_balls_start_position = 600;

            // kolku da bidat odaleceni topkite od gore na dolu
            int distance_between_balls_TopToBottom = 70;

            // kolku da bidat odaleceni topkite od levo na desno
            int distance_between_balls_LeftToRight = 200;


            for (int i = 0; i < 9; i++)
            {
                points.Add(new Point(left_nineBalls, top_balls_start_position + i * distance_between_balls_TopToBottom));
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    points.Add(new Point(bottom_column_threeBalls + i * distance_between_balls_LeftToRight, bottom_balls_start_position + j * distance_between_balls_TopToBottom));
                }
            }

            for (int i = 0; i < 9; i++)
            {
                points.Add(new Point(right_nineBalls, top_balls_start_position + i * distance_between_balls_TopToBottom));
            }


            foreach (Point point in points)
            {
                scene.AddBallPlacement(new BallPlacement(point));
            }

            Invalidate(true);
        }

        private void ballTimer_Tick(object sender, EventArgs e)
        {
            counter++;

            // does something every 4 seconds


            if (counter % 50 == 0)
            {
                scene.AddBall(new Ball(points[pointIndex], RandomColor(), GenerateRandomBallNumber()));
                pointIndex++;

                if (pointIndex == points.Count)
                {
                    ballTimer.Stop();
                    Invalidate(true);
                }
            }
            Invalidate(true);
        }
    }
}
