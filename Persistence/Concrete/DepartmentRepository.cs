using Domain;
using Persistence.Interface;

namespace Persistence.Concrete
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(EFCoreLearningDBContext dbContext) : base(dbContext)
        {
        }
    }
}


// CRUD
// C - Create (Insertion) 
// R - Read
// U - Update
// D - Delete