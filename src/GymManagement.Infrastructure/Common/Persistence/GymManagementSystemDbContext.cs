using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.Infrastructure.Common.Persistence;

public class GymManagementSystemDbContext : DbContext, IUnitOfWork
{
    public GymManagementSystemDbContext(DbContextOptions<GymManagementSystemDbContext> options) : base(options)
    {

    }

    public DbSet<Subscription> Subscriptions { get; set; } = null!;

    public async Task CommitChagesAsyn()
    {
        await base.SaveChangesAsync();
    }
}
