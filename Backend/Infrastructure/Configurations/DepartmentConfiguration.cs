
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entity;


namespace Infrastructure.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(c => c.Id);
              
            builder
                .HasData(
                    new Department() { Id = 1, ShortName = "HR", LongName = "Human Resources" },
                    new Department() { Id = 2, ShortName = "FN", LongName = "Finance" },
                    new Department() { Id = 3, ShortName = "TE", LongName = "Technology" }
                );

        }
    }
}
