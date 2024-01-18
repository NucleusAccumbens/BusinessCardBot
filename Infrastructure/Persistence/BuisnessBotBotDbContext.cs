using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence;

public class BuisnessBotBotDbContext : DbContext, IBotDbContext
{
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

    public DbSet<TlgUser> TlgUsers => Set<TlgUser>();

    public BuisnessBotBotDbContext(DbContextOptions<BuisnessBotBotDbContext> options,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
        : base(options)
    {
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
    }

    public async Task SaveChangesAsync()
    {
        await base.SaveChangesAsync();
    }
}
