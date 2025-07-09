using Microsoft.EntityFrameworkCore;
using PetShopScheduling.Infrastructure.Entry.Registration;
using ServiceShopScheduling.Infrastructure.Entry.Registration;

namespace PetShopScheduling.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Customer> Customer { get; set; }
    public DbSet<CustomerAddress> CustomerAddress { get; set; }
    public DbSet<CustomerPhone> CustomerPhone { get; set; }
    public DbSet<Pet> Pet { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<SchedulePet> SchedulePet { get; set; }
    public DbSet<ScheduleVaccine> ScheduleVaccine { get; set; }
    public DbSet<Vaccine> Vaccine { get; set; }
    public DbSet<ReservedVaccine> ReservedVaccine { get; set; }
    public DbSet<Service> Service { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Customer>()
            .HasIndex(x => x.Name);
    }
}