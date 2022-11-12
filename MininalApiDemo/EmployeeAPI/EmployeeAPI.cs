using MinimalApiDemo.DataAccess.Interface;
using MinimalApiDemo.Model;

namespace MininalApiDemo.EmployeeAPI
{
    public static class EmployeeAPI
    {
        public static void RegisterEmployeeAPI(this WebApplication app)
        {
            app.MapGet("/employees", GetEmployeeList);
            app.MapGet("/employees/{id}", GetEmployeeById);
            app.MapPost("/employee", SaveEmployee);
            app.MapDelete("/employee", DeleteEmployee);
            app.MapPut("/employee", UpdateEmployee);
        }
        public static IResult GetEmployeeList(IEmployeeRepository empRepository)
        {
            var employees = empRepository.GetAllEmployees();
            return Results.Ok(employees);
        }
        public static IResult GetEmployeeById(int id, IEmployeeRepository empRepository)
        {
            var employee = empRepository.GetEmployeeById(id);
            return Results.Ok(employee);
        }
        public static IResult SaveEmployee(Employee employee, IEmployeeRepository empRepository)
        {
            // Save Logic Here
            return Results.Created($"/employees/{employee.Id}",employee);
        }
        public static IResult DeleteEmployee(int employeeId)
        {
            // Delete Logic Here
            return Results.Accepted();
        }
        public static IResult UpdateEmployee(Employee employee)
        {
            // Update Logic goes Here
            return Results.Ok();
        }
    }
}
