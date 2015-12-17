﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;
using WPF.Toaster;

namespace WPFGrowlNotification
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const double TopOffset = 20;
        private const double LeftOffset = 380;
        private readonly Toasts _toasts;
        
        public MainWindow()
        {
            InitializeComponent();
            _toasts = new Toasts(NotificationLocation.TopRight);

        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Resources/notification-icon.png");
            var bitmap = new BitmapImage(uri);
            _toasts.AddNotification(new Toast { Title = "Mesage #1",
                Image = bitmap,
                Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });
       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Resources/microsoft-windows-8-logo.png");
            var bitmap = new BitmapImage(uri);
            _toasts.AddNotification(new Toast { Title = "Mesage #2", Image = bitmap, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Resources/facebook-button.png");
            var bitmap = new BitmapImage(uri);
            _toasts.AddNotification(new Toast { Title = "Mesage #3", Image = bitmap, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("pack://application:,,,/Resources/Radiation_warning_symbol.png");
            var bitmap = new BitmapImage(uri);
            _toasts.AddNotification(new Toast { Title = "Mesage #4", Image = bitmap, Message = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });
        }

        protected override void OnClosed(System.EventArgs e)
        {
            _toasts.Close();
            base.OnClosed(e);
        }

        private void WindowLoaded1(object sender, RoutedEventArgs e)
        {
            //this will make minimize restore of notifications too
            //growlNotifications.Owner = GetWindow(this);
        }
    }
}
