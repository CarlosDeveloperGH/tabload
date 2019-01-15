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
            Close();
        }
    }
}
