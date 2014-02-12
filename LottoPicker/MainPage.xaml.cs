using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LottoPicker.Resources;

namespace LottoPicker
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random1 = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            Random random4 = new Random();
            Random random5 = new Random();
            Random random6 = new Random();
            Random random7 = new Random();

            int no1 = random1.Next(1, 50);
            int no2 = random1.Next(1, 50);
            int no3 = random1.Next(1, 50);
            int no4 = random1.Next(1, 50);
            int no5 = random1.Next(1, 50);
            int no6 = random1.Next(1, 50);
            int no7 = random1.Next(1, 50);

            number1.Text = no1.ToString();
            number2.Text = no2.ToString();
            number3.Text = no3.ToString();
            number4.Text = no4.ToString();
            number5.Text = no5.ToString();
            number6.Text = no6.ToString();
            bonus.Text = no7.ToString();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}