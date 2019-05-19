using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class EmployeeDerived : Employee
    {
        public void showAll()
        {
            Console.WriteLine("Visible const in derived class:");
            Console.WriteLine(CompanyNameInternal + CompanyNamePrivateProtected + CompanyNameProtected
                                + CompanyNameProtectedInternal + CompanyNamePublic);
        }
    }
}
