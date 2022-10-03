using System;

namespace ReflectionExample
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        private string DOB { get; set; } = string.Empty;

        public string GetInfo()
        {
            // return { "ID: " + EmployeeId + "Name: " + Name + "Address: " + Address + "DOB: " + DOB};
            return "{ ID: " + EmployeeId + "Name: " + Name + "Address: " + Address + "DOB: " + DOB + "}";
            // return $"ID: {employeeID} Name: {Name} Address: {Address} DOB: {DOB}";
        }

    }
}


