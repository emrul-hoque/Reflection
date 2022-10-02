using System;

namespace ReflectionExample
{
    public class Employee
    {
     public int employeeID { get; set; }

     public string Name {get; set; }   

     public string Address { get; set; }

     private string DOB { get; set; }
     
     public string getInfo()
     {
        // return { "ID: " + employeeID + "Name: " + Name + "Address: " + Address + "DOB: " + DOB};
        return "{ ID: " + employeeID + "Name: " + Name + "Address: " + Address + "DOB: " + DOB + "}";
     }

    }
}


