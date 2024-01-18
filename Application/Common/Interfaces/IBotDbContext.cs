using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IBotDbContext 
{
    DbSet<TlgUser> TlgUsers { get; }
    
    Task SaveChangesAsync();
}
