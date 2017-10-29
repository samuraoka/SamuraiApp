using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        /// <summary>
        /// To create a data model, add following NuGet package using following command in Package Manager
        /// PK> Install-Package Microsoft.EntityFrameworkCore.SqlServer -ProjectName SamuraiApp.Domain -Version 2.0.0
        /// https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/
        /// </summary>
        public Samurai()
        {
            Quotes = new List<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int BattleId { get; set; }
    }
}
