using System.Windows.Forms;
using PackageTracker.Views;
using PackageTracker.Models;
using PackageTracker.Presenters;
using PackageTracker._Repositories;
using PackageTracker.Common;
using System.Configuration;
using Unity;

namespace PackageTracker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SetupApplication();

            string mySqlConnectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            IMainView view = DependencyConfig.GetContainer().Resolve<IMainView>();
            MainPresenter presenter = new MainPresenter(view, mySqlConnectionString);

            Application.Run((Form)view);
        }
        private static void SetupApplication()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}