using MinimalApiDemo.DataAccess.Interface;
using MinimalApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApiDemo.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>() {
    new Employee{
    Id= 1,
    FirstName = "John",
    LastName = "Doe",
    Age = 25,
    Salary = 5000
    },
        };
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public Employee? GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(emp => emp.Id == id);
        }
    }
}
