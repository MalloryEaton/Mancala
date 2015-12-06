using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Mancala
{
    public class Marble
    {
        public Ellipse ellipse;
        public int MarbleNumber;
        public Marble()
        {
            ellipse = new Ellipse();
            ellipse.Width = 20;
            ellipse.Height = 20;

            // randomize elipse color
            SolidColorBrush[] brushArray = new SolidColorBrush[5];
            brushArray[0] = new SolidColorBrush(Colors.Aquamarine);
            brushArray[1] = new SolidColorBrush(Colors.LightGreen);
            brushArray[2] = new SolidColorBrush(Colors.LightGoldenrodYellow);
            brushArray[3] = new SolidColorBrush(Colors.MediumPurple);
            brushArray[4] = new SolidColorBrush(Colors.MediumOrchid);
            Random _rand = new Random();
            ellipse.Fill = brushArray[_rand.Next(5)];
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
        }
    }

    
}
