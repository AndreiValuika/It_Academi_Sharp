using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ShowAll();
            Console.WriteLine();
            EmployeeDerived employeeDerived = new EmployeeDerived();
            employeeDerived.ShowAll();
            Console.WriteLine();
            Console.WriteLine("Visible const in project:");
            Console.WriteLine(Employee.CompanyNameInternal+Employee.CompanyNameProtectedInternal+Employee.CompanyNamePublic);

            Console.Read();
        }
    }
}
