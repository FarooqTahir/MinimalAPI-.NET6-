using MinimalApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApiDemo.DataAccess.Interface
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetAllEmployees();
        public Employee? GetEmployeeById(int id);
    }
}
