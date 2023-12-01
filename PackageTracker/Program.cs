class using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PackageTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new PackageDbContext())
            {
                CreatePackage(context, "John Doe", "Jane Doe", "In Transit", "3.73")
                DisplayPackages(context);
                UpdatePackage(context, 1, "In Delivery");
                DisplayPackage(context);
                DeletePackage(context, 1);
                DisplayPackage(context);
            }
        }

        public static coid CreatePackage(PackageDbContext context, string sender, string receiver, float weight)
    }
}
