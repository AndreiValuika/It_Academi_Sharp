using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class DerivedClassTwo:Employee
    {
        public void ShowAll()
        {
            Console.WriteLine("Visible const in derived class, other project:");
            Console.WriteLine(CompanyNameProtected + CompanyNameProtectedInternal + CompanyNamePublic);
        }

    }
}
