using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new Date(7, 24, 1949);
            var hireDate = new Date(3, 12, 1988);
            var employee = new Employee("Bob", "Blue", birthday, hireDate);

            Console.WriteLine(employee);
            Console.ReadLine();
        }
    }
}
