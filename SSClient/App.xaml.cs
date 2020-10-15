using SSClient.Views;
using System.Windows;

namespace ERPSolution
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {        
        protected override void OnStartup(StartupEventArgs e)
        {
            
            Window window = new Login();
            window.Show();

            base.OnStartup(e);
        }
    }
}
