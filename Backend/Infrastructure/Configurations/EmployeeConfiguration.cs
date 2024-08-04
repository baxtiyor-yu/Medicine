
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entity;


namespace Infrastructure.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);
              
            builder
                .HasData(
                    new Employee() { Id = 1, FirstName= "Bob", LastName= "Jones", AnnualSalary= 60000, IsManager=true, DepartmentId= 1 },
                    new Employee() { Id = 2, FirstName = "Sarah", LastName = "Jameson", AnnualSalary = 80000, IsManager = true, DepartmentId = 2 },
                    new Employee() { Id = 3, FirstName = "Douglas", LastName = "Roberts", AnnualSalary = 40000, IsManager = false, DepartmentId = 2 },
                    new Employee() { Id = 4, FirstName = "Jane", LastName = "Stevens", AnnualSalary = 30000, IsManager = false, DepartmentId = 3 }
                );

        }
    }
}
