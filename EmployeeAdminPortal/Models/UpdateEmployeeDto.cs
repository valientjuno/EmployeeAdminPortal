namespace EmployeeAdminPortal.Models
{
    // Data Transfer Object (DTO) used for updating an existing employee's information
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
