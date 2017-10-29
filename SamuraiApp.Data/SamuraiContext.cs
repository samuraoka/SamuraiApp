using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    /// <summary>
    /// To create a data model, add following NuGet package using the below command in Package Manager
    /// PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer -ProjectName SamuraiApp.Data -Version 2.0.0
    /// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
    /// To create migration files, add following NuGet package using the below command in Package Manager
    /// PM> Install-Package Microsoft.EntityFrameworkCore.Tools -ProjectName SamuraiApp.Data -Version 2.0.0
    /// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/
    /// To get help messages, use a following command in Package Manager.
    /// PM> get-help entityframeworkcore
    /// To add a new migration, execute a following command
    /// PM> Add-Migration -Name init -Context SamuraiContext -Project SamuraiApp.Data -StartupProject SamuraiApp.Data
    /// And if you have a error, try to add properties to the csproj file.
    /// <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    /// <GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>
    /// https://stackoverflow.com/questions/45978173/system-valuetuple-version-0-0-0-0-required-for-add-migration-on-net-4-6-1-cla
    /// https://blogs.msdn.microsoft.com/dotnet/2017/08/14/announcing-entity-framework-core-2-0/
    /// To Create or Update database, run following command in the Package Manager Console
    /// PM> Update-Database -Context SamuraiContext -Project SamuraiApp.Data -StartupProject SamuraiApp.Data
    /// </summary>
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        /// <summary>
        /// The following URL shows how to write connection strings
        /// https://msdn.microsoft.com/en-us/library/system.data.sqlclient.sqlconnection.connectionstring(v=vs.110).aspx
        /// https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/sqlclient-support-for-localdb
        /// https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2016-express-localdb
        /// https://docs.microsoft.com/en-us/sql/odbc/reference/syntax/sqldriverconnect-function
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;Database=SamuraiData;AttachDbFileName=E:\sato\MSSQLLocalDB\SamuraiData.mdf";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
