using EFCoreEmployee.Models;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreEmployee.Repositories
{
    public class TestEmployeeRepo:IEmployeeRepo
    {
        EmployeeContext context;
        public TestEmployeeRepo(EmployeeContext employeeContext)
        {
            context = employeeContext;
        }

        void IEmployeeRepo.AddNewEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        void IEmployeeRepo.DeleteEmployee(int id)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        List<Employee> IEmployeeRepo.GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public void UpdateEmployee(Employee newemployee)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.Id == newemployee.Id);
            if (employee != null)
            {
                employee.Id = newemployee.Id;
                employee.Name = newemployee.Name;             
               employee.Location = newemployee.Location;
                context.SaveChanges();

            }
        }
        public Employee GetEmployeeById(int id)
        {
            Employee emp = context.Employees.Find(id);
            return emp;
        }

    }
}
