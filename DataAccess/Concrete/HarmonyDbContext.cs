using System.Reflection;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class HarmonyDbContext : DbContext
{
    
    public HarmonyDbContext(DbContextOptions<HarmonyDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //modelBuilder.ApplyConfiguration(new ProductConfiguration());
        base.OnModelCreating(modelBuilder);
    }
   
   
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<SocialMedia> SocialMediae { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<RoomFeature> RoomFeatures { get; set; }
    
    public DbSet<RoomImage> RoomImages { get; set; }
    
    public DbSet<Newsletter> Newsletters { get; set; }
    
    public DbSet<Service> Services { get; set; }
    
    public DbSet<Footer> Footers { get; set; }
    
    public DbSet<Employee> Employees { get; set; }
    
    public DbSet<AboutImage> AboutImages { get; set; }
    
    public DbSet<Banner> Banners { get; set; }
    
    
}