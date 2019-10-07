using ApiNetCore_Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiNetCore_Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email);

            builder.Property(u => u.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("varchar");

            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(100)
                   .HasColumnType("varchar");
        }
    }
}
