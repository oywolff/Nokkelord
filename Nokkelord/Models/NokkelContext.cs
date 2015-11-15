using System.Data.Entity;

namespace Nokkelord.Models
{
    public class NokkelContext : DbContext
    {
        public NokkelContext() : base("Nokkelord_db")
        {
        }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<ItemKeyword> ItemKeywords { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}