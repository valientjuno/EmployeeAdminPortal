using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    // Base route: api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // DbContext used to interact with the database via Entity Framework Core
        private readonly ApplicationDbContext dbContext;

        // Constructor with dependency injection of DbContext
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/employees
        // Retrieves all employees from the database
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            // Uses LINQ to retrieve all employee records
            return Ok(dbContext.Employees.ToList());
        }

        // GET: api/employees/{id}
        // Retrieves a single employee by their unique ID
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            // Find employee by primary key
            var employee = dbContext.Employees.Find(id);

            // Return 404 if employee does not exist
            if (employee == null)
            {
                return NotFound();
            }

            // Return employee data with 200 OK
            return Ok(employee);
        }

        // POST: api/employees
        // Creates a new employee record in the database
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            // Map DTO to Entity model (prevents exposing internal structure)
            var employeeEntity = new Employee()
            {
                Name = addEmployeeDto.Name,
                Email = addEmployeeDto.Email,
                Phone = addEmployeeDto.Phone,
                Salary = addEmployeeDto.Salary
            };

            // Add employee to DbContext and save changes to database
            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            // Return created employee with 200 OK
            return Ok(employeeEntity);
        }

        // PUT: api/employees?id={id}
        // Updates an existing employee record
        [HttpPut]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDto updateEmployeeDto)
        {
            // Find existing employee
            var employee = dbContext.Employees.Find(id);

            // Return 404 if not found
            if (employee is null)
            {
                return NotFound();
            }

            // Update fields using DTO data
            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Salary = updateEmployeeDto.Salary;

            // Save updated data to database
            dbContext.SaveChanges();

            return Ok(employee);
        }

        // DELETE: api/employees/{id}
        // Removes an employee from the database
        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);

            // Return 404 if employee does not exist
            if (employee is null)
            {
                return NotFound();
            }

            // Remove employee and persist changes
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();

            return Ok(employee);
        }
    }
}
