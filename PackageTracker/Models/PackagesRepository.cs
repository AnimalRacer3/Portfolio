using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PackageTracker.Context;

namespace PackageTracker.Models
{
    public class PackageRepository
    {
        private readonly PackageDbContext _packageDbContext;
        public PackageRepository(PackageDbContext packageDbContext)
        {
            _packageDbContext = packageDbContext;
        }

        // Get All Packages List
        public async Task<List<PackageModel>> GetAllPackages()
        {
            return await _packageDbContext.Packages.ToListAsync<PackageModel>();
        }

        // Add New Package
        public async Task<bool> AddNewPackages(PackageModel package)
        {
            await _packageDbContext.Packages.AddAsync(package);
            await _packageDbContext.SaveChangesAsync();
            return true;
        }

        // Get Package By ID
        public async Task<PackageModel> GetPackageById(int id)
        {
            PackageModel package = await _packageDbContext.Packages.FirstOrDefaultAsync(x => x.PackageID == id);
            return package;
        }

        // Update Package Data
        public async Task<bool> UpdatePackage(PackageModel package)
        {
            _packageDbContext.Packages.Update(package);
            await _packageDbContext.SaveChangesAsync();
            return true;
        }

        // Delete Package
        public async Task<bool> DeletePackage(PackageModel package)
        {
            _packageDbContext.Packages.Remove(package);
            await _packageDbContext.SaveChangesAsync();
            return true;
        }
    }
}