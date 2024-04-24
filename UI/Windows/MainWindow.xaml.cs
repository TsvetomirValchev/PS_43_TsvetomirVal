using UI.Windows;

namespace UI
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

        private void ViewLogs_Click(object sender, RoutedEventArgs e)
        {
            LoggerWindow loggerWindow = new LoggerWindow();
            loggerWindow.ShowDialog();
        }
    }
}