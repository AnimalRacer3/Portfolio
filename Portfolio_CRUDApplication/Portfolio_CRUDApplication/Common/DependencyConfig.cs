using PackageTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PackageTracker.Common
{
    public static class DependencyConfig
    {
        private static readonly UnityContainer Container;

        static DependencyConfig()
        {
            Container = new UnityContainer();
            RegisterTypes(Container);
        }

        public static UnityContainer GetContainer()
        {
            return Container;
        }

        private static void RegisterTypes(UnityContainer container)
        {
            container.RegisterType<IMainView, MainView>();
            // Register other dependencies...
        }
    }
}
