
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.GetInfo();

            // var employeeInfo = typeof(Employee);
            // Same as above:
            var employeeInfo = employee.GetType();

            var methods = employeeInfo.GetMethods();            

            foreach (var item in methods)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
