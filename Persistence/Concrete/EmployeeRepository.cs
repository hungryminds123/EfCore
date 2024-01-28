using Domain;
using Persistence.Interface;

namespace Persistence.Concrete
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EFCoreLearningDBContext dbContext) : base(dbContext)
        {

        }
    }


   
}
