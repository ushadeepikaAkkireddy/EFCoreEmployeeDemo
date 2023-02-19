using EFCoreEmployee.Models;
using System.Collections.Generic;
using EFCoreEmployee.Repositories;

namespace EFCoreEmployee.Repositories
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAllEmployees();
        void AddNewEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
    }
}
