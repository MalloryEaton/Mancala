using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Mancala
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        Storyboard storyboard = new Storyboard();
        Storyboard storyboard1 = new Storyboard();
        DoubleAnimation animation = new DoubleAnimation();
        DoubleAnimation animation2 = new DoubleAnimation();
        bool isPlayer1Turn = true;
        bool preventClick = false;
        bool gameOverAnimationHasOccurred = true;

        #region Marbles
        Marble marble1 = new Marble(1);
        Marble marble2 = new Marble(2);
        Marble marble3 = new Marble(3);
        Marble marble4 = new Marble(4);
        Marble marble5 = new Marble(5);
        Marble marble6 = new Marble(6);
        Marble marble7 = new Marble(7);
        Marble marble8 = new Marble(8);
        Marble marble9 = new Marble(9);
        Marble marble10 = new Marble(10);
        Marble marble11 = new Marble(11);
        Marble marble12 = new Marble(12);
        Marble marble13 = new Marble(13);
        Marble marble14 = new Marble(14);
        Marble marble15 = new Marble(15);
        Marble marble16 = new Marble(16);
        Marble marble17 = new Marble(17);
        Marble marble18 = new Marble(18);
        Marble marble19 = new Marble(19);
        Marble marble20 = new Marble(20);
        Marble marble21 = new Marble(21);
        Marble marble22 = new Marble(22);
        Marble marble23 = new Marble(23);
        Marble marble24 = new Marble(24);
        Marble marble25 = new Marble(25);
        Marble marble26 = new Marble(26);
        Marble marble27 = new Marble(27);
        Marble marble28 = new Marble(28);
        Marble marble29 = new Marble(29);
        Marble marble30 = new Marble(30);
        Marble marble31 = new Marble(31);
        Marble marble32 = new Marble(32);
        Marble marble33 = new Marble(33);
        Marble marble34 = new Marble(34);
        Marble marble35 = new Marble(35);
        Marble marble36 = new Marble(36);
        Marble marble37 = new Marble(37);
        Marble marble38 = new Marble(38);
        Marble marble39 = new Marble(39);
        Marble marble40 = new Marble(40);
        Marble marble41 = new Marble(41);
        Marble marble42 = new Marble(42);
        Marble marble43 = new Marble(43);
        Marble marble44 = new Marble(44);
        Marble marble45 = new Marble(45);
        Marble marble46 = new Marble(46);
        Marble marble47 = new Marble(47);
        Marble marble48 = new Marble(48);

        List<Marble> marbles = new List<Marble>();
        #endregion

        #region Cups
        // cup 6 and 13 are mancala 1 and 2 respectively
        Cup cup0 = new Cup();
        Cup cup1 = new Cup();
        Cup cup2 = new Cup();
        Cup cup3 = new Cup();
        Cup cup4 = new Cup();
        Cup cup5 = new Cup();
        Cup cup7 = new Cup();
        Cup cup8 = new Cup();
        Cup cup9 = new Cup();
        Cup cup10 = new Cup();
        Cup cup11 = new Cup();
        Cup cup12 = new Cup();

        List<Cup> cups = new List<Cup>();
        #endregion

        #region Mancala
        // cup 6 and 13 are mancala 1 and 2 respectively
        private Mancala mancala1 = new Mancala();
        private Mancala mancala2 = new Mancala();
        #endregion

        public GamePage()
        {
            this.InitializeComponent();
            this.Loaded += (sender, e) =>
            {
                //have something for loading saved state
                InitializeBoard();
            };
        }

        #region Functions for Board Initialization
        private void InitializeBoard()
        {
            InitializeCups();
            InitializeMancala();
            InitializeMarble();

            PlaceMarblesOnBoard();
            PlaceMarblesInCup();
        }

        private void InitializeCups()
        {
            // add cups to list to enumerate through later.
            cups.Add(cup0);
            cups.Add(cup1);
            cups.Add(cup2);
            cups.Add(cup3);
            cups.Add(cup4);
            cups.Add(cup5);
            cups.Add(mancala1);
            cups.Add(cup7);
            cups.Add(cup8);
            cups.Add(cup9);
            cups.Add(cup10);
            cups.Add(cup11);
            cups.Add(cup12);
            cups.Add(mancala2);


            // initilize cupNumber
            cup0.cupNumber = 0;
            cup1.cupNumber = 1;
            cup2.cupNumber = 2;
            cup3.cupNumber = 3;
            cup4.cupNumber = 4;
            cup5.cupNumber = 5;
            cup7.cupNumber = 7;
            cup8.cupNumber = 8;
            cup9.cupNumber = 9;
            cup10.cupNumber = 10;
            cup11.cupNumber = 11;
            cup12.cupNumber = 12;

            // initialize X Coordinates of Cups
            cup0.coordinates[16].X = Canvas.GetLeft(Cup0);
            cup1.coordinates[16].X = Canvas.GetLeft(Cup1);
            cup2.coordinates[16].X = Canvas.GetLeft(Cup2);
            cup3.coordinates[16].X = Canvas.GetLeft(Cup3);
            cup4.coordinates[16].X = Canvas.GetLeft(Cup4);
            cup5.coordinates[16].X = Canvas.GetLeft(Cup5);
            cup7.coordinates[16].X = Canvas.GetLeft(Cup7);
            cup8.coordinates[16].X = Canvas.GetLeft(Cup8);
            cup9.coordinates[16].X = Canvas.GetLeft(Cup9);
            cup10.coordinates[16].X = Canvas.GetLeft(Cup10);
            cup11.coordinates[16].X = Canvas.GetLeft(Cup11);
            cup12.coordinates[16].X = Canvas.GetLeft(Cup12);

            // initialize Y Coordinates of Cups
            cup0.coordinates[16].Y = Canvas.GetTop(Cup0);
            cup1.coordinates[16].Y = Canvas.GetTop(Cup1);
            cup2.coordinates[16].Y = Canvas.GetTop(Cup2);
            cup3.coordinates[16].Y = Canvas.GetTop(Cup3);
            cup4.coordinates[16].Y = Canvas.GetTop(Cup4);
            cup5.coordinates[16].Y = Canvas.GetTop(Cup5);
            cup7.coordinates[16].Y = Canvas.GetTop(Cup7);
            cup8.coordinates[16].Y = Canvas.GetTop(Cup8);
            cup9.coordinates[16].Y = Canvas.GetTop(Cup9);
            cup10.coordinates[16].Y = Canvas.GetTop(Cup10);
            cup11.coordinates[16].Y = Canvas.GetTop(Cup11);
            cup12.coordinates[16].Y = Canvas.GetTop(Cup12);
            

            // initialize the rest of the Coordinates of Cups
            PopulateCupCoordinateGrid(cup0.coordinates);
            PopulateCupCoordinateGrid(cup1.coordinates);
            PopulateCupCoordinateGrid(cup2.coordinates);
            PopulateCupCoordinateGrid(cup3.coordinates);
            PopulateCupCoordinateGrid(cup4.coordinates);
            PopulateCupCoordinateGrid(cup5.coordinates);
            PopulateCupCoordinateGrid(cup7.coordinates);
            PopulateCupCoordinateGrid(cup8.coordinates);
            PopulateCupCoordinateGrid(cup9.coordinates);
            PopulateCupCoordinateGrid(cup10.coordinates);
            PopulateCupCoordinateGrid(cup11.coordinates);
            PopulateCupCoordinateGrid(cup12.coordinates);

        }

        private void PopulateCupCoordinateGrid(Coordinate[] coordinates)
        {
            coordinates[19].X = coordinates[16].X + 60;
            coordinates[19].Y = coordinates[16].Y;

            double currentLeft = coordinates[19].X;
            double currentTop = coordinates[19].Y;
            // 5 rows, 4 columns, 20 possible items
            for (int i = 19; i >= 0; i--)
            {
                coordinates[i].X = currentLeft;
                coordinates[i].Y = currentTop;
                // move to the next column
                currentLeft -= 20;
                // move to the next row
                if (i % 4 == 0)
                {
                    currentTop += 19;
                    currentLeft = coordinates[19].X;
                }
            }
        }

        private void InitializeMancala()
        {
            mancala1.cupNumber = 6;
            mancala1.mancalaCoordinates[44].X = Canvas.GetLeft(Cup6);
            mancala1.mancalaCoordinates[44].Y = Canvas.GetTop(Cup6);
            PopulateMancalaCoordinateGrid(mancala1.mancalaCoordinates);
            mancala1.marbleCount = 0;

            mancala2.cupNumber = 13;
            mancala2.mancalaCoordinates[44].X = Canvas.GetLeft(Cup13);
            mancala2.mancalaCoordinates[44].Y = Canvas.GetTop(Cup13);
            PopulateMancalaCoordinateGrid(mancala2.mancalaCoordinates);
            mancala2.marbleCount = 0;
        }

        private void PopulateMancalaCoordinateGrid(Coordinate[] coordinates)
        {
            coordinates[47].X = coordinates[44].X + 60;
            coordinates[47].Y = coordinates[44].Y;

            double currentLeft = coordinates[47].X;
            double currentTop = coordinates[47].Y;
            // 12 rows, 4 columns, 48 possible items
            for (int i = 47; i >= 0; i--)
            {
                coordinates[i].X = currentLeft;
                coordinates[i].Y = currentTop;
                // move to the next column
                currentLeft -= 20;
                // move to the next row
                if (i % 4 == 0)
                {
                    currentTop += 19;
                    currentLeft = coordinates[47].X;
                }
            }
        }

        private void InitializeMarble()
        {
            // add marbles to marble list
            marbles.Add(marble1);
            marbles.Add(marble2);
            marbles.Add(marble3);
            marbles.Add(marble4);
            marbles.Add(marble5);
            marbles.Add(marble6);
            marbles.Add(marble7);
            marbles.Add(marble8);
            marbles.Add(marble9);
            marbles.Add(marble10);
            marbles.Add(marble11);
            marbles.Add(marble12);
            marbles.Add(marble13);
            marbles.Add(marble14);
            marbles.Add(marble15);
            marbles.Add(marble16);
            marbles.Add(marble17);
            marbles.Add(marble18);
            marbles.Add(marble19);
            marbles.Add(marble20);
            marbles.Add(marble21);
            marbles.Add(marble22);
            marbles.Add(marble23);
            marbles.Add(marble24);
            marbles.Add(marble25);
            marbles.Add(marble26);
            marbles.Add(marble27);
            marbles.Add(marble28);
            marbles.Add(marble29);
            marbles.Add(marble30);
            marbles.Add(marble31);
            marbles.Add(marble32);
            marbles.Add(marble33);
            marbles.Add(marble34);
            marbles.Add(marble35);
            marbles.Add(marble36);
            marbles.Add(marble37);
            marbles.Add(marble38);
            marbles.Add(marble39);
            marbles.Add(marble40);
            marbles.Add(marble41);
            marbles.Add(marble42);
            marbles.Add(marble43);
            marbles.Add(marble44);
            marbles.Add(marble45);
            marbles.Add(marble46);
            marbles.Add(marble47);
            marbles.Add(marble48);

            // add marbles to the canvas
            for (int i = 0; i < 48; i++)
            {
                mainCanvas.Children.Add(marbles[i].ellipse);
            }
        }

        private void PlaceMarblesOnBoard()
        {
            int marbleToPlace = 0;
            for (int i = 0; i < 14; i++)
            {
                if (i != 6 && i != 13)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Canvas.SetTop(marbles[marbleToPlace].ellipse, cups[i].coordinates[j].Y);
                        Canvas.SetLeft(marbles[marbleToPlace].ellipse, cups[i].coordinates[j].X);
                        marbleToPlace++;
                    }
                }
            }
        }
        
        private void PlaceMarblesInCup()
        {
            int marbleToPlace = 0;
            for (int i = 0; i < 14; i++)
            {
                if (i != 6 && i != 13)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        cups[i].marbleCount++;
                        cups[i].marbles.Push(marbles[marbleToPlace]);
                        marbleToPlace++;
                    }
                }

            }
        }

        #endregion

        private void SetStoryboardAnimation1(int marbleNumber, double toCoordinate, double fromCoordinate)
        {
            animation.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation.Duration = new TimeSpan(0, 0, 0, 0, 150);
            switch (marbleNumber)
            {
                case 1:
                    Storyboard.SetTarget(animation, marble1.ellipse);
                    break;
                case 2:
                    Storyboard.SetTarget(animation, marble2.ellipse);
                    break;
                case 3:
                    Storyboard.SetTarget(animation, marble3.ellipse);
                    break;
                case 4:
                    Storyboard.SetTarget(animation, marble4.ellipse);
                    break;
                case 5:
                    Storyboard.SetTarget(animation, marble5.ellipse);
                    break;
                case 6:
                    Storyboard.SetTarget(animation, marble6.ellipse);
                    break;
                case 7:
                    Storyboard.SetTarget(animation, marble7.ellipse);
                    break;
                case 8:
                    Storyboard.SetTarget(animation, marble8.ellipse);
                    break;
                case 9:
                    Storyboard.SetTarget(animation, marble9.ellipse);
                    break;
                case 10:
                    Storyboard.SetTarget(animation, marble10.ellipse);
                    break;
                case 11:
                    Storyboard.SetTarget(animation, marble11.ellipse);
                    break;
                case 12:
                    Storyboard.SetTarget(animation, marble12.ellipse);
                    break;
                case 13:
                    Storyboard.SetTarget(animation, marble13.ellipse);
                    break;
                case 14:
                    Storyboard.SetTarget(animation, marble14.ellipse);
                    break;
                case 15:
                    Storyboard.SetTarget(animation, marble15.ellipse);
                    break;
                case 16:
                    Storyboard.SetTarget(animation, marble16.ellipse);
                    break;
                case 17:
                    Storyboard.SetTarget(animation, marble17.ellipse);
                    break;
                case 18:
                    Storyboard.SetTarget(animation, marble18.ellipse);
                    break;
                case 19:
                    Storyboard.SetTarget(animation, marble19.ellipse);
                    break;
                case 20:
                    Storyboard.SetTarget(animation, marble20.ellipse);
                    break;
                case 21:
                    Storyboard.SetTarget(animation, marble21.ellipse);
                    break;
                case 22:
                    Storyboard.SetTarget(animation, marble22.ellipse);
                    break;
                case 23:
                    Storyboard.SetTarget(animation, marble23.ellipse);
                    break;
                case 24:
                    Storyboard.SetTarget(animation, marble24.ellipse);
                    break;
                case 25:
                    Storyboard.SetTarget(animation, marble25.ellipse);
                    break;
                case 26:
                    Storyboard.SetTarget(animation, marble26.ellipse);
                    break;
                case 27:
                    Storyboard.SetTarget(animation, marble27.ellipse);
                    break;
                case 28:
                    Storyboard.SetTarget(animation, marble28.ellipse);
                    break;
                case 29:
                    Storyboard.SetTarget(animation, marble29.ellipse);
                    break;
                case 30:
                    Storyboard.SetTarget(animation, marble30.ellipse);
                    break;
                case 31:
                    Storyboard.SetTarget(animation, marble31.ellipse);
                    break;
                case 32:
                    Storyboard.SetTarget(animation, marble32.ellipse);
                    break;
                case 33:
                    Storyboard.SetTarget(animation, marble33.ellipse);
                    break;
                case 34:
                    Storyboard.SetTarget(animation, marble34.ellipse);
                    break;
                case 35:
                    Storyboard.SetTarget(animation, marble35.ellipse);
                    break;
                case 36:
                    Storyboard.SetTarget(animation, marble36.ellipse);
                    break;
                case 37:
                    Storyboard.SetTarget(animation, marble37.ellipse);
                    break;
                case 38:
                    Storyboard.SetTarget(animation, marble38.ellipse);
                    break;
                case 39:
                    Storyboard.SetTarget(animation, marble39.ellipse);
                    break;
                case 40:
                    Storyboard.SetTarget(animation, marble40.ellipse);
                    break;
                case 41:
                    Storyboard.SetTarget(animation, marble41.ellipse);
                    break;
                case 42:
                    Storyboard.SetTarget(animation, marble42.ellipse);
                    break;
                case 43:
                    Storyboard.SetTarget(animation, marble43.ellipse);
                    break;
                case 44:
                    Storyboard.SetTarget(animation, marble44.ellipse);
                    break;
                case 45:
                    Storyboard.SetTarget(animation, marble45.ellipse);
                    break;
                case 46:
                    Storyboard.SetTarget(animation, marble46.ellipse);
                    break;
                case 47:
                    Storyboard.SetTarget(animation, marble47.ellipse);
                    break;
                case 48:
                    Storyboard.SetTarget(animation, marble48.ellipse);
                    break;
            }
            Storyboard.SetTargetProperty(animation, "(Canvas.Left)");
            animation.To = toCoordinate;
            animation.From = fromCoordinate;
            animation.FillBehavior = FillBehavior.HoldEnd;
        }

        private void SetStoryboardAnimation2(int marbleNumber, double toCoordinate, double fromCoordinate)
        {
            animation2.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation2.Duration = new TimeSpan(0, 0, 0, 0, 150);
            switch (marbleNumber)
            {
                case 1:
                    Storyboard.SetTarget(animation2, marble1.ellipse);
                    break;
                case 2:
                    Storyboard.SetTarget(animation2, marble2.ellipse);
                    break;
                case 3:
                    Storyboard.SetTarget(animation2, marble3.ellipse);
                    break;
                case 4:
                    Storyboard.SetTarget(animation2, marble4.ellipse);
                    break;
                case 5:
                    Storyboard.SetTarget(animation2, marble5.ellipse);
                    break;
                case 6:
                    Storyboard.SetTarget(animation2, marble6.ellipse);
                    break;
                case 7:
                    Storyboard.SetTarget(animation2, marble7.ellipse);
                    break;
                case 8:
                    Storyboard.SetTarget(animation2, marble8.ellipse);
                    break;
                case 9:
                    Storyboard.SetTarget(animation2, marble9.ellipse);
                    break;
                case 10:
                    Storyboard.SetTarget(animation2, marble10.ellipse);
                    break;
                case 11:
                    Storyboard.SetTarget(animation2, marble11.ellipse);
                    break;
                case 12:
                    Storyboard.SetTarget(animation2, marble12.ellipse);
                    break;
                case 13:
                    Storyboard.SetTarget(animation2, marble13.ellipse);
                    break;
                case 14:
                    Storyboard.SetTarget(animation2, marble14.ellipse);
                    break;
                case 15:
                    Storyboard.SetTarget(animation2, marble15.ellipse);
                    break;
                case 16:
                    Storyboard.SetTarget(animation2, marble16.ellipse);
                    break;
                case 17:
                    Storyboard.SetTarget(animation2, marble17.ellipse);
                    break;
                case 18:
                    Storyboard.SetTarget(animation2, marble18.ellipse);
                    break;
                case 19:
                    Storyboard.SetTarget(animation2, marble19.ellipse);
                    break;
                case 20:
                    Storyboard.SetTarget(animation2, marble20.ellipse);
                    break;
                case 21:
                    Storyboard.SetTarget(animation2, marble21.ellipse);
                    break;
                case 22:
                    Storyboard.SetTarget(animation2, marble22.ellipse);
                    break;
                case 23:
                    Storyboard.SetTarget(animation2, marble23.ellipse);
                    break;
                case 24:
                    Storyboard.SetTarget(animation2, marble24.ellipse);
                    break;
                case 25:
                    Storyboard.SetTarget(animation2, marble25.ellipse);
                    break;
                case 26:
                    Storyboard.SetTarget(animation2, marble26.ellipse);
                    break;
                case 27:
                    Storyboard.SetTarget(animation2, marble27.ellipse);
                    break;
                case 28:
                    Storyboard.SetTarget(animation2, marble28.ellipse);
                    break;
                case 29:
                    Storyboard.SetTarget(animation2, marble29.ellipse);
                    break;
                case 30:
                    Storyboard.SetTarget(animation2, marble30.ellipse);
                    break;
                case 31:
                    Storyboard.SetTarget(animation2, marble31.ellipse);
                    break;
                case 32:
                    Storyboard.SetTarget(animation2, marble32.ellipse);
                    break;
                case 33:
                    Storyboard.SetTarget(animation2, marble33.ellipse);
                    break;
                case 34:
                    Storyboard.SetTarget(animation2, marble34.ellipse);
                    break;
                case 35:
                    Storyboard.SetTarget(animation2, marble35.ellipse);
                    break;
                case 36:
                    Storyboard.SetTarget(animation2, marble36.ellipse);
                    break;
                case 37:
                    Storyboard.SetTarget(animation2, marble37.ellipse);
                    break;
                case 38:
                    Storyboard.SetTarget(animation2, marble38.ellipse);
                    break;
                case 39:
                    Storyboard.SetTarget(animation2, marble39.ellipse);
                    break;
                case 40:
                    Storyboard.SetTarget(animation2, marble40.ellipse);
                    break;
                case 41:
                    Storyboard.SetTarget(animation2, marble41.ellipse);
                    break;
                case 42:
                    Storyboard.SetTarget(animation2, marble42.ellipse);
                    break;
                case 43:
                    Storyboard.SetTarget(animation2, marble43.ellipse);
                    break;
                case 44:
                    Storyboard.SetTarget(animation2, marble44.ellipse);
                    break;
                case 45:
                    Storyboard.SetTarget(animation2, marble45.ellipse);
                    break;
                case 46:
                    Storyboard.SetTarget(animation2, marble46.ellipse);
                    break;
                case 47:
                    Storyboard.SetTarget(animation2, marble47.ellipse);
                    break;
                case 48:
                    Storyboard.SetTarget(animation2, marble48.ellipse);
                    break;
            }
            Storyboard.SetTargetProperty(animation2, "(Canvas.Top)");
            animation2.To = toCoordinate;
            animation2.From = fromCoordinate;
            animation2.FillBehavior = FillBehavior.HoldEnd;
        }
        
        private void AnimateMarbles(Queue<AnimationInformation> queue, int endCupNumber)
        {
            AnimationInformation ani = new AnimationInformation();

            EventHandler<object> completed = null;
            completed += (s, ev) =>
            {
                storyboard.Completed -= completed;
                storyboard.Stop();
                storyboard.Children.Clear();
                Canvas.SetTop(ani.marbleToMove.ellipse, ani.toCoordinate.Y);
                Canvas.SetLeft(ani.marbleToMove.ellipse, ani.toCoordinate.X);

                if(queue.Count != 0)
                {
                    ani = queue.Dequeue();

                    // move with animation
                    SetStoryboardAnimation1(ani.marbleToMove.MarbleNumber, ani.toCoordinate.X, ani.fromCoordinate.X);
                    SetStoryboardAnimation2(ani.marbleToMove.MarbleNumber, ani.toCoordinate.Y, ani.fromCoordinate.Y);

                    storyboard.Children.Add(animation);
                    storyboard.Children.Add(animation2);
                    storyboard.Completed += completed;
                    storyboard.Begin();
                }
                else //animation is finished
                {
                    preventClick = false;

                    if (!SideIsEmpty())
                    {
                        if (isPlayer1Turn)
                        {
                            if (endCupNumber != 6)
                            {
                                // switch turns
                                if (IsCapture(endCupNumber))
                                {
                                    preventClick = true;
                                    CaptureLogic(endCupNumber);
                                    playerTurntxtbx.Text = "Player One: Capture!";
                                }
                                else
                                {
                                    isPlayer1Turn = !isPlayer1Turn;
                                    playerTurntxtbx.Text = "Player Two";
                                }
                            }
                            else
                            {
                                playerTurntxtbx.Text = "Player One: Free Turn";
                            }
                        }
                        else //player 2
                        {
                            if (endCupNumber != 13)
                            {
                                // switch turns
                                if (IsCapture(endCupNumber))
                                {
                                    preventClick = true;
                                    CaptureLogic(endCupNumber);
                                    playerTurntxtbx.Text = "Player Two: Capture!";
                                }
                                else
                                {
                                    isPlayer1Turn = !isPlayer1Turn;
                                    playerTurntxtbx.Text = "Player One";
                                }
                            }
                            else
                            {
                                playerTurntxtbx.Text = "Player Two: Free Turn";
                            }
                        }
                    }
                    else //game is over
                    {
                        if(gameOverAnimationHasOccurred)
                        {
                            playerTurntxtbx.Text = "Game Over";
                            GameOverLogic();
                        }
                        else
                        {
                            if (cups[6].marbleCount > cups[13].marbleCount) //player 1 wins
                            {
                                playerTurntxtbx.Text = "Player 1 Wins!!!";
                            }
                            else //player 2 wins
                            {
                                playerTurntxtbx.Text = "Player 2 Wins!!!";
                            }
                        }
                    }
                    
                }
            };
            if(queue.Count > 0)
            { 
                ani = queue.Dequeue();

                // move with animation
                SetStoryboardAnimation1(ani.marbleToMove.MarbleNumber, ani.toCoordinate.X, ani.fromCoordinate.X);
                SetStoryboardAnimation2(ani.marbleToMove.MarbleNumber, ani.toCoordinate.Y, ani.fromCoordinate.Y);

                storyboard.Children.Add(animation);
                storyboard.Children.Add(animation2);
                storyboard.Completed += completed;
                storyboard.Begin();
            }
        }

        private void MoveMarblesLogic(Cup startCup, int endCupNumber)
        {
            Marble marbleToMove;
            int numOfMarbles = -1;
            int numberOfMarblesToBeMoved = 0;
            Queue<AnimationInformation> stuffToAnimate = new Queue<AnimationInformation>();
            if (startCup.marbleCount != 0)
            {
                numOfMarbles = startCup.marbleCount;
                numberOfMarblesToBeMoved = startCup.marbleCount;
                startCup.marbleCount = 0;

                int i = startCup.cupNumber + 1;

                while (numberOfMarblesToBeMoved != 0)
                {
                    marbleToMove = startCup.marbles.Pop();

                    if (i == 6 && !isPlayer1Turn)
                    {
                        i++;
                    }
                    if (i == 13 && isPlayer1Turn)
                    {
                        i++;
                    }

                    if (i > 13)
                    {
                        i = 0;
                    }

                    double firstEmptySlotX = 0;
                    double firstEmptySlotY = 0;
                    // finds the coordinates of the first empty slot in the ith cup
                    if (i == 6 || i == 13)
                    {
                        Mancala m = (Mancala)cups[i];
                        firstEmptySlotX = m.mancalaCoordinates[cups[i].marbleCount].X;
                        firstEmptySlotY = m.mancalaCoordinates[cups[i].marbleCount].Y;
                    }
                    else
                    {
                        if (cups[i] == startCup)
                        {
                            firstEmptySlotX = cups[i].coordinates[0].X;
                            firstEmptySlotY = cups[i].coordinates[0].Y;
                        }
                        else
                        {
                            firstEmptySlotX = cups[i].coordinates[cups[i].marbles.Count].X;
                            firstEmptySlotY = cups[i].coordinates[cups[i].marbles.Count].Y;
                        }
                    }

                    cups[i].marbles.Push(marbleToMove);
                    numberOfMarblesToBeMoved--;
                    cups[i].marbleCount++;
                    i++;

                    stuffToAnimate.Enqueue(new AnimationInformation(marbleToMove, firstEmptySlotX, firstEmptySlotY,
                        startCup.coordinates[startCup.marbles.Count].X, startCup.coordinates[startCup.marbles.Count].Y));
                }
                AnimateMarbles(stuffToAnimate, endCupNumber);
            }
        }

        private int FindEndCup(int startCupNumber, int startCupMarbleCount)
        {
            int endCupNumber = startCupNumber;
            for (int i = 1; i <= startCupMarbleCount; i++)
            {
                if (startCupNumber + i == 14)
                {
                    endCupNumber = 0;
                }
                else
                {
                    if (isPlayer1Turn)
                    {
                        if (startCupNumber + i == 13)
                        {
                            endCupNumber = 0;
                        }
                        else
                        {
                            endCupNumber++;
                        }
                    }
                    else // player 2
                    {
                        if (startCupNumber + i == 6)
                        {
                            endCupNumber += 2;
                        }
                        else
                        {
                            endCupNumber++;
                        }
                    }
                }
            }
            return endCupNumber;
        }

        private void Cup_Click(object sender, RoutedEventArgs e)
        {
            if(!preventClick)
            {
                Cup startCup = null;
                int endCupNumber;

                #region Start Cup Initialization
                if (e.OriginalSource.Equals(Cup0Button))
                {
                    startCup = cup0;
                }
                if (e.OriginalSource.Equals(Cup1Button))
                {
                    startCup = cup1;
                }
                if (e.OriginalSource.Equals(Cup2Button))
                {
                    startCup = cup2;
                }
                if (e.OriginalSource.Equals(Cup3Button))
                {
                    startCup = cup3;
                }
                if (e.OriginalSource.Equals(Cup4Button))
                {
                    startCup = cup4;
                }
                if (e.OriginalSource.Equals(Cup5Button))
                {
                    startCup = cup5;
                }
                if (e.OriginalSource.Equals(Cup7Button))
                {
                    startCup = cup7;
                }
                if (e.OriginalSource.Equals(Cup8Button))
                {
                    startCup = cup8;
                }
                if (e.OriginalSource.Equals(Cup9Button))
                {
                    startCup = cup9;
                }
                if (e.OriginalSource.Equals(Cup10Button))
                {
                    startCup = cup10;
                }
                if (e.OriginalSource.Equals(Cup11Button))
                {
                    startCup = cup11;
                }
                if (e.OriginalSource.Equals(Cup12Button))
                {
                    startCup = cup12;
                }
                #endregion

                if (startCup.marbleCount > 0)
                {
                    if (isPlayer1Turn && startCup.cupNumber >= 0 && startCup.cupNumber <= 5)
                    {
                        endCupNumber = FindEndCup(startCup.cupNumber, startCup.marbleCount);
                        preventClick = true;
                        MoveMarblesLogic(startCup, endCupNumber);
                    }
                    else if (!isPlayer1Turn && startCup.cupNumber >= 7 && startCup.cupNumber <= 12)
                    {
                        endCupNumber = FindEndCup(startCup.cupNumber, startCup.marbleCount);
                        preventClick = true;
                        MoveMarblesLogic(startCup, endCupNumber);
                    }
                    else
                    {
                        // invalid move
                    }
                }
            }
        }

        private bool IsCapture(int endCupNumber)
        {
            if (isPlayer1Turn &&
                ((endCupNumber == 0 && cups[endCupNumber].marbleCount == 1 && cups[12].marbleCount > 0) ||
                (endCupNumber == 1 && cups[endCupNumber].marbleCount == 1 && cups[11].marbleCount > 0) ||
                (endCupNumber == 2 && cups[endCupNumber].marbleCount == 1 && cups[10].marbleCount > 0) ||
                (endCupNumber == 3 && cups[endCupNumber].marbleCount == 1 && cups[9].marbleCount > 0) ||
                (endCupNumber == 4 && cups[endCupNumber].marbleCount == 1 && cups[8].marbleCount > 0) ||
                (endCupNumber == 5 && cups[endCupNumber].marbleCount == 1 && cups[7].marbleCount > 0)))
            {
                return true;
            }
            else if(!isPlayer1Turn &&
                ((endCupNumber == 12 && cups[endCupNumber].marbleCount == 1 && cups[0].marbleCount > 0) ||
                (endCupNumber == 11 && cups[endCupNumber].marbleCount == 1 && cups[1].marbleCount > 0) ||
                (endCupNumber == 10 && cups[endCupNumber].marbleCount == 1 && cups[2].marbleCount > 0) ||
                (endCupNumber == 9 && cups[endCupNumber].marbleCount == 1 && cups[3].marbleCount > 0) ||
                (endCupNumber == 8 && cups[endCupNumber].marbleCount == 1 && cups[4].marbleCount > 0) ||
                (endCupNumber == 7 && cups[endCupNumber].marbleCount == 1 && cups[5].marbleCount > 0)))
            {
                return true;
            }
            return false;
        }

        private void CaptureLogic(int endCupNumber) 
        {
            Marble marbleToMove = cups[endCupNumber].marbles.Pop();
            cups[endCupNumber].marbleCount--;
            Cup capturedCup = null;
            Queue<AnimationInformation> marblesToAnimate = new Queue<AnimationInformation>();

            double firstEmptySlotX = 0;
            double firstEmptySlotY = 0;
            // finds the coordinates of the first empty slot in the correct player's mancala
            if (isPlayer1Turn)
            {
                Mancala m = (Mancala)cups[6];
                firstEmptySlotX = m.mancalaCoordinates[cups[6].marbleCount].X;
                firstEmptySlotY = m.mancalaCoordinates[cups[6].marbleCount].Y;
                cups[6].marbles.Push(marbleToMove);
                cups[6].marbleCount++;

            }
            else //player 2
            {
                Mancala m = (Mancala)cups[13];
                firstEmptySlotX = m.mancalaCoordinates[cups[13].marbleCount].X;
                firstEmptySlotY = m.mancalaCoordinates[cups[13].marbleCount].Y;
                cups[13].marbles.Push(marbleToMove);
                cups[13].marbleCount++;

            }

            marblesToAnimate.Enqueue(new AnimationInformation(marbleToMove, firstEmptySlotX, firstEmptySlotY,
                        cups[endCupNumber].coordinates[cups[endCupNumber].marbleCount].X, 
                        cups[endCupNumber].coordinates[cups[endCupNumber].marbleCount].Y));

            switch(endCupNumber)
            {
                case 0:
                    capturedCup = cup12;
                    break;
                case 1:
                    capturedCup = cup11;
                    break;
                case 2:
                    capturedCup = cup10;
                    break;
                case 3:
                    capturedCup = cup9;
                    break;
                case 4:
                    capturedCup = cup8;
                    break;
                case 5:
                    capturedCup = cup7;
                    break;
                case 7:
                    capturedCup = cup5;
                    break;
                case 8:
                    capturedCup = cup4;
                    break;
                case 9:
                    capturedCup = cup3;
                    break;
                case 10:
                    capturedCup = cup2;
                    break;
                case 11:
                    capturedCup = cup1;
                    break;
                case 12:
                    capturedCup = cup0;
                    break;
            }

            for(int i = capturedCup.marbleCount; i > 0; i--)
            {
                // find marble to send and deque it
                marbleToMove = capturedCup.marbles.Pop();

                // find the first empty slot and push on to mancala
                if (isPlayer1Turn)
                {
                    Mancala m = (Mancala)cups[6];
                    firstEmptySlotX = m.mancalaCoordinates[cups[6].marbleCount].X;
                    firstEmptySlotY = m.mancalaCoordinates[cups[6].marbleCount].Y;
                    cups[6].marbles.Push(marbleToMove);
                    cups[6].marbleCount++;
                }
                else //player 2
                {
                    Mancala m = (Mancala)cups[13];
                    firstEmptySlotX = m.mancalaCoordinates[cups[13].marbleCount].X;
                    firstEmptySlotY = m.mancalaCoordinates[cups[13].marbleCount].Y;
                    cups[13].marbles.Push(marbleToMove);
                    cups[13].marbleCount++;
                }

                // enque to send to animation
                marblesToAnimate.Enqueue(new AnimationInformation(marbleToMove, firstEmptySlotX, firstEmptySlotY, // keep using from above
                        capturedCup.coordinates[capturedCup.marbleCount].X, capturedCup.coordinates[capturedCup.marbleCount].Y));

                // decrement cup marble number
                capturedCup.marbleCount--;

            }
            // begin animation
            AnimateMarbles(marblesToAnimate, endCupNumber);
            preventClick = false;
        }

        private bool SideIsEmpty()
        {
            if((cup0.marbleCount == 0 &&
                cup1.marbleCount == 0 &&
                cup2.marbleCount == 0 &&
                cup3.marbleCount == 0 &&
                cup4.marbleCount == 0 &&
                cup5.marbleCount == 0) ||
                (cup7.marbleCount == 0 &&
                cup8.marbleCount == 0 &&
                cup9.marbleCount == 0 &&
                cup10.marbleCount == 0 &&
                cup11.marbleCount == 0 &&
                cup12.marbleCount == 0))
            {
                return true;
            }
            return false;
        }

        private void GameOverLogic()
        {
            Queue<AnimationInformation> marblesToAnimate = new Queue<AnimationInformation>();
            Marble marbleToMove = null;
            double toX = 0;
            double toY = 0;
            int endCupNumber;

            //this may need to switch, but I dont think so

            if (isPlayer1Turn) // move player 2's pieces
            {
                endCupNumber = 13;
                for (int i = 7; i <= 12; i++)
                {
                    for(int j = cups[i].marbleCount; j > 0; j--)
                    {
                        // remove from current cup
                        marbleToMove = cups[i].marbles.Pop();
                        
                        // place in mancala
                        Mancala m = (Mancala)cups[endCupNumber];
                        toX = m.mancalaCoordinates[cups[endCupNumber].marbleCount].X;
                        toY = m.mancalaCoordinates[cups[endCupNumber].marbleCount].Y;
                        cups[endCupNumber].marbles.Push(marbleToMove);
                        cups[endCupNumber].marbleCount++;

                        // enqueue to animation
                        marblesToAnimate.Enqueue(new AnimationInformation(marbleToMove, toX, toY, // keep using from above
                            cups[i].coordinates[cups[i].marbleCount].X, cups[i].coordinates[cups[i].marbleCount].Y));

                        // decrement cup marble number
                        cups[i].marbleCount--;
                    }
                }
            }
            else //move player 1's pieces
            {
                endCupNumber = 6;
                for (int i = 0; i <= 5; i++)
                {
                    for (int j = cups[i].marbleCount; j > 0; j--)
                    {
                        // remove from current cup
                        marbleToMove = cups[i].marbles.Pop();

                        // place in mancala
                        Mancala m = (Mancala)cups[endCupNumber];
                        toX = m.mancalaCoordinates[cups[endCupNumber].marbleCount].X;
                        toY = m.mancalaCoordinates[cups[endCupNumber].marbleCount].Y;
                        cups[endCupNumber].marbles.Push(marbleToMove);
                        cups[endCupNumber].marbleCount++;

                        // enqueue to animation
                        marblesToAnimate.Enqueue(new AnimationInformation(marbleToMove, toX, toY, // keep using from above
                            cups[i].coordinates[cups[i].marbleCount].X, cups[i].coordinates[cups[i].marbleCount].Y));

                        // decrement cup marble number
                        cups[i].marbleCount--;
                    }
                }
            }

            // begin animation
            AnimateMarbles(marblesToAnimate, endCupNumber);
            gameOverAnimationHasOccurred = false;
        }
        
        private void newGameBtn_Click(object sender, RoutedEventArgs e)
        {
            // remove all from cups progromatically (0 - 13)
            for (int i = 0; i < 14; i++)
            {
                cups[i].marbleCount = 0;
                cups[i].marbles.Clear();
            }

            // add all to cups again in right order (1 - 48)
            PlaceMarblesInCup();

            // repopulate them in the right position
            PlaceMarblesOnBoard();

            //reset player turn and text
            isPlayer1Turn = true;
            playerTurntxtbx.Text = "Player One";
        }
    }

    struct AnimationInformation
    {
        public Marble marbleToMove;
        public Coordinate toCoordinate;
        public Coordinate fromCoordinate;
        public AnimationInformation(Marble marble, double toX, double toY, double fromX, double fromY)
        {
            marbleToMove = marble;
            toCoordinate = new Coordinate();
            toCoordinate.X = toX;
            toCoordinate.Y = toY;
            fromCoordinate = new Coordinate();
            fromCoordinate.X = fromX;
            fromCoordinate.Y = fromY;
        }
    }
}
