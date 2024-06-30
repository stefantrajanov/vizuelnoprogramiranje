using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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

        public List<int> ChosenBalls = new List<int>();

        public int parnost { get; set; }

        public int pariUplateni { get; set; }
        public bool GameOver { get; set; }

        public int multiplier { get; set; }

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
            ChosenBalls = new List<int>();
            //ballTimer.Start();
            this.DoubleBuffered = true;
            this.multiplier = 0;
            this.GameOver = false;
            this.pariUplateni = 0;
            this.parnost = -1;
        }

        private void NovaScena()
        {
            scene = new Scene();
            points = new List<Point>();
            generatedBallNumbers = new List<int>();
            AddBallPlacement();
            ChosenBalls = new List<int>();
            //ballTimer.Start();
            this.DoubleBuffered = true;
            this.multiplier = 0;
            this.GameOver = false;
            this.pariUplateni = 0;
            this.parnost = -1;
            tbUplata.Text = "";
            btnUplata.Enabled = true;
            pointIndex = 0;
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

            if (counter % 40 == 0)
            {

                scene.AddBall(new Ball(points[pointIndex], RandomColor(), GenerateRandomBallNumber()));
                Invalidate(true);
                pointIndex++;
                Dobivka();

                if (this.GameOver)
                {
                    ballTimer.Stop();
                    Invalidate(true);

                    int vkupna_dobivka = this.pariUplateni * this.multiplier;
                    if (
                    MessageBox.Show("Играта заврши. Вашата добивка е " + vkupna_dobivka, "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        NovaScena();
                    }
                    else
                    {
                        Close();
                    }
                }
                else if (pointIndex == points.Count)
                {
                    ballTimer.Stop();
                    if (
                        MessageBox.Show("Играта заврши. Вашата добивка е " + 0, "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        NovaScena();
                    }
                    else
                    {
                        Close();
                    }
                    Invalidate(true);
                }
            }
            Invalidate(true);
        }

        private void DobivkaZaParnost() {
            if (scene.balls.Count < 6)
            {
                return;
            }

            bool allEven = true;
            bool allOdd = true;

            for (int i = 0; i < 6; i++)
            {
                if (scene.balls[i].number % 2 == 0)
                {
                    allOdd = false;
                }
                else
                {
                    allEven = false;
                }
            }

            if (allEven || allOdd)
            {
                this.multiplier = 1000;
                this.GameOver = true;
            }
        }
        private void Dobivka()
        {
            if (this.parnost >= 0)
            {
                DobivkaZaParnost();
                return;
            }

            if (scene.balls.Count < 6 || ChosenBalls == null)
            {
                return;
            }

            bool allBallsMatched = true;
            int maxIndex = -1;

            foreach (int chosenBall in ChosenBalls)
            {
                bool ballMatched = false;
                for (int i = 0; i < scene.balls.Count; i++)
                {
                    if (scene.balls[i].number == chosenBall)
                    {
                        ballMatched = true;
                        if (i > maxIndex)
                        {
                            maxIndex = i;
                        }
                        break;
                    }
                }
                if (!ballMatched)
                {
                    allBallsMatched = false;
                    break;
                }
            }

            if (allBallsMatched)
            {
                int result = 0;

                switch (maxIndex + 1) // maxIndex is 0-based, so add 1 to match your case values
                {
                    case 6:
                        result = 500;
                        break;
                    case 7:
                        result = 250;
                        break;
                    case 8:
                        result = 100;
                        break;
                    case 9:
                        result = 50;
                        break;
                    case 10:
                        result = 45;
                        break;
                    case 11:
                        result = 40;
                        break;
                    case 12:
                        result = 35;
                        break;
                    case 13:
                        result = 30;
                        break;
                    case 14:
                        result = 25;
                        break;
                    case 15:
                        result = 20;
                        break;
                    case 16:
                        result = 15;
                        break;
                    case 17:
                        result = 14;
                        break;
                    case 18:
                        result = 13;
                        break;
                    case 19:
                        result = 12;
                        break;
                    case 20:
                        result = 11;
                        break;
                    case 21:
                        result = 10;
                        break;
                    case 22:
                        result = 9;
                        break;
                    case 23:
                        result = 8;
                        break;
                    case 24:
                        result = 7;
                        break;
                    case 25:
                        result = 6;
                        break;
                    case 26:
                        result = 5;
                        break;
                    case 27:
                        result = 4;
                        break;
                    case 28:
                        result = 3;
                        break;
                    case 29:
                        result = 2;
                        break;
                    case 30:
                        result = 1;
                        break;
                    default:
                        result = 0;
                        break;
                }

                this.multiplier = result;
                this.GameOver = true;
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbUplata.Text.Length > 0)
            {

                ballTimer.Start();
                btnUplata.Enabled = false;
            }
            else
            {
                MessageBox.Show("Внесете уплата");
            }
        }

        private void btnUplata_Click(object sender, EventArgs e)
        {
            Uplata uplata = new Uplata();
            if(uplata.ShowDialog()==DialogResult.OK)
            {
                tbUplata.Clear();
                tbUplata.Text = uplata.ResultText;
                this.ChosenBalls = uplata.brojcinja;
                this.pariUplateni = uplata.pari;
                this.parnost = uplata.parnost;
                uplata.Close();
            }
        }
    }
}
