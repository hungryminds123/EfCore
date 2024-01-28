using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(
            EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);  // primary key 

            builder.Property(x => x.DepartmentName).IsRequired()  // property is required
                .HasMaxLength(100);


            // apply a foreign key using this approach
        }
    }
}
