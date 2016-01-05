using System;
using TestAppl.BL;

namespace TestAppl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employeeBL = new EmployeeBL();
            Console.WriteLine("--------------------");
            Console.WriteLine("Employee Information");
            Console.WriteLine("--------------------");
            Console.WriteLine("Name : " + employeeBL.GetEmployee(1));
            Console.WriteLine("DOB  : " + Convert.ToDateTime(employeeBL.GetDOB(1)).ToShortDateString());

            Console.ReadLine();
        }
    }
}
