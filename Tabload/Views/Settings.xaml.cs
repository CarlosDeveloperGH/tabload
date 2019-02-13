using System.Windows;

namespace Tabload.Views
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void OnLoad()
        {
            //Load the stuff into the settings textblocks.
        }
        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            //TODO Close window after saving all settings
            Close();
        }
        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void DragWindow(object sender, RoutedEventArgs e)
        {
            DragMove();
        }
    }
}
