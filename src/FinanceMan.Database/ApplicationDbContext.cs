using FinanceMan.Domain;
using Microsoft.EntityFrameworkCore;

namespace FinanceMan.Database;

public class ApplicationDbContext : DbContext
{
    public string DbPath { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public ApplicationDbContext()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        DbPath = Path.Join(path, "finance.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlite($"Data Source={DbPath}");
    }
}
