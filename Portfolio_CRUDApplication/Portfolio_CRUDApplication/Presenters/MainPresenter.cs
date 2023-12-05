using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageTracker.Models;
using PackageTracker.Views;
using PackageTracker._Repositories;

namespace PackageTracker.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string mySqlConnectionString;

        public MainPresenter(IMainView _mainView, string _mySqlConnectionString)
        {
            this.mainView = _mainView;
            this.mySqlConnectionString = _mySqlConnectionString;
            this.mainView.ShowPackageView += ShowPackageView;
        }

        private void ShowPackageView(object? sender, EventArgs e)
        {
            //var unityContainer = new UnityContainer();
            //unityContainer.RegisterType<IPackageView, PackageView.GetInstance()>();
            //unityContainer.RegisterType<IPackageRepository, PackageRepository>();
            //var packagePresenter = unityContainer.Resolve<PackagePresenter>();
            IPackageView view = PackageView.GetInstance((MainView)mainView);
            IPackageRepository repository = new PackageRepository(mySqlConnectionString);
            new PackagePresenter(view, repository);
        }
    }
}
