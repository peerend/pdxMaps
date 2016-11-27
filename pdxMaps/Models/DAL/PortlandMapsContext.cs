using Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Models.DAL
{
    public class pdxMaps : DbContext
    {
        public pdxMaps() : base("PortlandMapsContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
