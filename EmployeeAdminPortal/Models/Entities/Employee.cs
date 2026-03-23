namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        // Primary key for the Employee entity, represented as a GUID
        public Guid Id { get; set; }

        // Employee's full name, required field
        public required string Name { get; set; }

        // Employee's email address, required field
        public required string Email { get; set; }

        // Employee's phone number, optional field
        public string? Phone { get; set; }

        // Employee's salary, represented as a decimal value
        public decimal Salary { get; set; }
    }
}
