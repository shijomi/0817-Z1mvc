using System.Data.Entity;

namespace MVCproduct.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCproduct.Models.Product> Products { get; set; }
    }
}