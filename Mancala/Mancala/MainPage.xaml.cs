using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Mancala
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void InstructionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InstructionsPage));
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            //if saved data, show message and let user choose
            //if()
            //{

            //}
            //else
            //{

            //}

            MessageDialog msgDialog = new MessageDialog("Your message", "Your title");

            //New Game Button
            UICommand newGameBtn = new UICommand("New Game");
            newGameBtn.Invoked = NewGameBtnClick;
            msgDialog.Commands.Add(newGameBtn);

            //Load Game Button
            UICommand loadGameBtn = new UICommand("Load Game");
            loadGameBtn.Invoked = LoadGameBtnClick;
            msgDialog.Commands.Add(loadGameBtn);

            //Cancel Button
            UICommand cancelBtn = new UICommand("Cancel");
            cancelBtn.Invoked = CancelBtnClick;
            msgDialog.Commands.Add(cancelBtn);

            //Show message
            var result = msgDialog.ShowAsync();
        }

        private void NewGameBtnClick(IUICommand command)
        {
            this.Frame.Navigate(typeof(GamePage));
        }

        private void LoadGameBtnClick(IUICommand command)
        {
            //if saved data, load game
        }

        private void CancelBtnClick(IUICommand command)
        {
            //closes message dialog
        }
    }
}
