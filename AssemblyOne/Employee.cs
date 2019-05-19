using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Employee
    {
        const string CompanyName = "Default --  ";
        public const string CompanyNamePublic = "Public -- ";
        private const string CompanyNamePrivate = "Private -- ";
        protected const string CompanyNameProtected = "Protected -- ";
        internal const string CompanyNameInternal = "Internal -- ";
        protected internal const string CompanyNameProtectedInternal = "ProtectedInternal -- ";
        private protected const string CompanyNamePrivateProtected = "PrivateProtected -- ";

        public void showAll()
        {

            Console.WriteLine("Visible const in class:");
            Console.WriteLine(CompanyName+CompanyNameInternal+CompanyNamePrivate+CompanyNamePrivateProtected+
                CompanyNameProtected+CompanyNameProtectedInternal+CompanyNamePublic);
        }
    }
}
