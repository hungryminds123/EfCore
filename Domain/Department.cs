using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain
{
    public class Department
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }  // navigation property
    }
}
