using JCH.Domain.Modules.Candidates;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace JCH.Infrastructure.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<Candidate> Candidates { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

