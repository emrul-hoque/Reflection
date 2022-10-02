
namespace ReflectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.getInfo();

            var employeeInfo = typeof(Employee);

            var methods = employeeInfo.GetMethods();

            foreach (var item in methods)
            {
                Console.WriteLine(item);
            }
        }
    }
}
