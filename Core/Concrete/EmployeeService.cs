using Core.Interfaces;
using Core.ViewModels;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async  Task<IEnumerable<EmployeeViewModel>> GetAllEmployees()
        {
            List<EmployeeViewModel> empList = new List<EmployeeViewModel>();

            var existingEmployees = await _employeeRepository.GetAllAsync();  

            if (existingEmployees.Any())   // loop over results
            {
                foreach (var employee in existingEmployees)
                {
                    EmployeeViewModel employeeViewModel = new EmployeeViewModel()  // converting Employee into EmployeeViewModel
                    {
                        Age = employee.Age,
                        Gender = employee.Gender,
                        Id = employee.Id,

                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                    };

                    empList.Add(employeeViewModel);   // adding converted value into List of EmployeeViewModel
                }
            }

            return empList;  // returnining List of employeeViewModel
        }
    }
}
