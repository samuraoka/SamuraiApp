using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    /// <summary>
    /// To create a data model, add following NuGet package using the below command in Package Manager
    /// PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer -ProjectName SamuraiApp.Data -Version 2.0.0
    /// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
    /// </summary>
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
    }
}
