using System;

namespace ReflectionExample
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        private string DOB { get; set; }

        public string GetInfo()
        {
            // return { "ID: " + EmployeeId + "Name: " + Name + "Address: " + Address + "DOB: " + DOB};
            return "{ ID: " + EmployeeId + "Name: " + Name + "Address: " + Address + "DOB: " + DOB + "}";
            // return $"ID: {employeeID} Name: {Name} Address: {Address} DOB: {DOB}";
        }

    }
}


