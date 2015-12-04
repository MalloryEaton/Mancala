﻿using System;
using System.Collections.Generic;
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
        DoubleAnimation animation = new DoubleAnimation();
        DoubleAnimation animation2 = new DoubleAnimation();

        #region Marbles
        Marble marble1 = new Marble();
        Marble marble2 = new Marble();
        Marble marble3 = new Marble();
        Marble marble4 = new Marble();
        Marble marble5 = new Marble();
        Marble marble6 = new Marble();
        Marble marble7 = new Marble();
        Marble marble8 = new Marble();
        Marble marble9 = new Marble();
        Marble marble10 = new Marble();
        Marble marble11 = new Marble();
        Marble marble12 = new Marble();
        Marble marble13 = new Marble();
        Marble marble14 = new Marble();
        Marble marble15 = new Marble();
        Marble marble16 = new Marble();
        Marble marble17 = new Marble();
        Marble marble18 = new Marble();
        Marble marble19 = new Marble();
        Marble marble20 = new Marble();
        Marble marble21 = new Marble();
        Marble marble22 = new Marble();
        Marble marble23 = new Marble();
        Marble marble24 = new Marble();
        Marble marble25 = new Marble();
        Marble marble26 = new Marble();
        Marble marble27 = new Marble();
        Marble marble28 = new Marble();
        Marble marble29 = new Marble();
        Marble marble30 = new Marble();
        Marble marble31 = new Marble();
        Marble marble32 = new Marble();
        Marble marble33 = new Marble();
        Marble marble34 = new Marble();
        Marble marble35 = new Marble();
        Marble marble36 = new Marble();
        Marble marble37 = new Marble();
        Marble marble38 = new Marble();
        Marble marble39 = new Marble();
        Marble marble40 = new Marble();
        Marble marble41 = new Marble();
        Marble marble42 = new Marble();
        Marble marble43 = new Marble();
        Marble marble44 = new Marble();
        Marble marble45 = new Marble();
        Marble marble46 = new Marble();
        Marble marble47 = new Marble();
        Marble marble48 = new Marble();
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
                InitializeCups();
                InitializeMancala();
                InitializeMarbles();

                PlaceMarblesOnBoard();
                
            };
        }

        private void SetStoryboardAnimation1(int marbleNumber, double toCoordinate)
        {
            animation.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation.Duration = new TimeSpan(0, 0, 0, 0, 80);
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
            Storyboard.SetTargetProperty(animation, "(Canvas.Top)");
            animation.To = toCoordinate;
        }

        private void SetStoryboardAnimation2(int marbleNumber, double toCoordinate)
        {
            animation2.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation2.Duration = new TimeSpan(0, 0, 0, 0, 80);
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

            Storyboard.SetTargetProperty(animation2, "(Canvas.Left)");
            animation.To = toCoordinate;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            storyboard.Begin();
        }

        private void InitializeMarbles()
        {
            marble1.MarbleNumber = 1;
            marble2.MarbleNumber = 2;
            marble3.MarbleNumber = 3;
            marble4.MarbleNumber = 4;
            marble5.MarbleNumber = 5;
            marble6.MarbleNumber = 6;
            marble7.MarbleNumber = 7;
            marble8.MarbleNumber = 8;
            marble9.MarbleNumber = 9;
            marble10.MarbleNumber = 10;
            marble11.MarbleNumber = 11;
            marble12.MarbleNumber = 12;
            marble13.MarbleNumber = 13;
            marble14.MarbleNumber = 14;
            marble15.MarbleNumber = 15;
            marble16.MarbleNumber = 16;
            marble17.MarbleNumber = 17;
            marble18.MarbleNumber = 18;
            marble19.MarbleNumber = 19;
            marble20.MarbleNumber = 20;
            marble21.MarbleNumber = 21;
            marble22.MarbleNumber = 22;
            marble23.MarbleNumber = 23;
            marble24.MarbleNumber = 24;
            marble25.MarbleNumber = 25;
            marble26.MarbleNumber = 26;
            marble27.MarbleNumber = 27;
            marble28.MarbleNumber = 28;
            marble29.MarbleNumber = 29;
            marble30.MarbleNumber = 30;
            marble31.MarbleNumber = 31;
            marble32.MarbleNumber = 32;
            marble33.MarbleNumber = 33;
            marble34.MarbleNumber = 34;
            marble35.MarbleNumber = 35;
            marble36.MarbleNumber = 36;
            marble37.MarbleNumber = 37;
            marble38.MarbleNumber = 38;
            marble39.MarbleNumber = 39;
            marble40.MarbleNumber = 40;
            marble41.MarbleNumber = 41;
            marble42.MarbleNumber = 42;
            marble43.MarbleNumber = 43;
            marble44.MarbleNumber = 44;
            marble45.MarbleNumber = 45;
            marble46.MarbleNumber = 46;
            marble47.MarbleNumber = 47;
            marble48.MarbleNumber = 48;

        }

        private void PlaceMarblesOnBoard()
        {
            PlaceMarbleAtLocation(marble1, cup0.coordinates[0].X, cup0.coordinates[0].Y);
            PlaceMarbleAtLocation(marble2, cup0.coordinates[1].X, cup0.coordinates[1].Y);
            PlaceMarbleAtLocation(marble3, cup0.coordinates[2].X, cup0.coordinates[2].Y);
            PlaceMarbleAtLocation(marble4, cup0.coordinates[3].X, cup0.coordinates[3].Y);
            cup0.cupNumber += 4;

            PlaceMarbleAtLocation(marble5, cup1.coordinates[0].X, cup1.coordinates[0].Y);
            PlaceMarbleAtLocation(marble6, cup1.coordinates[1].X, cup1.coordinates[1].Y);
            PlaceMarbleAtLocation(marble7, cup1.coordinates[2].X, cup1.coordinates[2].Y);
            PlaceMarbleAtLocation(marble8, cup1.coordinates[3].X, cup1.coordinates[3].Y);
            cup1.cupNumber += 4;

            PlaceMarbleAtLocation(marble9, cup2.coordinates[0].X, cup2.coordinates[0].Y);
            PlaceMarbleAtLocation(marble10, cup2.coordinates[1].X, cup2.coordinates[1].Y);
            PlaceMarbleAtLocation(marble11, cup2.coordinates[2].X, cup2.coordinates[2].Y);
            PlaceMarbleAtLocation(marble12, cup2.coordinates[3].X, cup2.coordinates[3].Y);
            cup2.cupNumber += 4;

            PlaceMarbleAtLocation(marble13, cup3.coordinates[0].X, cup3.coordinates[0].Y);
            PlaceMarbleAtLocation(marble14, cup3.coordinates[1].X, cup3.coordinates[1].Y);
            PlaceMarbleAtLocation(marble15, cup3.coordinates[2].X, cup3.coordinates[2].Y);
            PlaceMarbleAtLocation(marble16, cup3.coordinates[3].X, cup3.coordinates[3].Y);
            cup3.cupNumber += 4;

            PlaceMarbleAtLocation(marble17, cup4.coordinates[0].X, cup4.coordinates[0].Y);
            PlaceMarbleAtLocation(marble18, cup4.coordinates[1].X, cup4.coordinates[1].Y);
            PlaceMarbleAtLocation(marble19, cup4.coordinates[2].X, cup4.coordinates[2].Y);
            PlaceMarbleAtLocation(marble20, cup4.coordinates[3].X, cup4.coordinates[3].Y);
            cup4.cupNumber += 4;

            PlaceMarbleAtLocation(marble21, cup5.coordinates[0].X, cup5.coordinates[0].Y);
            PlaceMarbleAtLocation(marble22, cup5.coordinates[1].X, cup5.coordinates[1].Y);
            PlaceMarbleAtLocation(marble23, cup5.coordinates[2].X, cup5.coordinates[2].Y);
            PlaceMarbleAtLocation(marble24, cup5.coordinates[3].X, cup5.coordinates[3].Y);
            cup5.cupNumber += 4;

            PlaceMarbleAtLocation(marble25, cup7.coordinates[0].X, cup7.coordinates[0].Y);
            PlaceMarbleAtLocation(marble26, cup7.coordinates[1].X, cup7.coordinates[1].Y);
            PlaceMarbleAtLocation(marble27, cup7.coordinates[2].X, cup7.coordinates[2].Y);
            PlaceMarbleAtLocation(marble28, cup7.coordinates[3].X, cup7.coordinates[3].Y);
            cup7.cupNumber += 4;

            PlaceMarbleAtLocation(marble29, cup8.coordinates[0].X, cup8.coordinates[0].Y);
            PlaceMarbleAtLocation(marble30, cup8.coordinates[1].X, cup8.coordinates[1].Y);
            PlaceMarbleAtLocation(marble31, cup8.coordinates[2].X, cup8.coordinates[2].Y);
            PlaceMarbleAtLocation(marble32, cup8.coordinates[3].X, cup8.coordinates[3].Y);
            cup8.cupNumber += 4;

            PlaceMarbleAtLocation(marble33, cup9.coordinates[0].X, cup9.coordinates[0].Y);
            PlaceMarbleAtLocation(marble34, cup9.coordinates[1].X, cup9.coordinates[1].Y);
            PlaceMarbleAtLocation(marble35, cup9.coordinates[2].X, cup9.coordinates[2].Y);
            PlaceMarbleAtLocation(marble36, cup9.coordinates[3].X, cup9.coordinates[3].Y);
            cup9.cupNumber += 4;

            PlaceMarbleAtLocation(marble37, cup10.coordinates[0].X, cup10.coordinates[0].Y);
            PlaceMarbleAtLocation(marble38, cup10.coordinates[1].X, cup10.coordinates[1].Y);
            PlaceMarbleAtLocation(marble39, cup10.coordinates[2].X, cup10.coordinates[2].Y);
            PlaceMarbleAtLocation(marble40, cup10.coordinates[3].X, cup10.coordinates[3].Y);
            cup10.cupNumber += 4;

            PlaceMarbleAtLocation(marble41, cup11.coordinates[0].X, cup11.coordinates[0].Y);
            PlaceMarbleAtLocation(marble42, cup11.coordinates[1].X, cup11.coordinates[1].Y);
            PlaceMarbleAtLocation(marble43, cup11.coordinates[2].X, cup11.coordinates[2].Y);
            PlaceMarbleAtLocation(marble44, cup11.coordinates[3].X, cup11.coordinates[3].Y);
            cup11.cupNumber += 4;

            PlaceMarbleAtLocation(marble45, cup12.coordinates[0].X, cup12.coordinates[0].Y);
            PlaceMarbleAtLocation(marble46, cup12.coordinates[1].X, cup12.coordinates[1].Y);
            PlaceMarbleAtLocation(marble47, cup12.coordinates[2].X, cup12.coordinates[2].Y);
            PlaceMarbleAtLocation(marble48, cup12.coordinates[3].X, cup12.coordinates[3].Y);
            cup12.cupNumber += 4;
        }

        private void PlaceMarbleAtLocation(Marble marble, double x, double y)
        {
            Canvas.SetTop(marble.ellipse, y);
            Canvas.SetLeft(marble.ellipse, x);
            mainCanvas.Children.Add(marble.ellipse);
        }

        private void InitializeMancala()
        {
            mancala1.mancalaNumber = 1;
            mancala1.coordinates[0].X = Canvas.GetLeft(Cup6);
            mancala1.coordinates[0].Y = Canvas.GetTop(Cup6);
            PopulateMancalaCoordinateGrid(mancala1.coordinates);

            mancala2.mancalaNumber = 2;
            mancala2.coordinates[0].X = Canvas.GetLeft(Cup13);
            mancala2.coordinates[0].Y = Canvas.GetTop(Cup13);
            PopulateMancalaCoordinateGrid(mancala2.coordinates);
        }
        
        private void PopulateMancalaCoordinateGrid(Coordinate[] coordinates)
        {
            double currentTop = coordinates[0].X;
            double currentLeft = coordinates[0].Y;
            // 12 rows, 4 columns, 48 possible items
            for (int i = 1; i < 49; i++)
            {   
                // move to the next row
                if (i % 4 == 0) 
                {
                    currentTop += 25;
                    currentLeft = coordinates[0].Y;
                }
                coordinates[i].X = currentTop;
                coordinates[i].Y = currentLeft;
                // move to the next column
                currentLeft += 25; 
            }
        }

        private void InitializeCups()
        {
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

            // add cups to list to enumerate through later.
            cups.Add(cup0);
            cups.Add(cup1);
            cups.Add(cup2);
            cups.Add(cup3);
            cups.Add(cup4);
            cups.Add(cup5);
            cups.Add(cup7);
            cups.Add(cup8);
            cups.Add(cup9);
            cups.Add(cup10);
            cups.Add(cup11);
            cups.Add(cup12);


        }

        private void PopulateCupCoordinateGrid(Coordinate[] coordinates)
        {
            coordinates[19].X = coordinates[16].X + 75;
            coordinates[19].Y = coordinates[16].Y;
            
            double currentLeft = coordinates[19].X;
            double currentTop = coordinates[19].Y;
            // 5 rows, 4 columns, 20 possible items
            for (int i = 19; i >= 0; i--)
            {
                coordinates[i].X = currentLeft;
                coordinates[i].Y = currentTop;
                // move to the next column
                currentLeft -= 25;
                // move to the next row
                if (i % 4 == 0)
                {
                    currentTop += 24;
                    currentLeft = coordinates[19].X;
                }
            }

        }
        
        private void Cup_Click(object sender, RoutedEventArgs e)
        {
            int startCup = -1;
            int numOfMarbles = -1;

            if(e.OriginalSource.Equals(Cup0))
            {
                numOfMarbles = cup0.cupNumber;
                cup0.cupNumber = 0;
                startCup = 0;
            }

            for (int i = startCup + 1; i < startCup + numOfMarbles; i++)
            {
                if (i == 6 || i == 13) { } //TODO: might loop around again, mancala to correct player...

                // finds the coordinates of the first empty slot in the ith cup
                double firstEmptySlotX = cups[i].coordinates[cups[i].cupNumber - 1].X;
                double firstEmptySlotY = cups[i].coordinates[cups[i].cupNumber - 1].Y;

                SetStoryboardAnimation1(1, firstEmptySlotX); //TODO: find the marble number......

                SetStoryboardAnimation2(1, firstEmptySlotY);

                storyboard.Children.Add(animation);
                storyboard.Children.Add(animation2);
            }
            
            
        }
    }
}
