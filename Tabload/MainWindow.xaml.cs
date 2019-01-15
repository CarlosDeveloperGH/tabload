﻿using System.Windows;

namespace Tabload
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenSettingsWindow(object sender, RoutedEventArgs e)
        {
            Views.Settings _settingsWindow = new Views.Settings(); ;
            _settingsWindow.Show();
        }
    }
}
