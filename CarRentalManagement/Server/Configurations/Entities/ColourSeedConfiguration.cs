using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
            new Colour
            {
                Id = 1,
                Name = "Black",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                CreatedBy = "System",
                UpdateBy = "System"
            },
        new Colour
        {
            Id = 2,
            Name = "Blue",
            DateCreated = DateTime.Now,
            DateUpdate = DateTime.Now,
            CreatedBy = "System",
            UpdateBy = "System"
        }
        );
        }
    }
}
