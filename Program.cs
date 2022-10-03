
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee(){
                Name = "Jon Doe"
            };

            employee.GetInfo();

            // var employeeInfo = typeof(Employee);
            // Same as above:
            var employeeInfo = employee.GetType();

            var methods = employeeInfo.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            foreach (var item in methods.Where(m => !m.IsSpecialName))
            {
                Console.WriteLine(item);

                if (item.Name.Equals("GetInfo"))
                {
                    var result = item.Invoke(employee, null);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
