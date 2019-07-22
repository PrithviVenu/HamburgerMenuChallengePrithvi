using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamBurgerMenuChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            TitleTextBlock.Text = "Financial";
            BackButton.Visibility = Visibility.Collapsed;
            Financial.IsSelected = true;
        }
        private void HamburgerButtonClicked(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                Financial.IsSelected = true;
            }
         }
        private void FrameSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (Financial.IsSelected)
            {
                MyFrame.Navigate(typeof(Financial));
                TitleTextBlock.Text = "Financial";
                BackButton.Visibility = Visibility.Collapsed;

            }
            else if (Food.IsSelected)
            {
                MyFrame.Navigate(typeof(Food));
                TitleTextBlock.Text = "Food";
                BackButton.Visibility = Visibility.Visible;

            }
        }
    }
   

}
