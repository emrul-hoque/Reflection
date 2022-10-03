
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(){
                EmployeeId = 123,
                Name = "Jon Doe",
                Address = "Road #456, House #ABC, MyCity"
            };

            employee.GetInfo();

            // var employeeInfo = typeof(Employee);
            // Same as above:
            var employeeInfo = employee.GetType();

            // BindingFlags act as filters
            var methods = employeeInfo.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            foreach (var item in methods.Where(m => !m.IsSpecialName))
            {
                Console.WriteLine(item);

                if (item.Name.Equals("GetInfo"))
                {
                    // To invoke a method like this using reflection, you need to use the "Invoke" method of the Method Info class 
                    // and pass the class instance (employee is the instance/object) and arguments (there's nothing, so null).
                    var result = item.Invoke(employee, null); 
                    Console.WriteLine(result);
                }
            }
        }
    }
}
