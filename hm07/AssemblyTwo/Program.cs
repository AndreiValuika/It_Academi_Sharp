using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee employee = new EmployeeDerived();
            employee.ShowAll();
            EmployeeDerived employeeDerived = new EmployeeDerived();
            employeeDerived.ShowAll();
            DerivedClassTwo derivedClassTwo = new DerivedClassTwo();
            derivedClassTwo.ShowAll();
            Console.WriteLine("Visible const in other project:");
            Console.WriteLine(Employee.CompanyNamePublic );
            Console.Read();

        }
    }
}
