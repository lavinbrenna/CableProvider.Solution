using Microsoft.EntityFrameworkCore;

namespace CableProvider.Models
{
  public class CableProviderContext : DbContext
  {
    public DbSet<Channel> Channels {get;set;}
    public DbSet<Show> Shows{get;set;}
    public DbSet<ChannelShow> ChannelShows {get;set;}

    public DbSet<Package> Packages {get;set;}
    public DbSet<Customer> Customers {get;set;}
    public DbSet<CustomerPackage> CustomerPackages {get;set;}

    public CableProviderContext(DbContextOptions options) : base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
    }
}