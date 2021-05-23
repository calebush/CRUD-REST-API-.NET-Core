using Microsoft.EntityFrameworkCore;

namespace CrudRESTApis.Models
{
    public class AssetContext : DbContext
    {
        //Constructor
        public AssetContext(DbContextOptions<AssetContext> options): base(options)
        {
        }
        //Creating table in a database
        public DbSet<Asset> Assets { get; set; }
    }
}