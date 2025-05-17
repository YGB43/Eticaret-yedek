﻿using Eticaret.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eticaret.Data.Conffigurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    Id = 1,   
                    UserName = "Admin",
                    Email = "admin@eticaret.io",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Test",
                    Password = "123456*",
                    SurName = "User",
                    CreateDate = new DateTime(2024, 1, 1), // sadece seed için
                    UserGuid = Guid.Parse("a1c9d3f9-8b8f-49de-a3c6-1ff0c2bc5f9e")

                }

                );

        }
    }
}
