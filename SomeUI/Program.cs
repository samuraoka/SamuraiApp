using SamuraiApp.Data;
using SamuraiApp.Domain;

namespace SomeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /// To compile this project, add following NuGet package using the below command in Package Manager
            /// PM> Install-Package Microsoft.EntityFrameworkCore.SqlServer -ProjectName SomeUI -Version 2.0.0
            /// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
            InsertSamurai();
        }

        private static void InsertSamurai()
        {
            var samurai = new Samurai { Name = "Julie" };
            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }
    }
}
