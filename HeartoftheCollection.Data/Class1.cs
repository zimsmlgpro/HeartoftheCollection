using HeartoftheCollection.Core.Models;
using Microsoft.EntityFrameworkCore;



namespace HeartoftheCollection.Data.Contexts;

public class PersonalCollection : DbContext
{
    public DbSet<Cards> Cards { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder opts)
        => opts.UseSqlite("Data Source=cardcollection.db");

    
}
