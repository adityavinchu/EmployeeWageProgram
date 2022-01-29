using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Employee Wages program");
            
            EmployeeWageProgram employee = new EmployeeWageProgram();
            employee.Attendence();
            
            Console.ReadLine();
        }
        
    }
}
