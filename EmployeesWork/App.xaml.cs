using System.Windows;
using System.Windows.Threading;

namespace EmployeesWork {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App {
        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
            MessageBox.Show($"An unhandled exception just occurred: {e.Exception.Message}", "Unhandled Exception",
                MessageBoxButton.OK, MessageBoxImage.Error);

            e.Handled = true;
        }
    }
}
