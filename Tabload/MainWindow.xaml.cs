using System.Windows;
using System.Windows.Input;

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
            Views.Settings _settingsWindow = new Views.Settings();
            _settingsWindow.Show();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DragWindow(object sender, RoutedEventArgs e)
        {
            DragMove();
        }
        public void RemoveText(object sender, RoutedEventArgs e)
        {
            tbURL.Text = "";
        }

        public void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbURL.Text))
                tbURL.Text = "Enter URL here...";
        }
    }
}
