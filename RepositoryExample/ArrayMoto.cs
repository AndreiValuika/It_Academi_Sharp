using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public class ArrayMoto
    {

        public int CurrentIndex { get; set; }
        public Motorcycle[] Motorcycles { get; set; }
        public ArrayMoto(int length)
        {
            Motorcycles = new Motorcycle[length];
            CurrentIndex = 0;
        }
    }
}
