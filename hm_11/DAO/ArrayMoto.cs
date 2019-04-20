using DAO.Entiti;
using System;

namespace DAO
{
    public class ArrayMoto
    {

        public int CorrentIndex { get; set; }
        public Motorcycle[] Motorcycles { get; set; }
        public ArrayMoto(int length)
        {
           Motorcycles = new Motorcycle[length];
           CorrentIndex = 0;
        }
    }
}
