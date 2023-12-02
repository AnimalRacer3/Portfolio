using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageTracker.Models
{
    public interface IPackageRepository
    {
        void Add(PackageModel packageModel);
        void Edit(PackageModel packageModel);
        void Delete(int id);

        IEnumerable<PackageModel> GetAll();
        IEnumerable<PackageModel> GetByValue();
    }
}