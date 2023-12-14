using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors").HasKey(b => b.Id);

            builder.Property(b => b.Id ).HasColumnName("Id").IsRequired(); builder.Property(b => b.Name ).HasColumnName("Name").IsRequired();

            builder.HasIndex(indexExpression: b => b.Name , name: "UK_Instructors_Name").IsUnique();

            builder.HasMany(b => b.Course);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
