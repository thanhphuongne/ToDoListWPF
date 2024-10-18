using System.Configuration;
using System.Data;
using System.Windows;
using ToDoListWPF.Views;

namespace ToDoListWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Login loginWindow = new Login();
            loginWindow.Show();
        }
    }

}
