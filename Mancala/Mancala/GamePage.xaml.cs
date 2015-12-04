using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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

        #region Marble Creation
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

        public GamePage()
        {
            this.InitializeComponent();
            InitializeMarbles();
            PlaceMarbles();
            
            SetStoryboardAnimation1(1, 500);

            SetStoryboardAnimation2(1, 500);

            storyboard.Children.Add(animation);
            storyboard.Children.Add(animation2);
        }

        private void SetStoryboardAnimation1(int marbleNumber, int toCoordinate)
        {
            animation.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation.Duration = new TimeSpan(0, 0, 0, 0, 100);
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

        private void SetStoryboardAnimation2(int marbleNumber, int toCoordinate)
        {
            animation2.BeginTime = new TimeSpan(0, 0, 0, 0, 0);
            animation2.Duration = new TimeSpan(0, 0, 0, 0, 100);
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

        private void PlaceMarbles()
        {
            Canvas.SetLeft(marble1.ellipse, 200);
            Canvas.SetTop(marble1.ellipse, 200);
            mainCanvas.Children.Add(marble1.ellipse);
        }
    }
}
