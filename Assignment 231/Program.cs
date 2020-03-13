using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Acme Industries";
            var greeting = "Welcome to "+ companyName;
            Console.WriteLine(greeting);
            Employee richard = new Employee("Richard");
            Console.WriteLine("{0}, You are employee number:{1}", richard.empName, richard.empId);
            Console.ReadLine();


        }
    }
}
