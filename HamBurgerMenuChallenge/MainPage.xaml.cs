﻿using HamBurgerMenuChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<NewsItem> NewsItems;
        public MainPage()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItem>();
            NewsManager.GetNews("Financial", NewsItems);
            TitleTextBlock.Text = "Financial";
            BackButton.Visibility = Visibility.Collapsed;

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (Food.IsSelected)
            {
                NewsManager.GetNews("Financial", NewsItems);
                TitleTextBlock.Text = "Financial";
                BackButton.Visibility = Visibility.Collapsed;
                Financial.IsSelected = true;

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Financial.IsSelected)
            {
                NewsManager.GetNews("Financial", NewsItems);
                TitleTextBlock.Text = "Financial";
                BackButton.Visibility = Visibility.Collapsed;

            }
            else if (Food.IsSelected)
            {
                NewsManager.GetNews("Food", NewsItems);
                TitleTextBlock.Text = "Food";
                BackButton.Visibility = Visibility.Visible;

            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Financial.IsSelected = true;
        }
    }


}
