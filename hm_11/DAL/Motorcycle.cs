using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_11
{
    class Motorcycle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int Odometr { get; set; }
    }
}
