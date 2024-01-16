using System.Globalization;
using Worker.Entities;

namespace Worker
{
    class Program
    {
        static void Main (string [] args)
        {
            List<Employee> list = new List<Employee>();
            System.Console.Write("Enter the number of employees: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                System.Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced (y/n)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write ("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (response == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
                foreach (Employee emp in list)
                {
                  System.Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));  
                }
            }
        }
    }
}