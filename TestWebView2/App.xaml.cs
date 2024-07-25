using System.Configuration;
using System.Data;
using System.Windows;

namespace TestWebView2;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        Application.Current.MainWindow = new MainWindow();
        if (new LoginWindow().ShowDialog() == true)
        {
            Application.Current.MainWindow.Show();
        }
        else
        {
            Environment.Exit(0);
        }
    }
}