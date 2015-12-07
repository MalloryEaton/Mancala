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
        public int MarbleNumber = 0;
        public Marble(int marbleNum)
        {
            MarbleNumber = marbleNum;
            ellipse = new Ellipse();
            ellipse.Width = 20;
            ellipse.Height = 20;

            // randomize elipse color
            SolidColorBrush[] brushArray = new SolidColorBrush[5];
            brushArray[0] = new SolidColorBrush(Colors.Aquamarine);
            brushArray[1] = new SolidColorBrush(Colors.LightGreen);
            brushArray[2] = new SolidColorBrush(Colors.CornflowerBlue);
            brushArray[3] = new SolidColorBrush(Colors.MediumPurple);
            brushArray[4] = new SolidColorBrush(Colors.AntiqueWhite);
            
            ellipse.Fill = brushArray[new Random((int)DateTime.Now.Ticks & MarbleNumber).Next(0,5)];
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
        }
    }

    
}
