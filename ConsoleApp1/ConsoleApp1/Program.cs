using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("CIndy", "eastern china", "typer", 111111, 223222);

            employee.Print();

            employee.ChangeName();

            employee.ChangeSalary();

            employee.Print();
        }
    }
}
