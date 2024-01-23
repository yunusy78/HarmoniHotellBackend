
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

internal class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(300);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.Image).IsRequired();
        builder.Property(x=> x.Size).IsRequired();
        builder.Property(x=> x.Capacity).IsRequired();
        builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
        builder.Property(x => x.CategoryId).IsRequired();
        builder.HasOne(x=> x.Category)
            .WithMany(x => x.Rooms)
            .HasForeignKey(x => x.CategoryId);
        builder.ToTable("Rooms");
    }
}