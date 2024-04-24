namespace UI.Windows
{
    /// <summary>
    /// Interaction logic for LoggerWindow.xaml
    /// </summary>
    public partial class LoggerWindow : Window
    {
        public LoggerWindow()
        {
            InitializeComponent();
        }
        private void LogGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (logGrid.SelectedItem != null)
            {
                LogEntry selectedLog = (LogEntry)logGrid.SelectedItem;
                MessageBox.Show(selectedLog.Message, "Log Details", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
